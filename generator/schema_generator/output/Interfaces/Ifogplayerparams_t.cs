using SwiftlyS2.Shared.Schemas;

namespace SwiftlyS2.Core.SchemaDefinitions;

public partial interface Ifogplayerparams_t : ISchemaClass {

  public ref CHandle<CFogController> Ctrl { get; }
  
  public ref float TransitionTime { get; }
  
  public ref Color OldColor { get; }
  
  public ref float OldStart { get; }
  
  public ref float OldEnd { get; }
  
  public ref float OldMaxDensity { get; }
  
  public ref float OldHDRColorScale { get; }
  
  public ref float OldFarZ { get; }
  
  public ref Color NewColor { get; }
  
  public ref float NewStart { get; }
  
  public ref float NewEnd { get; }
  
  public ref float NewMaxDensity { get; }
  
  public ref float NewHDRColorScale { get; }
  
  public ref float NewFarZ { get; }
  
}