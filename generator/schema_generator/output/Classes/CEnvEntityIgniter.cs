using SwiftlyS2.Core.Schemas;
using SwiftlyS2.Shared.Schemas;
using SwiftlyS2.Core.Extensions;

namespace SwiftlyS2.Core.SchemaDefinitions;

internal partial class CEnvEntityIgniter : CBaseEntity, IEnvEntityIgniter {

  public CEnvEntityIgniter(nint handle) : base(handle) {
  }

  public ref float Lifetime {
    get => ref _Handle.AsRef<float>(Schema.GetOffset(0xF8FFE95A39B35564));
  }


}