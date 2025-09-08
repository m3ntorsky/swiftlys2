using SwiftlyS2.Shared.Schemas;

namespace SwiftlyS2.Core.SchemaDefinitions;

public partial interface IRotDoor : IBaseDoor {

  public ref bool SolidBsp { get; }
  
}