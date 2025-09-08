using SwiftlyS2.Core.Schemas;
using SwiftlyS2.Shared.Schemas;
using SwiftlyS2.Core.Extensions;

namespace SwiftlyS2.Core.SchemaDefinitions;

internal partial class CConcreteAnimParameter : CAnimParameterBase, IConcreteAnimParameter {

  public CConcreteAnimParameter(nint handle) : base(handle) {
  }

  public ref AnimParamButton_t PreviewButton {
    get => ref _Handle.AsRef<AnimParamButton_t>(Schema.GetOffset(0xFB67B7E37D0352C7));
  }
  public ref AnimParamNetworkSetting NetworkSetting {
    get => ref _Handle.AsRef<AnimParamNetworkSetting>(Schema.GetOffset(0xFB67B7E3EEBF9DD2));
  }
  public ref bool UseMostRecentValue {
    get => ref _Handle.AsRef<bool>(Schema.GetOffset(0xFB67B7E37693B669));
  }
  public ref bool AutoReset {
    get => ref _Handle.AsRef<bool>(Schema.GetOffset(0xFB67B7E3EBC32499));
  }
  public ref bool GameWritable {
    get => ref _Handle.AsRef<bool>(Schema.GetOffset(0xFB67B7E3FB2CA7F7));
  }
  public ref bool GraphWritable {
    get => ref _Handle.AsRef<bool>(Schema.GetOffset(0xFB67B7E30633E7B7));
  }


}