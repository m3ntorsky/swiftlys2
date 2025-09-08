using SwiftlyS2.Shared.Schemas;

namespace SwiftlyS2.Core.SchemaDefinitions;

public partial interface IBuyZone : IBaseTrigger {

  public ref int LegacyTeamNum { get; }
  
}