namespace SwiftlyS2.Shared.Natives;

public class ManagedCUtlVector<T> : IDisposable where T : unmanaged
{
    private CUtlVector<T> _vector;

    public ManagedCUtlVector(int growSize, int initSize)
    {
        _vector = new CUtlVector<T>(growSize, initSize);
    }

    public ManagedCUtlVector(nint memory, int allocationCount, int numElements)
    {
        _vector = new CUtlVector<T>(memory, allocationCount, numElements);
    }

    public void Dispose()
    {
        _vector.Dispose();
    }

    public nint Base => _vector.Base;
    public int Count => _vector.Count;
    public ref CUtlVector<T> Value => ref _vector;

    public ref T this[int index] => ref _vector[index];
}