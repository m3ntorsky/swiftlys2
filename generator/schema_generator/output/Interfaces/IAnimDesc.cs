using SwiftlyS2.Shared.Schemas;

namespace SwiftlyS2.Core.SchemaDefinitions;

public partial interface IAnimDesc : ISchemaClass {

  public ref CBufferString Name { get; }
  
  public IAnimDesc_Flag Flags { get; }
  
  public ref float Fps { get; }
  
  public IAnimEncodedFrames Data { get; }
  
  public ref CUtlVector MovementArray { get; }
  
  public ref CTransform XInitialOffset { get; }
  
  public ref CUtlVector EventArray { get; }
  
  public ref CUtlVector ActivityArray { get; }
  
  public ref CUtlVector HierarchyArray { get; }
  
  public ref float Framestalltime { get; }
  
  public ref Vector RootMin { get; }
  
  public ref Vector RootMax { get; }
  
  public ref CUtlVector<Vector> BoneWorldMin { get; }
  
  public ref CUtlVector<Vector> BoneWorldMax { get; }
  
  public IAnimSequenceParams SequenceParams { get; }
  
}