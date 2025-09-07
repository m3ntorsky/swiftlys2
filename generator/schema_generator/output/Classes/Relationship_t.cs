using SwiftlyS2.Core.Schemas;
using SwiftlyS2.Shared.Schemas;
using SwiftlyS2.Core.Extensions;

namespace SwiftlyS2.Core.SchemaDefinitions;

internal partial class Relationship_t : SchemaClass, IRelationship_t {

  public Relationship_t(nint handle) : base(handle) {
  }

  public Relationship_t(nint handle, ulong hash, bool isField, bool isNetworked) : base(handle, hash, isField, isNetworked) {
  }

  public ref Disposition_t Disposition {
    get => ref _Handle.AsRef<Disposition_t>(Schema.GetOffset(0xD0FE62280D365234));
  }
  public ref int Priority {
    get => ref _Handle.AsRef<int>(Schema.GetOffset(0xD0FE622894E4E309));
  }


}