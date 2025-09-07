using SwiftlyS2.Core.Schemas;
using SwiftlyS2.Shared.Schemas;
using SwiftlyS2.Core.Extensions;

namespace SwiftlyS2.Core.SchemaDefinitions;

internal partial class CPathSimple : CBaseEntity, IPathSimple {

  public CPathSimple(nint handle) : base(handle) {
  }

  public CPathSimple(nint handle, ulong hash, bool isField, bool isNetworked) : base(handle, hash, isField, isNetworked) {
  }

  public IPathQueryComponent CPathQueryComponent {
    get => new CPathQueryComponent(_Handle + Schema.GetOffset(0x10936CB34513F542));
  }
  public ref CUtlString PathString {
    get => ref _Handle.AsRef<CUtlString>(Schema.GetOffset(0x10936CB36EC51AA7));
  }
  public ref bool ClosedLoop {
    get => ref _Handle.AsRef<bool>(Schema.GetOffset(0x10936CB37C20D1AB));
  }

  public void CPathQueryComponentUpdated() {
    Schema.Update(_Handle, 0x10936CB34513F542);
  }
  public void PathStringUpdated() {
    Schema.Update(_Handle, 0x10936CB36EC51AA7);
  }
}