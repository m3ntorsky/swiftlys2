using SwiftlyS2.Shared.Schemas;

namespace SwiftlyS2.Core.SchemaDefinitions;

public partial interface IAnimDataChannelDesc : ISchemaClass {

  public ref CBufferString ChannelClass { get; }
  
  public ref CBufferString VariableName { get; }
  
  public ref int Flags { get; }
  
  public ref int Type { get; }
  
  public ref CBufferString Grouping { get; }
  
  public ref CBufferString Description { get; }
  
  public ref CUtlVector<CBufferString> ElementNameArray { get; }
  
  public ref CUtlVector<int> ElementIndexArray { get; }
  
  public ref CUtlVector<uint> ElementMaskArray { get; }
  
}