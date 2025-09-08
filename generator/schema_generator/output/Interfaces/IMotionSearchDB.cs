using SwiftlyS2.Shared.Schemas;

namespace SwiftlyS2.Core.SchemaDefinitions;

public partial interface IMotionSearchDB : ISchemaClass {

  public IMotionSearchNode RootNode { get; }
  
  public IProductQuantizer ResidualQuantizer { get; }
  
  public ref CUtlVector CodeIndices { get; }
  
}