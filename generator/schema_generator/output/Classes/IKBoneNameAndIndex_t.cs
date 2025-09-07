using SwiftlyS2.Core.Schemas;
using SwiftlyS2.Shared.Schemas;
using SwiftlyS2.Core.Extensions;

namespace SwiftlyS2.Core.SchemaDefinitions;

internal partial class IKBoneNameAndIndex_t : SchemaClass, IIKBoneNameAndIndex_t {

  public IKBoneNameAndIndex_t(nint handle) : base(handle) {
  }

  public IKBoneNameAndIndex_t(nint handle, ulong hash, bool isField, bool isNetworked) : base(handle, hash, isField, isNetworked) {
  }

  public ref CUtlString Name {
    get => ref _Handle.AsRef<CUtlString>(Schema.GetOffset(0xEDEB678CAE8A266));
  }


}