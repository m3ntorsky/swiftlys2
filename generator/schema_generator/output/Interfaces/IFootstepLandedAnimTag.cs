using SwiftlyS2.Shared.Schemas;

namespace SwiftlyS2.Core.SchemaDefinitions;

public partial interface IFootstepLandedAnimTag : IAnimTagBase {

  public ref FootstepLandedFootSoundType_t FootstepType { get; }
  
  public ref CUtlString OverrideSoundName { get; }
  
  public ref CUtlString DebugAnimSourceString { get; }
  
  public ref CUtlString BoneName { get; }
  
}