using SwiftlyS2.Core.Schemas;
using SwiftlyS2.Shared.Schemas;
using SwiftlyS2.Core.Extensions;

namespace SwiftlyS2.Core.SchemaDefinitions;

internal partial class ResponseParams : SchemaClass, IResponseParams {

  public ResponseParams(nint handle) : base(handle) {
  }

  public ResponseParams(nint handle, ulong hash, bool isField, bool isNetworked) : base(handle, hash, isField, isNetworked) {
  }

  public ref short Odds {
    get => ref _Handle.AsRef<short>(Schema.GetOffset(0x5C5BE8C4E9B76DD7));
  }
  public ref short Flags {
    get => ref _Handle.AsRef<short>(Schema.GetOffset(0x5C5BE8C49C677A2C));
  }
  public IResponseFollowup Followup {
    get => new ResponseFollowup(_Handle + Schema.GetOffset(0x5C5BE8C481D8C38F));
  }


}