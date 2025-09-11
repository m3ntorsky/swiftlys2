using SwiftlyS2.Shared.Schemas;

namespace SwiftlyS2.Core.SchemaDefinitions;

public partial interface IBaseClientUIEntity : IBaseModelEntity {

  
  public ref bool Enabled { get; }
  
  public ref CUtlSymbolLarge DialogXMLName { get; }
  
  public ref CUtlSymbolLarge PanelClassName { get; }
  
  public ref CUtlSymbolLarge PanelID { get; }
  
  public IEntityIOOutput CustomOutput0 { get; }
  
  public IEntityIOOutput CustomOutput1 { get; }
  
  public IEntityIOOutput CustomOutput2 { get; }
  
  public IEntityIOOutput CustomOutput3 { get; }
  
  public IEntityIOOutput CustomOutput4 { get; }
  
  public IEntityIOOutput CustomOutput5 { get; }
  
  public IEntityIOOutput CustomOutput6 { get; }
  
  public IEntityIOOutput CustomOutput7 { get; }
  
  public IEntityIOOutput CustomOutput8 { get; }
  
  public IEntityIOOutput CustomOutput9 { get; }
}