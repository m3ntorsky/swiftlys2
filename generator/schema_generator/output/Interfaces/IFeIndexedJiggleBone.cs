using SwiftlyS2.Shared.Schemas;

namespace SwiftlyS2.Core.SchemaDefinitions;

public partial interface IFeIndexedJiggleBone : ISchemaClass {

  public ref uint Node { get; }
  
  public ref uint JiggleParent { get; }
  
  public IFeJiggleBone JiggleBone { get; }
  
}