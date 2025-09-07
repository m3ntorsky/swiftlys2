using SwiftlyS2.Core.Schemas;
using SwiftlyS2.Shared.Schemas;
using SwiftlyS2.Core.Extensions;

namespace SwiftlyS2.Core.SchemaDefinitions;

internal partial class CFootStepTriggerUpdateNode : CUnaryUpdateNode, IFootStepTriggerUpdateNode {

  public CFootStepTriggerUpdateNode(nint handle) : base(handle) {
  }

  public CFootStepTriggerUpdateNode(nint handle, ulong hash, bool isField, bool isNetworked) : base(handle, hash, isField, isNetworked) {
  }

  public ref CUtlVector< FootStepTrigger > Triggers {
    get => ref _Handle.AsRef<CUtlVector< FootStepTrigger >>(Schema.GetOffset(0x799A3B55684C6AF0));
  }
  public ref float Tolerance {
    get => ref _Handle.AsRef<float>(Schema.GetOffset(0x799A3B558C29728E));
  }


}