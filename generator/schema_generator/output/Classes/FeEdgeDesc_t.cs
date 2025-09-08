using SwiftlyS2.Core.Schemas;
using SwiftlyS2.Shared.Schemas;
using SwiftlyS2.Core.Extensions;

namespace SwiftlyS2.Core.SchemaDefinitions;

internal partial class FeEdgeDesc_t : SchemaClass, IFeEdgeDesc_t {

  public FeEdgeDesc_t(nint handle) : base(handle) {
  }

  public ISchemaFixedArray<ushort> Edge {
    get => new SchemaFixedArray<ushort>(_Handle, 0xD483120F9FB47768, 2, 2, 2);
  }
  public ISchemaFixedArray<ushort[2]> Side {
    get => new SchemaFixedArray<ushort[2]>(_Handle, 0xD483120FA0D97E1A, 2, 4, 2);
  }
  public ISchemaFixedArray<ushort> VirtElem {
    get => new SchemaFixedArray<ushort>(_Handle, 0xD483120F64A695A5, 2, 2, 2);
  }


}