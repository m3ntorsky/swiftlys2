using SwiftlyS2.Shared.Schemas;

namespace SwiftlyS2.Core.SchemaDefinitions;

public partial interface IMorphConstraint : IBaseConstraint {

  public ref CUtlString TargetMorph { get; }
  
  public ref int SlaveChannel { get; }
  
  public ref float Min { get; }
  
  public ref float Max { get; }
  
}