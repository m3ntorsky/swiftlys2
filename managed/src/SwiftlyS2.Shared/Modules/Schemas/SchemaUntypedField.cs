using SwiftlyS2.Shared.Natives;
using SwiftlyS2.Shared.Schemas;

namespace SwiftlyS2.Shared.Schemas;

public class SchemaUntypedField : INativeHandle, ISchemaClass<SchemaUntypedField> {

  private nint _handle;
  public nint Address => _handle;

  public bool IsValid => throw new NotImplementedException();

  public SchemaUntypedField(nint handle) {
    _handle = handle;
  }

  public static SchemaUntypedField From(nint handle) {
    return new SchemaUntypedField(handle);
  }

  public nint GetHandle()
  {
    return _handle;
  }
}
