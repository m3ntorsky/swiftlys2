using SwiftlyS2.Shared.Schemas;

namespace SwiftlyS2.Core.SchemaDefinitions;

public partial interface IAnimLocalHierarchy : ISchemaClass {

  public ref CBufferString Bone { get; }
  
  public ref CBufferString NewParent { get; }
  
  public ref int StartFrame { get; }
  
  public ref int PeakFrame { get; }
  
  public ref int TailFrame { get; }
  
  public ref int EndFrame { get; }
  
}