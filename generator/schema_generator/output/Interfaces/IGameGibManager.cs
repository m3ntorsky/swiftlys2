using SwiftlyS2.Shared.Schemas;

namespace SwiftlyS2.Core.SchemaDefinitions;

public partial interface IGameGibManager : IBaseEntity {

  public ref bool AllowNewGibs { get; }
  
  public ref int CurrentMaxPieces { get; }
  
  public ref int MaxPieces { get; }
  
  public ref int LastFrame { get; }
  
}