using SwiftlyS2.Core.Schemas;
using SwiftlyS2.Shared.Schemas;
using SwiftlyS2.Core.Extensions;

namespace SwiftlyS2.Core.SchemaDefinitions;

internal partial class CPulseCell_BaseValue : CPulseCell_Base, IPulseCell_BaseValue {

  public CPulseCell_BaseValue(nint handle) : base(handle) {
  }

  public CPulseCell_BaseValue(nint handle, ulong hash, bool isField, bool isNetworked) : base(handle, hash, isField, isNetworked) {
  }




}