using SwiftlyS2.Core.Schemas;
using SwiftlyS2.Shared.Schemas;
using SwiftlyS2.Core.Extensions;

namespace SwiftlyS2.Core.SchemaDefinitions;

internal partial class CBlendUpdateNode : CAnimUpdateNodeBase, IBlendUpdateNode {

  public CBlendUpdateNode(nint handle) : base(handle) {
  }

  public CBlendUpdateNode(nint handle, ulong hash, bool isField, bool isNetworked) : base(handle, hash, isField, isNetworked) {
  }

  public ref CUtlVector< CAnimUpdateNodeRef > Children {
    get => ref _Handle.AsRef<CUtlVector< CAnimUpdateNodeRef >>(Schema.GetOffset(0xD72498B47415FA72));
  }
  public ref CUtlVector< uint8 > SortedOrder {
    get => ref _Handle.AsRef<CUtlVector< uint8 >>(Schema.GetOffset(0xD72498B47CE82340));
  }
  public ref CUtlVector< float32 > TargetValues {
    get => ref _Handle.AsRef<CUtlVector< float32 >>(Schema.GetOffset(0xD72498B4913AEBFE));
  }
  public ref AnimValueSource BlendValueSource {
    get => ref _Handle.AsRef<AnimValueSource>(Schema.GetOffset(0xD72498B47AB7C374));
  }
  public ref LinearRootMotionBlendMode_t LinearRootMotionBlendMode {
    get => ref _Handle.AsRef<LinearRootMotionBlendMode_t>(Schema.GetOffset(0xD72498B4580BA151));
  }
  public IAnimParamHandle ParamIndex {
    get => new CAnimParamHandle(_Handle + Schema.GetOffset(0xD72498B461990A86));
  }
  public IAnimInputDamping Damping {
    get => new CAnimInputDamping(_Handle + Schema.GetOffset(0xD72498B415440FB5));
  }
  public ref BlendKeyType BlendKeyType {
    get => ref _Handle.AsRef<BlendKeyType>(Schema.GetOffset(0xD72498B4CD00B87F));
  }
  public ref bool LockBlendOnReset {
    get => ref _Handle.AsRef<bool>(Schema.GetOffset(0xD72498B476334223));
  }
  public ref bool SyncCycles {
    get => ref _Handle.AsRef<bool>(Schema.GetOffset(0xD72498B4EFFB5395));
  }
  public ref bool Loop {
    get => ref _Handle.AsRef<bool>(Schema.GetOffset(0xD72498B4C668A4CB));
  }
  public ref bool LockWhenWaning {
    get => ref _Handle.AsRef<bool>(Schema.GetOffset(0xD72498B4EED48004));
  }
  public ref bool IsAngle {
    get => ref _Handle.AsRef<bool>(Schema.GetOffset(0xD72498B4DE976A88));
  }


}