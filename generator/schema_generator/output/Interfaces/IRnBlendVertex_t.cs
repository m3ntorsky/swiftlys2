using SwiftlyS2.Shared.Schemas;

namespace SwiftlyS2.Core.SchemaDefinitions;

public partial interface IRnBlendVertex_t : ISchemaClass {

  
  public ref ushort Weight0 { get; }
  
  public ref ushort Index0 { get; }
  
  public ref ushort Weight1 { get; }
  
  public ref ushort Index1 { get; }
  
  public ref ushort Weight2 { get; }
  
  public ref ushort Index2 { get; }
  
  public ref ushort Flags { get; }
  
  public ref ushort TargetIndex { get; }
}