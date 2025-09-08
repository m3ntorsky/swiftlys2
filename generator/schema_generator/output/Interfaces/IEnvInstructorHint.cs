using SwiftlyS2.Shared.Schemas;

namespace SwiftlyS2.Core.SchemaDefinitions;

public partial interface IEnvInstructorHint : IPointEntity {

  public ref CUtlSymbolLarge Name { get; }
  
  public ref CUtlSymbolLarge Replace_Key { get; }
  
  public ref CUtlSymbolLarge HintTargetEntity { get; }
  
  public ref int Timeout { get; }
  
  public ref int DisplayLimit { get; }
  
  public ref CUtlSymbolLarge Icon_Onscreen { get; }
  
  public ref CUtlSymbolLarge Icon_Offscreen { get; }
  
  public ref CUtlSymbolLarge Caption { get; }
  
  public ref CUtlSymbolLarge ActivatorCaption { get; }
  
  public ref Color Color { get; }
  
  public ref float IconOffset { get; }
  
  public ref float Range { get; }
  
  public ref byte PulseOption { get; }
  
  public ref byte AlphaOption { get; }
  
  public ref byte ShakeOption { get; }
  
  public ref bool Static { get; }
  
  public ref bool NoOffscreen { get; }
  
  public ref bool ForceCaption { get; }
  
  public ref int InstanceType { get; }
  
  public ref bool SuppressRest { get; }
  
  public ref CUtlSymbolLarge Binding { get; }
  
  public ref bool AllowNoDrawTarget { get; }
  
  public ref bool AutoStart { get; }
  
  public ref bool LocalPlayerOnly { get; }
  
}