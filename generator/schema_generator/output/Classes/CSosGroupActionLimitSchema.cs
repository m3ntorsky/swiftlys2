using SwiftlyS2.Core.Schemas;
using SwiftlyS2.Shared.Schemas;
using SwiftlyS2.Core.Extensions;

namespace SwiftlyS2.Core.SchemaDefinitions;

internal partial class CSosGroupActionLimitSchema : CSosGroupActionSchema, ISosGroupActionLimitSchema {

  public CSosGroupActionLimitSchema(nint handle) : base(handle) {
  }

  public CSosGroupActionLimitSchema(nint handle, ulong hash, bool isField, bool isNetworked) : base(handle, hash, isField, isNetworked) {
  }

  public ref int MaxCount {
    get => ref _Handle.AsRef<int>(Schema.GetOffset(0xE06D795E64BED864));
  }
  public ref SosActionStopType_t StopType {
    get => ref _Handle.AsRef<SosActionStopType_t>(Schema.GetOffset(0xE06D795E13397259));
  }
  public ref SosActionSortType_t SortType {
    get => ref _Handle.AsRef<SosActionSortType_t>(Schema.GetOffset(0xE06D795E2E0E44B5));
  }


}