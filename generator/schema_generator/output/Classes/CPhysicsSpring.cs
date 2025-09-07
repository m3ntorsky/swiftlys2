using SwiftlyS2.Core.Schemas;
using SwiftlyS2.Shared.Schemas;
using SwiftlyS2.Core.Extensions;

namespace SwiftlyS2.Core.SchemaDefinitions;

internal partial class CPhysicsSpring : CBaseEntity, IPhysicsSpring {

  public CPhysicsSpring(nint handle) : base(handle) {
  }

  public CPhysicsSpring(nint handle, ulong hash, bool isField, bool isNetworked) : base(handle, hash, isField, isNetworked) {
  }

  public ref float Frequency {
    get => ref _Handle.AsRef<float>(Schema.GetOffset(0x5222EAAD2C16DD7));
  }
  public ref float DampingRatio {
    get => ref _Handle.AsRef<float>(Schema.GetOffset(0x5222EAAB40C859E));
  }
  public ref float RestLength {
    get => ref _Handle.AsRef<float>(Schema.GetOffset(0x5222EAA93AC4079));
  }
  public ref CUtlSymbolLarge NameAttachStart {
    get => ref _Handle.AsRef<CUtlSymbolLarge>(Schema.GetOffset(0x5222EAAD19CEDD5));
  }
  public ref CUtlSymbolLarge NameAttachEnd {
    get => ref _Handle.AsRef<CUtlSymbolLarge>(Schema.GetOffset(0x5222EAACF4DE50C));
  }
  public ref Vector Start {
    get => ref _Handle.AsRef<Vector>(Schema.GetOffset(0x5222EAAA539BEFF));
  }
  public ref Vector End {
    get => ref _Handle.AsRef<Vector>(Schema.GetOffset(0x5222EAA5B29CFCA));
  }
  public ref uint TeleportTick {
    get => ref _Handle.AsRef<uint>(Schema.GetOffset(0x5222EAA027C0C6B));
  }


}