using SwiftlyS2.Shared.Schemas;

namespace SwiftlyS2.Core.Schemas;

internal class SchemaUntypedField : SchemaField, ISchemaUntypedField {
  public SchemaUntypedField(nint handle, ulong hash, bool isField, bool isNetworked) : base(handle, hash, isField, isNetworked) {
  }
}
