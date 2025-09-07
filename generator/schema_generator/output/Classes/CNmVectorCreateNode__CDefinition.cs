using SwiftlyS2.Core.Schemas;
using SwiftlyS2.Shared.Schemas;
using SwiftlyS2.Core.Extensions;

namespace SwiftlyS2.Core.SchemaDefinitions;

internal partial class CNmVectorCreateNode__CDefinition : CNmVectorValueNode::CDefinition, INmVectorCreateNode__CDefinition {

  public CNmVectorCreateNode__CDefinition(nint handle) : base(handle) {
  }

  public CNmVectorCreateNode__CDefinition(nint handle, ulong hash, bool isField, bool isNetworked) : base(handle, hash, isField, isNetworked) {
  }

  public ref short InputVectorValueNodeIdx {
    get => ref _Handle.AsRef<short>(Schema.GetOffset(0xA7AE86C01EF0C864));
  }
  public ref short InputValueXNodeIdx {
    get => ref _Handle.AsRef<short>(Schema.GetOffset(0xA7AE86C0F25367BB));
  }
  public ref short InputValueYNodeIdx {
    get => ref _Handle.AsRef<short>(Schema.GetOffset(0xA7AE86C0D056A5E2));
  }
  public ref short InputValueZNodeIdx {
    get => ref _Handle.AsRef<short>(Schema.GetOffset(0xA7AE86C05ED1BD45));
  }


}