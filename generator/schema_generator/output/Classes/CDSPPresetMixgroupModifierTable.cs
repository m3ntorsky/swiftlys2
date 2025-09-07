using SwiftlyS2.Core.Schemas;
using SwiftlyS2.Shared.Schemas;
using SwiftlyS2.Core.Extensions;

namespace SwiftlyS2.Core.SchemaDefinitions;

internal partial class CDSPPresetMixgroupModifierTable : SchemaClass, IDSPPresetMixgroupModifierTable {

  public CDSPPresetMixgroupModifierTable(nint handle) : base(handle) {
  }

  public CDSPPresetMixgroupModifierTable(nint handle, ulong hash, bool isField, bool isNetworked) : base(handle, hash, isField, isNetworked) {
  }

  public ref CUtlVector< CDspPresetModifierList > Table {
    get => ref _Handle.AsRef<CUtlVector< CDspPresetModifierList >>(Schema.GetOffset(0xB4266D22715EA0FF));
  }


}