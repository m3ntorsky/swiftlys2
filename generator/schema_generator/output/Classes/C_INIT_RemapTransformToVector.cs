using SwiftlyS2.Core.Schemas;
using SwiftlyS2.Shared.Schemas;
using SwiftlyS2.Core.Extensions;

namespace SwiftlyS2.Core.SchemaDefinitions;

internal partial class C_INIT_RemapTransformToVector : CParticleFunctionInitializer, IC_INIT_RemapTransformToVector {

  public C_INIT_RemapTransformToVector(nint handle) : base(handle) {
  }

  public C_INIT_RemapTransformToVector(nint handle, ulong hash, bool isField, bool isNetworked) : base(handle, hash, isField, isNetworked) {
  }

  public IParticleAttributeIndex_t FieldOutput {
    get => new ParticleAttributeIndex_t(_Handle + Schema.GetOffset(0xED3971B7E5729606));
  }
  public ref Vector InputMin {
    get => ref _Handle.AsRef<Vector>(Schema.GetOffset(0xED3971B7367FBCC9));
  }
  public ref Vector InputMax {
    get => ref _Handle.AsRef<Vector>(Schema.GetOffset(0xED3971B7286C1F07));
  }
  public ref Vector OutputMin {
    get => ref _Handle.AsRef<Vector>(Schema.GetOffset(0xED3971B7A04D6C7C));
  }
  public ref Vector OutputMax {
    get => ref _Handle.AsRef<Vector>(Schema.GetOffset(0xED3971B78E39C86E));
  }
  public IParticleTransformInput TransformInput {
    get => new CParticleTransformInput(_Handle + Schema.GetOffset(0xED3971B7B3FDC289));
  }
  public IParticleTransformInput LocalSpaceTransform {
    get => new CParticleTransformInput(_Handle + Schema.GetOffset(0xED3971B733F99C86));
  }
  public ref float StartTime {
    get => ref _Handle.AsRef<float>(Schema.GetOffset(0xED3971B767FE9DC4));
  }
  public ref float EndTime {
    get => ref _Handle.AsRef<float>(Schema.GetOffset(0xED3971B72041DF9D));
  }
  public ref ParticleSetMethod_t SetMethod {
    get => ref _Handle.AsRef<ParticleSetMethod_t>(Schema.GetOffset(0xED3971B7FB53C31E));
  }
  public ref bool Offset {
    get => ref _Handle.AsRef<bool>(Schema.GetOffset(0xED3971B717412B2A));
  }
  public ref bool Accelerate {
    get => ref _Handle.AsRef<bool>(Schema.GetOffset(0xED3971B7A9BEFF50));
  }
  public ref float RemapBias {
    get => ref _Handle.AsRef<float>(Schema.GetOffset(0xED3971B7490D7325));
  }


}