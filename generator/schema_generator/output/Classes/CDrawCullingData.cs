using SwiftlyS2.Core.Schemas;
using SwiftlyS2.Shared.Schemas;
using SwiftlyS2.Core.Extensions;

namespace SwiftlyS2.Core.SchemaDefinitions;

internal partial class CDrawCullingData : SchemaClass, IDrawCullingData {

  public CDrawCullingData(nint handle) : base(handle) {
  }

  public CDrawCullingData(nint handle, ulong hash, bool isField, bool isNetworked) : base(handle, hash, isField, isNetworked) {
  }

  public ISchemaFixedArray<int8> ConeAxis {
    get => new SchemaFixedArray<int8>(_Handle + Schema.GetOffset(0x80665970C59E234F));
  }
  public ref byte ConeCutoff {
    get => ref _Handle.AsRef<byte>(Schema.GetOffset(0x80665970CAE61D67));
  }


}