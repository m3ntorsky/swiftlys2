using SwiftlyS2.Shared.Schemas;

namespace SwiftlyS2.Core.Schemas;

internal class SchemaUntypedField : SchemaField, ISchemaUntypedField {
  public SchemaUntypedField(nint handle, ulong hash) : base(handle, hash) {
  }
}
