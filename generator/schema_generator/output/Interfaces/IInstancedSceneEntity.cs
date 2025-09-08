using SwiftlyS2.Shared.Schemas;

namespace SwiftlyS2.Core.SchemaDefinitions;

public partial interface IInstancedSceneEntity : ISceneEntity {

  public ref CHandle<CBaseEntity> Owner { get; }
  
  public ref bool HadOwner { get; }
  
  public ref float PostSpeakDelay { get; }
  
  public ref float PreDelay { get; }
  
  public ref bool IsBackground { get; }
  
  public ref bool RemoveOnCompletion { get; }
  
  public ref CHandle<CBaseEntity> Target { get; }
  
}