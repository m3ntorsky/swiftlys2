using SwiftlyS2.Core.Schemas;
using SwiftlyS2.Shared.Schemas;
using SwiftlyS2.Core.Extensions;

namespace SwiftlyS2.Core.SchemaDefinitions;

internal partial class CSoundAreaEntityOrientedBox : CSoundAreaEntityBase, ISoundAreaEntityOrientedBox {

  public CSoundAreaEntityOrientedBox(nint handle) : base(handle) {
  }

  public CSoundAreaEntityOrientedBox(nint handle, ulong hash, bool isField, bool isNetworked) : base(handle, hash, isField, isNetworked) {
  }

  public ref Vector Min {
    get => ref _Handle.AsRef<Vector>(Schema.GetOffset(0x5D327060F4B0AA63));
  }
  public ref Vector Max {
    get => ref _Handle.AsRef<Vector>(Schema.GetOffset(0x5D327060EAC4225D));
  }

  public void MinUpdated() {
    Schema.Update(_Handle, 0x5D327060F4B0AA63);
  }
  public void MaxUpdated() {
    Schema.Update(_Handle, 0x5D327060EAC4225D);
  }
}