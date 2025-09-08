using SwiftlyS2.Shared.Schemas;

namespace SwiftlyS2.Core.SchemaDefinitions;

public partial interface ICommentaryAuto : IBaseEntity {

  public IEntityIOOutput OnCommentaryNewGame { get; }
  
  public IEntityIOOutput OnCommentaryMidGame { get; }
  
  public IEntityIOOutput OnCommentaryMultiplayerSpawn { get; }
  
}