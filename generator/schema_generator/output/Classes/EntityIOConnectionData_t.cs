using SwiftlyS2.Core.Schemas;
using SwiftlyS2.Shared.Schemas;
using SwiftlyS2.Core.Extensions;

namespace SwiftlyS2.Core.SchemaDefinitions;

internal partial class EntityIOConnectionData_t : SchemaClass, IEntityIOConnectionData_t {

  public EntityIOConnectionData_t(nint handle) : base(handle) {
  }

  public EntityIOConnectionData_t(nint handle, ulong hash, bool isField, bool isNetworked) : base(handle, hash, isField, isNetworked) {
  }

  public ref CUtlString OutputName {
    get => ref _Handle.AsRef<CUtlString>(Schema.GetOffset(0xDEBEBB4D5BFC85BF));
  }
  public ref uint TargetType {
    get => ref _Handle.AsRef<uint>(Schema.GetOffset(0xDEBEBB4D13C167A0));
  }
  public ref CUtlString TargetName {
    get => ref _Handle.AsRef<CUtlString>(Schema.GetOffset(0xDEBEBB4DC58FE46B));
  }
  public ref CUtlString InputName {
    get => ref _Handle.AsRef<CUtlString>(Schema.GetOffset(0xDEBEBB4D61478B20));
  }
  public ref CUtlString OverrideParam {
    get => ref _Handle.AsRef<CUtlString>(Schema.GetOffset(0xDEBEBB4DB454EE6A));
  }
  public ref float Delay {
    get => ref _Handle.AsRef<float>(Schema.GetOffset(0xDEBEBB4D7D68FD6E));
  }
  public ref int TimesToFire {
    get => ref _Handle.AsRef<int>(Schema.GetOffset(0xDEBEBB4D0393A604));
  }
  public ISchemaUntypedField ParamMap {
    get => new SchemaUntypedField(_Handle + Schema.GetOffset(0xDEBEBB4DF64DD25C));
  }


}