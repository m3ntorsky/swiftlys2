using SwiftlyS2.Shared.Schemas;

namespace SwiftlyS2.Core.SchemaDefinitions;

public partial interface IPhysSurfacePropertiesSoundNames : ISchemaClass {

  public ref CUtlString ImpactSoft { get; }
  
  public ref CUtlString ImpactHard { get; }
  
  public ref CUtlString ScrapeSmooth { get; }
  
  public ref CUtlString ScrapeRough { get; }
  
  public ref CUtlString BulletImpact { get; }
  
  public ref CUtlString Rolling { get; }
  
  public ref CUtlString Break { get; }
  
  public ref CUtlString Strain { get; }
  
  public ref CUtlString MeleeImpact { get; }
  
  public ref CUtlString PushOff { get; }
  
  public ref CUtlString SkidStop { get; }
  
  public ref CUtlString Resonant { get; }
  
}