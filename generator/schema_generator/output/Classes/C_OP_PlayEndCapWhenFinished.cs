using SwiftlyS2.Core.Schemas;
using SwiftlyS2.Shared.Schemas;
using SwiftlyS2.Core.Extensions;

namespace SwiftlyS2.Core.SchemaDefinitions;

internal partial class C_OP_PlayEndCapWhenFinished : CParticleFunctionPreEmission, IC_OP_PlayEndCapWhenFinished {

  public C_OP_PlayEndCapWhenFinished(nint handle) : base(handle) {
  }

  public ref bool FireOnEmissionEnd {
    get => ref _Handle.AsRef<bool>(Schema.GetOffset(0xFC89982E01C357B0));
  }
  public ref bool IncludeChildren {
    get => ref _Handle.AsRef<bool>(Schema.GetOffset(0xFC89982EA7706C80));
  }


}