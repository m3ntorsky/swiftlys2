using SwiftlyS2.Shared.Schemas;

namespace SwiftlyS2.Core.SchemaDefinitions;

public partial interface IMomentaryRotButton : IRotButton {

  
  public ISchemaUntypedField Position { get; }
  
  public IEntityIOOutput OnUnpressed { get; }
  
  public IEntityIOOutput OnFullyOpen { get; }
  
  public IEntityIOOutput OnFullyClosed { get; }
  
  public IEntityIOOutput OnReachedPosition { get; }
  
  public ref int LastUsed { get; }
  
  public ref QAngle Start { get; }
  
  public ref QAngle End { get; }
  
  public ref float IdealYaw { get; }
  
  public ref CUtlSymbolLarge Noise { get; }
  
  public ref bool UpdateTarget { get; }
  
  public ref int Direction { get; }
  
  public ref float ReturnSpeed { get; }
  
  public ref float StartPosition { get; }
}