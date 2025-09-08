using SwiftlyS2.Core.Schemas;
using SwiftlyS2.Shared.Schemas;
using SwiftlyS2.Core.Extensions;

namespace SwiftlyS2.Core.SchemaDefinitions;

internal partial class CSosGroupActionSetSoundeventParameterSchema : CSosGroupActionSchema, ISosGroupActionSetSoundeventParameterSchema {

  public CSosGroupActionSetSoundeventParameterSchema(nint handle) : base(handle) {
  }

  public ref int MaxCount {
    get => ref _Handle.AsRef<int>(Schema.GetOffset(0x40D29D8964BED864));
  }
  public ref float MinValue {
    get => ref _Handle.AsRef<float>(Schema.GetOffset(0x40D29D897C31AC56));
  }
  public ref float MaxValue {
    get => ref _Handle.AsRef<float>(Schema.GetOffset(0x40D29D89D0A5C87C));
  }
  public ref CUtlString OpvarName {
    get => ref _Handle.AsRef<CUtlString>(Schema.GetOffset(0x40D29D894ECBF7E4));
  }
  public ref SosActionSortType_t SortType {
    get => ref _Handle.AsRef<SosActionSortType_t>(Schema.GetOffset(0x40D29D892E0E44B5));
  }


}