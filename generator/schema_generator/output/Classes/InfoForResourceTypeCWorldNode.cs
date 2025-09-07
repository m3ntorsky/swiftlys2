using SwiftlyS2.Core.Schemas;
using SwiftlyS2.Shared.Schemas;
using SwiftlyS2.Core.Extensions;

namespace SwiftlyS2.Core.SchemaDefinitions;

internal partial class InfoForResourceTypeCWorldNode : SchemaClass, IInfoForResourceTypeCWorldNode {

  public InfoForResourceTypeCWorldNode(nint handle) : base(handle) {
  }

  public InfoForResourceTypeCWorldNode(nint handle, ulong hash, bool isField, bool isNetworked) : base(handle, hash, isField, isNetworked) {
  }




}