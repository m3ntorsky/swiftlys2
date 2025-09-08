using SwiftlyS2.Core.Schemas;
using SwiftlyS2.Shared.Schemas;
using SwiftlyS2.Core.Extensions;

namespace SwiftlyS2.Core.SchemaDefinitions;

internal partial class CMotionGraphGroup : SchemaClass, IMotionGraphGroup {

  public CMotionGraphGroup(nint handle) : base(handle) {
  }

  public IMotionSearchDB SearchDB {
    get => new CMotionSearchDB(_Handle + Schema.GetOffset(0x34D64AAF5662226F));
  }
  public ref CUtlVector MotionGraphs {
    get => ref _Handle.AsRef<CUtlVector>(Schema.GetOffset(0x34D64AAFE9CB46D2));
  }
  public ref CUtlVector MotionGraphConfigs {
    get => ref _Handle.AsRef<CUtlVector>(Schema.GetOffset(0x34D64AAF8D9A544C));
  }
  public ref CUtlVector<int> SampleToConfig {
    get => ref _Handle.AsRef<CUtlVector<int>>(Schema.GetOffset(0x34D64AAF85EC9B7C));
  }
  public IAnimScriptHandle IsActiveScript {
    get => new AnimScriptHandle(_Handle + Schema.GetOffset(0x34D64AAFF2DBEC2A));
  }


}