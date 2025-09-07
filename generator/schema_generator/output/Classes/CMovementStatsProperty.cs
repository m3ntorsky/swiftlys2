using SwiftlyS2.Core.Schemas;
using SwiftlyS2.Shared.Schemas;
using SwiftlyS2.Core.Extensions;

namespace SwiftlyS2.Core.SchemaDefinitions;

internal partial class CMovementStatsProperty : SchemaClass, IMovementStatsProperty {

  public CMovementStatsProperty(nint handle) : base(handle) {
  }

  public CMovementStatsProperty(nint handle, ulong hash, bool isField, bool isNetworked) : base(handle, hash, isField, isNetworked) {
  }

  public ref int UseCounter {
    get => ref _Handle.AsRef<int>(Schema.GetOffset(0xDE38DFFB6294198C));
  }
  public IVectorExponentialMovingAverage EmaMovementDirection {
    get => new CVectorExponentialMovingAverage(_Handle + Schema.GetOffset(0xDE38DFFB3878FC8C));
  }


}