using SwiftlyS2.Core.Schemas;
using SwiftlyS2.Shared.Schemas;
using SwiftlyS2.Core.Extensions;

namespace SwiftlyS2.Core.SchemaDefinitions;

internal partial class CTriggerImpact : CTriggerMultiple, ITriggerImpact {

  public CTriggerImpact(nint handle) : base(handle) {
  }

  public CTriggerImpact(nint handle, ulong hash, bool isField, bool isNetworked) : base(handle, hash, isField, isNetworked) {
  }

  public ref float Magnitude {
    get => ref _Handle.AsRef<float>(Schema.GetOffset(0x2A6A2B48ED0A1D8B));
  }
  public ref float Noise {
    get => ref _Handle.AsRef<float>(Schema.GetOffset(0x2A6A2B48C0E47FDB));
  }
  public ref float Viewkick {
    get => ref _Handle.AsRef<float>(Schema.GetOffset(0x2A6A2B48C8BC3FC4));
  }
  public ISchemaUntypedField OutputForce {
    get => new SchemaUntypedField(_Handle + Schema.GetOffset(0x2A6A2B488653AFA9));
  }


}