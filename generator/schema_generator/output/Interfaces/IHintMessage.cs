using SwiftlyS2.Shared.Schemas;

namespace SwiftlyS2.Core.SchemaDefinitions;

public partial interface IHintMessage : ISchemaClass {

  public ref CString HintString { get; }
  
  public ref CUtlVector<PointerTo<CString>> Args { get; }
  
  public ref float Duration { get; }
  
}