using SwiftlyS2.Shared.Schemas;

namespace SwiftlyS2.Core.SchemaDefinitions;

public partial interface ITwoBoneIKSettings_t : ISchemaClass {

  
  public ref IkEndEffectorType EndEffectorType { get; }
  
  public IAnimAttachment EndEffectorAttachment { get; }
  
  public ref IkTargetType TargetType { get; }
  
  public IAnimAttachment TargetAttachment { get; }
  
  public ref int TargetBoneIndex { get; }
  
  public IAnimParamHandle PositionParam { get; }
  
  public IAnimParamHandle RotationParam { get; }
  
  public ref bool AlwaysUseFallbackHinge { get; }
  
  public ref VectorAligned LsFallbackHingeAxis { get; }
  
  public ref int FixedBoneIndex { get; }
  
  public ref int MiddleBoneIndex { get; }
  
  public ref int EndBoneIndex { get; }
  
  public ref bool MatchTargetOrientation { get; }
  
  public ref bool ConstrainTwist { get; }
  
  public ref float MaxTwist { get; }
}