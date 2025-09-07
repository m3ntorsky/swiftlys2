using SwiftlyS2.Core.Schemas;
using SwiftlyS2.Shared.Schemas;
using SwiftlyS2.Core.Extensions;

namespace SwiftlyS2.Core.SchemaDefinitions;

internal partial class CPulseCell_BaseRequirement : CPulseCell_Base, IPulseCell_BaseRequirement {

  public CPulseCell_BaseRequirement(nint handle) : base(handle) {
  }

  public CPulseCell_BaseRequirement(nint handle, ulong hash, bool isField, bool isNetworked) : base(handle, hash, isField, isNetworked) {
  }




}