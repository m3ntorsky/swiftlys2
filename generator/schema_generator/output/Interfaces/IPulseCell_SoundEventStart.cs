using SwiftlyS2.Shared.Schemas;

namespace SwiftlyS2.Core.SchemaDefinitions;

public partial interface IPulseCell_SoundEventStart : IPulseCell_BaseFlow {

  
  public ref SoundEventStartType_t Type { get; }
}