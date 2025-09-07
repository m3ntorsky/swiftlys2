using SwiftlyS2.Core.Schemas;
using SwiftlyS2.Shared.Schemas;
using SwiftlyS2.Core.Extensions;

namespace SwiftlyS2.Core.SchemaDefinitions;

internal partial class C_INIT_NormalOffset : CParticleFunctionInitializer, IC_INIT_NormalOffset {

  public C_INIT_NormalOffset(nint handle) : base(handle) {
  }

  public C_INIT_NormalOffset(nint handle, ulong hash, bool isField, bool isNetworked) : base(handle, hash, isField, isNetworked) {
  }

  public ref Vector OffsetMin {
    get => ref _Handle.AsRef<Vector>(Schema.GetOffset(0x79E80AD67E1ECBDE));
  }
  public ref Vector OffsetMax {
    get => ref _Handle.AsRef<Vector>(Schema.GetOffset(0x79E80AD69009CD7C));
  }
  public ref int ControlPointNumber {
    get => ref _Handle.AsRef<int>(Schema.GetOffset(0x79E80AD63F31A6BD));
  }
  public ref bool LocalCoords {
    get => ref _Handle.AsRef<bool>(Schema.GetOffset(0x79E80AD630E716DE));
  }
  public ref bool Normalize {
    get => ref _Handle.AsRef<bool>(Schema.GetOffset(0x79E80AD648BC424C));
  }


}