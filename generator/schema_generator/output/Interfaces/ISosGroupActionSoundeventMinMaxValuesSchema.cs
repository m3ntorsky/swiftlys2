using SwiftlyS2.Shared.Schemas;

namespace SwiftlyS2.Core.SchemaDefinitions;

public partial interface ISosGroupActionSoundeventMinMaxValuesSchema : ISosGroupActionSchema {

  public ref CUtlString StrQueryPublicFieldName { get; }
  
  public ref CUtlString StrDelayPublicFieldName { get; }
  
  public ref bool ExcludeStoppedSounds { get; }
  
  public ref bool ExcludeDelayedSounds { get; }
  
  public ref bool ExcludeSoundsBelowThreshold { get; }
  
  public ref float ExcludeSoundsMinThresholdValue { get; }
  
  public ref bool ExcludSoundsAboveThreshold { get; }
  
  public ref float ExcludeSoundsMaxThresholdValue { get; }
  
  public ref CUtlString StrMinValueName { get; }
  
  public ref CUtlString StrMaxValueName { get; }
  
}