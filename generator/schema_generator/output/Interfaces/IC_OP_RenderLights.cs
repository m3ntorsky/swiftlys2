using SwiftlyS2.Shared.Schemas;

namespace SwiftlyS2.Core.SchemaDefinitions;

public partial interface IC_OP_RenderLights : IC_OP_RenderPoints {

  public ref float AnimationRate { get; }
  
  public ref AnimationType_t AnimationType { get; }
  
  public ref bool AnimateInFPS { get; }
  
  public ref float MinSize { get; }
  
  public ref float MaxSize { get; }
  
  public ref float StartFadeSize { get; }
  
  public ref float EndFadeSize { get; }
  
}