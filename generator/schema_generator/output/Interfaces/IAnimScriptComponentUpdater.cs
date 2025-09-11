using SwiftlyS2.Shared.Schemas;

namespace SwiftlyS2.Core.SchemaDefinitions;

public partial interface IAnimScriptComponentUpdater : IAnimComponentUpdater {

  
  public IAnimScriptHandle Script { get; }
}