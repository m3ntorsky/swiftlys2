using SwiftlyS2.Core.Schemas;
using SwiftlyS2.Shared.Schemas;
using SwiftlyS2.Core.Extensions;

namespace SwiftlyS2.Core.SchemaDefinitions;

internal partial class CMathCounter : CLogicalEntity, IMathCounter {

  public CMathCounter(nint handle) : base(handle) {
  }

  public CMathCounter(nint handle, ulong hash, bool isField, bool isNetworked) : base(handle, hash, isField, isNetworked) {
  }

  public ref float Min {
    get => ref _Handle.AsRef<float>(Schema.GetOffset(0x516742BC3B1A5649));
  }
  public ref float Max {
    get => ref _Handle.AsRef<float>(Schema.GetOffset(0x516742BC2D06B887));
  }
  public ref bool HitMin {
    get => ref _Handle.AsRef<bool>(Schema.GetOffset(0x516742BC563A161E));
  }
  public ref bool HitMax {
    get => ref _Handle.AsRef<bool>(Schema.GetOffset(0x516742BC6826AABC));
  }
  public ref bool Disabled {
    get => ref _Handle.AsRef<bool>(Schema.GetOffset(0x516742BC3A7C5965));
  }
  public ISchemaUntypedField OutValue {
    get => new SchemaUntypedField(_Handle + Schema.GetOffset(0x516742BCB5358CB4));
  }
  public ISchemaUntypedField OnGetValue {
    get => new SchemaUntypedField(_Handle + Schema.GetOffset(0x516742BC4246EF45));
  }
  public IEntityIOOutput OnHitMin {
    get => new CEntityIOOutput(_Handle + Schema.GetOffset(0x516742BCFBD89E37));
  }
  public IEntityIOOutput OnHitMax {
    get => new CEntityIOOutput(_Handle + Schema.GetOffset(0x516742BC09EC3BF9));
  }
  public IEntityIOOutput OnChangedFromMin {
    get => new CEntityIOOutput(_Handle + Schema.GetOffset(0x516742BC0DDBD960));
  }
  public IEntityIOOutput OnChangedFromMax {
    get => new CEntityIOOutput(_Handle + Schema.GetOffset(0x516742BC23C8744A));
  }


}