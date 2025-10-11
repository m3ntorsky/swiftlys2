#include "plat.h"

#include <safetyhook/safetyhook.hpp>


void Plat_WriteMemory(void* pPatchAddress, uint8_t* pPatch, int iPatchSize)
{
    if (!pPatchAddress || !pPatch || iPatchSize <= 0)
        return;

    safetyhook::unprotect(reinterpret_cast<uint8_t*>(pPatchAddress), iPatchSize);
    memcpy(pPatchAddress, pPatch, iPatchSize);
}