using SwiftlyS2.Shared.Schemas;

namespace SwiftlyS2.Core.SchemaDefinitions;

public partial interface IPulseGraphDef : ISchemaClass {

  
  public ISchemaUntypedField DomainIdentifier { get; }
  
  public ISchemaUntypedField DomainSubType { get; }
  
  public ISchemaUntypedField ParentMapName { get; }
  
  public ISchemaUntypedField ParentXmlName { get; }
  
  public ref CUtlVector<PointerTo<CPulse_Chunk>> Chunks { get; }
  
  public ref CUtlVector<PointerTo<CPulseCell_Base>> Cells { get; }
  
// CUtlVector< CPulse_Variable >
  public ref CUtlVector Vars { get; }
  
// CUtlVector< CPulse_PublicOutput >
  public ref CUtlVector PublicOutputs { get; }
  
  public ref CUtlVector<PointerTo<CPulse_InvokeBinding>> InvokeBindings { get; }
  
  public ref CUtlVector<PointerTo<CPulse_CallInfo>> CallInfos { get; }
  
// CUtlVector< CPulse_Constant >
  public ref CUtlVector Constants { get; }
  
// CUtlVector< CPulse_DomainValue >
  public ref CUtlVector DomainValues { get; }
  
// CUtlVector< CPulse_BlackboardReference >
  public ref CUtlVector BlackboardReferences { get; }
  
  public ref CUtlVector<PointerTo<CPulse_OutputConnection>> OutputConnections { get; }
}