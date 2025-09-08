using SwiftlyS2.Core.Schemas;
using SwiftlyS2.Shared.Schemas;
using SwiftlyS2.Core.Extensions;

namespace SwiftlyS2.Core.SchemaDefinitions;

internal partial class CSosSoundEventGroupListSchema : SchemaClass, ISosSoundEventGroupListSchema {

  public CSosSoundEventGroupListSchema(nint handle) : base(handle) {
  }

  public ref CUtlVector GroupList {
    get => ref _Handle.AsRef<CUtlVector>(Schema.GetOffset(0x86B277E81E01B7F4));
  }


}