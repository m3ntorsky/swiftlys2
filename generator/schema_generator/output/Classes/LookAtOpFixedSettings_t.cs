using SwiftlyS2.Core.Schemas;
using SwiftlyS2.Shared.Schemas;
using SwiftlyS2.Core.Extensions;

namespace SwiftlyS2.Core.SchemaDefinitions;

internal partial class LookAtOpFixedSettings_t : SchemaClass, ILookAtOpFixedSettings_t {

  public LookAtOpFixedSettings_t(nint handle) : base(handle) {
  }

  public IAnimAttachment Attachment {
    get => new CAnimAttachment(_Handle + Schema.GetOffset(0xF114BD602C5CA308));
  }
  public IAnimInputDamping Damping {
    get => new CAnimInputDamping(_Handle + Schema.GetOffset(0xF114BD6015440FB5));
  }
  public ref CUtlVector Bones {
    get => ref _Handle.AsRef<CUtlVector>(Schema.GetOffset(0xF114BD600FDA60D4));
  }
  public ref float YawLimit {
    get => ref _Handle.AsRef<float>(Schema.GetOffset(0xF114BD60C8DE6E19));
  }
  public ref float PitchLimit {
    get => ref _Handle.AsRef<float>(Schema.GetOffset(0xF114BD60A68363C6));
  }
  public ref float HysteresisInnerAngle {
    get => ref _Handle.AsRef<float>(Schema.GetOffset(0xF114BD6097B2D677));
  }
  public ref float HysteresisOuterAngle {
    get => ref _Handle.AsRef<float>(Schema.GetOffset(0xF114BD60F67403AE));
  }
  public ref bool RotateYawForward {
    get => ref _Handle.AsRef<bool>(Schema.GetOffset(0xF114BD6058C8E372));
  }
  public ref bool MaintainUpDirection {
    get => ref _Handle.AsRef<bool>(Schema.GetOffset(0xF114BD601F5BE57E));
  }
  public ref bool TargetIsPosition {
    get => ref _Handle.AsRef<bool>(Schema.GetOffset(0xF114BD6014C34163));
  }
  public ref bool UseHysteresis {
    get => ref _Handle.AsRef<bool>(Schema.GetOffset(0xF114BD60A1B392FB));
  }


}