using SwiftlyS2.Core.Schemas;
using SwiftlyS2.Shared.Schemas;
using SwiftlyS2.Core.Extensions;

namespace SwiftlyS2.Core.SchemaDefinitions;

internal partial class C_OP_LockToSavedSequentialPathV2 : CParticleFunctionOperator, IC_OP_LockToSavedSequentialPathV2 {

  public C_OP_LockToSavedSequentialPathV2(nint handle) : base(handle) {
  }

  public C_OP_LockToSavedSequentialPathV2(nint handle, ulong hash, bool isField, bool isNetworked) : base(handle, hash, isField, isNetworked) {
  }

  public ref float FadeStart {
    get => ref _Handle.AsRef<float>(Schema.GetOffset(0x817A0CEE1A81343));
  }
  public ref float FadeEnd {
    get => ref _Handle.AsRef<float>(Schema.GetOffset(0x817A0CEBE7F4636));
  }
  public ref bool CPPairs {
    get => ref _Handle.AsRef<bool>(Schema.GetOffset(0x817A0CEA5D36D0F));
  }
  public IPathParameters PathParams {
    get => new CPathParameters(_Handle + Schema.GetOffset(0x817A0CE3C10092C));
  }


}