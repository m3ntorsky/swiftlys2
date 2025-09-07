using SwiftlyS2.Core.Schemas;
using SwiftlyS2.Shared.Schemas;
using SwiftlyS2.Core.Extensions;

namespace SwiftlyS2.Core.SchemaDefinitions;

internal partial class CMathRemap : CLogicalEntity, IMathRemap {

  public CMathRemap(nint handle) : base(handle) {
  }

  public CMathRemap(nint handle, ulong hash, bool isField, bool isNetworked) : base(handle, hash, isField, isNetworked) {
  }

  public ref float InMin {
    get => ref _Handle.AsRef<float>(Schema.GetOffset(0xDE4BD86D7506C6C8));
  }
  public ref float InMax {
    get => ref _Handle.AsRef<float>(Schema.GetOffset(0xDE4BD86D6B1BD1C2));
  }
  public ref float Out1 {
    get => ref _Handle.AsRef<float>(Schema.GetOffset(0xDE4BD86D536FFA50));
  }
  public ref float Out2 {
    get => ref _Handle.AsRef<float>(Schema.GetOffset(0xDE4BD86D566FFF09));
  }
  public ref float OldInValue {
    get => ref _Handle.AsRef<float>(Schema.GetOffset(0xDE4BD86D36ED0B54));
  }
  public ref bool Enabled {
    get => ref _Handle.AsRef<bool>(Schema.GetOffset(0xDE4BD86D6154EB7E));
  }
  public ISchemaUntypedField OutValue {
    get => new SchemaUntypedField(_Handle + Schema.GetOffset(0xDE4BD86DB5358CB4));
  }
  public IEntityIOOutput OnRoseAboveMin {
    get => new CEntityIOOutput(_Handle + Schema.GetOffset(0xDE4BD86D814C5D50));
  }
  public IEntityIOOutput OnRoseAboveMax {
    get => new CEntityIOOutput(_Handle + Schema.GetOffset(0xDE4BD86D7738C5DA));
  }
  public IEntityIOOutput OnFellBelowMin {
    get => new CEntityIOOutput(_Handle + Schema.GetOffset(0xDE4BD86DBF740886));
  }
  public IEntityIOOutput OnFellBelowMax {
    get => new CEntityIOOutput(_Handle + Schema.GetOffset(0xDE4BD86DD187AC94));
  }


}