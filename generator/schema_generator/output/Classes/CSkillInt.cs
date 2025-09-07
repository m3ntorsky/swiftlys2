using SwiftlyS2.Core.Schemas;
using SwiftlyS2.Shared.Schemas;
using SwiftlyS2.Core.Extensions;

namespace SwiftlyS2.Core.SchemaDefinitions;

internal partial class CSkillInt : SchemaClass, ISkillInt {

  public CSkillInt(nint handle) : base(handle) {
  }

  public CSkillInt(nint handle, ulong hash, bool isField, bool isNetworked) : base(handle, hash, isField, isNetworked) {
  }

  public ISchemaFixedArray<int32> Value {
    get => new SchemaFixedArray<int32>(_Handle + Schema.GetOffset(0xE86F537C7F437844));
  }


}