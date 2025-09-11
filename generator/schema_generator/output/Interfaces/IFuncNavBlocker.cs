using SwiftlyS2.Shared.Schemas;

namespace SwiftlyS2.Core.SchemaDefinitions;

public partial interface IFuncNavBlocker : IBaseModelEntity {

  
  public ref bool Disabled { get; }
  
  public ref int BlockedTeamNumber { get; }
}