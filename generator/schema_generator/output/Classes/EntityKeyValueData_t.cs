using SwiftlyS2.Core.Schemas;
using SwiftlyS2.Shared.Schemas;
using SwiftlyS2.Core.Extensions;

namespace SwiftlyS2.Core.SchemaDefinitions;

internal partial class EntityKeyValueData_t : SchemaClass, IEntityKeyValueData_t {

  public EntityKeyValueData_t(nint handle) : base(handle) {
  }

  public EntityKeyValueData_t(nint handle, ulong hash, bool isField, bool isNetworked) : base(handle, hash, isField, isNetworked) {
  }

  public ref CUtlVector< EntityIOConnectionData_t > Connections {
    get => ref _Handle.AsRef<CUtlVector< EntityIOConnectionData_t >>(Schema.GetOffset(0x66FE4A4558F33FBE));
  }
  public ref CUtlBinaryBlock KeyValuesData {
    get => ref _Handle.AsRef<CUtlBinaryBlock>(Schema.GetOffset(0x66FE4A451BD58EB2));
  }


}