using SwiftlyS2.Shared.Schemas;

namespace SwiftlyS2.Core.SchemaDefinitions;

public partial interface IVPhysXCollisionAttributes_t : ISchemaClass {

  
  public ref uint CollisionGroup { get; }
  
  public ref CUtlVector<uint> InteractAs { get; }
  
  public ref CUtlVector<uint> InteractWith { get; }
  
  public ref CUtlVector<uint> InteractExclude { get; }
  
  public ref CUtlString CollisionGroupString { get; }
  
  public ref CUtlVector<CUtlString> InteractAsStrings { get; }
  
  public ref CUtlVector<CUtlString> InteractWithStrings { get; }
  
  public ref CUtlVector<CUtlString> InteractExcludeStrings { get; }
}