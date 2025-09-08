using SwiftlyS2.Core.Schemas;
using SwiftlyS2.Shared.Schemas;
using SwiftlyS2.Core.Extensions;

namespace SwiftlyS2.Core.SchemaDefinitions;

internal partial class JiggleBoneSettingsList_t : SchemaClass, IJiggleBoneSettingsList_t {

  public JiggleBoneSettingsList_t(nint handle) : base(handle) {
  }

  public ref CUtlVector BoneSettings {
    get => ref _Handle.AsRef<CUtlVector>(Schema.GetOffset(0xD234E39D689AEBE2));
  }


}