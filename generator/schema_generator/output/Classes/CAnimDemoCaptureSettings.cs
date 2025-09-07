using SwiftlyS2.Core.Schemas;
using SwiftlyS2.Shared.Schemas;
using SwiftlyS2.Core.Extensions;

namespace SwiftlyS2.Core.SchemaDefinitions;

internal partial class CAnimDemoCaptureSettings : SchemaClass, IAnimDemoCaptureSettings {

  public CAnimDemoCaptureSettings(nint handle) : base(handle) {
  }

  public CAnimDemoCaptureSettings(nint handle, ulong hash, bool isField, bool isNetworked) : base(handle, hash, isField, isNetworked) {
  }

  public ref Vector2D ErrorRangeSplineRotation {
    get => ref _Handle.AsRef<Vector2D>(Schema.GetOffset(0xD4FC71974DBFEF49));
  }
  public ref Vector2D ErrorRangeSplineTranslation {
    get => ref _Handle.AsRef<Vector2D>(Schema.GetOffset(0xD4FC71972D53C5DE));
  }
  public ref Vector2D ErrorRangeSplineScale {
    get => ref _Handle.AsRef<Vector2D>(Schema.GetOffset(0xD4FC7197E6E421C7));
  }
  public ref float IkRotation_MaxSplineError {
    get => ref _Handle.AsRef<float>(Schema.GetOffset(0xD4FC71971DA8FCB5));
  }
  public ref float IkTranslation_MaxSplineError {
    get => ref _Handle.AsRef<float>(Schema.GetOffset(0xD4FC719732DF1990));
  }
  public ref Vector2D ErrorRangeQuantizationRotation {
    get => ref _Handle.AsRef<Vector2D>(Schema.GetOffset(0xD4FC7197D6AADA59));
  }
  public ref Vector2D ErrorRangeQuantizationTranslation {
    get => ref _Handle.AsRef<Vector2D>(Schema.GetOffset(0xD4FC71975BCCF6AE));
  }
  public ref Vector2D ErrorRangeQuantizationScale {
    get => ref _Handle.AsRef<Vector2D>(Schema.GetOffset(0xD4FC7197E7487A37));
  }
  public ref float IkRotation_MaxQuantizationError {
    get => ref _Handle.AsRef<float>(Schema.GetOffset(0xD4FC71973F1ED56D));
  }
  public ref float IkTranslation_MaxQuantizationError {
    get => ref _Handle.AsRef<float>(Schema.GetOffset(0xD4FC7197BF5570E8));
  }
  public ref CUtlString BaseSequence {
    get => ref _Handle.AsRef<CUtlString>(Schema.GetOffset(0xD4FC719704AABA45));
  }
  public ref int BaseSequenceFrame {
    get => ref _Handle.AsRef<int>(Schema.GetOffset(0xD4FC71972BAAA932));
  }
  public ref EDemoBoneSelectionMode BoneSelectionMode {
    get => ref _Handle.AsRef<EDemoBoneSelectionMode>(Schema.GetOffset(0xD4FC71971C4BEF04));
  }
  public ref CUtlVector< BoneDemoCaptureSettings_t > Bones {
    get => ref _Handle.AsRef<CUtlVector< BoneDemoCaptureSettings_t >>(Schema.GetOffset(0xD4FC71970FDA60D4));
  }
  public ref CUtlVector< IKDemoCaptureSettings_t > IkChains {
    get => ref _Handle.AsRef<CUtlVector< IKDemoCaptureSettings_t >>(Schema.GetOffset(0xD4FC7197A467D4E7));
  }


}