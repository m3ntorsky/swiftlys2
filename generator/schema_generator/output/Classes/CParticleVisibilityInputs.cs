using SwiftlyS2.Core.Schemas;
using SwiftlyS2.Shared.Schemas;
using SwiftlyS2.Core.Extensions;

namespace SwiftlyS2.Core.SchemaDefinitions;

internal partial class CParticleVisibilityInputs : SchemaClass, IParticleVisibilityInputs {

  public CParticleVisibilityInputs(nint handle) : base(handle) {
  }

  public CParticleVisibilityInputs(nint handle, ulong hash, bool isField, bool isNetworked) : base(handle, hash, isField, isNetworked) {
  }

  public ref float CameraBias {
    get => ref _Handle.AsRef<float>(Schema.GetOffset(0xF3FC60F57CAF2EE5));
  }
  public ref int CPin {
    get => ref _Handle.AsRef<int>(Schema.GetOffset(0xF3FC60F5CAA9CA3D));
  }
  public ref float ProxyRadius {
    get => ref _Handle.AsRef<float>(Schema.GetOffset(0xF3FC60F55BDAD4C7));
  }
  public ref float InputMin {
    get => ref _Handle.AsRef<float>(Schema.GetOffset(0xF3FC60F5E88A0D0F));
  }
  public ref float InputMax {
    get => ref _Handle.AsRef<float>(Schema.GetOffset(0xF3FC60F5D6766901));
  }
  public ref float InputPixelVisFade {
    get => ref _Handle.AsRef<float>(Schema.GetOffset(0xF3FC60F521E711C1));
  }
  public ref float NoPixelVisibilityFallback {
    get => ref _Handle.AsRef<float>(Schema.GetOffset(0xF3FC60F586460B8E));
  }
  public ref float DistanceInputMin {
    get => ref _Handle.AsRef<float>(Schema.GetOffset(0xF3FC60F5D734ED90));
  }
  public ref float DistanceInputMax {
    get => ref _Handle.AsRef<float>(Schema.GetOffset(0xF3FC60F5CD21561A));
  }
  public ref float DotInputMin {
    get => ref _Handle.AsRef<float>(Schema.GetOffset(0xF3FC60F5AD21DD8A));
  }
  public ref float DotInputMax {
    get => ref _Handle.AsRef<float>(Schema.GetOffset(0xF3FC60F5B7357500));
  }
  public ref bool DotCPAngles {
    get => ref _Handle.AsRef<bool>(Schema.GetOffset(0xF3FC60F50D0315CB));
  }
  public ref bool DotCameraAngles {
    get => ref _Handle.AsRef<bool>(Schema.GetOffset(0xF3FC60F5A84A80CF));
  }
  public ref float AlphaScaleMin {
    get => ref _Handle.AsRef<float>(Schema.GetOffset(0xF3FC60F53AEC0597));
  }
  public ref float AlphaScaleMax {
    get => ref _Handle.AsRef<float>(Schema.GetOffset(0xF3FC60F548FFA359));
  }
  public ref float RadiusScaleMin {
    get => ref _Handle.AsRef<float>(Schema.GetOffset(0xF3FC60F53A308DB3));
  }
  public ref float RadiusScaleMax {
    get => ref _Handle.AsRef<float>(Schema.GetOffset(0xF3FC60F55044380D));
  }
  public ref float RadiusScaleFOVBase {
    get => ref _Handle.AsRef<float>(Schema.GetOffset(0xF3FC60F521D6B3D5));
  }
  public ref bool RightEye {
    get => ref _Handle.AsRef<bool>(Schema.GetOffset(0xF3FC60F5D4BB0DBA));
  }


}