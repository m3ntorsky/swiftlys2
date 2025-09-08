using SwiftlyS2.Core.Schemas;
using SwiftlyS2.Shared.Schemas;
using SwiftlyS2.Core.Extensions;

namespace SwiftlyS2.Core.SchemaDefinitions;

internal partial class CPointClientUIDialog : CBaseClientUIEntity, IPointClientUIDialog {

  public CPointClientUIDialog(nint handle) : base(handle) {
  }

  public ref bool StartEnabled {
    get => ref _Handle.AsRef<bool>(Schema.GetOffset(0x1136C185500D5C24));
  }

  public void ActivatorUpdated() {
    Schema.Update(_Handle, 0x1136C185AB093BB2);
  }
}