using SwiftlyS2.Shared.Schemas;

namespace SwiftlyS2.Core.SchemaDefinitions;

public partial interface IVPhysXBodyPart_t : ISchemaClass {

  
  public ref uint Flags { get; }
  
  public ref float Mass { get; }
  
  public IVPhysics2ShapeDef_t RnShape { get; }
  
  public ref ushort CollisionAttributeIndex { get; }
  
  public ref ushort Reserved { get; }
  
  public ref float InertiaScale { get; }
  
  public ref float LinearDamping { get; }
  
  public ref float AngularDamping { get; }
  
  public ref float LinearDrag { get; }
  
  public ref float AngularDrag { get; }
  
  public ref bool OverrideMassCenter { get; }
  
  public ref Vector MassCenterOverride { get; }
}