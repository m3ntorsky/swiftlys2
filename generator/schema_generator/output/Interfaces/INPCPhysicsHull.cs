using SwiftlyS2.Shared.Schemas;

namespace SwiftlyS2.Core.SchemaDefinitions;

public partial interface INPCPhysicsHull : ISchemaClass {

  public ref CGlobalSymbol Name { get; }
  
  public ref NPCPhysicsHullType_t Type { get; }
  
  public ref float CapsuleHeight { get; }
  
  public ref float CapsuleRadius { get; }
  
  public ref Vector CapsuleCenter1 { get; }
  
  public ref Vector CapsuleCenter2 { get; }
  
  public ref float GroundBoxHeight { get; }
  
  public ref float GroundBoxWidth { get; }
  
}