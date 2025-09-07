using SwiftlyS2.Core.Schemas;
using SwiftlyS2.Shared.Schemas;
using SwiftlyS2.Core.Extensions;

namespace SwiftlyS2.Core.SchemaDefinitions;

internal partial class CSosGroupActionMemberCountEnvelopeSchema : CSosGroupActionSchema, ISosGroupActionMemberCountEnvelopeSchema {

  public CSosGroupActionMemberCountEnvelopeSchema(nint handle) : base(handle) {
  }

  public CSosGroupActionMemberCountEnvelopeSchema(nint handle, ulong hash, bool isField, bool isNetworked) : base(handle, hash, isField, isNetworked) {
  }

  public ref int BaseCount {
    get => ref _Handle.AsRef<int>(Schema.GetOffset(0x5C85206CE09342E3));
  }
  public ref int TargetCount {
    get => ref _Handle.AsRef<int>(Schema.GetOffset(0x5C85206CFEA8571B));
  }
  public ref float BaseValue {
    get => ref _Handle.AsRef<float>(Schema.GetOffset(0x5C85206CB5B71A9B));
  }
  public ref float TargetValue {
    get => ref _Handle.AsRef<float>(Schema.GetOffset(0x5C85206C1584D0BB));
  }
  public ref float Attack {
    get => ref _Handle.AsRef<float>(Schema.GetOffset(0x5C85206C0A6A5BE7));
  }
  public ref float Decay {
    get => ref _Handle.AsRef<float>(Schema.GetOffset(0x5C85206CE24ABC67));
  }
  public ref CUtlString ResultVarName {
    get => ref _Handle.AsRef<CUtlString>(Schema.GetOffset(0x5C85206CF566E926));
  }
  public ref bool SaveToGroup {
    get => ref _Handle.AsRef<bool>(Schema.GetOffset(0x5C85206C6ED720F8));
  }


}