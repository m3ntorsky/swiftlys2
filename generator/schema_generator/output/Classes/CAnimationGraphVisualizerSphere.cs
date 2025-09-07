using SwiftlyS2.Core.Schemas;
using SwiftlyS2.Shared.Schemas;
using SwiftlyS2.Core.Extensions;

namespace SwiftlyS2.Core.SchemaDefinitions;

internal partial class CAnimationGraphVisualizerSphere : CAnimationGraphVisualizerPrimitiveBase, IAnimationGraphVisualizerSphere {

  public CAnimationGraphVisualizerSphere(nint handle) : base(handle) {
  }

  public CAnimationGraphVisualizerSphere(nint handle, ulong hash, bool isField, bool isNetworked) : base(handle, hash, isField, isNetworked) {
  }

  public ref VectorAligned WsPosition {
    get => ref _Handle.AsRef<VectorAligned>(Schema.GetOffset(0x85D725BDCA77AB88));
  }
  public ref float Radius {
    get => ref _Handle.AsRef<float>(Schema.GetOffset(0x85D725BD5ACFC08D));
  }
  public ref Color Color {
    get => ref _Handle.AsRef<Color>(Schema.GetOffset(0x85D725BDD7D017D8));
  }


}