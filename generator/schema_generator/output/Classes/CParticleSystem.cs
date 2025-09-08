using SwiftlyS2.Core.Schemas;
using SwiftlyS2.Shared.Schemas;
using SwiftlyS2.Core.Extensions;

namespace SwiftlyS2.Core.SchemaDefinitions;

internal partial class CParticleSystem : CBaseModelEntity, IParticleSystem {

  public CParticleSystem(nint handle) : base(handle) {
  }

  public ref bool StartActive {
    get => ref _Handle.AsRef<bool>(Schema.GetOffset(0x8F6D2B25953CBC21));
  }
  public ref CUtlSymbolLarge EffectName {
    get => ref _Handle.AsRef<CUtlSymbolLarge>(Schema.GetOffset(0x8F6D2B2582D2BFC7));
  }
  public ISchemaFixedArray<CUtlSymbolLarge> ControlPointNames {
    get => new SchemaFixedArray<CUtlSymbolLarge>(_Handle, 0x8F6D2B258DBFEC78, 64, 8, 8);
  }
  public ref int DataCP {
    get => ref _Handle.AsRef<int>(Schema.GetOffset(0x8F6D2B258DC46F82));
  }
  public ref Vector DataCPValue {
    get => ref _Handle.AsRef<Vector>(Schema.GetOffset(0x8F6D2B250AC27507));
  }
  public ref int TintCP {
    get => ref _Handle.AsRef<int>(Schema.GetOffset(0x8F6D2B2554940ABB));
  }
  public ref Color Tint {
    get => ref _Handle.AsRef<Color>(Schema.GetOffset(0x8F6D2B25CEA8BB7D));
  }

  public void SnapshotFileNameUpdated() {
    Schema.Update(_Handle, 0x8F6D2B258D2636C1);
  }
  public void ActiveUpdated() {
    Schema.Update(_Handle, 0x8F6D2B258334208F);
  }
  public void FrozenUpdated() {
    Schema.Update(_Handle, 0x8F6D2B25119A2BE3);
  }
  public void FreezeTransitionDurationUpdated() {
    Schema.Update(_Handle, 0x8F6D2B259CE29C67);
  }
  public void StopTypeUpdated() {
    Schema.Update(_Handle, 0x8F6D2B2513397259);
  }
  public void AnimateDuringGameplayPauseUpdated() {
    Schema.Update(_Handle, 0x8F6D2B25A4EB73F5);
  }
  public void EffectIndexUpdated() {
    Schema.Update(_Handle, 0x8F6D2B253C93DC73);
  }
  public void StartTimeUpdated() {
    Schema.Update(_Handle, 0x8F6D2B2567FE9DC4);
  }
  public void PreSimTimeUpdated() {
    Schema.Update(_Handle, 0x8F6D2B25CD67F64E);
  }
  public void ServerControlPointsUpdated() {
    Schema.Update(_Handle, 0x8F6D2B2561386048);
  }
  public void ServerControlPointAssignmentsUpdated() {
    Schema.Update(_Handle, 0x8F6D2B25E9DEDAC8);
  }
  public void ControlPointEntsUpdated() {
    Schema.Update(_Handle, 0x8F6D2B25ECA36598);
  }
  public void NoSaveUpdated() {
    Schema.Update(_Handle, 0x8F6D2B257507B947);
  }
  public void NoFreezeUpdated() {
    Schema.Update(_Handle, 0x8F6D2B256015A661);
  }
  public void NoRampUpdated() {
    Schema.Update(_Handle, 0x8F6D2B25AD7F8116);
  }
}