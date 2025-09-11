using SwiftlyS2.Shared.Schemas;

namespace SwiftlyS2.Core.SchemaDefinitions;

public partial interface IEconItemView : IIEconItemInterface {

  
  public ref ushort ItemDefinitionIndex { get; }
  
  public ref int EntityQuality { get; }
  
  public ref uint EntityLevel { get; }
  
  public ref ulong ItemID { get; }
  
  public ref uint ItemIDHigh { get; }
  
  public ref uint ItemIDLow { get; }
  
  public ref uint AccountID { get; }
  
  public ref uint InventoryPosition { get; }
  
  public ref bool Initialized { get; }
  
  public IAttributeList AttributeList { get; }
  
  public IAttributeList NetworkedDynamicAttributes { get; }
  
  public ISchemaFixedString CustomName { get; }
  
  public ISchemaFixedString CustomNameOverride { get; }
}