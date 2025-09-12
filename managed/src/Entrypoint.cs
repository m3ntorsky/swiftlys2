using System.Runtime.InteropServices;
using SwiftlyS2.Core;
using SwiftlyS2.Core.Natives;

namespace SwiftlyS2;

internal class Entrypoint
{
    [UnmanagedCallersOnly]
    public unsafe static void Start(IntPtr nativeTable, int nativeTableSize)
    {
        Bootstrap.Start(nativeTable, nativeTableSize);
    }
}
