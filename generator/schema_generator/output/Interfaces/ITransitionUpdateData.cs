using SwiftlyS2.Shared.Schemas;

namespace SwiftlyS2.Core.SchemaDefinitions;

public partial interface ITransitionUpdateData : ISchemaClass {

  public ref byte SrcStateIndex { get; }
  
  public ref byte DestStateIndex { get; }
  
  public ISchemaUntypedField HandshakeMaskToDisableFirst { get; }
  
  public ISchemaUntypedField Disabled { get; }
  
}