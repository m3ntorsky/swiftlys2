using SwiftlyS2.Core.Schemas;
using SwiftlyS2.Shared.Schemas;
using SwiftlyS2.Core.Extensions;

namespace SwiftlyS2.Core.SchemaDefinitions;

internal partial class VecInputMaterialVariable_t : SchemaClass, IVecInputMaterialVariable_t {

  public VecInputMaterialVariable_t(nint handle) : base(handle) {
  }

  public VecInputMaterialVariable_t(nint handle, ulong hash, bool isField, bool isNetworked) : base(handle, hash, isField, isNetworked) {
  }

  public ref CUtlString StrVariable {
    get => ref _Handle.AsRef<CUtlString>(Schema.GetOffset(0x3A84C75DA52C3390));
  }
  public IParticleCollectionVecInput Input {
    get => new CParticleCollectionVecInput(_Handle + Schema.GetOffset(0x3A84C75D1EA0ED5B));
  }


}