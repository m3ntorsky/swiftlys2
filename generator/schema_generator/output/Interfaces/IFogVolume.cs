using SwiftlyS2.Shared.Schemas;

namespace SwiftlyS2.Core.SchemaDefinitions;

public partial interface IFogVolume : IServerOnlyModelEntity {

  
  public ISchemaUntypedField FogName { get; }
  
  public ISchemaUntypedField PostProcessName { get; }
  
  public ISchemaUntypedField ColorCorrectionName { get; }
  
  public ref bool Disabled { get; }
  
  public ref bool InFogVolumesList { get; }
}