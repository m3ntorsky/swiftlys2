using SwiftlyS2.Shared.Schemas;

namespace SwiftlyS2.Core.SchemaDefinitions;

public partial interface IPulse_RegisterInfo : ISchemaClass {

  
  public IPulseRuntimeRegisterIndex_t Reg { get; }
  
  public ISchemaUntypedField Type { get; }
  
  public ISchemaUntypedField OriginName { get; }
  
  public ref int WrittenByInstruction { get; }
  
  public ref int LastReadByInstruction { get; }
}