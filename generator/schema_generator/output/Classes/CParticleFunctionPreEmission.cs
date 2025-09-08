using SwiftlyS2.Core.Schemas;
using SwiftlyS2.Shared.Schemas;
using SwiftlyS2.Core.Extensions;

namespace SwiftlyS2.Core.SchemaDefinitions;

internal partial class CParticleFunctionPreEmission : CParticleFunctionOperator, IParticleFunctionPreEmission {

  public CParticleFunctionPreEmission(nint handle) : base(handle) {
  }

  public ref bool RunOnce {
    get => ref _Handle.AsRef<bool>(Schema.GetOffset(0x60FF68618CD905F));
  }


}