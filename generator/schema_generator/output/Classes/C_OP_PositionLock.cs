using SwiftlyS2.Core.Schemas;
using SwiftlyS2.Shared.Schemas;
using SwiftlyS2.Core.Extensions;

namespace SwiftlyS2.Core.SchemaDefinitions;

internal partial class C_OP_PositionLock : CParticleFunctionOperator, IC_OP_PositionLock {

  public C_OP_PositionLock(nint handle) : base(handle) {
  }

  public C_OP_PositionLock(nint handle, ulong hash, bool isField, bool isNetworked) : base(handle, hash, isField, isNetworked) {
  }

  public IParticleTransformInput TransformInput {
    get => new CParticleTransformInput(_Handle + Schema.GetOffset(0xCE90EAD5B3FDC289));
  }
  public ref float StartTime_min {
    get => ref _Handle.AsRef<float>(Schema.GetOffset(0xCE90EAD55AC75BFB));
  }
  public ref float StartTime_max {
    get => ref _Handle.AsRef<float>(Schema.GetOffset(0xCE90EAD550B23185));
  }
  public ref float StartTime_exp {
    get => ref _Handle.AsRef<float>(Schema.GetOffset(0xCE90EAD5E9B22DE4));
  }
  public ref float EndTime_min {
    get => ref _Handle.AsRef<float>(Schema.GetOffset(0xCE90EAD57B891932));
  }
  public ref float EndTime_max {
    get => ref _Handle.AsRef<float>(Schema.GetOffset(0xCE90EAD58575A138));
  }
  public ref float EndTime_exp {
    get => ref _Handle.AsRef<float>(Schema.GetOffset(0xCE90EAD51CA4CB99));
  }
  public ref float Range {
    get => ref _Handle.AsRef<float>(Schema.GetOffset(0xCE90EAD53FC92844));
  }
  public IParticleCollectionFloatInput RangeBias {
    get => new CParticleCollectionFloatInput(_Handle + Schema.GetOffset(0xCE90EAD56BC1F129));
  }
  public ref float JumpThreshold {
    get => ref _Handle.AsRef<float>(Schema.GetOffset(0xCE90EAD5B6BB1AD6));
  }
  public ref float PrevPosScale {
    get => ref _Handle.AsRef<float>(Schema.GetOffset(0xCE90EAD546CED122));
  }
  public ref bool LockRot {
    get => ref _Handle.AsRef<bool>(Schema.GetOffset(0xCE90EAD5549B459B));
  }
  public IParticleCollectionVecInput Scale {
    get => new CParticleCollectionVecInput(_Handle + Schema.GetOffset(0xCE90EAD55F596B51));
  }
  public IParticleAttributeIndex_t FieldOutput {
    get => new ParticleAttributeIndex_t(_Handle + Schema.GetOffset(0xCE90EAD5E5729606));
  }
  public IParticleAttributeIndex_t FieldOutputPrev {
    get => new ParticleAttributeIndex_t(_Handle + Schema.GetOffset(0xCE90EAD568D9463B));
  }


}