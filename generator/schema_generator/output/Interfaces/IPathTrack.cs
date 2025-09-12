using SwiftlyS2.Shared.Schemas;

namespace SwiftlyS2.Core.SchemaDefinitions;

public partial interface IPathTrack : IPointEntity {

  
  public IPathTrack Pnext { get; }
  
  public IPathTrack Pprevious { get; }
  
  public IPathTrack Paltpath { get; }
  
  public ref float Radius { get; }
  
  public ref float Length { get; }
  
  public ISchemaUntypedField AltName { get; }
  
  public ref int IterVal { get; }
  
  public ref TrackOrientationType_t OrientationType { get; }
  
  public IEntityIOOutput OnPass { get; }
}