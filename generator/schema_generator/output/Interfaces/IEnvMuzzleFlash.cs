using SwiftlyS2.Shared.Schemas;

namespace SwiftlyS2.Core.SchemaDefinitions;

public partial interface IEnvMuzzleFlash : IPointEntity {

  
  public ref float Scale { get; }
  
  public ref CUtlSymbolLarge ParentAttachment { get; }
}