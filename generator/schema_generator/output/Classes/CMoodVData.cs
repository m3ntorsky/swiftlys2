using SwiftlyS2.Core.Schemas;
using SwiftlyS2.Shared.Schemas;
using SwiftlyS2.Core.Extensions;

namespace SwiftlyS2.Core.SchemaDefinitions;

internal partial class CMoodVData : SchemaClass, IMoodVData {

  public CMoodVData(nint handle) : base(handle) {
  }

  public CMoodVData(nint handle, ulong hash, bool isField, bool isNetworked) : base(handle, hash, isField, isNetworked) {
  }

  public ISchemaUntypedField ModelName {
    get => new SchemaUntypedField(_Handle + Schema.GetOffset(0x3C9F4201002A227C));
  }
  public ref MoodType_t MoodType {
    get => ref _Handle.AsRef<MoodType_t>(Schema.GetOffset(0x3C9F42019039BEAA));
  }
  public ref CUtlVector< MoodAnimationLayer_t > AnimationLayers {
    get => ref _Handle.AsRef<CUtlVector< MoodAnimationLayer_t >>(Schema.GetOffset(0x3C9F420179729D37));
  }


}