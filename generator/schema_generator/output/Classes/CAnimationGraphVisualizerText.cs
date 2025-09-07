using SwiftlyS2.Core.Schemas;
using SwiftlyS2.Shared.Schemas;
using SwiftlyS2.Core.Extensions;

namespace SwiftlyS2.Core.SchemaDefinitions;

internal partial class CAnimationGraphVisualizerText : CAnimationGraphVisualizerPrimitiveBase, IAnimationGraphVisualizerText {

  public CAnimationGraphVisualizerText(nint handle) : base(handle) {
  }

  public CAnimationGraphVisualizerText(nint handle, ulong hash, bool isField, bool isNetworked) : base(handle, hash, isField, isNetworked) {
  }

  public ref VectorAligned WsPosition {
    get => ref _Handle.AsRef<VectorAligned>(Schema.GetOffset(0x123E08CFCA77AB88));
  }
  public ref Color Color {
    get => ref _Handle.AsRef<Color>(Schema.GetOffset(0x123E08CFD7D017D8));
  }
  public ref CUtlString Text {
    get => ref _Handle.AsRef<CUtlString>(Schema.GetOffset(0x123E08CFFB9532BE));
  }


}