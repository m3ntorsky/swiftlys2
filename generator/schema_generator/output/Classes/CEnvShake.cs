using SwiftlyS2.Core.Schemas;
using SwiftlyS2.Shared.Schemas;
using SwiftlyS2.Core.Extensions;

namespace SwiftlyS2.Core.SchemaDefinitions;

internal partial class CEnvShake : CPointEntity, IEnvShake {

  public CEnvShake(nint handle) : base(handle) {
  }

  public ref CUtlSymbolLarge LimitToEntity {
    get => ref _Handle.AsRef<CUtlSymbolLarge>(Schema.GetOffset(0x10FEA945E1C029E2));
  }
  public ref float Amplitude {
    get => ref _Handle.AsRef<float>(Schema.GetOffset(0x10FEA945A38BF822));
  }
  public ref float Frequency {
    get => ref _Handle.AsRef<float>(Schema.GetOffset(0x10FEA945BCCAA981));
  }
  public ref float Duration {
    get => ref _Handle.AsRef<float>(Schema.GetOffset(0x10FEA9459879A98D));
  }
  public ref float Radius {
    get => ref _Handle.AsRef<float>(Schema.GetOffset(0x10FEA9457C5B0533));
  }
  public IGameTime_t StopTime {
    get => new GameTime_t(_Handle + Schema.GetOffset(0x10FEA9456BFFEDC4));
  }
  public IGameTime_t NextShake {
    get => new GameTime_t(_Handle + Schema.GetOffset(0x10FEA94563E0833E));
  }
  public ref float CurrentAmp {
    get => ref _Handle.AsRef<float>(Schema.GetOffset(0x10FEA94504EE10FC));
  }
  public ref Vector MaxForce {
    get => ref _Handle.AsRef<Vector>(Schema.GetOffset(0x10FEA945FA9D37B8));
  }
  public IPhysicsShake ShakeCallback {
    get => new CPhysicsShake(_Handle + Schema.GetOffset(0x10FEA945C4E1E076));
  }


}