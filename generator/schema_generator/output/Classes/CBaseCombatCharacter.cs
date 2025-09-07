using SwiftlyS2.Core.Schemas;
using SwiftlyS2.Shared.Schemas;
using SwiftlyS2.Core.Extensions;

namespace SwiftlyS2.Core.SchemaDefinitions;

internal partial class CBaseCombatCharacter : CBaseFlex, IBaseCombatCharacter {

  public CBaseCombatCharacter(nint handle) : base(handle) {
  }

  public CBaseCombatCharacter(nint handle, ulong hash, bool isField, bool isNetworked) : base(handle, hash, isField, isNetworked) {
  }

  public ref bool ForceServerRagdoll {
    get => ref _Handle.AsRef<bool>(Schema.GetOffset(0xB47DE3DEC0D0B742));
  }
  public ref CUtlVector< CHandle< CEconWearable > > MyWearables {
    get => ref _Handle.AsRef<CUtlVector< CHandle< CEconWearable > >>(Schema.GetOffset(0xB47DE3DE000B8B43));
  }
  public ref float ImpactEnergyScale {
    get => ref _Handle.AsRef<float>(Schema.GetOffset(0xB47DE3DEC66BAC1B));
  }
  public ref int MinVehicleDamageToTempRagdoll {
    get => ref _Handle.AsRef<int>(Schema.GetOffset(0xB47DE3DE5D22468A));
  }
  public ref bool ApplyStressDamage {
    get => ref _Handle.AsRef<bool>(Schema.GetOffset(0xB47DE3DEC16FF452));
  }
  public ref bool DeathEventsDispatched {
    get => ref _Handle.AsRef<bool>(Schema.GetOffset(0xB47DE3DE8F5C8C9F));
  }
  public ref CUtlVector< RelationshipOverride_t > VecRelationships {
    get => ref _Handle.Deref<CUtlVector< RelationshipOverride_t >>(Schema.GetOffset(0xB47DE3DE2B978F5E));
  }
  public ref CUtlSymbolLarge StrRelationships {
    get => ref _Handle.AsRef<CUtlSymbolLarge>(Schema.GetOffset(0xB47DE3DEF96E2AD7));
  }
  public ref Hull_t Hull {
    get => ref _Handle.AsRef<Hull_t>(Schema.GetOffset(0xB47DE3DE20B7E577));
  }
  public ref uint NavHullIdx {
    get => ref _Handle.AsRef<uint>(Schema.GetOffset(0xB47DE3DE90C08DF0));
  }
  public IMovementStatsProperty MovementStats {
    get => new CMovementStatsProperty(_Handle + Schema.GetOffset(0xB47DE3DE4CF2CCDB));
  }

  public void MyWearablesUpdated() {
    Schema.Update(_Handle, 0xB47DE3DE000B8B43);
  }
}