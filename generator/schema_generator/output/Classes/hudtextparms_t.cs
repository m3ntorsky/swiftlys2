using SwiftlyS2.Core.Schemas;
using SwiftlyS2.Shared.Schemas;
using SwiftlyS2.Core.Extensions;

namespace SwiftlyS2.Core.SchemaDefinitions;

internal partial class hudtextparms_t : SchemaClass, Ihudtextparms_t {

  public hudtextparms_t(nint handle) : base(handle) {
  }

  public hudtextparms_t(nint handle, ulong hash, bool isField, bool isNetworked) : base(handle, hash, isField, isNetworked) {
  }

  public ref Color Color1 {
    get => ref _Handle.AsRef<Color>(Schema.GetOffset(0x827B8DBF36F4EB4B));
  }
  public ref Color Color2 {
    get => ref _Handle.AsRef<Color>(Schema.GetOffset(0x827B8DBF37F4ECDE));
  }
  public ref byte Effect {
    get => ref _Handle.AsRef<byte>(Schema.GetOffset(0x827B8DBF6E6E8D54));
  }
  public ref byte Channel {
    get => ref _Handle.AsRef<byte>(Schema.GetOffset(0x827B8DBF21C252A4));
  }
  public ref float X {
    get => ref _Handle.AsRef<float>(Schema.GetOffset(0x827B8DBFFD0C5087));
  }
  public ref float Y {
    get => ref _Handle.AsRef<float>(Schema.GetOffset(0x827B8DBFFC0C4EF4));
  }


}