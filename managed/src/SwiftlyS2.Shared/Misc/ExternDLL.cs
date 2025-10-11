using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace SwiftlyS2.Shared.Misc;

class ExternDLL
{
    [DllImport("kernel32.dll", CharSet = CharSet.Ansi, SetLastError = true)]
    private static extern IntPtr GetModuleHandle(string lpModuleName);

    [DllImport("kernel32.dll", CharSet = CharSet.Ansi, SetLastError = true)]
    private static extern IntPtr GetProcAddress(IntPtr hModule, string procName);

    [DllImport("kernel32.dll", SetLastError = true)]
    private static extern bool FreeLibrary(IntPtr hModule);

    [DllImport("libdl.so.2", CharSet = CharSet.Ansi)]
    private static extern IntPtr dlopen(string filename, int flags);

    [DllImport("libdl.so.2", CharSet = CharSet.Ansi)]
    private static extern IntPtr dlsym(IntPtr handle, string symbol);

    [DllImport("libdl.so.2")]
    private static extern int dlclose(IntPtr handle);

    private const int RTLD_NOW = 2;

    [DllImport("tier0", SetLastError = true)]
    public static extern IntPtr UtlVectorMemory_Alloc(IntPtr pMemory, [MarshalAs(UnmanagedType.Bool)] bool bRealloc, int newSize, int oldSize);

    [DllImport("tier0", SetLastError = true)]
    public static extern void UtlVectorMemory_FailedAllocation(int totalElements, int newElements);

    [DllImport("tier0", SetLastError = true)]
    public static extern int UtlVectorMemory_CalcNewAllocationCount(int allocationCount, int growSize, int newSize, int bytesItem);

    public static IntPtr LoadLibrary(string dllName)
    {
        if (RuntimeInformation.IsOSPlatform(OSPlatform.Windows))
        {
            IntPtr hModule = GetModuleHandle(dllName);
            if (hModule == IntPtr.Zero)
            {
                hModule = NativeLibrary.Load(dllName);
            }
            return hModule;
        }
        else if (RuntimeInformation.IsOSPlatform(OSPlatform.Linux))
        {
            IntPtr handle = dlopen(dllName, RTLD_NOW);
            if (handle == IntPtr.Zero)
                throw new Exception("Failed to load library: " + dllName);
            return handle;
        }
        else
        {
            throw new PlatformNotSupportedException("Unsupported OS platform");
        }
    }

    public static IntPtr GetAddress(IntPtr libraryHandle, string functionName)
    {
        if (RuntimeInformation.IsOSPlatform(OSPlatform.Windows))
        {
            return GetProcAddress(libraryHandle, functionName);
        }
        else if (RuntimeInformation.IsOSPlatform(OSPlatform.Linux))
        {
            return dlsym(libraryHandle, functionName);
        }
        else
        {
            throw new PlatformNotSupportedException("Unsupported OS platform");
        }
    }

    public static void CloseLibrary(IntPtr libraryHandle)
    {
        if (RuntimeInformation.IsOSPlatform(OSPlatform.Windows))
        {
            FreeLibrary(libraryHandle);
        }
        else if (RuntimeInformation.IsOSPlatform(OSPlatform.Linux))
        {
            _ = dlclose(libraryHandle);
        }
        else
        {
            throw new PlatformNotSupportedException("Unsupported OS platform");
        }
    }

    public static T GetExportedFunction<T>(string dllName, string functionName) where T : Delegate
    {
        IntPtr hModule = GetModuleHandle(dllName);
        if (hModule == IntPtr.Zero)
            throw new Exception("Module not found: " + dllName);

        IntPtr pFunc = GetProcAddress(hModule, functionName);
        if (pFunc == IntPtr.Zero)
            throw new Exception("Export not found: " + functionName);

        return Marshal.GetDelegateForFunctionPointer<T>(pFunc);
    }

    public static unsafe T GetExportedVariable<T>(string dllName, string variableName)
    {
        IntPtr hModule = GetModuleHandle(dllName);
        if (hModule == IntPtr.Zero)
            throw new Exception("Module not found: " + dllName);

        IntPtr pVar = GetProcAddress(hModule, variableName);
        if (pVar == IntPtr.Zero)
            throw new Exception("Export not found: " + variableName);

        return Unsafe.Read<T>(pVar.ToPointer());
    }
}
