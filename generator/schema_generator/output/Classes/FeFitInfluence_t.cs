using SwiftlyS2.Core.Schemas;
using SwiftlyS2.Shared.Schemas;
using SwiftlyS2.Core.Extensions;

namespace SwiftlyS2.Core.SchemaDefinitions;

internal partial class FeFitInfluence_t : SchemaClass, IFeFitInfluence_t {

  public FeFitInfluence_t(nint handle) : base(handle) {
  }

  public ref uint VertexNode {
    get => ref _Handle.AsRef<uint>(Schema.GetOffset(0xF8271D2105342743));
  }
  public ref float Weight {
    get => ref _Handle.AsRef<float>(Schema.GetOffset(0xF8271D21CFFC66CB));
  }
  public ref uint MatrixNode {
    get => ref _Handle.AsRef<uint>(Schema.GetOffset(0xF8271D2189590174));
  }


}