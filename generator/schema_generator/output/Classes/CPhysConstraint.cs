using SwiftlyS2.Core.Schemas;
using SwiftlyS2.Shared.Schemas;
using SwiftlyS2.Core.Extensions;

namespace SwiftlyS2.Core.SchemaDefinitions;

internal partial class CPhysConstraint : CLogicalEntity, IPhysConstraint {

  public CPhysConstraint(nint handle) : base(handle) {
  }

  public CPhysConstraint(nint handle, ulong hash, bool isField, bool isNetworked) : base(handle, hash, isField, isNetworked) {
  }

  public ref CUtlSymbolLarge NameAttach1 {
    get => ref _Handle.AsRef<CUtlSymbolLarge>(Schema.GetOffset(0xB17225456776530A));
  }
  public ref CUtlSymbolLarge NameAttach2 {
    get => ref _Handle.AsRef<CUtlSymbolLarge>(Schema.GetOffset(0xB172254566765177));
  }
  public ref CHandle< CBaseEntity > Attach1 {
    get => ref _Handle.AsRef<CHandle< CBaseEntity >>(Schema.GetOffset(0xB1722545384EDC59));
  }
  public ref CHandle< CBaseEntity > Attach2 {
    get => ref _Handle.AsRef<CHandle< CBaseEntity >>(Schema.GetOffset(0xB1722545354ED7A0));
  }
  public ref CUtlSymbolLarge NameAttachment1 {
    get => ref _Handle.AsRef<CUtlSymbolLarge>(Schema.GetOffset(0xB172254517A81C36));
  }
  public ref CUtlSymbolLarge NameAttachment2 {
    get => ref _Handle.AsRef<CUtlSymbolLarge>(Schema.GetOffset(0xB172254516A81AA3));
  }
  public ref CUtlSymbolLarge BreakSound {
    get => ref _Handle.AsRef<CUtlSymbolLarge>(Schema.GetOffset(0xB17225456CFE49F7));
  }
  public ref float ForceLimit {
    get => ref _Handle.AsRef<float>(Schema.GetOffset(0xB1722545BA45B8F7));
  }
  public ref float TorqueLimit {
    get => ref _Handle.AsRef<float>(Schema.GetOffset(0xB17225456D51FE3E));
  }
  public ref float MinTeleportDistance {
    get => ref _Handle.AsRef<float>(Schema.GetOffset(0xB172254512C704EB));
  }
  public ref bool SnapObjectPositions {
    get => ref _Handle.AsRef<bool>(Schema.GetOffset(0xB172254570EDFC5A));
  }
  public IEntityIOOutput OnBreak {
    get => new CEntityIOOutput(_Handle + Schema.GetOffset(0xB172254546BFEC4F));
  }


}