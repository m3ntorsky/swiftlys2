using SwiftlyS2.Core.Schemas;
using SwiftlyS2.Shared.Schemas;
using SwiftlyS2.Core.Extensions;

namespace SwiftlyS2.Core.SchemaDefinitions;

internal partial class C_OP_MaintainEmitter : CParticleFunctionEmitter, IC_OP_MaintainEmitter {

  public C_OP_MaintainEmitter(nint handle) : base(handle) {
  }

  public C_OP_MaintainEmitter(nint handle, ulong hash, bool isField, bool isNetworked) : base(handle, hash, isField, isNetworked) {
  }

  public IParticleCollectionFloatInput ParticlesToMaintain {
    get => new CParticleCollectionFloatInput(_Handle + Schema.GetOffset(0xAD7D6862537AE378));
  }
  public ref float StartTime {
    get => ref _Handle.AsRef<float>(Schema.GetOffset(0xAD7D686267FE9DC4));
  }
  public IParticleCollectionFloatInput EmissionDuration {
    get => new CParticleCollectionFloatInput(_Handle + Schema.GetOffset(0xAD7D686290181C90));
  }
  public ref float EmissionRate {
    get => ref _Handle.AsRef<float>(Schema.GetOffset(0xAD7D68620F6F6312));
  }
  public ref int SnapshotControlPoint {
    get => ref _Handle.AsRef<int>(Schema.GetOffset(0xAD7D6862192638EC));
  }
  public ref CUtlString StrSnapshotSubset {
    get => ref _Handle.AsRef<CUtlString>(Schema.GetOffset(0xAD7D6862BD8A8E5E));
  }
  public ref bool EmitInstantaneously {
    get => ref _Handle.AsRef<bool>(Schema.GetOffset(0xAD7D686205EFA03B));
  }
  public ref bool FinalEmitOnStop {
    get => ref _Handle.AsRef<bool>(Schema.GetOffset(0xAD7D68626A482A7D));
  }
  public IParticleCollectionFloatInput Scale {
    get => new CParticleCollectionFloatInput(_Handle + Schema.GetOffset(0xAD7D6862B731A42F));
  }


}