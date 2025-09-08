using SwiftlyS2.Core.Schemas;
using SwiftlyS2.Shared.Schemas;
using SwiftlyS2.Core.Extensions;

namespace SwiftlyS2.Core.SchemaDefinitions;

internal partial class CSlowDownOnSlopesUpdateNode : CUnaryUpdateNode, ISlowDownOnSlopesUpdateNode {

  public CSlowDownOnSlopesUpdateNode(nint handle) : base(handle) {
  }

  public ref float SlowDownStrength {
    get => ref _Handle.AsRef<float>(Schema.GetOffset(0x196FB4938D85E247));
  }


}