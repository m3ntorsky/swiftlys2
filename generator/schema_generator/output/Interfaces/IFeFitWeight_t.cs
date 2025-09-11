using SwiftlyS2.Shared.Schemas;

namespace SwiftlyS2.Core.SchemaDefinitions;

public partial interface IFeFitWeight_t : ISchemaClass {

  
  public ref float Weight { get; }
  
  public ref ushort Node { get; }
  
  public ref ushort Dummy { get; }
}