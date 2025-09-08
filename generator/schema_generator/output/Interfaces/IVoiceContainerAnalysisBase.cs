using SwiftlyS2.Shared.Schemas;

namespace SwiftlyS2.Core.SchemaDefinitions;

public partial interface IVoiceContainerAnalysisBase : ISchemaClass {

  public ref bool RegenerateCurveOnCompile { get; }
  
  public ISchemaUntypedField Curve { get; }
  
}