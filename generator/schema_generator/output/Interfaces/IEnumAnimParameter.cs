using SwiftlyS2.Shared.Schemas;

namespace SwiftlyS2.Core.SchemaDefinitions;

public partial interface IEnumAnimParameter : IConcreteAnimParameter {

  
  public ref byte DefaultValue { get; }
  
  public ref CUtlVector<CUtlString> EnumOptions { get; }
  
  public ref CUtlVector<ulong> EnumReferenced { get; }
}