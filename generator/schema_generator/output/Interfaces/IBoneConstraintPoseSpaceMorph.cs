using SwiftlyS2.Shared.Schemas;

namespace SwiftlyS2.Core.SchemaDefinitions;

public partial interface IBoneConstraintPoseSpaceMorph : IBoneConstraintBase {

  
  public ref CUtlString BoneName { get; }
  
  public ref CUtlString AttachmentName { get; }
  
  public ref CUtlVector<CUtlString> OutputMorph { get; }
  
// CUtlVector< CBoneConstraintPoseSpaceMorph::Input_t >
  public ref CUtlVector InputList { get; }
  
  public ref bool Clamp { get; }
}