using SwiftlyS2.Core.Schemas;
using SwiftlyS2.Shared.Schemas;
using SwiftlyS2.Core.Extensions;

namespace SwiftlyS2.Core.SchemaDefinitions;

internal partial class EntitySpottedState_t : SchemaClass, IEntitySpottedState_t {

  public EntitySpottedState_t(nint handle) : base(handle) {
  }

  public EntitySpottedState_t(nint handle, ulong hash, bool isField, bool isNetworked) : base(handle, hash, isField, isNetworked) {
  }

  public ref bool Spotted {
    get => ref _Handle.AsRef<bool>(Schema.GetOffset(0x6E33B0176DE4F1CA));
  }
  public ISchemaFixedArray<uint32> SpottedByMask {
    get => new SchemaFixedArray<uint32>(_Handle + Schema.GetOffset(0x6E33B0170BD77207));
  }

  public void SpottedUpdated() {
    Schema.Update(_Handle, 0x6E33B0176DE4F1CA);
  }
  public void SpottedByMaskUpdated() {
    Schema.Update(_Handle, 0x6E33B0170BD77207);
  }
}