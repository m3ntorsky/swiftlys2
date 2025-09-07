using SwiftlyS2.Core.Schemas;
using SwiftlyS2.Shared.Schemas;
using SwiftlyS2.Core.Extensions;

namespace SwiftlyS2.Core.SchemaDefinitions;

internal partial class CMorphConstraint : CBaseConstraint, IMorphConstraint {

  public CMorphConstraint(nint handle) : base(handle) {
  }

  public CMorphConstraint(nint handle, ulong hash, bool isField, bool isNetworked) : base(handle, hash, isField, isNetworked) {
  }

  public ref CUtlString TargetMorph {
    get => ref _Handle.AsRef<CUtlString>(Schema.GetOffset(0xC24859C39FF7D337));
  }
  public ref int SlaveChannel {
    get => ref _Handle.AsRef<int>(Schema.GetOffset(0xC24859C3A439DE4F));
  }
  public ref float Min {
    get => ref _Handle.AsRef<float>(Schema.GetOffset(0xC24859C33B1A5649));
  }
  public ref float Max {
    get => ref _Handle.AsRef<float>(Schema.GetOffset(0xC24859C32D06B887));
  }


}