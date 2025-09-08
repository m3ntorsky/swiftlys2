using SwiftlyS2.Core.Schemas;
using SwiftlyS2.Shared.Schemas;
using SwiftlyS2.Core.Extensions;

namespace SwiftlyS2.Core.SchemaDefinitions;

internal partial class C_OP_CPOffsetToPercentageBetweenCPs : CParticleFunctionOperator, IC_OP_CPOffsetToPercentageBetweenCPs {

  public C_OP_CPOffsetToPercentageBetweenCPs(nint handle) : base(handle) {
  }

  public ref float InputMin {
    get => ref _Handle.AsRef<float>(Schema.GetOffset(0x93039DC8E88A0D0F));
  }
  public ref float InputMax {
    get => ref _Handle.AsRef<float>(Schema.GetOffset(0x93039DC8D6766901));
  }
  public ref float InputBias {
    get => ref _Handle.AsRef<float>(Schema.GetOffset(0x93039DC885F2736C));
  }
  public ref int StartCP {
    get => ref _Handle.AsRef<int>(Schema.GetOffset(0x93039DC82C2FF970));
  }
  public ref int EndCP {
    get => ref _Handle.AsRef<int>(Schema.GetOffset(0x93039DC88C9B426D));
  }
  public ref int OffsetCP {
    get => ref _Handle.AsRef<int>(Schema.GetOffset(0x93039DC8587E7DA5));
  }
  public ref int OuputCP {
    get => ref _Handle.AsRef<int>(Schema.GetOffset(0x93039DC8FCE2222D));
  }
  public ref int InputCP {
    get => ref _Handle.AsRef<int>(Schema.GetOffset(0x93039DC8F39A3C14));
  }
  public ref bool RadialCheck {
    get => ref _Handle.AsRef<bool>(Schema.GetOffset(0x93039DC8496187DE));
  }
  public ref bool ScaleOffset {
    get => ref _Handle.AsRef<bool>(Schema.GetOffset(0x93039DC8AB39558E));
  }
  public ref Vector Offset {
    get => ref _Handle.AsRef<Vector>(Schema.GetOffset(0x93039DC8BD25CC2A));
  }


}