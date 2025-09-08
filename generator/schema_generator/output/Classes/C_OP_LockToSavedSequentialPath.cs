using SwiftlyS2.Core.Schemas;
using SwiftlyS2.Shared.Schemas;
using SwiftlyS2.Core.Extensions;

namespace SwiftlyS2.Core.SchemaDefinitions;

internal partial class C_OP_LockToSavedSequentialPath : CParticleFunctionOperator, IC_OP_LockToSavedSequentialPath {

  public C_OP_LockToSavedSequentialPath(nint handle) : base(handle) {
  }

  public ref float FadeStart {
    get => ref _Handle.AsRef<float>(Schema.GetOffset(0x69BF8E0EE1A81343));
  }
  public ref float FadeEnd {
    get => ref _Handle.AsRef<float>(Schema.GetOffset(0x69BF8E0EBE7F4636));
  }
  public ref bool CPPairs {
    get => ref _Handle.AsRef<bool>(Schema.GetOffset(0x69BF8E0EA5D36D0F));
  }
  public IPathParameters PathParams {
    get => new CPathParameters(_Handle + Schema.GetOffset(0x69BF8E0E3C10092C));
  }


}