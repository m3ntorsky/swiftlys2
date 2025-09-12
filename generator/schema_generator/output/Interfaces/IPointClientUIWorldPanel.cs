using SwiftlyS2.Shared.Schemas;

namespace SwiftlyS2.Core.SchemaDefinitions;

public partial interface IPointClientUIWorldPanel : IBaseClientUIEntity {

  
  public ref bool IgnoreInput { get; }
  
  public ref bool Lit { get; }
  
  public ref bool FollowPlayerAcrossTeleport { get; }
  
  public ref float Width { get; }
  
  public ref float Height { get; }
  
  public ref float DPI { get; }
  
  public ref float InteractDistance { get; }
  
  public ref float DepthOffset { get; }
  
  public ref uint OwnerContext { get; }
  
  public ref uint HorizontalAlign { get; }
  
  public ref uint VerticalAlign { get; }
  
  public ref uint Orientation { get; }
  
  public ref bool AllowInteractionFromAllSceneWorlds { get; }
  
// CNetworkUtlVectorBase< CUtlSymbolLarge >
  public ref CUtlVector CSSClasses { get; }
  
  public ref bool Opaque { get; }
  
  public ref bool NoDepth { get; }
  
  public ref bool VisibleWhenParentNoDraw { get; }
  
  public ref bool RenderBackface { get; }
  
  public ref bool UseOffScreenIndicator { get; }
  
  public ref bool ExcludeFromSaveGames { get; }
  
  public ref bool Grabbable { get; }
  
  public ref bool OnlyRenderToTexture { get; }
  
  public ref bool DisableMipGen { get; }
  
  public ref int ExplicitImageLayout { get; }
}