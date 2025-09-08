using SwiftlyS2.Core.Schemas;
using SwiftlyS2.Shared.Schemas;
using SwiftlyS2.Core.Extensions;

namespace SwiftlyS2.Core.SchemaDefinitions;

internal partial class CPhysImpact : CPointEntity, IPhysImpact {

  public CPhysImpact(nint handle) : base(handle) {
  }

  public ref float Damage {
    get => ref _Handle.AsRef<float>(Schema.GetOffset(0x2C5E7E549C988CE0));
  }
  public ref float Distance {
    get => ref _Handle.AsRef<float>(Schema.GetOffset(0x2C5E7E543CB20D02));
  }
  public ref CUtlSymbolLarge DirectionEntityName {
    get => ref _Handle.AsRef<CUtlSymbolLarge>(Schema.GetOffset(0x2C5E7E54329C8132));
  }


}