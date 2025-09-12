using SwiftlyS2.Shared.Schemas;

namespace SwiftlyS2.Core.SchemaDefinitions;

public partial interface IEnvInstructorVRHint : IPointEntity {

  
  public ISchemaUntypedField Name { get; }
  
  public ISchemaUntypedField HintTargetEntity { get; }
  
  public ref int Timeout { get; }
  
  public ISchemaUntypedField Caption { get; }
  
  public ISchemaUntypedField StartSound { get; }
  
  public ref int LayoutFileType { get; }
  
  public ISchemaUntypedField CustomLayoutFile { get; }
  
  public ref int AttachType { get; }
  
  public ref float HeightOffset { get; }
}