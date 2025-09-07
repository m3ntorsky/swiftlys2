using SwiftlyS2.Core.Schemas;
using SwiftlyS2.Shared.Schemas;
using SwiftlyS2.Core.Extensions;

namespace SwiftlyS2.Core.SchemaDefinitions;

internal partial class CInferno : CBaseModelEntity, IInferno {

  public CInferno(nint handle) : base(handle) {
  }

  public CInferno(nint handle, ulong hash, bool isField, bool isNetworked) : base(handle, hash, isField, isNetworked) {
  }

  public ISchemaFixedArray<Vector> FirePositions {
    get => new SchemaFixedArray<Vector>(_Handle + Schema.GetOffset(0xABE104C91E992007));
  }
  public ISchemaFixedArray<Vector> FireParentPositions {
    get => new SchemaFixedArray<Vector>(_Handle + Schema.GetOffset(0xABE104C9A58B35D7));
  }
  public ISchemaFixedArray<bool> FireIsBurning {
    get => new SchemaFixedArray<bool>(_Handle + Schema.GetOffset(0xABE104C9E5CD906C));
  }
  public ISchemaFixedArray<Vector> BurnNormal {
    get => new SchemaFixedArray<Vector>(_Handle + Schema.GetOffset(0xABE104C9382663DB));
  }
  public ref int FireCount {
    get => ref _Handle.AsRef<int>(Schema.GetOffset(0xABE104C9820942A0));
  }
  public ref int InfernoType {
    get => ref _Handle.AsRef<int>(Schema.GetOffset(0xABE104C903C628B8));
  }
  public ref int FireEffectTickBegin {
    get => ref _Handle.AsRef<int>(Schema.GetOffset(0xABE104C989EB57F2));
  }
  public ref float FireLifetime {
    get => ref _Handle.AsRef<float>(Schema.GetOffset(0xABE104C9B2E34E7E));
  }
  public ref bool InPostEffectTime {
    get => ref _Handle.AsRef<bool>(Schema.GetOffset(0xABE104C963E4F6B8));
  }
  public ref bool WasCreatedInSmoke {
    get => ref _Handle.AsRef<bool>(Schema.GetOffset(0xABE104C95CC1EF2A));
  }
  public IExtent Extent {
    get => new Extent(_Handle + Schema.GetOffset(0xABE104C9DD2CA0B9));
  }
  public ICountdownTimer DamageTimer {
    get => new CountdownTimer(_Handle + Schema.GetOffset(0xABE104C979F45751));
  }
  public ICountdownTimer DamageRampTimer {
    get => new CountdownTimer(_Handle + Schema.GetOffset(0xABE104C9400054C9));
  }
  public ref Vector SplashVelocity {
    get => ref _Handle.AsRef<Vector>(Schema.GetOffset(0xABE104C963461F75));
  }
  public ref Vector InitialSplashVelocity {
    get => ref _Handle.AsRef<Vector>(Schema.GetOffset(0xABE104C9757A42BF));
  }
  public ref Vector StartPos {
    get => ref _Handle.AsRef<Vector>(Schema.GetOffset(0xABE104C9676FC33F));
  }
  public ref Vector OriginalSpawnLocation {
    get => ref _Handle.AsRef<Vector>(Schema.GetOffset(0xABE104C95E59F382));
  }
  public IIntervalTimer ActiveTimer {
    get => new IntervalTimer(_Handle + Schema.GetOffset(0xABE104C946FF8D04));
  }
  public ref int FireSpawnOffset {
    get => ref _Handle.AsRef<int>(Schema.GetOffset(0xABE104C90C7D268F));
  }
  public ref int MaxFlames {
    get => ref _Handle.AsRef<int>(Schema.GetOffset(0xABE104C972805F39));
  }
  public ref int SpreadCount {
    get => ref _Handle.AsRef<int>(Schema.GetOffset(0xABE104C9F27833E1));
  }
  public ICountdownTimer BookkeepingTimer {
    get => new CountdownTimer(_Handle + Schema.GetOffset(0xABE104C975065DCC));
  }
  public ICountdownTimer NextSpreadTimer {
    get => new CountdownTimer(_Handle + Schema.GetOffset(0xABE104C93045281C));
  }
  public ref ushort SourceItemDefIndex {
    get => ref _Handle.AsRef<ushort>(Schema.GetOffset(0xABE104C905A4D2E6));
  }

  public void FirePositionsUpdated() {
    Schema.Update(_Handle, 0xABE104C91E992007);
  }
  public void FireParentPositionsUpdated() {
    Schema.Update(_Handle, 0xABE104C9A58B35D7);
  }
  public void FireIsBurningUpdated() {
    Schema.Update(_Handle, 0xABE104C9E5CD906C);
  }
  public void BurnNormalUpdated() {
    Schema.Update(_Handle, 0xABE104C9382663DB);
  }
  public void FireCountUpdated() {
    Schema.Update(_Handle, 0xABE104C9820942A0);
  }
  public void InfernoTypeUpdated() {
    Schema.Update(_Handle, 0xABE104C903C628B8);
  }
  public void FireEffectTickBeginUpdated() {
    Schema.Update(_Handle, 0xABE104C989EB57F2);
  }
  public void FireLifetimeUpdated() {
    Schema.Update(_Handle, 0xABE104C9B2E34E7E);
  }
  public void InPostEffectTimeUpdated() {
    Schema.Update(_Handle, 0xABE104C963E4F6B8);
  }
}