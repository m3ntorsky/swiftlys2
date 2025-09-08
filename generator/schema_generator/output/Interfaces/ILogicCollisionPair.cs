using SwiftlyS2.Shared.Schemas;

namespace SwiftlyS2.Core.SchemaDefinitions;

public partial interface ILogicCollisionPair : ILogicalEntity {

  public ref CUtlSymbolLarge NameAttach1 { get; }
  
  public ref CUtlSymbolLarge NameAttach2 { get; }
  
  public ref bool SupportMultipleEntitiesWithSameName { get; }
  
  public ref bool Disabled { get; }
  
  public ref bool Succeeded { get; }
  
}