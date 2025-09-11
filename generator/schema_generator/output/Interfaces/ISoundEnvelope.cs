using SwiftlyS2.Shared.Schemas;

namespace SwiftlyS2.Core.SchemaDefinitions;

public partial interface ISoundEnvelope : ISchemaClass {

  
  public ref float Current { get; }
  
  public ref float Target { get; }
  
  public ref float Rate { get; }
  
  public ref bool Forceupdate { get; }
}