using SwiftlyS2.Core.Schemas;
using SwiftlyS2.Shared.Schemas;
using SwiftlyS2.Core.Extensions;

namespace SwiftlyS2.Core.SchemaDefinitions;

internal partial class C_INIT_RemapScalarToVector : CParticleFunctionInitializer, IC_INIT_RemapScalarToVector {

  public C_INIT_RemapScalarToVector(nint handle) : base(handle) {
  }

  public C_INIT_RemapScalarToVector(nint handle, ulong hash, bool isField, bool isNetworked) : base(handle, hash, isField, isNetworked) {
  }

  public IParticleAttributeIndex_t FieldInput {
    get => new ParticleAttributeIndex_t(_Handle + Schema.GetOffset(0x8CA3FD8DAE775669));
  }
  public IParticleAttributeIndex_t FieldOutput {
    get => new ParticleAttributeIndex_t(_Handle + Schema.GetOffset(0x8CA3FD8DE5729606));
  }
  public ref float InputMin {
    get => ref _Handle.AsRef<float>(Schema.GetOffset(0x8CA3FD8DE88A0D0F));
  }
  public ref float InputMax {
    get => ref _Handle.AsRef<float>(Schema.GetOffset(0x8CA3FD8DD6766901));
  }
  public ref Vector OutputMin {
    get => ref _Handle.AsRef<Vector>(Schema.GetOffset(0x8CA3FD8D2EFED678));
  }
  public ref Vector OutputMax {
    get => ref _Handle.AsRef<Vector>(Schema.GetOffset(0x8CA3FD8D451280D2));
  }
  public ref float StartTime {
    get => ref _Handle.AsRef<float>(Schema.GetOffset(0x8CA3FD8D67FE9DC4));
  }
  public ref float EndTime {
    get => ref _Handle.AsRef<float>(Schema.GetOffset(0x8CA3FD8D2041DF9D));
  }
  public ref ParticleSetMethod_t SetMethod {
    get => ref _Handle.AsRef<ParticleSetMethod_t>(Schema.GetOffset(0x8CA3FD8DFB53C31E));
  }
  public ref int ControlPointNumber {
    get => ref _Handle.AsRef<int>(Schema.GetOffset(0x8CA3FD8D3F31A6BD));
  }
  public ref bool LocalCoords {
    get => ref _Handle.AsRef<bool>(Schema.GetOffset(0x8CA3FD8D30E716DE));
  }
  public ref float RemapBias {
    get => ref _Handle.AsRef<float>(Schema.GetOffset(0x8CA3FD8D490D7325));
  }


}