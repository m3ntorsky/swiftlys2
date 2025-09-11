using SwiftlyS2.Shared.Schemas;

namespace SwiftlyS2.Core.SchemaDefinitions;

public partial interface INavLinkAnimgraphVar : ISchemaClass {

  
  public ref CGlobalSymbol AnimGraphNavlinkType { get; }
  
  public ref uint AlignmentDegrees { get; }
}