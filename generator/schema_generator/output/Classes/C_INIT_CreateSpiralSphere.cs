using SwiftlyS2.Core.Schemas;
using SwiftlyS2.Shared.Schemas;
using SwiftlyS2.Core.Extensions;

namespace SwiftlyS2.Core.SchemaDefinitions;

internal partial class C_INIT_CreateSpiralSphere : CParticleFunctionInitializer, IC_INIT_CreateSpiralSphere {

  public C_INIT_CreateSpiralSphere(nint handle) : base(handle) {
  }

  public C_INIT_CreateSpiralSphere(nint handle, ulong hash, bool isField, bool isNetworked) : base(handle, hash, isField, isNetworked) {
  }

  public ref int ControlPointNumber {
    get => ref _Handle.AsRef<int>(Schema.GetOffset(0x97C2018A3F31A6BD));
  }
  public ref int OverrideCP {
    get => ref _Handle.AsRef<int>(Schema.GetOffset(0x97C2018ADD495162));
  }
  public ref int Density {
    get => ref _Handle.AsRef<int>(Schema.GetOffset(0x97C2018AA65E630F));
  }
  public ref float InitialRadius {
    get => ref _Handle.AsRef<float>(Schema.GetOffset(0x97C2018A8B8AAB8B));
  }
  public ref float InitialSpeedMin {
    get => ref _Handle.AsRef<float>(Schema.GetOffset(0x97C2018AE36FD694));
  }
  public ref float InitialSpeedMax {
    get => ref _Handle.AsRef<float>(Schema.GetOffset(0x97C2018AD184D4F6));
  }
  public ref bool UseParticleCount {
    get => ref _Handle.AsRef<bool>(Schema.GetOffset(0x97C2018AD4DA0515));
  }


}