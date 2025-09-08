using SwiftlyS2.Core.Schemas;
using SwiftlyS2.Shared.Schemas;
using SwiftlyS2.Core.Extensions;

namespace SwiftlyS2.Core.SchemaDefinitions;

internal partial class TwoBoneIKSettings_t : SchemaClass, ITwoBoneIKSettings_t {

  public TwoBoneIKSettings_t(nint handle) : base(handle) {
  }

  public ref IkEndEffectorType EndEffectorType {
    get => ref _Handle.AsRef<IkEndEffectorType>(Schema.GetOffset(0xBE091551687CB4CE));
  }
  public IAnimAttachment EndEffectorAttachment {
    get => new CAnimAttachment(_Handle + Schema.GetOffset(0xBE0915516872873B));
  }
  public ref IkTargetType TargetType {
    get => ref _Handle.AsRef<IkTargetType>(Schema.GetOffset(0xBE09155113C167A0));
  }
  public IAnimAttachment TargetAttachment {
    get => new CAnimAttachment(_Handle + Schema.GetOffset(0xBE091551C90DDA55));
  }
  public ref int TargetBoneIndex {
    get => ref _Handle.AsRef<int>(Schema.GetOffset(0xBE091551D1D2A3DA));
  }
  public IAnimParamHandle PositionParam {
    get => new CAnimParamHandle(_Handle + Schema.GetOffset(0xBE091551FF710245));
  }
  public IAnimParamHandle RotationParam {
    get => new CAnimParamHandle(_Handle + Schema.GetOffset(0xBE09155193200F16));
  }
  public ref bool AlwaysUseFallbackHinge {
    get => ref _Handle.AsRef<bool>(Schema.GetOffset(0xBE09155158B8E174));
  }
  public ref VectorAligned LsFallbackHingeAxis {
    get => ref _Handle.AsRef<VectorAligned>(Schema.GetOffset(0xBE0915517DF22B04));
  }
  public ref int FixedBoneIndex {
    get => ref _Handle.AsRef<int>(Schema.GetOffset(0xBE091551D1DD1DC5));
  }
  public ref int MiddleBoneIndex {
    get => ref _Handle.AsRef<int>(Schema.GetOffset(0xBE091551489C3976));
  }
  public ref int EndBoneIndex {
    get => ref _Handle.AsRef<int>(Schema.GetOffset(0xBE09155146E23D1C));
  }
  public ref bool MatchTargetOrientation {
    get => ref _Handle.AsRef<bool>(Schema.GetOffset(0xBE09155142E0C3DB));
  }
  public ref bool ConstrainTwist {
    get => ref _Handle.AsRef<bool>(Schema.GetOffset(0xBE091551DB3DB7ED));
  }
  public ref float MaxTwist {
    get => ref _Handle.AsRef<float>(Schema.GetOffset(0xBE091551A898EE6E));
  }


}