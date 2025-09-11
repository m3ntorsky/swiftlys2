using SwiftlyS2.Shared.Schemas;

namespace SwiftlyS2.Core.SchemaDefinitions;

public partial interface INewParticleEffect : IIParticleEffect {

  
  public INewParticleEffect Next { get; }
  
  public INewParticleEffect Prev { get; }
  
  public IIParticleCollection Particles { get; }
  
  public ref CString DebugName { get; }
  
  public ISchemaUntypedField DontRemove { get; }
  
  public ISchemaUntypedField Remove { get; }
  
  public ISchemaUntypedField NeedsBBoxUpdate { get; }
  
  public ISchemaUntypedField IsFirstFrame { get; }
  
  public ISchemaUntypedField AutoUpdateBBox { get; }
  
  public ISchemaUntypedField Allocated { get; }
  
  public ISchemaUntypedField Simulate { get; }
  
  public ISchemaUntypedField ShouldPerformCullCheck { get; }
  
  public ISchemaUntypedField ForceNoDraw { get; }
  
  public ISchemaUntypedField SuppressScreenSpaceEffect { get; }
  
  public ISchemaUntypedField ShouldSave { get; }
  
  public ISchemaUntypedField ShouldSimulateDuringGamePaused { get; }
  
  public ISchemaUntypedField ShouldCheckFoW { get; }
  
  public ref Vector SortOrigin { get; }
  
  public ref float Scale { get; }
  
  public IPARTICLE_EHANDLE__ Owner { get; }
  
  public IParticleProperty OwningParticleProperty { get; }
  
  public ref float FreezeTransitionStart { get; }
  
  public ref float FreezeTransitionDuration { get; }
  
  public ref float FreezeTransitionOverride { get; }
  
  public ref bool FreezeTransitionActive { get; }
  
  public ref bool FreezeTargetState { get; }
  
  public ref bool CanFreeze { get; }
  
  public ref Vector LastMin { get; }
  
  public ref Vector LastMax { get; }
  
  public ref CSplitScreenSlot SplitScreenUser { get; }
  
  public ref Vector AggregationCenter { get; }
  
  public ref int RefCount { get; }
}