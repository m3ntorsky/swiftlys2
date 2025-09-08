using SwiftlyS2.Shared.Schemas;

namespace SwiftlyS2.Core.SchemaDefinitions;

public partial interface IVMixFreeverbDesc_t : ISchemaClass {

  public ref float RoomSize { get; }
  
  public ref float Damp { get; }
  
  public ref float Width { get; }
  
  public ref float LateReflections { get; }
  
}