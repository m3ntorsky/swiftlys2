using SwiftlyS2.Shared.Schemas;

namespace SwiftlyS2.Core.SchemaDefinitions;

public partial interface IMarkupVolume : IBaseModelEntity {

  public ref bool Disabled { get; }
  
}