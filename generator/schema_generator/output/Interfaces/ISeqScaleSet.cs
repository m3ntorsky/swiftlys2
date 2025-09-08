using SwiftlyS2.Shared.Schemas;

namespace SwiftlyS2.Core.SchemaDefinitions;

public partial interface ISeqScaleSet : ISchemaClass {

  public ref CBufferString Name { get; }
  
  public ref bool RootOffset { get; }
  
  public ref Vector RootOffset { get; }
  
  public ref CUtlVector<short> LocalBoneArray { get; }
  
  public ref CUtlVector<float> BoneScaleArray { get; }
  
}