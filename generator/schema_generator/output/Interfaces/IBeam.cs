using SwiftlyS2.Shared.Schemas;

namespace SwiftlyS2.Core.SchemaDefinitions;

public partial interface IBeam : IBaseModelEntity {

  public ref float FrameRate { get; }
  
  public ref float HDRColorScale { get; }
  
  public IGameTime_t FireTime { get; }
  
  public ref float Damage { get; }
  
  public ref byte NumBeamEnts { get; }
  
  public CStrongHandle<IInfoForResourceTypeIMaterial2> BaseMaterial { get; }
  
  public CStrongHandle<IInfoForResourceTypeIMaterial2> HaloIndex { get; }
  
  public ref BeamType_t BeamType { get; }
  
  public ref uint BeamFlags { get; }
  
  public CHandle<IBaseEntity> AttachEntity { get; }
  
  public IAttachmentHandle_t AttachIndex { get; }
  
  public ref float Width { get; }
  
  public ref float EndWidth { get; }
  
  public ref float FadeLength { get; }
  
  public ref float HaloScale { get; }
  
  public ref float Amplitude { get; }
  
  public ref float StartFrame { get; }
  
  public ref float Speed { get; }
  
  public ref float Frame { get; }
  
  public ref BeamClipStyle_t ClipStyle { get; }
  
  public ref bool TurnedOff { get; }
  
  public ref Vector EndPos { get; }
  
  public CHandle<IBaseEntity> EndEntity { get; }
  
  public ref int DissolveType { get; }
  
}