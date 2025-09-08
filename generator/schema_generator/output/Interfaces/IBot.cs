using SwiftlyS2.Shared.Schemas;

namespace SwiftlyS2.Core.SchemaDefinitions;

public partial interface IBot : ISchemaClass {

  public ICSPlayerController Controller { get; }
  
  public ICSPlayerPawn Player { get; }
  
  public ref bool HasSpawned { get; }
  
  public ref uint Id { get; }
  
  public ref bool IsRunning { get; }
  
  public ref bool IsCrouching { get; }
  
  public ref float ForwardSpeed { get; }
  
  public ref float LeftSpeed { get; }
  
  public ref float VerticalSpeed { get; }
  
  public ref ulong ButtonFlags { get; }
  
  public ref float JumpTimestamp { get; }
  
  public ref Vector ViewForward { get; }
  
  public ref int PostureStackIndex { get; }
  
}