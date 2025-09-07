using SwiftlyS2.Core.Schemas;
using SwiftlyS2.Shared.Schemas;
using SwiftlyS2.Core.Extensions;

namespace SwiftlyS2.Core.SchemaDefinitions;

internal partial class CFootAdjustmentUpdateNode : CUnaryUpdateNode, IFootAdjustmentUpdateNode {

  public CFootAdjustmentUpdateNode(nint handle) : base(handle) {
  }

  public CFootAdjustmentUpdateNode(nint handle, ulong hash, bool isField, bool isNetworked) : base(handle, hash, isField, isNetworked) {
  }

  public ref CUtlVector< HSequence > Clips {
    get => ref _Handle.AsRef<CUtlVector< HSequence >>(Schema.GetOffset(0x667ADE248CB21A38));
  }
  public IPoseHandle BasePoseCacheHandle {
    get => new CPoseHandle(_Handle + Schema.GetOffset(0x667ADE240690C505));
  }
  public IAnimParamHandle FacingTarget {
    get => new CAnimParamHandle(_Handle + Schema.GetOffset(0x667ADE24ED73C452));
  }
  public ref float TurnTimeMin {
    get => ref _Handle.AsRef<float>(Schema.GetOffset(0x667ADE247BF2813F));
  }
  public ref float TurnTimeMax {
    get => ref _Handle.AsRef<float>(Schema.GetOffset(0x667ADE2489DF0F91));
  }
  public ref float StepHeightMax {
    get => ref _Handle.AsRef<float>(Schema.GetOffset(0x667ADE24C48F8DDC));
  }
  public ref float StepHeightMaxAngle {
    get => ref _Handle.AsRef<float>(Schema.GetOffset(0x667ADE24E36AE247));
  }
  public ref bool ResetChild {
    get => ref _Handle.AsRef<bool>(Schema.GetOffset(0x667ADE2465CC88B6));
  }
  public ref bool AnimationDriven {
    get => ref _Handle.AsRef<bool>(Schema.GetOffset(0x667ADE24B5FFC0F3));
  }


}