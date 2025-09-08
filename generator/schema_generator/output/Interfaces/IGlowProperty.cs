using SwiftlyS2.Shared.Schemas;

namespace SwiftlyS2.Core.SchemaDefinitions;

public partial interface IGlowProperty : ISchemaClass {

  public ref Vector GlowColor { get; }
  
  public ref int GlowType { get; }
  
  public ref int GlowTeam { get; }
  
  public ref int GlowRange { get; }
  
  public ref int GlowRangeMin { get; }
  
  public ref Color GlowColorOverride { get; }
  
  public ref bool Flashing { get; }
  
  public ref float GlowTime { get; }
  
  public ref float GlowStartTime { get; }
  
  public ref bool EligibleForScreenHighlight { get; }
  
  public ref bool Glowing { get; }
  
}