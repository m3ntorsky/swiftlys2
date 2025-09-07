using SwiftlyS2.Core.Schemas;
using SwiftlyS2.Shared.Schemas;
using SwiftlyS2.Core.Extensions;

namespace SwiftlyS2.Core.SchemaDefinitions;

internal partial class CPulse_RegisterInfo : SchemaClass, IPulse_RegisterInfo {

  public CPulse_RegisterInfo(nint handle) : base(handle) {
  }

  public CPulse_RegisterInfo(nint handle, ulong hash, bool isField, bool isNetworked) : base(handle, hash, isField, isNetworked) {
  }

  public IPulseRuntimeRegisterIndex_t Reg {
    get => new PulseRuntimeRegisterIndex_t(_Handle + Schema.GetOffset(0x8D60BE3D464A7749));
  }
  public ISchemaUntypedField Type {
    get => new SchemaUntypedField(_Handle + Schema.GetOffset(0x8D60BE3D8ED6D5CD));
  }
  public ISchemaUntypedField OriginName {
    get => new SchemaUntypedField(_Handle + Schema.GetOffset(0x8D60BE3D745ADAEC));
  }
  public ref int WrittenByInstruction {
    get => ref _Handle.AsRef<int>(Schema.GetOffset(0x8D60BE3D5311609B));
  }
  public ref int LastReadByInstruction {
    get => ref _Handle.AsRef<int>(Schema.GetOffset(0x8D60BE3D9D1961CC));
  }


}