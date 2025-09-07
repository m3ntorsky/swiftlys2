using SwiftlyS2.Core.Schemas;
using SwiftlyS2.Shared.Schemas;
using SwiftlyS2.Core.Extensions;

namespace SwiftlyS2.Core.SchemaDefinitions;

internal partial class CDspPresetModifierList : SchemaClass, IDspPresetModifierList {

  public CDspPresetModifierList(nint handle) : base(handle) {
  }

  public CDspPresetModifierList(nint handle, ulong hash, bool isField, bool isNetworked) : base(handle, hash, isField, isNetworked) {
  }

  public ref CUtlString DspName {
    get => ref _Handle.AsRef<CUtlString>(Schema.GetOffset(0x68EE16FD7E9A0D3));
  }
  public ref CUtlVector< CDSPMixgroupModifier > Modifiers {
    get => ref _Handle.AsRef<CUtlVector< CDSPMixgroupModifier >>(Schema.GetOffset(0x68EE16F541F1439));
  }


}