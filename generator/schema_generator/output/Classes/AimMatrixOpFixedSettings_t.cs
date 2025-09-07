using SwiftlyS2.Core.Schemas;
using SwiftlyS2.Shared.Schemas;
using SwiftlyS2.Core.Extensions;

namespace SwiftlyS2.Core.SchemaDefinitions;

internal partial class AimMatrixOpFixedSettings_t : SchemaClass, IAimMatrixOpFixedSettings_t {

  public AimMatrixOpFixedSettings_t(nint handle) : base(handle) {
  }

  public AimMatrixOpFixedSettings_t(nint handle, ulong hash, bool isField, bool isNetworked) : base(handle, hash, isField, isNetworked) {
  }

  public IAnimAttachment Attachment {
    get => new CAnimAttachment(_Handle + Schema.GetOffset(0xE059B1E02C5CA308));
  }
  public IAnimInputDamping Damping {
    get => new CAnimInputDamping(_Handle + Schema.GetOffset(0xE059B1E015440FB5));
  }
  public IPoseHandle PoseCacheHandles {
    get => new CPoseHandle(_Handle + Schema.GetOffset(0xE059B1E0E7BA8E61));
  }
  public ref AimMatrixBlendMode BlendMode {
    get => ref _Handle.AsRef<AimMatrixBlendMode>(Schema.GetOffset(0xE059B1E0DBED6224));
  }
  public ref float MaxYawAngle {
    get => ref _Handle.AsRef<float>(Schema.GetOffset(0xE059B1E049BAD4B1));
  }
  public ref float MaxPitchAngle {
    get => ref _Handle.AsRef<float>(Schema.GetOffset(0xE059B1E0AE96A782));
  }
  public ref int SequenceMaxFrame {
    get => ref _Handle.AsRef<int>(Schema.GetOffset(0xE059B1E05FD0AE0B));
  }
  public ref int BoneMaskIndex {
    get => ref _Handle.AsRef<int>(Schema.GetOffset(0xE059B1E04871547D));
  }
  public ref bool TargetIsPosition {
    get => ref _Handle.AsRef<bool>(Schema.GetOffset(0xE059B1E014C34163));
  }
  public ref bool UseBiasAndClamp {
    get => ref _Handle.AsRef<bool>(Schema.GetOffset(0xE059B1E0F71F7341));
  }
  public ref float BiasAndClampYawOffset {
    get => ref _Handle.AsRef<float>(Schema.GetOffset(0xE059B1E07D3789F6));
  }
  public ref float BiasAndClampPitchOffset {
    get => ref _Handle.AsRef<float>(Schema.GetOffset(0xE059B1E08421472F));
  }
  public IBlendCurve BiasAndClampBlendCurve {
    get => new CBlendCurve(_Handle + Schema.GetOffset(0xE059B1E0D81016FE));
  }


}