using SwiftlyS2.Core.Schemas;
using SwiftlyS2.Shared.Schemas;
using SwiftlyS2.Core.Extensions;

namespace SwiftlyS2.Core.SchemaDefinitions;

internal partial class CBaseFilter : CLogicalEntity, IBaseFilter {

  public CBaseFilter(nint handle) : base(handle) {
  }

  public CBaseFilter(nint handle, ulong hash, bool isField, bool isNetworked) : base(handle, hash, isField, isNetworked) {
  }

  public ref bool Negated {
    get => ref _Handle.AsRef<bool>(Schema.GetOffset(0x2D59B2893803BF0D));
  }
  public IEntityIOOutput OnPass {
    get => new CEntityIOOutput(_Handle + Schema.GetOffset(0x2D59B2899B527249));
  }
  public IEntityIOOutput OnFail {
    get => new CEntityIOOutput(_Handle + Schema.GetOffset(0x2D59B289794EF854));
  }


}