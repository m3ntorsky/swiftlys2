using SwiftlyS2.Core.Schemas;
using SwiftlyS2.Shared.Schemas;
using SwiftlyS2.Core.Extensions;

namespace SwiftlyS2.Core.SchemaDefinitions;

internal partial class CSosSoundEventGroupListSchema : SchemaClass, ISosSoundEventGroupListSchema {

  public CSosSoundEventGroupListSchema(nint handle) : base(handle) {
  }

  public CSosSoundEventGroupListSchema(nint handle, ulong hash, bool isField, bool isNetworked) : base(handle, hash, isField, isNetworked) {
  }

  public ref CUtlVector< CSosSoundEventGroupSchema > GroupList {
    get => ref _Handle.AsRef<CUtlVector< CSosSoundEventGroupSchema >>(Schema.GetOffset(0x86B277E81E01B7F4));
  }


}