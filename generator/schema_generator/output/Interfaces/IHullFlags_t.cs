using SwiftlyS2.Shared.Schemas;

namespace SwiftlyS2.Core.SchemaDefinitions;

public partial interface IHullFlags_t : ISchemaClass {

  public ref bool Hull_Human { get; }
  
  public ref bool Hull_SmallCentered { get; }
  
  public ref bool Hull_WideHuman { get; }
  
  public ref bool Hull_Tiny { get; }
  
  public ref bool Hull_Medium { get; }
  
  public ref bool Hull_TinyCentered { get; }
  
  public ref bool Hull_Large { get; }
  
  public ref bool Hull_LargeCentered { get; }
  
  public ref bool Hull_MediumTall { get; }
  
  public ref bool Hull_Small { get; }
  
}