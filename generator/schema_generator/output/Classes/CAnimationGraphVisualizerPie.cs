using SwiftlyS2.Core.Schemas;
using SwiftlyS2.Shared.Schemas;
using SwiftlyS2.Core.Extensions;

namespace SwiftlyS2.Core.SchemaDefinitions;

internal partial class CAnimationGraphVisualizerPie : CAnimationGraphVisualizerPrimitiveBase, IAnimationGraphVisualizerPie {

  public CAnimationGraphVisualizerPie(nint handle) : base(handle) {
  }

  public ref VectorAligned WsCenter {
    get => ref _Handle.AsRef<VectorAligned>(Schema.GetOffset(0x152844C290A3905E));
  }
  public ref VectorAligned WsStart {
    get => ref _Handle.AsRef<VectorAligned>(Schema.GetOffset(0x152844C2EFF42149));
  }
  public ref VectorAligned WsEnd {
    get => ref _Handle.AsRef<VectorAligned>(Schema.GetOffset(0x152844C280C1EC98));
  }
  public ref Color Color {
    get => ref _Handle.AsRef<Color>(Schema.GetOffset(0x152844C2D7D017D8));
  }


}