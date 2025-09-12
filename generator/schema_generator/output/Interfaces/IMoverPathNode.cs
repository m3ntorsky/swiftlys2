using SwiftlyS2.Shared.Schemas;

namespace SwiftlyS2.Core.SchemaDefinitions;

public partial interface IMoverPathNode : IPointEntity {

  
  public ref Vector InTangentLocal { get; }
  
  public ref Vector OutTangentLocal { get; }
  
  public ISchemaUntypedField ParentPathUniqueID { get; }
  
  public ISchemaUntypedField PathNodeParameter { get; }
  
  public IEntityIOOutput OnStartFromOrInSegment { get; }
  
  public IEntityIOOutput OnStoppedAtOrInSegment { get; }
  
  public IEntityIOOutput OnPassThrough { get; }
  
  public IEntityIOOutput OnPassThroughForward { get; }
  
  public IEntityIOOutput OnPassThroughReverse { get; }
  
  public ref CHandle<CPathMover> Mover { get; }
  
  public ref CTransform XWSPrevParent { get; }
}