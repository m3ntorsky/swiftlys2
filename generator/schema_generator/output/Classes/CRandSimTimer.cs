using SwiftlyS2.Core.Schemas;
using SwiftlyS2.Shared.Schemas;
using SwiftlyS2.Core.Extensions;

namespace SwiftlyS2.Core.SchemaDefinitions;

internal partial class CRandSimTimer : CSimpleSimTimer, IRandSimTimer {

  public CRandSimTimer(nint handle) : base(handle) {
  }

  public CRandSimTimer(nint handle, ulong hash, bool isField, bool isNetworked) : base(handle, hash, isField, isNetworked) {
  }

  public ref float MinInterval {
    get => ref _Handle.AsRef<float>(Schema.GetOffset(0x6268F694BB35EE4));
  }
  public ref float MaxInterval {
    get => ref _Handle.AsRef<float>(Schema.GetOffset(0x6268F69400B2156));
  }


}