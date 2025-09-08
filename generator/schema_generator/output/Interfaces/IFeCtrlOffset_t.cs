using SwiftlyS2.Shared.Schemas;

namespace SwiftlyS2.Core.SchemaDefinitions;

public partial interface IFeCtrlOffset_t : ISchemaClass {

  public ref Vector Offset { get; }
  
  public ref ushort CtrlParent { get; }
  
  public ref ushort CtrlChild { get; }
  
}