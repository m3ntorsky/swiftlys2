using SwiftlyS2.Shared.Schemas;

namespace SwiftlyS2.Core.SchemaDefinitions;

public partial interface IShatterGlassShardPhysics : IPhysicsProp {

  
  public ref bool Debris { get; }
  
  public ref uint ParentShard { get; }
  
  public Ishard_model_desc_t ShardDesc { get; }
}