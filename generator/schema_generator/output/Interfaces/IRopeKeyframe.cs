using SwiftlyS2.Shared.Schemas;

namespace SwiftlyS2.Core.SchemaDefinitions;

public partial interface IRopeKeyframe : IBaseModelEntity {

  public ref ushort RopeFlags { get; }
  
  public ref CUtlSymbolLarge NextLinkName { get; }
  
  public ref short Slack { get; }
  
  public ref float Width { get; }
  
  public ref float TextureScale { get; }
  
  public ref byte Segments { get; }
  
  public ref bool ConstrainBetweenEndpoints { get; }
  
  public ref CUtlSymbolLarge StrRopeMaterialModel { get; }
  
  public CStrongHandle<IInfoForResourceTypeIMaterial2> RopeMaterialModelIndex { get; }
  
  public ref byte Subdiv { get; }
  
  public ref byte ChangeCount { get; }
  
  public ref short RopeLength { get; }
  
  public ref byte LockedPoints { get; }
  
  public ref bool CreatedFromMapFile { get; }
  
  public ref float ScrollSpeed { get; }
  
  public ref bool StartPointValid { get; }
  
  public ref bool EndPointValid { get; }
  
  public CHandle<IBaseEntity> StartPoint { get; }
  
  public CHandle<IBaseEntity> EndPoint { get; }
  
  public IAttachmentHandle_t StartAttachment { get; }
  
  public IAttachmentHandle_t EndAttachment { get; }
  
}