using SwiftlyS2.Shared.Schemas;

namespace SwiftlyS2.Core.SchemaDefinitions;

public partial interface IC_OP_RenderCables : IParticleFunctionRenderer {

  
  public IParticleCollectionFloatInput RadiusScale { get; }
  
  public IParticleCollectionFloatInput AlphaScale { get; }
  
  public IParticleCollectionVecInput ColorScale { get; }
  
  public ref ParticleColorBlendType_t ColorBlendType { get; }
  
  public ref CStrongHandle<InfoForResourceTypeIMaterial2> Material { get; }
  
  public ref TextureRepetitionMode_t TextureRepetitionMode { get; }
  
  public IParticleCollectionFloatInput TextureRepeatsPerSegment { get; }
  
  public IParticleCollectionFloatInput TextureRepeatsCircumference { get; }
  
  public IParticleCollectionFloatInput ColorMapOffsetV { get; }
  
  public IParticleCollectionFloatInput ColorMapOffsetU { get; }
  
  public IParticleCollectionFloatInput NormalMapOffsetV { get; }
  
  public IParticleCollectionFloatInput NormalMapOffsetU { get; }
  
  public ref bool DrawCableCaps { get; }
  
  public ref float CapRoundness { get; }
  
  public ref float CapOffsetAmount { get; }
  
  public ref float TessScale { get; }
  
  public ref int MinTesselation { get; }
  
  public ref int MaxTesselation { get; }
  
  public ref int Roundness { get; }
  
  public IParticleTransformInput LightingTransform { get; }
  
  public ISchemaUntypedField MaterialFloatVars { get; }
  
  public ISchemaUntypedField MaterialVecVars { get; }
}