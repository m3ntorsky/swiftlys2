using SwiftlyS2.Shared.Schemas;

namespace SwiftlyS2.Core.SchemaDefinitions;

public partial interface IPhysSurfaceProperties : ISchemaClass {

  public ref CUtlString Name { get; }
  
  public ref uint NameHash { get; }
  
  public ref uint BaseNameHash { get; }
  
  public ref bool Hidden { get; }
  
  public ref CUtlString Description { get; }
  
  public IPhysSurfacePropertiesPhysics Physics { get; }
  
  public IPhysSurfacePropertiesVehicle VehicleParams { get; }
  
  public IPhysSurfacePropertiesSoundNames AudioSounds { get; }
  
  public IPhysSurfacePropertiesAudio AudioParams { get; }
  
}