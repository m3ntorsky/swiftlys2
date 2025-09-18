using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace SwiftlyS2.Shared.Misc;

class ExternDLL
{
    [DllImport("kernel32", CharSet = CharSet.Ansi, SetLastError = true)]
    private static extern IntPtr GetModuleHandle(string lpModuleName);

    [DllImport("kernel32", CharSet = CharSet.Ansi, SetLastError = true)]
    private static extern IntPtr GetProcAddress(IntPtr hModule, string procName);

    public static unsafe bool GetExportedBool(string dllName, string variableName)
    {
        IntPtr hModule = GetModuleHandle(dllName);
        if (hModule == IntPtr.Zero)
            throw new Exception("Module not found: " + dllName);

        IntPtr pVar = GetProcAddress(hModule, variableName);
        if (pVar == IntPtr.Zero)
            throw new Exception("Export not found: " + variableName);

        return Unsafe.Read<bool>(pVar.ToPointer());
    }
}
