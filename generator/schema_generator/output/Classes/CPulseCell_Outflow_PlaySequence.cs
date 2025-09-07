using SwiftlyS2.Core.Schemas;
using SwiftlyS2.Shared.Schemas;
using SwiftlyS2.Core.Extensions;

namespace SwiftlyS2.Core.SchemaDefinitions;

internal partial class CPulseCell_Outflow_PlaySequence : CPulseCell_Outflow_PlaySceneBase, IPulseCell_Outflow_PlaySequence {

  public CPulseCell_Outflow_PlaySequence(nint handle) : base(handle) {
  }

  public CPulseCell_Outflow_PlaySequence(nint handle, ulong hash, bool isField, bool isNetworked) : base(handle, hash, isField, isNetworked) {
  }

  public ref CUtlString ParamSequenceName {
    get => ref _Handle.AsRef<CUtlString>(Schema.GetOffset(0x9E1D42661D9365E0));
  }


}