using SwiftlyS2.Core.Schemas;
using SwiftlyS2.Shared.Schemas;
using SwiftlyS2.Core.Extensions;

namespace SwiftlyS2.Core.SchemaDefinitions;

internal partial class CTriggerBrush : CBaseModelEntity, ITriggerBrush {

  public CTriggerBrush(nint handle) : base(handle) {
  }

  public CTriggerBrush(nint handle, ulong hash, bool isField, bool isNetworked) : base(handle, hash, isField, isNetworked) {
  }

  public IEntityIOOutput OnStartTouch {
    get => new CEntityIOOutput(_Handle + Schema.GetOffset(0xD9D3DFB2B4E38193));
  }
  public IEntityIOOutput OnEndTouch {
    get => new CEntityIOOutput(_Handle + Schema.GetOffset(0xD9D3DFB25D181B48));
  }
  public IEntityIOOutput OnUse {
    get => new CEntityIOOutput(_Handle + Schema.GetOffset(0xD9D3DFB2C3D50673));
  }
  public ref int InputFilter {
    get => ref _Handle.AsRef<int>(Schema.GetOffset(0xD9D3DFB2D5B46E3A));
  }
  public ref int DontMessageParent {
    get => ref _Handle.AsRef<int>(Schema.GetOffset(0xD9D3DFB2EE2AF166));
  }


}