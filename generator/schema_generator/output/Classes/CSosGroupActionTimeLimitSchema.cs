using SwiftlyS2.Core.Schemas;
using SwiftlyS2.Shared.Schemas;
using SwiftlyS2.Core.Extensions;

namespace SwiftlyS2.Core.SchemaDefinitions;

internal partial class CSosGroupActionTimeLimitSchema : CSosGroupActionSchema, ISosGroupActionTimeLimitSchema {

  public CSosGroupActionTimeLimitSchema(nint handle) : base(handle) {
  }

  public ref float MaxDuration {
    get => ref _Handle.AsRef<float>(Schema.GetOffset(0xB90F1DFD39BAF9F3));
  }


}