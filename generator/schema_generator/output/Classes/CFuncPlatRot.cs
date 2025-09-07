using SwiftlyS2.Core.Schemas;
using SwiftlyS2.Shared.Schemas;
using SwiftlyS2.Core.Extensions;

namespace SwiftlyS2.Core.SchemaDefinitions;

internal partial class CFuncPlatRot : CFuncPlat, IFuncPlatRot {

  public CFuncPlatRot(nint handle) : base(handle) {
  }

  public CFuncPlatRot(nint handle, ulong hash, bool isField, bool isNetworked) : base(handle, hash, isField, isNetworked) {
  }

  public ref QAngle End {
    get => ref _Handle.AsRef<QAngle>(Schema.GetOffset(0xF566498E5B29CFCA));
  }
  public ref QAngle Start {
    get => ref _Handle.AsRef<QAngle>(Schema.GetOffset(0xF566498EA539BEFF));
  }


}