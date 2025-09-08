using SwiftlyS2.Core.Schemas;
using SwiftlyS2.Shared.Schemas;
using SwiftlyS2.Core.Extensions;

namespace SwiftlyS2.Core.SchemaDefinitions;

internal partial class CBtActionParachutePositioning : CBtNode, IBtActionParachutePositioning {

  public CBtActionParachutePositioning(nint handle) : base(handle) {
  }

  public ICountdownTimer ActionTimer {
    get => new CountdownTimer(_Handle + Schema.GetOffset(0x132D0F5E8777F414));
  }


}