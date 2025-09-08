using SwiftlyS2.Core.Schemas;
using SwiftlyS2.Shared.Schemas;
using SwiftlyS2.Core.Extensions;

namespace SwiftlyS2.Core.SchemaDefinitions;

internal partial class CInfoProjectedDecal : CPointEntity, IInfoProjectedDecal {

  public CInfoProjectedDecal(nint handle) : base(handle) {
  }

  public CStrongHandle<IInfoForResourceTypeIMaterial2> Material {
    get => new CStrongHandle<InfoForResourceTypeIMaterial2>(_Handle + Schema.GetOffset(0x99210447888CE42E));
  }
  public ref CUtlStringToken SequenceName {
    get => ref _Handle.AsRef<CUtlStringToken>(Schema.GetOffset(0x992104477462AF30));
  }
  public ref float Distance {
    get => ref _Handle.AsRef<float>(Schema.GetOffset(0x9921044700DC4A68));
  }
  public ref bool NotInMultiplayer {
    get => ref _Handle.AsRef<bool>(Schema.GetOffset(0x992104479DCFF11B));
  }


}