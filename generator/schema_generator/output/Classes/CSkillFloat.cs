using SwiftlyS2.Core.Schemas;
using SwiftlyS2.Shared.Schemas;
using SwiftlyS2.Core.Extensions;

namespace SwiftlyS2.Core.SchemaDefinitions;

internal partial class CSkillFloat : SchemaClass, ISkillFloat {

  public CSkillFloat(nint handle) : base(handle) {
  }

  public ISchemaFixedArray<float> Value {
    get => new SchemaFixedArray<float>(_Handle, 0x6C22E5377F437844, 4, 4, 4);
  }


}