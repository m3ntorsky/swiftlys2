using SwiftlyS2.Shared.Schemas;

namespace SwiftlyS2.Core.SchemaDefinitions;

public partial interface ILogicNPCCounter : IBaseEntity {

  
  public IEntityIOOutput OnMinCountAll { get; }
  
  public IEntityIOOutput OnMaxCountAll { get; }
  
  public ISchemaUntypedField OnFactorAll { get; }
  
  public ISchemaUntypedField OnMinPlayerDistAll { get; }
  
  public IEntityIOOutput OnMinCount_1 { get; }
  
  public IEntityIOOutput OnMaxCount_1 { get; }
  
  public ISchemaUntypedField OnFactor_1 { get; }
  
  public ISchemaUntypedField OnMinPlayerDist_1 { get; }
  
  public IEntityIOOutput OnMinCount_2 { get; }
  
  public IEntityIOOutput OnMaxCount_2 { get; }
  
  public ISchemaUntypedField OnFactor_2 { get; }
  
  public ISchemaUntypedField OnMinPlayerDist_2 { get; }
  
  public IEntityIOOutput OnMinCount_3 { get; }
  
  public IEntityIOOutput OnMaxCount_3 { get; }
  
  public ISchemaUntypedField OnFactor_3 { get; }
  
  public ISchemaUntypedField OnMinPlayerDist_3 { get; }
  
  public ref CEntityHandle Source { get; }
  
  public ref CUtlSymbolLarge SourceEntityName { get; }
  
  public ref float DistanceMax { get; }
  
  public ref bool Disabled { get; }
  
  public ref int MinCountAll { get; }
  
  public ref int MaxCountAll { get; }
  
  public ref int MinFactorAll { get; }
  
  public ref int MaxFactorAll { get; }
  
  public ref CUtlSymbolLarge NPCClassname_1 { get; }
  
  public ref int NPCState_1 { get; }
  
  public ref bool InvertState_1 { get; }
  
  public ref int MinCount_1 { get; }
  
  public ref int MaxCount_1 { get; }
  
  public ref int MinFactor_1 { get; }
  
  public ref int MaxFactor_1 { get; }
  
  public ref float DefaultDist_1 { get; }
  
  public ref CUtlSymbolLarge NPCClassname_2 { get; }
  
  public ref int NPCState_2 { get; }
  
  public ref bool InvertState_2 { get; }
  
  public ref int MinCount_2 { get; }
  
  public ref int MaxCount_2 { get; }
  
  public ref int MinFactor_2 { get; }
  
  public ref int MaxFactor_2 { get; }
  
  public ref float DefaultDist_2 { get; }
  
  public ref CUtlSymbolLarge NPCClassname_3 { get; }
  
  public ref int NPCState_3 { get; }
  
  public ref bool InvertState_3 { get; }
  
  public ref int MinCount_3 { get; }
  
  public ref int MaxCount_3 { get; }
  
  public ref int MinFactor_3 { get; }
  
  public ref int MaxFactor_3 { get; }
  
  public ref float DefaultDist_3 { get; }
}