using SwiftlyS2.Core.Schemas;
using SwiftlyS2.Shared.Schemas;
using SwiftlyS2.Core.Extensions;

namespace SwiftlyS2.Core.SchemaDefinitions;

internal partial class CModelConfig : SchemaClass, IModelConfig {

  public CModelConfig(nint handle) : base(handle) {
  }

  public CModelConfig(nint handle, ulong hash, bool isField, bool isNetworked) : base(handle, hash, isField, isNetworked) {
  }

  public ref CUtlString ConfigName {
    get => ref _Handle.AsRef<CUtlString>(Schema.GetOffset(0xF6401D5DA7B74064));
  }
  public ref CUtlVector< CModelConfigElement* > Elements {
    get => ref _Handle.AsRef<CUtlVector< CModelConfigElement* >>(Schema.GetOffset(0xF6401D5DC36D5D4C));
  }
  public ref bool TopLevel {
    get => ref _Handle.AsRef<bool>(Schema.GetOffset(0xF6401D5D0EC64BE2));
  }
  public ref bool ActiveInEditorByDefault {
    get => ref _Handle.AsRef<bool>(Schema.GetOffset(0xF6401D5D6E287741));
  }


}