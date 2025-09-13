using System.Runtime.InteropServices;
using SwiftlyS2.Core;

namespace SwiftlyS2;

internal class Entrypoint
{
    [UnmanagedCallersOnly]
    public unsafe static void Start(IntPtr nativeTable, int nativeTableSize)
    {
        try {
            Bootstrap.Start(nativeTable, nativeTableSize);
        } catch (Exception e) {
            Console.WriteLine(e);
        }
    }
}
