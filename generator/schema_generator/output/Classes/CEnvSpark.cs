using SwiftlyS2.Core.Schemas;
using SwiftlyS2.Shared.Schemas;
using SwiftlyS2.Core.Extensions;

namespace SwiftlyS2.Core.SchemaDefinitions;

internal partial class CEnvSpark : CPointEntity, IEnvSpark {

  public CEnvSpark(nint handle) : base(handle) {
  }

  public ref float Delay {
    get => ref _Handle.AsRef<float>(Schema.GetOffset(0x3BACCABA7D68FD6E));
  }
  public ref int Magnitude {
    get => ref _Handle.AsRef<int>(Schema.GetOffset(0x3BACCABA0C71BDF1));
  }
  public ref int TrailLength {
    get => ref _Handle.AsRef<int>(Schema.GetOffset(0x3BACCABA65AAB1A7));
  }
  public ref int Type {
    get => ref _Handle.AsRef<int>(Schema.GetOffset(0x3BACCABA18853D59));
  }
  public IEntityIOOutput OnSpark {
    get => new CEntityIOOutput(_Handle + Schema.GetOffset(0x3BACCABA67E1EE5D));
  }


}