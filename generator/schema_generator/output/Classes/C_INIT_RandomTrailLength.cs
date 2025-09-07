using SwiftlyS2.Core.Schemas;
using SwiftlyS2.Shared.Schemas;
using SwiftlyS2.Core.Extensions;

namespace SwiftlyS2.Core.SchemaDefinitions;

internal partial class C_INIT_RandomTrailLength : CParticleFunctionInitializer, IC_INIT_RandomTrailLength {

  public C_INIT_RandomTrailLength(nint handle) : base(handle) {
  }

  public C_INIT_RandomTrailLength(nint handle, ulong hash, bool isField, bool isNetworked) : base(handle, hash, isField, isNetworked) {
  }

  public ref float MinLength {
    get => ref _Handle.AsRef<float>(Schema.GetOffset(0x6418031B95FB8E51));
  }
  public ref float MaxLength {
    get => ref _Handle.AsRef<float>(Schema.GetOffset(0x6418031B87A8B4C7));
  }
  public ref float LengthRandExponent {
    get => ref _Handle.AsRef<float>(Schema.GetOffset(0x6418031B41B064A7));
  }


}