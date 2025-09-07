using SwiftlyS2.Core.Schemas;
using SwiftlyS2.Shared.Schemas;
using SwiftlyS2.Core.Extensions;

namespace SwiftlyS2.Core.SchemaDefinitions;

internal partial class C_INIT_RandomRotationSpeed : CGeneralRandomRotation, IC_INIT_RandomRotationSpeed {

  public C_INIT_RandomRotationSpeed(nint handle) : base(handle) {
  }

  public C_INIT_RandomRotationSpeed(nint handle, ulong hash, bool isField, bool isNetworked) : base(handle, hash, isField, isNetworked) {
  }




}