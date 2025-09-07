using SwiftlyS2.Core.Schemas;
using SwiftlyS2.Shared.Schemas;
using SwiftlyS2.Core.Extensions;

namespace SwiftlyS2.Core.SchemaDefinitions;

internal partial class CStanceOverrideUpdateNode : CUnaryUpdateNode, IStanceOverrideUpdateNode {

  public CStanceOverrideUpdateNode(nint handle) : base(handle) {
  }

  public CStanceOverrideUpdateNode(nint handle, ulong hash, bool isField, bool isNetworked) : base(handle, hash, isField, isNetworked) {
  }

  public ref CUtlVector< StanceInfo_t > FootStanceInfo {
    get => ref _Handle.AsRef<CUtlVector< StanceInfo_t >>(Schema.GetOffset(0x322EE1B7D5687289));
  }
  public IAnimUpdateNodeRef StanceSourceNode {
    get => new CAnimUpdateNodeRef(_Handle + Schema.GetOffset(0x322EE1B7D25DA07A));
  }
  public IAnimParamHandle Parameter {
    get => new CAnimParamHandle(_Handle + Schema.GetOffset(0x322EE1B70C7008F6));
  }
  public ref StanceOverrideMode Mode {
    get => ref _Handle.AsRef<StanceOverrideMode>(Schema.GetOffset(0x322EE1B71050A633));
  }


}