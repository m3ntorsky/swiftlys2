using SwiftlyS2.Shared.Schemas;

namespace SwiftlyS2.Core.SchemaDefinitions;

public partial interface IVMixDiffusorDesc_t : ISchemaClass {

  public ref float Size { get; }
  
  public ref float Complexity { get; }
  
  public ref float Feedback { get; }
  
  public ref float OutputGain { get; }
  
}