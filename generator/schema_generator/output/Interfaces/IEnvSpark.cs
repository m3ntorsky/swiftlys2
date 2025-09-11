using SwiftlyS2.Shared.Schemas;

namespace SwiftlyS2.Core.SchemaDefinitions;

public partial interface IEnvSpark : IPointEntity {

  
  public ref float Delay { get; }
  
  public ref int Magnitude { get; }
  
  public ref int TrailLength { get; }
  
  public ref int Type { get; }
  
  public IEntityIOOutput OnSpark { get; }
}