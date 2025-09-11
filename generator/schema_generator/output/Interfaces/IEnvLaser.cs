using SwiftlyS2.Shared.Schemas;

namespace SwiftlyS2.Core.SchemaDefinitions;

public partial interface IEnvLaser : IBeam {

  
  public ref CUtlSymbolLarge LaserTarget { get; }
  
  public ISprite Sprite { get; }
  
  public ref CUtlSymbolLarge SpriteName { get; }
  
  public ref Vector FirePosition { get; }
  
  public ref float StartFrame { get; }
}