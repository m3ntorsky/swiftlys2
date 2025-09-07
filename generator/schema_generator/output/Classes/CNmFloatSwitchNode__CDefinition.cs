using SwiftlyS2.Core.Schemas;
using SwiftlyS2.Shared.Schemas;
using SwiftlyS2.Core.Extensions;

namespace SwiftlyS2.Core.SchemaDefinitions;

internal partial class CNmFloatSwitchNode__CDefinition : CNmFloatValueNode::CDefinition, INmFloatSwitchNode__CDefinition {

  public CNmFloatSwitchNode__CDefinition(nint handle) : base(handle) {
  }

  public CNmFloatSwitchNode__CDefinition(nint handle, ulong hash, bool isField, bool isNetworked) : base(handle, hash, isField, isNetworked) {
  }

  public ref short SwitchValueNodeIdx {
    get => ref _Handle.AsRef<short>(Schema.GetOffset(0x6D97CCCD7FBD7561));
  }
  public ref short TrueValueNodeIdx {
    get => ref _Handle.AsRef<short>(Schema.GetOffset(0x6D97CCCDFDE74365));
  }
  public ref short FalseValueNodeIdx {
    get => ref _Handle.AsRef<short>(Schema.GetOffset(0x6D97CCCD8DBA2C78));
  }
  public ref float FalseValue {
    get => ref _Handle.AsRef<float>(Schema.GetOffset(0x6D97CCCD5C87DE2F));
  }
  public ref float TrueValue {
    get => ref _Handle.AsRef<float>(Schema.GetOffset(0x6D97CCCD28CBA8A0));
  }


}