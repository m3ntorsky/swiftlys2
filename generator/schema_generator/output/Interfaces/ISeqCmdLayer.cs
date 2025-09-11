using SwiftlyS2.Shared.Schemas;

namespace SwiftlyS2.Core.SchemaDefinitions;

public partial interface ISeqCmdLayer : ISchemaClass {

  
  public ref short Cmd { get; }
  
  public ref short LocalReference { get; }
  
  public ref short LocalBonemask { get; }
  
  public ref short DstResult { get; }
  
  public ref short SrcResult { get; }
  
  public ref bool Spline { get; }
  
  public ref float Var1 { get; }
  
  public ref float Var2 { get; }
  
  public ref short LineNumber { get; }
}