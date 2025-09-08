using SwiftlyS2.Shared.Schemas;

namespace SwiftlyS2.Core.SchemaDefinitions;

public partial interface IAmmoTypeInfo_t : ISchemaClass {

  public ref int MaxCarry { get; }
  
  public IRangeInt SplashSize { get; }
  
  public ref AmmoFlags_t Flags { get; }
  
  public ref float Mass { get; }
  
  public IRangeFloat Speed { get; }
  
}