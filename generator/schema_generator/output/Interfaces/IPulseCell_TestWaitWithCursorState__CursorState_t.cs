using SwiftlyS2.Shared.Schemas;

namespace SwiftlyS2.Core.SchemaDefinitions;

public partial interface IPulseCell_TestWaitWithCursorState__CursorState_t : ISchemaClass {

  
  public ref float WaitValue { get; }
  
  public ref bool FailOnCancel { get; }
}