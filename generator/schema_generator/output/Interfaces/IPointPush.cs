using SwiftlyS2.Shared.Schemas;

namespace SwiftlyS2.Core.SchemaDefinitions;

public partial interface IPointPush : IPointEntity {

  
  public ref bool Enabled { get; }
  
  public ref float Magnitude { get; }
  
  public ref float Radius { get; }
  
  public ref float InnerRadius { get; }
  
  public ref float ConeOfInfluence { get; }
  
  public ISchemaUntypedField FilterName { get; }
  
  public ref CHandle<CBaseFilter> Filter { get; }
}