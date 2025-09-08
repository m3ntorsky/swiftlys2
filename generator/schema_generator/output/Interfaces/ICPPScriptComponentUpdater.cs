using SwiftlyS2.Shared.Schemas;

namespace SwiftlyS2.Core.SchemaDefinitions;

public partial interface ICPPScriptComponentUpdater : IAnimComponentUpdater {

  public ref CUtlVector<CGlobalSymbol> ScriptsToRun { get; }
  
}