using SwiftlyS2.Shared.Schemas;

namespace SwiftlyS2.Core.SchemaDefinitions;

public partial interface IPermModelInfo_t : ISchemaClass {

  public ref uint Flags { get; }
  
  public ref Vector HullMin { get; }
  
  public ref Vector HullMax { get; }
  
  public ref Vector ViewMin { get; }
  
  public ref Vector ViewMax { get; }
  
  public ref float Mass { get; }
  
  public ref Vector EyePosition { get; }
  
  public ref float MaxEyeDeflection { get; }
  
  public ref CUtlString SurfaceProperty { get; }
  
  public ref CUtlString KeyValueText { get; }
  
}