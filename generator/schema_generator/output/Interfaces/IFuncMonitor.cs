using SwiftlyS2.Shared.Schemas;

namespace SwiftlyS2.Core.SchemaDefinitions;

public partial interface IFuncMonitor : IFuncBrush {

  public ref CUtlString TargetCamera { get; }
  
  public ref int ResolutionEnum { get; }
  
  public ref bool RenderShadows { get; }
  
  public ref bool UseUniqueColorTarget { get; }
  
  public ref CUtlString BrushModelName { get; }
  
  public ref CHandle<CBaseEntity> TargetCamera { get; }
  
  public ref bool Enabled { get; }
  
  public ref bool Draw3DSkybox { get; }
  
  public ref bool StartEnabled { get; }
  
}