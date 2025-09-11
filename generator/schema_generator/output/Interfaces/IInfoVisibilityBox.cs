using SwiftlyS2.Shared.Schemas;

namespace SwiftlyS2.Core.SchemaDefinitions;

public partial interface IInfoVisibilityBox : IBaseEntity {

  
  public ref int Mode { get; }
  
  public ref Vector BoxSize { get; }
  
  public ref bool Enabled { get; }
}