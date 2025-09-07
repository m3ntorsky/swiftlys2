using SwiftlyS2.Core.Schemas;
using SwiftlyS2.Shared.Schemas;
using SwiftlyS2.Core.Extensions;

namespace SwiftlyS2.Core.SchemaDefinitions;

internal partial class CPhysMagnet : CBaseAnimGraph, IPhysMagnet {

  public CPhysMagnet(nint handle) : base(handle) {
  }

  public CPhysMagnet(nint handle, ulong hash, bool isField, bool isNetworked) : base(handle, hash, isField, isNetworked) {
  }

  public IEntityIOOutput OnMagnetAttach {
    get => new CEntityIOOutput(_Handle + Schema.GetOffset(0x5772891055B6907B));
  }
  public IEntityIOOutput OnMagnetDetach {
    get => new CEntityIOOutput(_Handle + Schema.GetOffset(0x57728910FA716045));
  }
  public ref float MassScale {
    get => ref _Handle.AsRef<float>(Schema.GetOffset(0x5772891001B9E905));
  }
  public ref float ForceLimit {
    get => ref _Handle.AsRef<float>(Schema.GetOffset(0x57728910BA45B8F7));
  }
  public ref float TorqueLimit {
    get => ref _Handle.AsRef<float>(Schema.GetOffset(0x577289106D51FE3E));
  }
  public ref CUtlVector< magnetted_objects_t > MagnettedEntities {
    get => ref _Handle.AsRef<CUtlVector< magnetted_objects_t >>(Schema.GetOffset(0x57728910E39284F3));
  }
  public ref bool Active {
    get => ref _Handle.AsRef<bool>(Schema.GetOffset(0x577289108334208F));
  }
  public ref bool HasHitSomething {
    get => ref _Handle.AsRef<bool>(Schema.GetOffset(0x577289109E7903E0));
  }
  public ref float TotalMass {
    get => ref _Handle.AsRef<float>(Schema.GetOffset(0x57728910A3F382DB));
  }
  public ref float Radius {
    get => ref _Handle.AsRef<float>(Schema.GetOffset(0x577289105ACFC08D));
  }
  public IGameTime_t NextSuckTime {
    get => new GameTime_t(_Handle + Schema.GetOffset(0x577289102E3592CD));
  }
  public ref int MaxObjectsAttached {
    get => ref _Handle.AsRef<int>(Schema.GetOffset(0x57728910326F6EB6));
  }


}