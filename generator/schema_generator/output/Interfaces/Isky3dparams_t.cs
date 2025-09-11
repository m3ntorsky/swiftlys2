using SwiftlyS2.Shared.Schemas;

namespace SwiftlyS2.Core.SchemaDefinitions;

public partial interface Isky3dparams_t : ISchemaClass {

  
  public ref short Scale { get; }
  
  public ref Vector Origin { get; }
  
  public ref bool Clip3DSkyBoxNearToWorldFar { get; }
  
  public ref float Clip3DSkyBoxNearToWorldFarOffset { get; }
  
  public Ifogparams_t Fog { get; }
  
  public ref WorldGroupId_t WorldGroupID { get; }
}