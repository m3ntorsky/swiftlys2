using SwiftlyS2.Shared.Schemas;

namespace SwiftlyS2.Core.SchemaDefinitions;

public partial interface ISSDSMsg_ViewTarget : ISchemaClass {

  public ref CUtlString Name { get; }
  
  public ref ulong TextureId { get; }
  
  public ref int Width { get; }
  
  public ref int Height { get; }
  
  public ref int RequestedWidth { get; }
  
  public ref int RequestedHeight { get; }
  
  public ref int NumMipLevels { get; }
  
  public ref int Depth { get; }
  
  public ref int MultisampleNumSamples { get; }
  
  public ref int Format { get; }
  
}