using SwiftlyS2.Core.Schemas;
using SwiftlyS2.Shared.Schemas;
using SwiftlyS2.Core.Extensions;

namespace SwiftlyS2.Core.SchemaDefinitions;

internal partial class C_OP_ChooseRandomChildrenInGroup : CParticleFunctionPreEmission, IC_OP_ChooseRandomChildrenInGroup {

  public C_OP_ChooseRandomChildrenInGroup(nint handle) : base(handle) {
  }

  public ref int ChildGroupID {
    get => ref _Handle.AsRef<int>(Schema.GetOffset(0xF79CD816E3F3C965));
  }
  public IParticleCollectionFloatInput NumberOfChildren {
    get => new CParticleCollectionFloatInput(_Handle + Schema.GetOffset(0xF79CD8160275D868));
  }


}