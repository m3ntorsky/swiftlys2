using SwiftlyS2.Core.Natives.NativeObjects;
using SwiftlyS2.Shared.Schemas;

namespace SwiftlyS2.Core.Schemas;

internal abstract class SchemaClass : SchemaField, ISchemaClass {

  public SchemaClass(nint handle) : base(handle, 0, false, false) {
  }

  public SchemaClass(nint handle, ulong hash, bool isField, bool isNetworked) : base(handle, hash, isField, isNetworked) {
  }

}