using SwiftlyS2.Shared.Schemas;

namespace SwiftlyS2.Core.SchemaDefinitions;

public partial interface INavLinkMovementVData : ISchemaClass {

  public ISchemaUntypedField ToolsOnlyOwnerModelName { get; }
  
  public ref bool IsInterpolated { get; }
  
  public ref uint RecommendedDistance { get; }
  
  public ref CUtlVector AnimgraphVars { get; }
  
}