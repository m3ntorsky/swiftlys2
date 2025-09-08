using SwiftlyS2.Shared.Schemas;

namespace SwiftlyS2.Core.SchemaDefinitions;

public partial interface IToggleComponentActionUpdater : IAnimActionUpdater {

  public IAnimComponentID ComponentID { get; }
  
  public ref bool SetEnabled { get; }
  
}