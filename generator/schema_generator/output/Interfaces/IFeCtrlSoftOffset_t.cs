using SwiftlyS2.Shared.Schemas;

namespace SwiftlyS2.Core.SchemaDefinitions;

public partial interface IFeCtrlSoftOffset_t : ISchemaClass {

  public ref ushort CtrlParent { get; }
  
  public ref ushort CtrlChild { get; }
  
  public ref Vector Offset { get; }
  
  public ref float Alpha { get; }
  
}