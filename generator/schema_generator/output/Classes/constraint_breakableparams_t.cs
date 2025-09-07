using SwiftlyS2.Core.Schemas;
using SwiftlyS2.Shared.Schemas;
using SwiftlyS2.Core.Extensions;

namespace SwiftlyS2.Core.SchemaDefinitions;

internal partial class constraint_breakableparams_t : SchemaClass, Iconstraint_breakableparams_t {

  public constraint_breakableparams_t(nint handle) : base(handle) {
  }

  public constraint_breakableparams_t(nint handle, ulong hash, bool isField, bool isNetworked) : base(handle, hash, isField, isNetworked) {
  }

  public ref float Strength {
    get => ref _Handle.AsRef<float>(Schema.GetOffset(0xEDA0F377E07A18B0));
  }
  public ref float ForceLimit {
    get => ref _Handle.AsRef<float>(Schema.GetOffset(0xEDA0F3777F2D0897));
  }
  public ref float TorqueLimit {
    get => ref _Handle.AsRef<float>(Schema.GetOffset(0xEDA0F37777EB0DDE));
  }
  public ISchemaFixedArray<float32> BodyMassScale {
    get => new SchemaFixedArray<float32>(_Handle + Schema.GetOffset(0xEDA0F3775BED8FB5));
  }
  public ref bool IsActive {
    get => ref _Handle.AsRef<bool>(Schema.GetOffset(0xEDA0F3773D94F45F));
  }


}