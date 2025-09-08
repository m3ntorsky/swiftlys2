using SwiftlyS2.Shared.Schemas;

namespace SwiftlyS2.Core.SchemaDefinitions;

public partial interface ISeqIKLock : ISchemaClass {

  public ref float PosWeight { get; }
  
  public ref float AngleWeight { get; }
  
  public ref short LocalBone { get; }
  
  public ref bool BonesOrientedAlongPositiveX { get; }
  
}