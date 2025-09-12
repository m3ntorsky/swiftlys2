using SwiftlyS2.Core.Schemas;
using SwiftlyS2.Shared.Schemas;
using SwiftlyS2.Core.Extensions;

namespace SwiftlyS2.Core.SchemaDefinitions;

internal partial class CLogicDistanceCheck : CLogicalEntity, ILogicDistanceCheck {

  public CLogicDistanceCheck(nint handle) : base(handle) {
  }

  public ISchemaUntypedField EntityA {
    get => new SchemaUntypedField(_Handle + Schema.GetOffset(0x523E7E6D07823CB9));
  }
  public ISchemaUntypedField EntityB {
    get => new SchemaUntypedField(_Handle + Schema.GetOffset(0x523E7E6D04823800));
  }
  public ref float Zone1Distance {
    get => ref _Handle.AsRef<float>(Schema.GetOffset(0x523E7E6DFF385A8F));
  }
  public ref float Zone2Distance {
    get => ref _Handle.AsRef<float>(Schema.GetOffset(0x523E7E6DE1734A1A));
  }
  public IEntityIOOutput InZone1 {
    get => new CEntityIOOutput(_Handle + Schema.GetOffset(0x523E7E6D25378DB3));
  }
  public IEntityIOOutput InZone2 {
    get => new CEntityIOOutput(_Handle + Schema.GetOffset(0x523E7E6D26378F46));
  }
  public IEntityIOOutput InZone3 {
    get => new CEntityIOOutput(_Handle + Schema.GetOffset(0x523E7E6D273790D9));
  }


}