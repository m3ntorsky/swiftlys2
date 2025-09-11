using SwiftlyS2.Shared.Schemas;

namespace SwiftlyS2.Core.SchemaDefinitions;

public partial interface IFeTaperedCapsuleStretch_t : ISchemaClass {

  
  public ISchemaFixedArray<ushort> Node { get; }
  
  public ref ushort CollisionMask { get; }
  
  public ref ushort Dummy { get; }
  
  public ISchemaFixedArray<float> Radius { get; }
}