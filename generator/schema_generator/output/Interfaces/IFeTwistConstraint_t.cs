using SwiftlyS2.Shared.Schemas;

namespace SwiftlyS2.Core.SchemaDefinitions;

public partial interface IFeTwistConstraint_t : ISchemaClass {

  public ref ushort NodeOrient { get; }
  
  public ref ushort NodeEnd { get; }
  
  public ref float TwistRelax { get; }
  
  public ref float SwingRelax { get; }
  
}