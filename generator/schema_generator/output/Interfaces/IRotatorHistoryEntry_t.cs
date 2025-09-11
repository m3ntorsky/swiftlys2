using SwiftlyS2.Shared.Schemas;

namespace SwiftlyS2.Core.SchemaDefinitions;

public partial interface IRotatorHistoryEntry_t : ISchemaClass {

  
  public ref Quaternion InvChange { get; }
  
  public IGameTime_t TimeRotationStart { get; }
}