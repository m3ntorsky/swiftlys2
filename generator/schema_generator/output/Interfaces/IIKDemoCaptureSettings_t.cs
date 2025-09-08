using SwiftlyS2.Shared.Schemas;

namespace SwiftlyS2.Core.SchemaDefinitions;

public partial interface IIKDemoCaptureSettings_t : ISchemaClass {

  public ref CUtlString ParentBoneName { get; }
  
  public ref IKChannelMode Mode { get; }
  
  public ref CUtlString IkChainName { get; }
  
  public ref CUtlString OneBoneStart { get; }
  
  public ref CUtlString OneBoneEnd { get; }
  
}