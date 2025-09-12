using SwiftlyS2.Core.Schemas;
using SwiftlyS2.Shared.Schemas;
using SwiftlyS2.Core.Extensions;

namespace SwiftlyS2.Core.SchemaDefinitions;

internal partial class NmBoneMaskSetDefinition_t : SchemaClass, INmBoneMaskSetDefinition_t {

  public NmBoneMaskSetDefinition_t(nint handle) : base(handle) {
  }

  public ref CGlobalSymbol ID {
    get => ref _Handle.AsRef<CGlobalSymbol>(Schema.GetOffset(0xEA12116095066900));
  }
  public INmBoneWeightList PrimaryWeightList {
    get => new CNmBoneWeightList(_Handle + Schema.GetOffset(0xEA1211603AF7FF49));
  }
  public ISchemaUntypedField SecondaryWeightLists {
    get => new SchemaUntypedField(_Handle + Schema.GetOffset(0xEA12116021DB2776));
  }


}