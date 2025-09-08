using SwiftlyS2.Shared.Schemas;

namespace SwiftlyS2.Core.SchemaDefinitions;

public partial interface ISeqAutoLayerFlag : ISchemaClass {

  public ref bool Post { get; }
  
  public ref bool Spline { get; }
  
  public ref bool XFade { get; }
  
  public ref bool NoBlend { get; }
  
  public ref bool Local { get; }
  
  public ref bool Pose { get; }
  
  public ref bool FetchFrame { get; }
  
  public ref bool Subtract { get; }
  
}