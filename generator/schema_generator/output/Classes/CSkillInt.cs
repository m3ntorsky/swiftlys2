using SwiftlyS2.Core.Schemas;
using SwiftlyS2.Shared.Schemas;
using SwiftlyS2.Core.Extensions;

namespace SwiftlyS2.Core.SchemaDefinitions;

internal partial class CSkillInt : SchemaClass, ISkillInt {

  public CSkillInt(nint handle) : base(handle) {
  }

  public ISchemaFixedArray<int> Value {
    get => new SchemaFixedArray<int>(_Handle, 0xE86F537C7F437844, 4, 4, 4);
  }


}