using SwiftlyS2.Core.Schemas;
using SwiftlyS2.Shared.Schemas;
using SwiftlyS2.Core.Extensions;

namespace SwiftlyS2.Core.SchemaDefinitions;

internal partial class CZeroPoseUpdateNode : CLeafUpdateNode, IZeroPoseUpdateNode {

  public CZeroPoseUpdateNode(nint handle) : base(handle) {
  }

  public CZeroPoseUpdateNode(nint handle, ulong hash, bool isField, bool isNetworked) : base(handle, hash, isField, isNetworked) {
  }




}