using SwiftlyS2.Shared.Schemas;

namespace SwiftlyS2.Core.SchemaDefinitions;

public partial interface IPointWorldText : IModelPointEntity {

  public ISchemaFixedString MessageText { get; }
  
  public ISchemaFixedString FontName { get; }
  
  public ISchemaFixedString BackgroundMaterialName { get; }
  
  public ref bool Enabled { get; }
  
  public ref bool Fullbright { get; }
  
  public ref float WorldUnitsPerPx { get; }
  
  public ref float FontSize { get; }
  
  public ref float DepthOffset { get; }
  
  public ref bool DrawBackground { get; }
  
  public ref float BackgroundBorderWidth { get; }
  
  public ref float BackgroundBorderHeight { get; }
  
  public ref float BackgroundWorldToUV { get; }
  
  public ref Color Color { get; }
  
  public ref PointWorldTextJustifyHorizontal_t JustifyHorizontal { get; }
  
  public ref PointWorldTextJustifyVertical_t JustifyVertical { get; }
  
  public ref PointWorldTextReorientMode_t ReorientMode { get; }
  
}