using SwiftlyS2.Core.Schemas;
using SwiftlyS2.Shared.Schemas;
using SwiftlyS2.Core.Extensions;

namespace SwiftlyS2.Core.SchemaDefinitions;

internal partial class CInfoVisibilityBox : CBaseEntity, IInfoVisibilityBox {

  public CInfoVisibilityBox(nint handle) : base(handle) {
  }

  public CInfoVisibilityBox(nint handle, ulong hash, bool isField, bool isNetworked) : base(handle, hash, isField, isNetworked) {
  }

  public ref int Mode {
    get => ref _Handle.AsRef<int>(Schema.GetOffset(0xD226824F137F1E0E));
  }
  public ref Vector BoxSize {
    get => ref _Handle.AsRef<Vector>(Schema.GetOffset(0xD226824FE553E487));
  }
  public ref bool Enabled {
    get => ref _Handle.AsRef<bool>(Schema.GetOffset(0xD226824F6154EB7E));
  }

  public void ModeUpdated() {
    Schema.Update(_Handle, 0xD226824F137F1E0E);
  }
  public void BoxSizeUpdated() {
    Schema.Update(_Handle, 0xD226824FE553E487);
  }
  public void EnabledUpdated() {
    Schema.Update(_Handle, 0xD226824F6154EB7E);
  }
}