using SwiftlyS2.Shared.Schemas;

namespace SwiftlyS2.Core.SchemaDefinitions;

public partial interface IMaterialAttributeAnimTag : IAnimTagBase {

  
  public ref CUtlString AttributeName { get; }
  
  public ref MatterialAttributeTagType_t AttributeType { get; }
  
  public ref float Value { get; }
  
  public ref Color Color { get; }
}