using SwiftlyS2.Core.Schemas;
using SwiftlyS2.Shared.Schemas;
using SwiftlyS2.Core.Extensions;

namespace SwiftlyS2.Core.SchemaDefinitions;

internal partial class C_OP_BoxConstraint : CParticleFunctionConstraint, IC_OP_BoxConstraint {

  public C_OP_BoxConstraint(nint handle) : base(handle) {
  }

  public IParticleCollectionVecInput Min {
    get => new CParticleCollectionVecInput(_Handle + Schema.GetOffset(0x111EED71B0765F37));
  }
  public IParticleCollectionVecInput Max {
    get => new CParticleCollectionVecInput(_Handle + Schema.GetOffset(0x111EED71BE89FCF9));
  }
  public ref int CP {
    get => ref _Handle.AsRef<int>(Schema.GetOffset(0x111EED71EB661472));
  }
  public ref bool LocalSpace {
    get => ref _Handle.AsRef<bool>(Schema.GetOffset(0x111EED7162418E6E));
  }
  public ref bool AccountForRadius {
    get => ref _Handle.AsRef<bool>(Schema.GetOffset(0x111EED71E4DE9E21));
  }


}