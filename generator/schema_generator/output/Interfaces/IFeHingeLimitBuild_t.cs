using SwiftlyS2.Shared.Schemas;

namespace SwiftlyS2.Core.SchemaDefinitions;

public partial interface IFeHingeLimitBuild_t : ISchemaClass {

  public ISchemaFixedArray<ushort> Node { get; }
  
  public ref uint Flags { get; }
  
  public ref float LimitCW { get; }
  
  public ref float LimitCCW { get; }
  
}