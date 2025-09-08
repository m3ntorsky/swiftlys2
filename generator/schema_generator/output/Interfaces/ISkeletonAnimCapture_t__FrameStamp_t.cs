using SwiftlyS2.Shared.Schemas;

namespace SwiftlyS2.Core.SchemaDefinitions;

public partial interface ISkeletonAnimCapture_t__FrameStamp_t : ISchemaClass {

  public ref float Time { get; }
  
  public ref float EntitySimTime { get; }
  
  public ref bool TeleportTick { get; }
  
  public ref bool Predicted { get; }
  
  public ref float CurTime { get; }
  
  public ref float RealTime { get; }
  
  public ref int FrameCount { get; }
  
  public ref int TickCount { get; }
  
}