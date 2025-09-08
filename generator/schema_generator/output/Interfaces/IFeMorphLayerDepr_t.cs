using SwiftlyS2.Shared.Schemas;

namespace SwiftlyS2.Core.SchemaDefinitions;

public partial interface IFeMorphLayerDepr_t : ISchemaClass {

  public ref CUtlString Name { get; }
  
  public ref uint NameHash { get; }
  
  public ref CUtlVector<ushort> Nodes { get; }
  
  public ref CUtlVector<Vector> InitPos { get; }
  
  public ref CUtlVector<float> Gravity { get; }
  
  public ref CUtlVector<float> GoalStrength { get; }
  
  public ref CUtlVector<float> GoalDamping { get; }
  
  public ref uint Flags { get; }
  
}