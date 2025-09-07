using SwiftlyS2.Core.Schemas;
using SwiftlyS2.Shared.Schemas;
using SwiftlyS2.Core.Extensions;

namespace SwiftlyS2.Core.SchemaDefinitions;

internal partial class CSeqMultiFetchFlag : SchemaClass, ISeqMultiFetchFlag {

  public CSeqMultiFetchFlag(nint handle) : base(handle) {
  }

  public CSeqMultiFetchFlag(nint handle, ulong hash, bool isField, bool isNetworked) : base(handle, hash, isField, isNetworked) {
  }

  public ref bool Realtime {
    get => ref _Handle.AsRef<bool>(Schema.GetOffset(0xE7EB44FCB658139C));
  }
  public ref bool Cylepose {
    get => ref _Handle.AsRef<bool>(Schema.GetOffset(0xE7EB44FCCB757B6B));
  }
  public ref bool B0D {
    get => ref _Handle.AsRef<bool>(Schema.GetOffset(0xE7EB44FC76DE6DB1));
  }
  public ref bool B1D {
    get => ref _Handle.AsRef<bool>(Schema.GetOffset(0xE7EB44FC50DBF348));
  }
  public ref bool B2D {
    get => ref _Handle.AsRef<bool>(Schema.GetOffset(0xE7EB44FC42E42C03));
  }
  public ref bool B2D_TRI {
    get => ref _Handle.AsRef<bool>(Schema.GetOffset(0xE7EB44FCC9FA6A0D));
  }


}