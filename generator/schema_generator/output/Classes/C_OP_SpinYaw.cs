using SwiftlyS2.Core.Schemas;
using SwiftlyS2.Shared.Schemas;
using SwiftlyS2.Core.Extensions;

namespace SwiftlyS2.Core.SchemaDefinitions;

internal partial class C_OP_SpinYaw : CGeneralSpin, IC_OP_SpinYaw {

  public C_OP_SpinYaw(nint handle) : base(handle) {
  }

  public C_OP_SpinYaw(nint handle, ulong hash, bool isField, bool isNetworked) : base(handle, hash, isField, isNetworked) {
  }




}