using SwiftlyS2.Shared.Schemas;

namespace SwiftlyS2.Core.SchemaDefinitions;

public partial interface IPulseGraphDef : ISchemaClass {

  public ISchemaUntypedField DomainIdentifier { get; }
  
  public ISchemaUntypedField DomainSubType { get; }
  
  public ISchemaUntypedField ParentMapName { get; }
  
  public ISchemaUntypedField ParentXmlName { get; }
  
  public ref CUtlVector<PointerTo<CPulse_Chunk>> Chunks { get; }
  
  public ref CUtlVector<PointerTo<CPulseCell_Base>> Cells { get; }
  
  public ref CUtlVector Vars { get; }
  
  public ref CUtlVector PublicOutputs { get; }
  
  public ref CUtlVector<PointerTo<CPulse_InvokeBinding>> InvokeBindings { get; }
  
  public ref CUtlVector<PointerTo<CPulse_CallInfo>> CallInfos { get; }
  
  public ref CUtlVector Constants { get; }
  
  public ref CUtlVector DomainValues { get; }
  
  public ref CUtlVector BlackboardReferences { get; }
  
  public ref CUtlVector<PointerTo<CPulse_OutputConnection>> OutputConnections { get; }
  
}