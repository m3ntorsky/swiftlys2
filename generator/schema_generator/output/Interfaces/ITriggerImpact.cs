using SwiftlyS2.Shared.Schemas;

namespace SwiftlyS2.Core.SchemaDefinitions;

public partial interface ITriggerImpact : ITriggerMultiple {

  
  public ref float Magnitude { get; }
  
  public ref float Noise { get; }
  
  public ref float Viewkick { get; }
  
  public ISchemaUntypedField OutputForce { get; }
}