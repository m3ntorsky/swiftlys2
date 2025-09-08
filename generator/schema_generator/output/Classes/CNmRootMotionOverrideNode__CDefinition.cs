using SwiftlyS2.Core.Schemas;
using SwiftlyS2.Shared.Schemas;
using SwiftlyS2.Core.Extensions;

namespace SwiftlyS2.Core.SchemaDefinitions;

internal partial class CNmRootMotionOverrideNode__CDefinition : CNmPassthroughNode::CDefinition, INmRootMotionOverrideNode__CDefinition {

  public CNmRootMotionOverrideNode__CDefinition(nint handle) : base(handle) {
  }

  public ref short DesiredMovingVelocityNodeIdx {
    get => ref _Handle.AsRef<short>(Schema.GetOffset(0x63AAD28BA5EFD80B));
  }
  public ref short DesiredFacingDirectionNodeIdx {
    get => ref _Handle.AsRef<short>(Schema.GetOffset(0x63AAD28BAC723A63));
  }
  public ref short LinearVelocityLimitNodeIdx {
    get => ref _Handle.AsRef<short>(Schema.GetOffset(0x63AAD28B56A698BD));
  }
  public ref short AngularVelocityLimitNodeIdx {
    get => ref _Handle.AsRef<short>(Schema.GetOffset(0x63AAD28BCC9208F8));
  }
  public ref float MaxLinearVelocity {
    get => ref _Handle.AsRef<float>(Schema.GetOffset(0x63AAD28B70FC93F7));
  }
  public ref float MaxAngularVelocityRadians {
    get => ref _Handle.AsRef<float>(Schema.GetOffset(0x63AAD28BC15BAB90));
  }
  public INmBitFlags OverrideFlags {
    get => new CNmBitFlags(_Handle + Schema.GetOffset(0x63AAD28BBDB571A4));
  }


}