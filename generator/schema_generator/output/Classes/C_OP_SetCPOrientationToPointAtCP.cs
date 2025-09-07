using SwiftlyS2.Core.Schemas;
using SwiftlyS2.Shared.Schemas;
using SwiftlyS2.Core.Extensions;

namespace SwiftlyS2.Core.SchemaDefinitions;

internal partial class C_OP_SetCPOrientationToPointAtCP : CParticleFunctionPreEmission, IC_OP_SetCPOrientationToPointAtCP {

  public C_OP_SetCPOrientationToPointAtCP(nint handle) : base(handle) {
  }

  public C_OP_SetCPOrientationToPointAtCP(nint handle, ulong hash, bool isField, bool isNetworked) : base(handle, hash, isField, isNetworked) {
  }

  public ref int InputCP {
    get => ref _Handle.AsRef<int>(Schema.GetOffset(0xEB886769F39A3C14));
  }
  public ref int OutputCP {
    get => ref _Handle.AsRef<int>(Schema.GetOffset(0xEB88676950DF5703));
  }
  public IParticleCollectionFloatInput Interpolation {
    get => new CParticleCollectionFloatInput(_Handle + Schema.GetOffset(0xEB886769CF55B987));
  }
  public ref bool B2DOrientation {
    get => ref _Handle.AsRef<bool>(Schema.GetOffset(0xEB886769D5B7C017));
  }
  public ref bool AvoidSingularity {
    get => ref _Handle.AsRef<bool>(Schema.GetOffset(0xEB8867694B0F0B45));
  }
  public ref bool PointAway {
    get => ref _Handle.AsRef<bool>(Schema.GetOffset(0xEB88676987355BAF));
  }


}