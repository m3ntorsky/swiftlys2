using SwiftlyS2.Shared.Schemas;

namespace SwiftlyS2.Core.SchemaDefinitions;

public partial interface IPathParameters : ISchemaClass {

  
  public ref int StartControlPointNumber { get; }
  
  public ref int EndControlPointNumber { get; }
  
  public ref int BulgeControl { get; }
  
  public ref float Bulge { get; }
  
  public ref float MidPoint { get; }
  
  public ref Vector StartPointOffset { get; }
  
  public ref Vector MidPointOffset { get; }
  
  public ref Vector EndOffset { get; }
}