using SwiftlyS2.Shared.Schemas;

namespace SwiftlyS2.Core.SchemaDefinitions;

public partial interface IMessageEntity : IPointEntity {

  
  public ref int Radius { get; }
  
  public ISchemaUntypedField MessageText { get; }
  
  public ref bool DrawText { get; }
  
  public ref bool DeveloperOnly { get; }
  
  public ref bool Enabled { get; }
}