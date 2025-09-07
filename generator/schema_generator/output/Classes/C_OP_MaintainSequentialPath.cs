using SwiftlyS2.Core.Schemas;
using SwiftlyS2.Shared.Schemas;
using SwiftlyS2.Core.Extensions;

namespace SwiftlyS2.Core.SchemaDefinitions;

internal partial class C_OP_MaintainSequentialPath : CParticleFunctionOperator, IC_OP_MaintainSequentialPath {

  public C_OP_MaintainSequentialPath(nint handle) : base(handle) {
  }

  public C_OP_MaintainSequentialPath(nint handle, ulong hash, bool isField, bool isNetworked) : base(handle, hash, isField, isNetworked) {
  }

  public ref float MaxDistance {
    get => ref _Handle.AsRef<float>(Schema.GetOffset(0x3F7004B8844E396A));
  }
  public ref float NumToAssign {
    get => ref _Handle.AsRef<float>(Schema.GetOffset(0x3F7004B8F73366BD));
  }
  public ref float CohesionStrength {
    get => ref _Handle.AsRef<float>(Schema.GetOffset(0x3F7004B8A5A506EA));
  }
  public ref float Tolerance {
    get => ref _Handle.AsRef<float>(Schema.GetOffset(0x3F7004B88C29728E));
  }
  public ref bool Loop {
    get => ref _Handle.AsRef<bool>(Schema.GetOffset(0x3F7004B8C668A4CB));
  }
  public ref bool UseParticleCount {
    get => ref _Handle.AsRef<bool>(Schema.GetOffset(0x3F7004B8D4DA0515));
  }
  public IPathParameters PathParams {
    get => new CPathParameters(_Handle + Schema.GetOffset(0x3F7004B83C10092C));
  }


}