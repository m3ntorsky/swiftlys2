using SwiftlyS2.Core.Schemas;
using SwiftlyS2.Shared.Schemas;
using SwiftlyS2.Core.Extensions;

namespace SwiftlyS2.Core.SchemaDefinitions;

internal partial class CSosGroupActionTimeBlockLimitSchema : CSosGroupActionSchema, ISosGroupActionTimeBlockLimitSchema {

  public CSosGroupActionTimeBlockLimitSchema(nint handle) : base(handle) {
  }

  public ref int MaxCount {
    get => ref _Handle.AsRef<int>(Schema.GetOffset(0x79E8A1AC64BED864));
  }
  public ref float MaxDuration {
    get => ref _Handle.AsRef<float>(Schema.GetOffset(0x79E8A1AC39BAF9F3));
  }


}