using SwiftlyS2.Shared.Schemas;

namespace SwiftlyS2.Core.SchemaDefinitions;

public partial interface ISoundAreaEntityBase : IBaseEntity {

  
  public ref bool Disabled { get; }
  
  public ISchemaUntypedField SoundAreaType { get; }
  
  public ref Vector Pos { get; }
}