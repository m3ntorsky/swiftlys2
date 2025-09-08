using SwiftlyS2.Shared.Schemas;

namespace SwiftlyS2.Core.SchemaDefinitions;

public partial interface INmGraphDefinition : ISchemaClass {

  public ref CGlobalSymbol VariationID { get; }
  
  public ref CStrongHandle<InfoForResourceTypeCNmSkeleton> Skeleton { get; }
  
  public ref CUtlVector<short> PersistentNodeIndices { get; }
  
  public ref short RootNodeIdx { get; }
  
  public ref CUtlVector<CGlobalSymbol> ControlParameterIDs { get; }
  
  public ref CUtlVector<CGlobalSymbol> VirtualParameterIDs { get; }
  
  public ref CUtlVector<short> VirtualParameterNodeIndices { get; }
  
  public ref CUtlVector ReferencedGraphSlots { get; }
  
  public ref CUtlVector ExternalGraphSlots { get; }
  
  public ref CUtlVector<CUtlString> NodePaths { get; }
  
  public ref CUtlVector<CStrongHandle<oi>> Resources { get; }
  
}