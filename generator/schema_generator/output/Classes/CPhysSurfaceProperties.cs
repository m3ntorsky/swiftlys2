using SwiftlyS2.Core.Schemas;
using SwiftlyS2.Shared.Schemas;
using SwiftlyS2.Core.Extensions;

namespace SwiftlyS2.Core.SchemaDefinitions;

internal partial class CPhysSurfaceProperties : SchemaClass, IPhysSurfaceProperties {

  public CPhysSurfaceProperties(nint handle) : base(handle) {
  }

  public CPhysSurfaceProperties(nint handle, ulong hash, bool isField, bool isNetworked) : base(handle, hash, isField, isNetworked) {
  }

  public ref CUtlString Name {
    get => ref _Handle.AsRef<CUtlString>(Schema.GetOffset(0x682A31344D8F5786));
  }
  public ref uint NameHash {
    get => ref _Handle.AsRef<uint>(Schema.GetOffset(0x682A313474C2670A));
  }
  public ref uint BaseNameHash {
    get => ref _Handle.AsRef<uint>(Schema.GetOffset(0x682A31347BCDC37B));
  }
  public ref bool Hidden {
    get => ref _Handle.AsRef<bool>(Schema.GetOffset(0x682A313457D2DC99));
  }
  public ref CUtlString Description {
    get => ref _Handle.AsRef<CUtlString>(Schema.GetOffset(0x682A313499F68389));
  }
  public IPhysSurfacePropertiesPhysics Physics {
    get => new CPhysSurfacePropertiesPhysics(_Handle + Schema.GetOffset(0x682A3134B4C7F5C2));
  }
  public IPhysSurfacePropertiesVehicle VehicleParams {
    get => new CPhysSurfacePropertiesVehicle(_Handle + Schema.GetOffset(0x682A3134FF85787D));
  }
  public IPhysSurfacePropertiesSoundNames AudioSounds {
    get => new CPhysSurfacePropertiesSoundNames(_Handle + Schema.GetOffset(0x682A3134F7E0C689));
  }
  public IPhysSurfacePropertiesAudio AudioParams {
    get => new CPhysSurfacePropertiesAudio(_Handle + Schema.GetOffset(0x682A3134BCDFAD3F));
  }


}