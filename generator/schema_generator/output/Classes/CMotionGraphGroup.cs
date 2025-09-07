using SwiftlyS2.Core.Schemas;
using SwiftlyS2.Shared.Schemas;
using SwiftlyS2.Core.Extensions;

namespace SwiftlyS2.Core.SchemaDefinitions;

internal partial class CMotionGraphGroup : SchemaClass, IMotionGraphGroup {

  public CMotionGraphGroup(nint handle) : base(handle) {
  }

  public CMotionGraphGroup(nint handle, ulong hash, bool isField, bool isNetworked) : base(handle, hash, isField, isNetworked) {
  }

  public IMotionSearchDB SearchDB {
    get => new CMotionSearchDB(_Handle + Schema.GetOffset(0x34D64AAF5662226F));
  }
  public ref CUtlVector< CSmartPtr< CMotionGraph > > MotionGraphs {
    get => ref _Handle.AsRef<CUtlVector< CSmartPtr< CMotionGraph > >>(Schema.GetOffset(0x34D64AAFE9CB46D2));
  }
  public ref CUtlVector< CMotionGraphConfig > MotionGraphConfigs {
    get => ref _Handle.AsRef<CUtlVector< CMotionGraphConfig >>(Schema.GetOffset(0x34D64AAF8D9A544C));
  }
  public ref CUtlVector< int32 > SampleToConfig {
    get => ref _Handle.AsRef<CUtlVector< int32 >>(Schema.GetOffset(0x34D64AAF85EC9B7C));
  }
  public IAnimScriptHandle IsActiveScript {
    get => new AnimScriptHandle(_Handle + Schema.GetOffset(0x34D64AAFF2DBEC2A));
  }


}