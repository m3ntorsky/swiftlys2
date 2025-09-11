using SwiftlyS2.Shared.Schemas;

namespace SwiftlyS2.Core.SchemaDefinitions;

public partial interface IDecalInstance : ISchemaClass {

  
  public ref CGlobalSymbol DecalGroup { get; }
  
  public ref CStrongHandle<InfoForResourceTypeIMaterial2> Material { get; }
  
  public ref CUtlStringToken SequenceName { get; }
  
  public ref CHandle<CBaseEntity> Entity { get; }
  
  public ref int BoneIndex { get; }
  
  public ref Vector PositionLS { get; }
  
  public ref Vector NormalLS { get; }
  
  public ref Vector SAxisLS { get; }
  
  public ref DecalFlags_t Flags { get; }
  
  public ref Color Color { get; }
  
  public ref float Width { get; }
  
  public ref float Height { get; }
  
  public ref float Depth { get; }
  
  public ref float AnimationScale { get; }
  
  public IGameTime_t PlaceTime { get; }
  
  public ref float FadeStartTime { get; }
  
  public ref float FadeDuration { get; }
  
  public ref float LightingOriginOffset { get; }
  
  public ref int VBSlot { get; }
  
  public ref float BoundingRadiusSqr { get; }
  
  public ref short SequenceIndex { get; }
  
  public ref bool IsAdjacent { get; }
  
  public ref bool DoDecalLightmapping { get; }
  
  public IDecalInstance Next { get; }
  
  public IDecalInstance Prev { get; }
}