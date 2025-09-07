using SwiftlyS2.Core.Schemas;
using SwiftlyS2.Shared.Schemas;
using SwiftlyS2.Core.Extensions;

namespace SwiftlyS2.Core.SchemaDefinitions;

internal partial class FeEdgeDesc_t : SchemaClass, IFeEdgeDesc_t {

  public FeEdgeDesc_t(nint handle) : base(handle) {
  }

  public FeEdgeDesc_t(nint handle, ulong hash, bool isField, bool isNetworked) : base(handle, hash, isField, isNetworked) {
  }

  public ISchemaFixedArray<uint16> Edge {
    get => new SchemaFixedArray<uint16>(_Handle + Schema.GetOffset(0xD483120F9FB47768));
  }
  public ISchemaFixedArray<uint16[2]> Side {
    get => new SchemaFixedArray<uint16[2]>(_Handle + Schema.GetOffset(0xD483120FA0D97E1A));
  }
  public ISchemaFixedArray<uint16> VirtElem {
    get => new SchemaFixedArray<uint16>(_Handle + Schema.GetOffset(0xD483120F64A695A5));
  }


}