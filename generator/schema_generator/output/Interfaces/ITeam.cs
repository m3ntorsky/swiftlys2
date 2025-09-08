using SwiftlyS2.Shared.Schemas;

namespace SwiftlyS2.Core.SchemaDefinitions;

public partial interface ITeam : IBaseEntity {

  public ref CUtlVector PlayerControllers { get; }
  
  public ref CUtlVector Players { get; }
  
  public ref int Score { get; }
  
  public ISchemaFixedString Teamname { get; }
  
}