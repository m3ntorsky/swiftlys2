using SwiftlyS2.Shared.Schemas;

namespace SwiftlyS2.Core.SchemaDefinitions;

public partial interface ISprite : IBaseModelEntity {

  public CStrongHandle<IInfoForResourceTypeIMaterial2> SpriteMaterial { get; }
  
  public CHandle<IBaseEntity> AttachedToEntity { get; }
  
  public IAttachmentHandle_t Attachment { get; }
  
  public ref float SpriteFramerate { get; }
  
  public ref float Frame { get; }
  
  public IGameTime_t DieTime { get; }
  
  public ref uint Brightness { get; }
  
  public ref float BrightnessDuration { get; }
  
  public ref float SpriteScale { get; }
  
  public ref float ScaleDuration { get; }
  
  public ref bool WorldSpaceScale { get; }
  
  public ref float GlowProxySize { get; }
  
  public ref float HDRColorScale { get; }
  
  public IGameTime_t LastTime { get; }
  
  public ref float MaxFrame { get; }
  
  public ref float StartScale { get; }
  
  public ref float DestScale { get; }
  
  public IGameTime_t ScaleTimeStart { get; }
  
  public ref int StartBrightness { get; }
  
  public ref int DestBrightness { get; }
  
  public IGameTime_t BrightnessTimeStart { get; }
  
  public ref int SpriteWidth { get; }
  
  public ref int SpriteHeight { get; }
  
}