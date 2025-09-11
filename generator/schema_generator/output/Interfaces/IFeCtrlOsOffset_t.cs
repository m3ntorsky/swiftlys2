using SwiftlyS2.Shared.Schemas;

namespace SwiftlyS2.Core.SchemaDefinitions;

public partial interface IFeCtrlOsOffset_t : ISchemaClass {

  
  public ref ushort CtrlParent { get; }
  
  public ref ushort CtrlChild { get; }
}