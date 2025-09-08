using SwiftlyS2.Shared.Schemas;

namespace SwiftlyS2.Core.SchemaDefinitions;

public partial interface IDynamicVolumeDef_t : ISchemaClass {

  public CHandle<IBaseEntity> Source { get; }
  
  public CHandle<IBaseEntity> Target { get; }
  
  public ref int HullIdx { get; }
  
  public ref Vector SourceAnchorPos { get; }
  
  public ref Vector TargetAnchorPos { get; }
  
  public ref uint AreaSrc { get; }
  
  public ref uint AreaDst { get; }
  
  public ref bool Attached { get; }
  
}