using SwiftlyS2.Core.Schemas;
using SwiftlyS2.Shared.Schemas;
using SwiftlyS2.Core.Extensions;

namespace SwiftlyS2.Core.SchemaDefinitions;

internal partial class CChoiceUpdateNode : CAnimUpdateNodeBase, IChoiceUpdateNode {

  public CChoiceUpdateNode(nint handle) : base(handle) {
  }

  public CChoiceUpdateNode(nint handle, ulong hash, bool isField, bool isNetworked) : base(handle, hash, isField, isNetworked) {
  }

  public ref CUtlVector< CAnimUpdateNodeRef > Children {
    get => ref _Handle.AsRef<CUtlVector< CAnimUpdateNodeRef >>(Schema.GetOffset(0x1CF0A6AC7415FA72));
  }
  public ref CUtlVector< float32 > Weights {
    get => ref _Handle.AsRef<CUtlVector< float32 >>(Schema.GetOffset(0x1CF0A6AC77B2F91E));
  }
  public ref CUtlVector< float32 > BlendTimes {
    get => ref _Handle.AsRef<CUtlVector< float32 >>(Schema.GetOffset(0x1CF0A6AC12AD0366));
  }
  public ref ChoiceMethod ChoiceMethod {
    get => ref _Handle.AsRef<ChoiceMethod>(Schema.GetOffset(0x1CF0A6AC4E106F5B));
  }
  public ref ChoiceChangeMethod ChoiceChangeMethod {
    get => ref _Handle.AsRef<ChoiceChangeMethod>(Schema.GetOffset(0x1CF0A6AC265F1E7F));
  }
  public ref ChoiceBlendMethod BlendMethod {
    get => ref _Handle.AsRef<ChoiceBlendMethod>(Schema.GetOffset(0x1CF0A6ACFF929529));
  }
  public ref float BlendTime {
    get => ref _Handle.AsRef<float>(Schema.GetOffset(0x1CF0A6AC73D026B1));
  }
  public ref bool CrossFade {
    get => ref _Handle.AsRef<bool>(Schema.GetOffset(0x1CF0A6AC64BEC665));
  }
  public ref bool ResetChosen {
    get => ref _Handle.AsRef<bool>(Schema.GetOffset(0x1CF0A6AC2FFC43FA));
  }
  public ref bool DontResetSameSelection {
    get => ref _Handle.AsRef<bool>(Schema.GetOffset(0x1CF0A6ACB9EC0773));
  }


}