using SwiftlyS2.Core.Schemas;
using SwiftlyS2.Shared.Schemas;
using SwiftlyS2.Core.Extensions;

namespace SwiftlyS2.Core.SchemaDefinitions;

internal partial class CPulseCell_Step_SetAnimGraphParam : CPulseCell_BaseFlow, IPulseCell_Step_SetAnimGraphParam {

  public CPulseCell_Step_SetAnimGraphParam(nint handle) : base(handle) {
  }

  public CPulseCell_Step_SetAnimGraphParam(nint handle, ulong hash, bool isField, bool isNetworked) : base(handle, hash, isField, isNetworked) {
  }

  public ref CUtlString ParamName {
    get => ref _Handle.AsRef<CUtlString>(Schema.GetOffset(0x7727698D230FDA59));
  }


}