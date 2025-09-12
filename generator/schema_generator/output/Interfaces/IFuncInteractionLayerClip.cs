using SwiftlyS2.Shared.Schemas;

namespace SwiftlyS2.Core.SchemaDefinitions;

public partial interface IFuncInteractionLayerClip : IBaseModelEntity {

  
  public ref bool Disabled { get; }
  
  public ISchemaUntypedField InteractsAs { get; }
  
  public ISchemaUntypedField InteractsWith { get; }
}