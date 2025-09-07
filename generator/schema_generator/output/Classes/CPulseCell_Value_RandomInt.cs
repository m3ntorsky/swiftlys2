using SwiftlyS2.Core.Schemas;
using SwiftlyS2.Shared.Schemas;
using SwiftlyS2.Core.Extensions;

namespace SwiftlyS2.Core.SchemaDefinitions;

internal partial class CPulseCell_Value_RandomInt : CPulseCell_BaseValue, IPulseCell_Value_RandomInt {

  public CPulseCell_Value_RandomInt(nint handle) : base(handle) {
  }

  public CPulseCell_Value_RandomInt(nint handle, ulong hash, bool isField, bool isNetworked) : base(handle, hash, isField, isNetworked) {
  }




}