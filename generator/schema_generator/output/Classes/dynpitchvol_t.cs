using SwiftlyS2.Core.Schemas;
using SwiftlyS2.Shared.Schemas;
using SwiftlyS2.Core.Extensions;

namespace SwiftlyS2.Core.SchemaDefinitions;

internal partial class dynpitchvol_t : dynpitchvol_base_t, Idynpitchvol_t {

  public dynpitchvol_t(nint handle) : base(handle) {
  }

  public dynpitchvol_t(nint handle, ulong hash, bool isField, bool isNetworked) : base(handle, hash, isField, isNetworked) {
  }




}