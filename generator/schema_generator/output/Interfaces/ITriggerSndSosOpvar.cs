using SwiftlyS2.Shared.Schemas;

namespace SwiftlyS2.Core.SchemaDefinitions;

public partial interface ITriggerSndSosOpvar : IBaseTrigger {

  public ref CUtlVector<CHandle<CBaseEntity>> TouchingPlayers { get; }
  
  public ref Vector Position { get; }
  
  public ref float CenterSize { get; }
  
  public ref float MinVal { get; }
  
  public ref float MaxVal { get; }
  
  public ref CUtlSymbolLarge OpvarName { get; }
  
  public ref CUtlSymbolLarge StackName { get; }
  
  public ref CUtlSymbolLarge OperatorName { get; }
  
  public ref bool VolIs2D { get; }
  
  public ISchemaFixedString OpvarNameChar { get; }
  
  public ISchemaFixedString StackNameChar { get; }
  
  public ISchemaFixedString OperatorNameChar { get; }
  
  public ref Vector VecNormPos { get; }
  
  public ref float NormCenterSize { get; }
  
}