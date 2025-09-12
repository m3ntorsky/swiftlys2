using SwiftlyS2.Shared.Schemas;

namespace SwiftlyS2.Core.SchemaDefinitions;

public partial interface INavLinkAreaEntity : IPointEntity {

  
  public ref float Width { get; }
  
  public ref Vector LocatorOffset { get; }
  
  public ref QAngle LocatorAnglesOffset { get; }
  
  public ISchemaUntypedField StrMovementForward { get; }
  
  public ISchemaUntypedField StrMovementReverse { get; }
  
  public ref bool Enabled { get; }
  
  public ref bool AllowCrossMovableConnections { get; }
  
  public ISchemaUntypedField StrFilterName { get; }
  
  public ref CHandle<CBaseFilter> Filter { get; }
  
  public IEntityIOOutput OnNavLinkStart { get; }
  
  public IEntityIOOutput OnNavLinkFinish { get; }
  
  public ref bool IsTerminus { get; }
  
  public ref int Splits { get; }
}