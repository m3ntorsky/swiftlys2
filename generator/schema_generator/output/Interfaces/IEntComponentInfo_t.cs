using SwiftlyS2.Shared.Schemas;

namespace SwiftlyS2.Core.SchemaDefinitions;

public partial interface IEntComponentInfo_t : ISchemaClass {

  
  public ref CString Name { get; }
  
  public ref CString CPPClassname { get; }
  
  public ref CString NetworkDataReferencedDescription { get; }
  
  public ref CString NetworkDataReferencedPtrPropDescription { get; }
  
  public ref int RuntimeIndex { get; }
  
  public ref uint Flags { get; }
  
  public IEntityComponentHelper BaseClassComponentHelper { get; }
}