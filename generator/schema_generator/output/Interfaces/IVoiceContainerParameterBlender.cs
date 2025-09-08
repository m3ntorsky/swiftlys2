using SwiftlyS2.Shared.Schemas;

namespace SwiftlyS2.Core.SchemaDefinitions;

public partial interface IVoiceContainerParameterBlender : IVoiceContainerBase {

  public ISoundContainerReference FirstSound { get; }
  
  public ISoundContainerReference SecondSound { get; }
  
  public ref bool EnableOcclusionBlend { get; }
  
  public ISchemaUntypedField Curve1 { get; }
  
  public ISchemaUntypedField Curve2 { get; }
  
  public ref bool EnableDistanceBlend { get; }
  
  public ISchemaUntypedField Curve3 { get; }
  
  public ISchemaUntypedField Curve4 { get; }
  
}