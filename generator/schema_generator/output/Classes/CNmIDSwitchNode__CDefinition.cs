using SwiftlyS2.Core.Schemas;
using SwiftlyS2.Shared.Schemas;
using SwiftlyS2.Core.Extensions;

namespace SwiftlyS2.Core.SchemaDefinitions;

internal partial class CNmIDSwitchNode__CDefinition : CNmIDValueNode::CDefinition, INmIDSwitchNode__CDefinition {

  public CNmIDSwitchNode__CDefinition(nint handle) : base(handle) {
  }

  public ref short SwitchValueNodeIdx {
    get => ref _Handle.AsRef<short>(Schema.GetOffset(0x24752DA7FBD7561));
  }
  public ref short TrueValueNodeIdx {
    get => ref _Handle.AsRef<short>(Schema.GetOffset(0x24752DAFDE74365));
  }
  public ref short FalseValueNodeIdx {
    get => ref _Handle.AsRef<short>(Schema.GetOffset(0x24752DA8DBA2C78));
  }
  public ref CGlobalSymbol FalseValue {
    get => ref _Handle.AsRef<CGlobalSymbol>(Schema.GetOffset(0x24752DAD3506AE9));
  }
  public ref CGlobalSymbol TrueValue {
    get => ref _Handle.AsRef<CGlobalSymbol>(Schema.GetOffset(0x24752DAF134112A));
  }


}