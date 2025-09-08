using SwiftlyS2.Core.Schemas;
using SwiftlyS2.Shared.Schemas;
using SwiftlyS2.Core.Extensions;

namespace SwiftlyS2.Core.SchemaDefinitions;

internal partial class C_OP_MaxVelocity : CParticleFunctionOperator, IC_OP_MaxVelocity {

  public C_OP_MaxVelocity(nint handle) : base(handle) {
  }

  public ref float MaxVelocity {
    get => ref _Handle.AsRef<float>(Schema.GetOffset(0xE7D67D7E281BD640));
  }
  public ref float MinVelocity {
    get => ref _Handle.AsRef<float>(Schema.GetOffset(0xE7D67D7EAE8F0ADE));
  }
  public ref int OverrideCP {
    get => ref _Handle.AsRef<int>(Schema.GetOffset(0xE7D67D7EDD495162));
  }
  public ref int OverrideCPField {
    get => ref _Handle.AsRef<int>(Schema.GetOffset(0xE7D67D7E2FF9A086));
  }


}