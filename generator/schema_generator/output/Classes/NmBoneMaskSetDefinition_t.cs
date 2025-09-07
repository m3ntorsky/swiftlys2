using SwiftlyS2.Core.Schemas;
using SwiftlyS2.Shared.Schemas;
using SwiftlyS2.Core.Extensions;

namespace SwiftlyS2.Core.SchemaDefinitions;

internal partial class NmBoneMaskSetDefinition_t : SchemaClass, INmBoneMaskSetDefinition_t {

  public NmBoneMaskSetDefinition_t(nint handle) : base(handle) {
  }

  public NmBoneMaskSetDefinition_t(nint handle, ulong hash, bool isField, bool isNetworked) : base(handle, hash, isField, isNetworked) {
  }

  public ref CGlobalSymbol ID {
    get => ref _Handle.AsRef<CGlobalSymbol>(Schema.GetOffset(0xEA12116095066900));
  }
  public INmBoneWeightList PrimaryWeightList {
    get => new CNmBoneWeightList(_Handle + Schema.GetOffset(0xEA1211603AF7FF49));
  }
  public ref CUtlLeanVector< CNmBoneWeightList > SecondaryWeightLists {
    get => ref _Handle.AsRef<CUtlLeanVector< CNmBoneWeightList >>(Schema.GetOffset(0xEA12116021DB2776));
  }


}