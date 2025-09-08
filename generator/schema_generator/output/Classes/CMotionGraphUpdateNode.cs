using SwiftlyS2.Core.Schemas;
using SwiftlyS2.Shared.Schemas;
using SwiftlyS2.Core.Extensions;

namespace SwiftlyS2.Core.SchemaDefinitions;

internal partial class CMotionGraphUpdateNode : CLeafUpdateNode, IMotionGraphUpdateNode {

  public CMotionGraphUpdateNode(nint handle) : base(handle) {
  }

  public ISchemaUntypedField MotionGraph {
    get => new SchemaUntypedField(_Handle + Schema.GetOffset(0x69396A054F70C737));
  }


}