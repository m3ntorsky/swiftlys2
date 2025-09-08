using SwiftlyS2.Core.Schemas;
using SwiftlyS2.Shared.Schemas;
using SwiftlyS2.Core.Extensions;

namespace SwiftlyS2.Core.SchemaDefinitions;

internal partial class CStateNodeStateData : SchemaClass, IStateNodeStateData {

  public CStateNodeStateData(nint handle) : base(handle) {
  }

  public IAnimUpdateNodeRef Child {
    get => new CAnimUpdateNodeRef(_Handle + Schema.GetOffset(0x6AB991A04A0B773F));
  }
  public ISchemaUntypedField ExclusiveRootMotion {
    get => new SchemaUntypedField(_Handle + Schema.GetOffset(0x6AB991A019C8014D));
  }
  public ISchemaUntypedField ExclusiveRootMotionFirstFrame {
    get => new SchemaUntypedField(_Handle + Schema.GetOffset(0x6AB991A0220BA45A));
  }


}