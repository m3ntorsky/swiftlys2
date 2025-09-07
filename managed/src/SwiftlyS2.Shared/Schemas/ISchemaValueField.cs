namespace SwiftlyS2.Shared.Schemas;

public interface ISchemaValueField<T> : ISchemaField where T : unmanaged {

  public ref T Raw { get; }

  public void Set(T value);

  public void SetWithoutUpdate(T value);

  public ref T Get();

}