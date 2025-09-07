using SwiftlyS2.Core.Schemas;
using SwiftlyS2.Shared.Schemas;
using SwiftlyS2.Core.Extensions;

namespace SwiftlyS2.Core.SchemaDefinitions;

internal partial class CBtActionMoveTo : CBtNode, IBtActionMoveTo {

  public CBtActionMoveTo(nint handle) : base(handle) {
  }

  public CBtActionMoveTo(nint handle, ulong hash, bool isField, bool isNetworked) : base(handle, hash, isField, isNetworked) {
  }

  public ref CUtlString DestinationInputKey {
    get => ref _Handle.AsRef<CUtlString>(Schema.GetOffset(0xD3E75386EA98FEAB));
  }
  public ref CUtlString HidingSpotInputKey {
    get => ref _Handle.AsRef<CUtlString>(Schema.GetOffset(0xD3E75386B3449D70));
  }
  public ref CUtlString ThreatInputKey {
    get => ref _Handle.AsRef<CUtlString>(Schema.GetOffset(0xD3E75386E8FD875B));
  }
  public ref Vector Destination {
    get => ref _Handle.AsRef<Vector>(Schema.GetOffset(0xD3E753868964CB9F));
  }
  public ref bool AutoLookAdjust {
    get => ref _Handle.AsRef<bool>(Schema.GetOffset(0xD3E75386CC24EFB6));
  }
  public ref bool ComputePath {
    get => ref _Handle.AsRef<bool>(Schema.GetOffset(0xD3E75386E6332AE9));
  }
  public ref float DamagingAreasPenaltyCost {
    get => ref _Handle.AsRef<float>(Schema.GetOffset(0xD3E753868B6813F3));
  }
  public ICountdownTimer CheckApproximateCornersTimer {
    get => new CountdownTimer(_Handle + Schema.GetOffset(0xD3E7538689360D84));
  }
  public ICountdownTimer CheckHighPriorityItem {
    get => new CountdownTimer(_Handle + Schema.GetOffset(0xD3E7538619EE60B4));
  }
  public ICountdownTimer RepathTimer {
    get => new CountdownTimer(_Handle + Schema.GetOffset(0xD3E753866BF3B99C));
  }
  public ref float ArrivalEpsilon {
    get => ref _Handle.AsRef<float>(Schema.GetOffset(0xD3E75386193730DE));
  }
  public ref float AdditionalArrivalEpsilon2D {
    get => ref _Handle.AsRef<float>(Schema.GetOffset(0xD3E7538601105845));
  }
  public ref float HidingSpotCheckDistanceThreshold {
    get => ref _Handle.AsRef<float>(Schema.GetOffset(0xD3E75386BA171B2E));
  }
  public ref float NearestAreaDistanceThreshold {
    get => ref _Handle.AsRef<float>(Schema.GetOffset(0xD3E75386C5DEF260));
  }


}