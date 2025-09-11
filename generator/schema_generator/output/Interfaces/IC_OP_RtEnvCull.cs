using SwiftlyS2.Shared.Schemas;

namespace SwiftlyS2.Core.SchemaDefinitions;

public partial interface IC_OP_RtEnvCull : IParticleFunctionOperator {

  
  public ref Vector TestDir { get; }
  
  public ref Vector TestNormal { get; }
  
  public ref bool CullOnMiss { get; }
  
  public ref bool StickInsteadOfCull { get; }
  
  public ISchemaFixedString RtEnvName { get; }
  
  public ref int RTEnvCP { get; }
  
  public ref int Component { get; }
}