using SwiftlyS2.Shared.Schemas;

namespace SwiftlyS2.Core.SchemaDefinitions;

public partial interface IDSPMixgroupModifier : ISchemaClass {

  public ref CUtlString Mixgroup { get; }
  
  public ref float Modifier { get; }
  
  public ref float ModifierMin { get; }
  
  public ref float SourceModifier { get; }
  
  public ref float SourceModifierMin { get; }
  
  public ref float ListenerReverbModifierWhenSourceReverbIsActive { get; }
  
}