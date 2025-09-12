using SwiftlyS2.Core.Schemas;
using SwiftlyS2.Shared.Schemas;
using SwiftlyS2.Core.Extensions;

namespace SwiftlyS2.Core.SchemaDefinitions;

internal partial class CFuncElectrifiedVolume : CFuncBrush, IFuncElectrifiedVolume {

  public CFuncElectrifiedVolume(nint handle) : base(handle) {
  }

  public ISchemaUntypedField EffectInterpenetrateName {
    get => new SchemaUntypedField(_Handle + Schema.GetOffset(0x51A0E5987691FB19));
  }
  public ISchemaUntypedField EffectZapName {
    get => new SchemaUntypedField(_Handle + Schema.GetOffset(0x51A0E598BE142B78));
  }
  public ISchemaUntypedField EffectSource {
    get => new SchemaUntypedField(_Handle + Schema.GetOffset(0x51A0E598300F4ED9));
  }

  public void EffectNameUpdated() {
    Schema.Update(_Handle, 0x51A0E59866CD81EF);
  }
}