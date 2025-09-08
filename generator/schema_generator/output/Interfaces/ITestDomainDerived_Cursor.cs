using SwiftlyS2.Shared.Schemas;

namespace SwiftlyS2.Core.SchemaDefinitions;

public partial interface ITestDomainDerived_Cursor : IPulseExecCursor {

  public ref int CursorValueA { get; }
  
  public ref int CursorValueB { get; }
  
}