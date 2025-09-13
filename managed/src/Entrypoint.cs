using System.Runtime.InteropServices;
using System.Security;
using SwiftlyS2.Core;

namespace SwiftlyS2;

internal class Entrypoint
{
    [UnmanagedCallersOnly]
    [SecurityCritical]
    public unsafe static void Start(IntPtr nativeTable, int nativeTableSize)
    {   
        Bootstrap.Start(nativeTable, nativeTableSize);
    }
    
}
