using SwiftlyS2.Core.Schemas;
using SwiftlyS2.Shared.Schemas;
using SwiftlyS2.Core.Extensions;

namespace SwiftlyS2.Core.SchemaDefinitions;

internal partial class CTestEffect : CBaseEntity, ITestEffect {

  public CTestEffect(nint handle) : base(handle) {
  }

  public ref int Loop {
    get => ref _Handle.AsRef<int>(Schema.GetOffset(0xF4103FBFFFB6D07A));
  }
  public ref int Beam {
    get => ref _Handle.AsRef<int>(Schema.GetOffset(0xF4103FBF54034EE3));
  }
  public IBeam Beam {
    get => new CBeam(_Handle, 0xF4103FBFC4017428, 24, 8, 8);
  }
  public IGameTime_t BeamTime {
    get => new GameTime_t(_Handle, 0xF4103FBF60293F01, 24, 4, 4);
  }
  public IGameTime_t StartTime {
    get => new GameTime_t(_Handle + Schema.GetOffset(0xF4103FBF67FE9DC4));
  }


}