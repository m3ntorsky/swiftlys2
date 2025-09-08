using SwiftlyS2.Shared.Schemas;

namespace SwiftlyS2.Core.SchemaDefinitions;

public partial interface IFeCollisionPlane_t : ISchemaClass {

  public ref ushort CtrlParent { get; }
  
  public ref ushort ChildNode { get; }
  
  public IRnPlane_t Plane { get; }
  
  public ref float Strength { get; }
  
}