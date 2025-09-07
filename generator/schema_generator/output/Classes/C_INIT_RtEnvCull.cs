using SwiftlyS2.Core.Schemas;
using SwiftlyS2.Shared.Schemas;
using SwiftlyS2.Core.Extensions;

namespace SwiftlyS2.Core.SchemaDefinitions;

internal partial class C_INIT_RtEnvCull : CParticleFunctionInitializer, IC_INIT_RtEnvCull {

  public C_INIT_RtEnvCull(nint handle) : base(handle) {
  }

  public C_INIT_RtEnvCull(nint handle, ulong hash, bool isField, bool isNetworked) : base(handle, hash, isField, isNetworked) {
  }

  public ref Vector TestDir {
    get => ref _Handle.AsRef<Vector>(Schema.GetOffset(0xEA96DD4FC17166B4));
  }
  public ref Vector TestNormal {
    get => ref _Handle.AsRef<Vector>(Schema.GetOffset(0xEA96DD4FD4AC77F2));
  }
  public ref bool UseVelocity {
    get => ref _Handle.AsRef<bool>(Schema.GetOffset(0xEA96DD4F5E806BAF));
  }
  public ref bool CullOnMiss {
    get => ref _Handle.AsRef<bool>(Schema.GetOffset(0xEA96DD4F5E118398));
  }
  public ref bool LifeAdjust {
    get => ref _Handle.AsRef<bool>(Schema.GetOffset(0xEA96DD4FA38568F0));
  }
  public ISchemaFixedString RtEnvName {
    get => new SchemaFixedString(_Handle + Schema.GetOffset(0xEA96DD4FC32A9775));
  }
  public ref int RTEnvCP {
    get => ref _Handle.AsRef<int>(Schema.GetOffset(0xEA96DD4F01881731));
  }
  public ref int Component {
    get => ref _Handle.AsRef<int>(Schema.GetOffset(0xEA96DD4FBFD0952C));
  }


}