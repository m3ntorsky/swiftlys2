using SwiftlyS2.Shared.Schemas;

namespace SwiftlyS2.Core.SchemaDefinitions;

public partial interface IEffectData : ISchemaClass {

  
  public ref Vector Origin { get; }
  
  public ref Vector Start { get; }
  
  public ref Vector Normal { get; }
  
  public ref QAngle Angles { get; }
  
  public ref CEntityHandle Entity { get; }
  
  public ref CEntityHandle OtherEntity { get; }
  
  public ref float Scale { get; }
  
  public ref float Magnitude { get; }
  
  public ref float Radius { get; }
  
  public ref CUtlStringToken SurfaceProp { get; }
  
  public ref CWeakHandle<InfoForResourceTypeIParticleSystemDefinition> EffectIndex { get; }
  
  public ref uint DamageType { get; }
  
  public ref byte Penetrate { get; }
  
  public ref ushort Material { get; }
  
  public ref short HitBox { get; }
  
  public ref byte Color { get; }
  
  public ref byte Flags { get; }
  
  public IAttachmentHandle_t AttachmentIndex { get; }
  
  public ref CUtlStringToken AttachmentName { get; }
  
  public ref ushort EffectName { get; }
  
  public ref byte ExplosionType { get; }
}