using SwiftlyS2.Core.Schemas;
using SwiftlyS2.Shared.Schemas;
using SwiftlyS2.Core.Extensions;

namespace SwiftlyS2.Core.SchemaDefinitions;

internal partial class PermModelDataAnimatedMaterialAttribute_t : SchemaClass, IPermModelDataAnimatedMaterialAttribute_t {

  public PermModelDataAnimatedMaterialAttribute_t(nint handle) : base(handle) {
  }

  public PermModelDataAnimatedMaterialAttribute_t(nint handle, ulong hash, bool isField, bool isNetworked) : base(handle, hash, isField, isNetworked) {
  }

  public ref CUtlString AttributeName {
    get => ref _Handle.AsRef<CUtlString>(Schema.GetOffset(0x6489C15F1408864C));
  }
  public ref int NumChannels {
    get => ref _Handle.AsRef<int>(Schema.GetOffset(0x6489C15FEA44FE77));
  }


}