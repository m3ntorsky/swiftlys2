using SwiftlyS2.Core.Schemas;
using SwiftlyS2.Shared.Schemas;
using SwiftlyS2.Core.Extensions;

namespace SwiftlyS2.Core.SchemaDefinitions;

internal partial class CNmEventConsumerAttributes : CNmEventConsumer, INmEventConsumerAttributes {

  public CNmEventConsumerAttributes(nint handle) : base(handle) {
  }

  public CNmEventConsumerAttributes(nint handle, ulong hash, bool isField, bool isNetworked) : base(handle, hash, isField, isNetworked) {
  }




}