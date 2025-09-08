using SwiftlyS2.Shared.Schemas;

namespace SwiftlyS2.Core.SchemaDefinitions;

public partial interface Iaudioparams_t : ISchemaClass {

  public ISchemaFixedArray<Vector> LocalSound { get; }
  
  public ref int SoundscapeIndex { get; }
  
  public ref byte LocalBits { get; }
  
  public ref int SoundscapeEntityListIndex { get; }
  
  public ref uint SoundEventHash { get; }
  
}