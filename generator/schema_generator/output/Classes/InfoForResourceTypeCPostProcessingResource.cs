using SwiftlyS2.Core.Schemas;
using SwiftlyS2.Shared.Schemas;
using SwiftlyS2.Core.Extensions;

namespace SwiftlyS2.Core.SchemaDefinitions;

internal partial class InfoForResourceTypeCPostProcessingResource : SchemaClass, IInfoForResourceTypeCPostProcessingResource {

  public InfoForResourceTypeCPostProcessingResource(nint handle) : base(handle) {
  }

  public InfoForResourceTypeCPostProcessingResource(nint handle, ulong hash, bool isField, bool isNetworked) : base(handle, hash, isField, isNetworked) {
  }




}