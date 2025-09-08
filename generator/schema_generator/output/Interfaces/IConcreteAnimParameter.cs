using SwiftlyS2.Shared.Schemas;

namespace SwiftlyS2.Core.SchemaDefinitions;

public partial interface IConcreteAnimParameter : IAnimParameterBase {

  public ref AnimParamButton_t PreviewButton { get; }
  
  public ref AnimParamNetworkSetting NetworkSetting { get; }
  
  public ref bool UseMostRecentValue { get; }
  
  public ref bool AutoReset { get; }
  
  public ref bool GameWritable { get; }
  
  public ref bool GraphWritable { get; }
  
}