using SwiftlyS2.Shared.Schemas;

namespace SwiftlyS2.Core.SchemaDefinitions;

public partial interface IHitboxComponent : IEntityComponent {

  
  public ISchemaFixedArray<uint> DisabledHitGroups { get; }
}