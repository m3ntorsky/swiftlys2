using SwiftlyS2.Core.Schemas;
using SwiftlyS2.Shared.Schemas;
using SwiftlyS2.Core.Extensions;

namespace SwiftlyS2.Core.SchemaDefinitions;

internal partial class ModelBoneFlexDriver_t : SchemaClass, IModelBoneFlexDriver_t {

  public ModelBoneFlexDriver_t(nint handle) : base(handle) {
  }

  public ref CUtlString BoneName {
    get => ref _Handle.AsRef<CUtlString>(Schema.GetOffset(0xBCBDE5AAFDEE0E0C));
  }
  public ref uint BoneNameToken {
    get => ref _Handle.AsRef<uint>(Schema.GetOffset(0xBCBDE5AA44D1E369));
  }
  public ref CUtlVector Controls {
    get => ref _Handle.AsRef<CUtlVector>(Schema.GetOffset(0xBCBDE5AA5FCAD2B7));
  }


}