using SwiftlyS2.Shared.SchemaDefinitions;
using System.Runtime.InteropServices;

namespace SwiftlyS2.Shared.Natives;

[StructLayout(LayoutKind.Explicit)]
public struct CTraceFilter
{
    [FieldOffset(0x0)] private nint _pVTable;
    [FieldOffset(0x8)] public RnQueryShapeAttr_t QueryShapeAttributes;
    [FieldOffset(0x30)] public bool IterateEntities;

    public CTraceFilter()
    {
        _pVTable = CTraceFilterVTable.pCTraceFilterVTable;
    }
}

internal static class CTraceFilterVTable
{
    public static nint pCTraceFilterVTable;

    [UnmanagedCallersOnly]
    public unsafe static void Destructor(CTraceFilter* filter)
    {
        // do nothing
    }

    [UnmanagedCallersOnly]
    public unsafe static bool ShouldHitEntity(CTraceFilter* filter)
    {
        return true;
    }

    static unsafe CTraceFilterVTable()
    {
        pCTraceFilterVTable = Marshal.AllocHGlobal(sizeof(nint) * 2);
        Span<nint> vtable = new((void*)pCTraceFilterVTable, 2);
        vtable[0] = (nint)(delegate* unmanaged<CTraceFilter*, void>)(&Destructor);
        vtable[1] = (nint)(delegate* unmanaged<CTraceFilter*, bool>)(&ShouldHitEntity);
    }
}