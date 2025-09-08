using SwiftlyS2.Shared.Schemas;

namespace SwiftlyS2.Core.SchemaDefinitions;

public partial interface IPhysConstraint : ILogicalEntity {

  public ref CUtlSymbolLarge NameAttach1 { get; }
  
  public ref CUtlSymbolLarge NameAttach2 { get; }
  
  public CHandle<IBaseEntity> Attach1 { get; }
  
  public CHandle<IBaseEntity> Attach2 { get; }
  
  public ref CUtlSymbolLarge NameAttachment1 { get; }
  
  public ref CUtlSymbolLarge NameAttachment2 { get; }
  
  public ref CUtlSymbolLarge BreakSound { get; }
  
  public ref float ForceLimit { get; }
  
  public ref float TorqueLimit { get; }
  
  public ref float MinTeleportDistance { get; }
  
  public ref bool SnapObjectPositions { get; }
  
  public IEntityIOOutput OnBreak { get; }
  
}