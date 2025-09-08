using SwiftlyS2.Shared.Schemas;

namespace SwiftlyS2.Core.SchemaDefinitions;

public partial interface IAnimKeyData : ISchemaClass {

  public ref CBufferString Name { get; }
  
  public ref CUtlVector BoneArray { get; }
  
  public ref CUtlVector UserArray { get; }
  
  public ref CUtlVector<CBufferString> MorphArray { get; }
  
  public ref int ChannelElements { get; }
  
  public ref CUtlVector DataChannelArray { get; }
  
}