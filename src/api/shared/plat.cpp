#include "plat.h"


#ifdef _WIN32

#include <windows.h>

void Plat_WriteMemory(void* pPatchAddress, uint8_t* pPatch, int iPatchSize)
{
    if (!pPatchAddress || !pPatch || iPatchSize <= 0)
        return;

    WriteProcessMemory(GetCurrentProcess(), pPatchAddress, pPatch, iPatchSize, nullptr);
}

using namespace DynLibUtils;

CMemory FindVirtTable(DynLibUtils::CModule* _this, const std::string_view svTableName, int32_t offset, bool bDecorated)
{
    if (svTableName.empty())
        return CMemory();

    CModule::ModuleSections_t runTimeData = _this->GetSectionByName(".data"), readOnlyData = _this->GetSectionByName(".rdata");
    if (!runTimeData.IsSectionValid() || !readOnlyData.IsSectionValid())
        return CMemory();

    std::string sDecoratedTableName(bDecorated ? svTableName : ".?AV" + std::string(svTableName) + "@@");
    std::string sMask(sDecoratedTableName.length() + 1, 'x');

    CMemory typeDescriptorName = _this->FindPattern(sDecoratedTableName.data(), sMask, nullptr, &runTimeData);
    if (!typeDescriptorName)
        return CMemory();

    CMemory rttiTypeDescriptor = typeDescriptorName.Offset(-0x10);
    const uintptr_t rttiTDRva = rttiTypeDescriptor - _this->GetModuleBase(); // The RTTI gets referenced by a 4-Byte RVA address. We need to scan for that address.

    CMemory reference;
    while ((reference = _this->FindPattern(&rttiTDRva, "xxxx", reference, &readOnlyData))) // Get reference typeinfo in vtable
    {
        // Check if we got a RTTI Object Locator for this reference by checking if -0xC is 1, which is the 'signature' field which is always 1 on x64.
        // Check that offset of this vtable is 0
        if (reference.Offset(-0xC).GetValue<int32_t>() == 1 && reference.Offset(-0x8).GetValue<int32_t>() == offset)
        {
            CMemory referenceOffset = reference.Offset(-0xC);
            CMemory rttiCompleteObjectLocator = _this->FindPattern(&referenceOffset, "xxxxxxxx", nullptr, &readOnlyData);
            if (rttiCompleteObjectLocator)
                return rttiCompleteObjectLocator.Offset(0x8);
        }

        reference.OffsetSelf(0x4);
    }

    return CMemory();
}

#else
#include <dlfcn.h>
#include <libgen.h>
#include <stdio.h>
#include <string.h>
#include "sys/mman.h"
#include <locale>
#include <elf.h>
#include <link.h>
#include "dbg.h"

static int parse_prot(const char* s)
{
    int prot = 0;

    for (; *s; s++)
    {
        switch (*s)
        {
        case '-':
            break;
        case 'r':
            prot |= PROT_READ;
            break;
        case 'w':
            prot |= PROT_WRITE;
            break;
        case 'x':
            prot |= PROT_EXEC;
            break;
        case 's':
            break;
        case 'p':
            break;
        default:
            break;
        }
    }

    return prot;
}

static int get_prot(void* pAddr, size_t nSize)
{
    FILE* f = fopen("/proc/self/maps", "r");

    uintptr_t nAddr = (uintptr_t)pAddr;

    char line[512];
    while (fgets(line, sizeof(line), f))
    {
        char start[16];
        char end[16];
        char prot[16];

        const char* src = line;

        char* dst = start;
        while (*src != '-')
            *dst++ = *src++;
        *dst = 0;

        src++; // skip "-""

        dst = end;
        while (!isspace(*src))
            *dst++ = *src++;
        *dst = 0;

        src++; // skip space

        dst = prot;
        while (!isspace(*src))
            *dst++ = *src++;
        *dst = 0;

        uintptr_t nStart = (uintptr_t)strtoul(start, nullptr, 16);
        uintptr_t nEnd = (uintptr_t)strtoul(end, nullptr, 16);

        if (nStart < nAddr && nEnd >(nAddr + nSize))
        {
            fclose(f);
            return parse_prot(prot);
        }
    }

    fclose(f);
    return 0;
}

void Plat_WriteMemory(void* pPatchAddress, uint8_t* pPatch, int iPatchSize)
{
    int old_prot = get_prot(pPatchAddress, iPatchSize);

    uintptr_t page_size = sysconf(_SC_PAGESIZE);
    uint8_t* align_addr = (uint8_t*)((uintptr_t)pPatchAddress & ~(page_size - 1));

    uint8_t* end = (uint8_t*)pPatchAddress + iPatchSize;
    uintptr_t align_size = end - align_addr;

    int result = mprotect(align_addr, align_size, PROT_READ | PROT_WRITE);

    memcpy(pPatchAddress, pPatch, iPatchSize);

    result = mprotect(align_addr, align_size, old_prot);
}

using namespace DynLibUtils;

CMemory FindVirtTable(DynLibUtils::CModule* _this, const std::string_view svTableName, int32_t offset, bool bDecorated)
{
    if (svTableName.empty())
        return CMemory();

    CModule::ModuleSections_t readOnlyData = _this->GetSectionByName(".rodata"), readOnlyRelocations = _this->GetSectionByName(".data.rel.ro");
    if (!readOnlyData.IsSectionValid() || !readOnlyRelocations.IsSectionValid())
        return CMemory();

    std::string sDecoratedTableName(bDecorated ? svTableName : std::to_string(svTableName.length()) + std::string(svTableName));
    std::string sMask(sDecoratedTableName.length() + 1, 'x');

    CMemory typeInfoName = _this->FindPattern(sDecoratedTableName.data(), sMask, nullptr, &readOnlyData);
    if (!typeInfoName)
        return CMemory();

    CMemory referenceTypeName = _this->FindPattern(&typeInfoName, "xxxxxxxx", nullptr, &readOnlyRelocations); // Get reference to type name.
    if (!referenceTypeName)
        return CMemory();

    CMemory typeInfo = referenceTypeName.Offset(-0x8); // Offset -0x8 to typeinfo.

    for (const auto& sectionName : { std::string_view(".data.rel.ro"), std::string_view(".data.rel.ro.local") })
    {
        CModule::ModuleSections_t section = _this->GetSectionByName(sectionName);
        if (!section.IsSectionValid())
            continue;

        CMemory reference;
        while ((reference = _this->FindPattern(&typeInfo, "xxxxxxxx", reference, &section))) // Get reference typeinfo in vtable
        {
            if (reference.Offset(-0x8).GetValue<int64_t>() == offset) // Offset to this.
            {
                return reference.Offset(0x8);
            }

            reference.OffsetSelf(0x8);
        }
    }

    return CMemory();
}

#endif