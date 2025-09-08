using SwiftlyS2.Core.Schemas;
using SwiftlyS2.Shared.Schemas;
using SwiftlyS2.Core.Extensions;

namespace SwiftlyS2.Core.SchemaDefinitions;

internal partial class CDestructiblePartsSystemData_HitGroupInfoAndDamageLevels : SchemaClass, IDestructiblePartsSystemData_HitGroupInfoAndDamageLevels {

  public CDestructiblePartsSystemData_HitGroupInfoAndDamageLevels(nint handle) : base(handle) {
  }

  public ref CGlobalSymbol DebugName {
    get => ref _Handle.AsRef<CGlobalSymbol>(Schema.GetOffset(0x5EA392F7CAC1909B));
  }
  public ref HitGroup_t HitGroup {
    get => ref _Handle.AsRef<HitGroup_t>(Schema.GetOffset(0x5EA392F79C854D19));
  }
  public ref bool DisableHitGroupWhenDestroyed {
    get => ref _Handle.AsRef<bool>(Schema.GetOffset(0x5EA392F7AA847E82));
  }
  public ref CUtlVector<HitGroup_t> OtherHitgroupsToDestroyWhenFullyDestructed {
    get => ref _Handle.AsRef<CUtlVector<HitGroup_t>>(Schema.GetOffset(0x5EA392F72ECFEA5A));
  }
  public ref bool OnlyDestroyWhenGibbing {
    get => ref _Handle.AsRef<bool>(Schema.GetOffset(0x5EA392F70F77EEC1));
  }
  public ref CGlobalSymbol BodyGroupName {
    get => ref _Handle.AsRef<CGlobalSymbol>(Schema.GetOffset(0x5EA392F7FFA38852));
  }
  public ref CUtlVector DamageLevels {
    get => ref _Handle.AsRef<CUtlVector>(Schema.GetOffset(0x5EA392F73B88DC4F));
  }


}