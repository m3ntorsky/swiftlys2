using SwiftlyS2.Shared.Schemas;

namespace SwiftlyS2.Core.SchemaDefinitions;

public partial interface IInfoProjectedDecal : IPointEntity {

  public ref CStrongHandle<InfoForResourceTypeIMaterial2> Material { get; }
  
  public ref CUtlStringToken SequenceName { get; }
  
  public ref float Distance { get; }
  
  public ref bool NotInMultiplayer { get; }
  
}