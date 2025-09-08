using SwiftlyS2.Shared.Schemas;

namespace SwiftlyS2.Core.SchemaDefinitions;

public partial interface ITestPulseIO : ILogicalEntity {

  public IEntityIOOutput OnVariantVoid { get; }
  
  public IEntityIOOutput OnVariantBool { get; }
  
  public IEntityIOOutput OnVariantInt { get; }
  
  public IEntityIOOutput OnVariantFloat { get; }
  
  public IEntityIOOutput OnVariantString { get; }
  
  public IEntityIOOutput OnVariantColor { get; }
  
  public IEntityIOOutput OnVariantVector { get; }
  
  public ref bool AllowEmptyInputs { get; }
  
}