using SwiftlyS2.Core.Schemas;
using SwiftlyS2.Shared.Schemas;
using SwiftlyS2.Core.Extensions;

namespace SwiftlyS2.Core.SchemaDefinitions;

internal partial class CNmFloatEaseNode__CDefinition : CNmFloatValueNode::CDefinition, INmFloatEaseNode__CDefinition {

  public CNmFloatEaseNode__CDefinition(nint handle) : base(handle) {
  }

  public CNmFloatEaseNode__CDefinition(nint handle, ulong hash, bool isField, bool isNetworked) : base(handle, hash, isField, isNetworked) {
  }

  public ref float EaseTime {
    get => ref _Handle.AsRef<float>(Schema.GetOffset(0x9D7103D0A54FCC));
  }
  public ref float StartValue {
    get => ref _Handle.AsRef<float>(Schema.GetOffset(0x9D710351C82C2A));
  }
  public ref short InputValueNodeIdx {
    get => ref _Handle.AsRef<short>(Schema.GetOffset(0x9D710395E89F27));
  }
  public ref NmEasingOperation_t EasingOp {
    get => ref _Handle.AsRef<NmEasingOperation_t>(Schema.GetOffset(0x9D7103CF457EAF));
  }
  public ref bool UseStartValue {
    get => ref _Handle.AsRef<bool>(Schema.GetOffset(0x9D710306DE6089));
  }


}