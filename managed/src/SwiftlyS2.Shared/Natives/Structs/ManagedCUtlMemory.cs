namespace SwiftlyS2.Shared.Natives;

public class ManagedCUtlMemory<T> : IDisposable where T : unmanaged
{
    private CUtlMemory<T> _memory;

    public ManagedCUtlMemory(int growSize, int initSize)
    {
        _memory = new CUtlMemory<T>(growSize, initSize);
    }

    public ManagedCUtlMemory(nint memory, int numelements, bool readOnly)
    {
        _memory = new CUtlMemory<T>(memory, numelements, readOnly);
    }

    public void Dispose()
    {
        _memory.Dispose();
    }

    public nint Base => _memory.Base;
    public int Count => _memory.Count;

    public ref T this[int index] => ref _memory[index];
}