using SwiftlyS2.Core.Schemas;
using SwiftlyS2.Shared.Schemas;
using SwiftlyS2.Core.Extensions;

namespace SwiftlyS2.Core.SchemaDefinitions;

internal partial class CPathHelperUpdateNode : CUnaryUpdateNode, IPathHelperUpdateNode {

  public CPathHelperUpdateNode(nint handle) : base(handle) {
  }

  public ref float StoppingRadius {
    get => ref _Handle.AsRef<float>(Schema.GetOffset(0xB24262C3172E3D9));
  }
  public ref float StoppingSpeedScale {
    get => ref _Handle.AsRef<float>(Schema.GetOffset(0xB24262CA2389D04));
  }


}