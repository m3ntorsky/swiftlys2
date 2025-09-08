using SwiftlyS2.Shared.Schemas;

namespace SwiftlyS2.Core.SchemaDefinitions;

public partial interface IVMixEnvelopeDesc_t : ISchemaClass {

  public ref float AttackTimeMS { get; }
  
  public ref float HoldTimeMS { get; }
  
  public ref float ReleaseTimeMS { get; }
  
}