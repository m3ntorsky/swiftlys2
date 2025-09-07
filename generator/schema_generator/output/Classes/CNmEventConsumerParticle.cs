using SwiftlyS2.Core.Schemas;
using SwiftlyS2.Shared.Schemas;
using SwiftlyS2.Core.Extensions;

namespace SwiftlyS2.Core.SchemaDefinitions;

internal partial class CNmEventConsumerParticle : CNmEventConsumer, INmEventConsumerParticle {

  public CNmEventConsumerParticle(nint handle) : base(handle) {
  }

  public CNmEventConsumerParticle(nint handle, ulong hash, bool isField, bool isNetworked) : base(handle, hash, isField, isNetworked) {
  }




}