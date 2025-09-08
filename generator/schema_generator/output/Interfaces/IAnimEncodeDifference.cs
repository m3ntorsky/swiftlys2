using SwiftlyS2.Shared.Schemas;

namespace SwiftlyS2.Core.SchemaDefinitions;

public partial interface IAnimEncodeDifference : ISchemaClass {

  public ref CUtlVector BoneArray { get; }
  
  public ref CUtlVector MorphArray { get; }
  
  public ref CUtlVector UserArray { get; }
  
  public ref CUtlVector<byte> HasRotationBitArray { get; }
  
  public ref CUtlVector<byte> HasMovementBitArray { get; }
  
  public ref CUtlVector<byte> HasMorphBitArray { get; }
  
  public ref CUtlVector<byte> HasUserBitArray { get; }
  
}