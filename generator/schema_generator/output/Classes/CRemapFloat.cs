using SwiftlyS2.Core.Schemas;
using SwiftlyS2.Shared.Schemas;
using SwiftlyS2.Core.Extensions;

namespace SwiftlyS2.Core.SchemaDefinitions;

internal partial class CRemapFloat : SchemaClass, IRemapFloat {

  public CRemapFloat(nint handle) : base(handle) {
  }

  public CRemapFloat(nint handle, ulong hash, bool isField, bool isNetworked) : base(handle, hash, isField, isNetworked) {
  }

  public ISchemaFixedArray<float32> Value {
    get => new SchemaFixedArray<float32>(_Handle + Schema.GetOffset(0x49763A6B7F437844));
  }


}