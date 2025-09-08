using SwiftlyS2.Shared.Schemas;

namespace SwiftlyS2.Core.SchemaDefinitions;

public partial interface IJiggleBoneSettings_t : ISchemaClass {

  public ref int BoneIndex { get; }
  
  public ref float SpringStrength { get; }
  
  public ref float MaxTimeStep { get; }
  
  public ref float Damping { get; }
  
  public ref Vector BoundsMaxLS { get; }
  
  public ref Vector BoundsMinLS { get; }
  
  public ref JiggleBoneSimSpace SimSpace { get; }
  
}