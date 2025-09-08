using SwiftlyS2.Core.Schemas;
using SwiftlyS2.Shared.Schemas;
using SwiftlyS2.Core.Extensions;

namespace SwiftlyS2.Core.SchemaDefinitions;

internal partial class FeSourceEdge_t : SchemaClass, IFeSourceEdge_t {

  public FeSourceEdge_t(nint handle) : base(handle) {
  }

  public ISchemaFixedArray<ushort> Node {
    get => new SchemaFixedArray<ushort>(_Handle, 0x88268BD3CD6694B9, 2, 2, 2);
  }


}