using SwiftlyS2.Shared.Schemas;

namespace SwiftlyS2.Core.SchemaDefinitions;

public partial interface IPulse_BlackboardReference : ISchemaClass {

  public CStrongHandle<IInfoForResourceTypeIPulseGraphDef> BlackboardResource { get; }
  
  public ISchemaUntypedField BlackboardResource { get; }
  
  public IPulseDocNodeID_t NodeID { get; }
  
  public ref CGlobalSymbol NodeName { get; }
  
}