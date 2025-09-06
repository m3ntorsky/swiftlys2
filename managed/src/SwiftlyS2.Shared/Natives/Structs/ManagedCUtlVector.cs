namespace SwiftlyS2.Shared.Natives;

public class ManagedCUtlVector<T> where T : unmanaged {
  private CUtlVector<T> _vector;

  public ManagedCUtlVector() {
    ManagedCUtlMemory<T> memory = new(0, 0);
    _vector = new CUtlVector<T>(memory.Value);
  }

  public ref CUtlVector<T> Value { get => ref _vector; }

}