using SwiftlyS2.Core.Schemas;
using SwiftlyS2.Shared.Schemas;
using SwiftlyS2.Core.Extensions;

namespace SwiftlyS2.Core.SchemaDefinitions;

internal partial class CAnimationGraphVisualizerLine : CAnimationGraphVisualizerPrimitiveBase, IAnimationGraphVisualizerLine {

  public CAnimationGraphVisualizerLine(nint handle) : base(handle) {
  }

  public ref VectorAligned WsPositionStart {
    get => ref _Handle.AsRef<VectorAligned>(Schema.GetOffset(0x688831B2D941E214));
  }
  public ref VectorAligned WsPositionEnd {
    get => ref _Handle.AsRef<VectorAligned>(Schema.GetOffset(0x688831B26EB28B6D));
  }
  public ref Color Color {
    get => ref _Handle.AsRef<Color>(Schema.GetOffset(0x688831B2D7D017D8));
  }


}