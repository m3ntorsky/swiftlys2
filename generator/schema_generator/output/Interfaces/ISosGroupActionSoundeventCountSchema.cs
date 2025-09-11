using SwiftlyS2.Shared.Schemas;

namespace SwiftlyS2.Core.SchemaDefinitions;

public partial interface ISosGroupActionSoundeventCountSchema : ISosGroupActionSchema {

  
  public ref bool ExcludeStoppedSounds { get; }
  
  public ref CUtlString StrCountKeyName { get; }
}