using SwiftlyS2.Shared.Schemas;

namespace SwiftlyS2.Core.SchemaDefinitions;

public partial interface IParticleChildrenInfo_t : ISchemaClass {

  public CStrongHandle<IInfoForResourceTypeIParticleSystemDefinition> ChildRef { get; }
  
  public ref float Delay { get; }
  
  public ref bool EndCap { get; }
  
  public ref bool DisableChild { get; }
  
  public ref ParticleDetailLevel_t DetailLevel { get; }
  
}