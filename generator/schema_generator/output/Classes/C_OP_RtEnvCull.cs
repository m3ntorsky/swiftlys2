using SwiftlyS2.Core.Schemas;
using SwiftlyS2.Shared.Schemas;
using SwiftlyS2.Core.Extensions;

namespace SwiftlyS2.Core.SchemaDefinitions;

internal partial class C_OP_RtEnvCull : CParticleFunctionOperator, IC_OP_RtEnvCull {

  public C_OP_RtEnvCull(nint handle) : base(handle) {
  }

  public ref Vector TestDir {
    get => ref _Handle.AsRef<Vector>(Schema.GetOffset(0x72531BAEC17166B4));
  }
  public ref Vector TestNormal {
    get => ref _Handle.AsRef<Vector>(Schema.GetOffset(0x72531BAED4AC77F2));
  }
  public ref bool CullOnMiss {
    get => ref _Handle.AsRef<bool>(Schema.GetOffset(0x72531BAE5E118398));
  }
  public ref bool StickInsteadOfCull {
    get => ref _Handle.AsRef<bool>(Schema.GetOffset(0x72531BAE343222A2));
  }
  public ISchemaFixedString RtEnvName {
    get => new SchemaFixedString(_Handle, 0x72531BAEC32A9775, 128, 1, 1);
  }
  public ref int RTEnvCP {
    get => ref _Handle.AsRef<int>(Schema.GetOffset(0x72531BAE01881731));
  }
  public ref int Component {
    get => ref _Handle.AsRef<int>(Schema.GetOffset(0x72531BAEBFD0952C));
  }


}