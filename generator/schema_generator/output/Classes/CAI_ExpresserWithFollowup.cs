using SwiftlyS2.Core.Schemas;
using SwiftlyS2.Shared.Schemas;
using SwiftlyS2.Core.Extensions;

namespace SwiftlyS2.Core.SchemaDefinitions;

internal partial class CAI_ExpresserWithFollowup : CAI_Expresser, IAI_ExpresserWithFollowup {

  public CAI_ExpresserWithFollowup(nint handle) : base(handle) {
  }

  public CAI_ExpresserWithFollowup(nint handle, ulong hash, bool isField, bool isNetworked) : base(handle, hash, isField, isNetworked) {
  }




}