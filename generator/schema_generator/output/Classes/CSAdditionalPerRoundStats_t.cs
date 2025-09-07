using SwiftlyS2.Core.Schemas;
using SwiftlyS2.Shared.Schemas;
using SwiftlyS2.Core.Extensions;

namespace SwiftlyS2.Core.SchemaDefinitions;

internal partial class CSAdditionalPerRoundStats_t : SchemaClass, ISAdditionalPerRoundStats_t {

  public CSAdditionalPerRoundStats_t(nint handle) : base(handle) {
  }

  public CSAdditionalPerRoundStats_t(nint handle, ulong hash, bool isField, bool isNetworked) : base(handle, hash, isField, isNetworked) {
  }

  public ref int NumChickensKilled {
    get => ref _Handle.AsRef<int>(Schema.GetOffset(0x719C617993548CDE));
  }
  public ref int KillsWhileBlind {
    get => ref _Handle.AsRef<int>(Schema.GetOffset(0x719C61794FEC6186));
  }
  public ref int BombCarrierkills {
    get => ref _Handle.AsRef<int>(Schema.GetOffset(0x719C617913457A30));
  }
  public ref int BurnDamageInflicted {
    get => ref _Handle.AsRef<int>(Schema.GetOffset(0x719C61798974E9B6));
  }
  public ref int BlastDamageInflicted {
    get => ref _Handle.AsRef<int>(Schema.GetOffset(0x719C617936AD5C8F));
  }
  public ref int Dinks {
    get => ref _Handle.AsRef<int>(Schema.GetOffset(0x719C617910BCE83D));
  }


}