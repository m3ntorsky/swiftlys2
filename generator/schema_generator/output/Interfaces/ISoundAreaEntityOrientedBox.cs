using SwiftlyS2.Shared.Schemas;

namespace SwiftlyS2.Core.SchemaDefinitions;

public partial interface ISoundAreaEntityOrientedBox : ISoundAreaEntityBase {

  
  public ref Vector Min { get; }
  
  public ref Vector Max { get; }
}