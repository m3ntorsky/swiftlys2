using SwiftlyS2.Shared.Schemas;

namespace SwiftlyS2.Core.SchemaDefinitions;

public partial interface IAnimDesc_Flag : ISchemaClass {

  
  public ref bool Looping { get; }
  
  public ref bool AllZeros { get; }
  
  public ref bool Hidden { get; }
  
  public ref bool Delta { get; }
  
  public ref bool LegacyWorldspace { get; }
  
  public ref bool ModelDoc { get; }
  
  public ref bool ImplicitSeqIgnoreDelta { get; }
  
  public ref bool AnimGraphAdditive { get; }
}