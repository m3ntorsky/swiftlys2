using SwiftlyS2.Core.Schemas;
using SwiftlyS2.Shared.Schemas;
using SwiftlyS2.Core.Extensions;

namespace SwiftlyS2.Core.SchemaDefinitions;

internal partial class C_OP_SetControlPointPositionToTimeOfDayValue : CParticleFunctionPreEmission, IC_OP_SetControlPointPositionToTimeOfDayValue {

  public C_OP_SetControlPointPositionToTimeOfDayValue(nint handle) : base(handle) {
  }

  public ref int ControlPointNumber {
    get => ref _Handle.AsRef<int>(Schema.GetOffset(0x976831CB3F31A6BD));
  }
  public ISchemaFixedString TimeOfDayParameter {
    get => new SchemaFixedString(_Handle, 0x976831CB5B5E9DD3, 128, 1, 1);
  }
  public ref Vector DefaultValue {
    get => ref _Handle.AsRef<Vector>(Schema.GetOffset(0x976831CB0A18BFDF));
  }


}