using SwiftlyS2.Shared.Schemas;

namespace SwiftlyS2.Core.SchemaDefinitions;

public partial interface IEntityDissolve : IBaseModelEntity {

  public ref float FadeInStart { get; }
  
  public ref float FadeInLength { get; }
  
  public ref float FadeOutModelStart { get; }
  
  public ref float FadeOutModelLength { get; }
  
  public ref float FadeOutStart { get; }
  
  public ref float FadeOutLength { get; }
  
  public IGameTime_t StartTime { get; }
  
  public ref EntityDisolveType_t DissolveType { get; }
  
  public ref Vector DissolverOrigin { get; }
  
  public ref uint Magnitude { get; }
  
}