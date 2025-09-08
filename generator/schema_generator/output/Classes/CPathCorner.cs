using SwiftlyS2.Core.Schemas;
using SwiftlyS2.Shared.Schemas;
using SwiftlyS2.Core.Extensions;

namespace SwiftlyS2.Core.SchemaDefinitions;

internal partial class CPathCorner : CPointEntity, IPathCorner {

  public CPathCorner(nint handle) : base(handle) {
  }

  public ref float Wait {
    get => ref _Handle.AsRef<float>(Schema.GetOffset(0xF74EA45499A062B6));
  }
  public ref float Radius {
    get => ref _Handle.AsRef<float>(Schema.GetOffset(0xF74EA4545ACFC08D));
  }
  public IEntityIOOutput OnPass {
    get => new CEntityIOOutput(_Handle + Schema.GetOffset(0xF74EA4549B527249));
  }


}