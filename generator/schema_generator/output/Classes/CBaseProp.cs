using SwiftlyS2.Core.Schemas;
using SwiftlyS2.Shared.Schemas;
using SwiftlyS2.Core.Extensions;

namespace SwiftlyS2.Core.SchemaDefinitions;

internal partial class CBaseProp : CBaseAnimGraph, IBaseProp {

  public CBaseProp(nint handle) : base(handle) {
  }

  public ref bool ModelOverrodeBlockLOS {
    get => ref _Handle.AsRef<bool>(Schema.GetOffset(0x14D39FA24CF7EDF1));
  }
  public ref int ShapeType {
    get => ref _Handle.AsRef<int>(Schema.GetOffset(0x14D39FA23BE42771));
  }
  public ref bool ConformToCollisionBounds {
    get => ref _Handle.AsRef<bool>(Schema.GetOffset(0x14D39FA2A98E60A1));
  }
  public ref CTransform MPreferredCatchTransform {
    get => ref _Handle.AsRef<CTransform>(Schema.GetOffset(0x14D39FA2CC626070));
  }


}