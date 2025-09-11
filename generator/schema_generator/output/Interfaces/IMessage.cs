using SwiftlyS2.Shared.Schemas;

namespace SwiftlyS2.Core.SchemaDefinitions;

public partial interface IMessage : IPointEntity {

  
  public ref CUtlSymbolLarge Message { get; }
  
  public ref float MessageVolume { get; }
  
  public ref int MessageAttenuation { get; }
  
  public ref float Radius { get; }
  
  public ref CUtlSymbolLarge Noise { get; }
  
  public IEntityIOOutput OnShowMessage { get; }
}