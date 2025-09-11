using SwiftlyS2.Shared.Schemas;

namespace SwiftlyS2.Core.SchemaDefinitions;

public partial interface IFeHingeLimit_t : ISchemaClass {

  
  public ISchemaFixedArray<ushort> Node { get; }
  
  public ref uint Flags { get; }
  
  public ref float Weight4 { get; }
  
  public ref float Weight5 { get; }
  
  public ref float AngleCenter { get; }
  
  public ref float AngleExtents { get; }
}