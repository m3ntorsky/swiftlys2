using SwiftlyS2.Shared.Schemas;

namespace SwiftlyS2.Core.SchemaDefinitions;

public partial interface IWorld_t : ISchemaClass {

  public IWorldBuilderParams_t BuilderParams { get; }
  
  public ref CUtlVector WorldNodes { get; }
  
  public IBakedLightingInfo_t WorldLightingInfo { get; }
  
  public ref CUtlVector EntityLumps { get; }
  
}