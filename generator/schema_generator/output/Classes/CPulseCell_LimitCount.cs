using SwiftlyS2.Core.Schemas;
using SwiftlyS2.Shared.Schemas;
using SwiftlyS2.Core.Extensions;

namespace SwiftlyS2.Core.SchemaDefinitions;

internal partial class CPulseCell_LimitCount : CPulseCell_BaseRequirement, IPulseCell_LimitCount {

  public CPulseCell_LimitCount(nint handle) : base(handle) {
  }

  public CPulseCell_LimitCount(nint handle, ulong hash, bool isField, bool isNetworked) : base(handle, hash, isField, isNetworked) {
  }

  public ref int LimitCount {
    get => ref _Handle.AsRef<int>(Schema.GetOffset(0x879D9892603807FF));
  }


}