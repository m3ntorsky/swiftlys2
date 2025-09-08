using SwiftlyS2.Shared.Schemas;

namespace SwiftlyS2.Core.SchemaDefinitions;

public partial interface IEconWearable : IEconEntity {

  public ref int ForceSkin { get; }
  
  public ref bool AlwaysAllow { get; }
  
}