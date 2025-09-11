using SwiftlyS2.Shared.Schemas;

namespace SwiftlyS2.Core.SchemaDefinitions;

public partial interface IFeNamedJiggleBone : ISchemaClass {

  
  public ref CUtlString StrParentBone { get; }
  
  public ref CTransform Transform { get; }
  
  public ref uint JiggleParent { get; }
  
  public IFeJiggleBone JiggleBone { get; }
}