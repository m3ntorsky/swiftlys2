using SwiftlyS2.Core.Schemas;
using SwiftlyS2.Shared.Schemas;
using SwiftlyS2.Core.Extensions;

namespace SwiftlyS2.Core.SchemaDefinitions;

internal partial class CPhysForce : CPointEntity, IPhysForce {

  public CPhysForce(nint handle) : base(handle) {
  }

  public ISchemaUntypedField NameAttach {
    get => new SchemaUntypedField(_Handle + Schema.GetOffset(0x29E850D5BECAEF3F));
  }
  public ref float Force {
    get => ref _Handle.AsRef<float>(Schema.GetOffset(0x29E850D5B9B6AFA4));
  }
  public ref float ForceTime {
    get => ref _Handle.AsRef<float>(Schema.GetOffset(0x29E850D58835FD05));
  }
  public ref CHandle<CBaseEntity> AttachedObject {
    get => ref _Handle.AsRef<CHandle<CBaseEntity>>(Schema.GetOffset(0x29E850D51AE8F30A));
  }
  public ref bool WasRestored {
    get => ref _Handle.AsRef<bool>(Schema.GetOffset(0x29E850D500C1E774));
  }
  public IConstantForceController Integrator {
    get => new CConstantForceController(_Handle + Schema.GetOffset(0x29E850D5BC2E3924));
  }


}