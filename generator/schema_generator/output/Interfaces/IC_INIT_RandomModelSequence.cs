using SwiftlyS2.Shared.Schemas;

namespace SwiftlyS2.Core.SchemaDefinitions;

public partial interface IC_INIT_RandomModelSequence : IParticleFunctionInitializer {

  public ISchemaFixedString ActivityName { get; }
  
  public ISchemaFixedString SequenceName { get; }
  
  public CStrongHandle<IInfoForResourceTypeCModel> Model { get; }
  
}