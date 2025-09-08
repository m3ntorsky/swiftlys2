using SwiftlyS2.Shared.Schemas;

namespace SwiftlyS2.Core.SchemaDefinitions;

public partial interface IPulseCell_CursorQueue : IPulseCell_WaitForCursorsWithTagBase {

  public ref int CursorsAllowedToRunParallel { get; }
  
}