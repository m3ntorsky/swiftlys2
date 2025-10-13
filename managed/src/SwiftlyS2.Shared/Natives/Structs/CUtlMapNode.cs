using System.Runtime.InteropServices;

namespace SwiftlyS2.Shared.Natives;

[StructLayout(LayoutKind.Sequential)]
public struct CUtlMapTreeNode<TKey, TValue>
    where TKey : unmanaged
    where TValue : unmanaged
{
    public TKey Key;
    public TValue Element;
}