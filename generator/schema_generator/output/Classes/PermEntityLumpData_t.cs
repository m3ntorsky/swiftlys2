using SwiftlyS2.Core.Schemas;
using SwiftlyS2.Shared.Schemas;
using SwiftlyS2.Core.Extensions;

namespace SwiftlyS2.Core.SchemaDefinitions;

internal partial class PermEntityLumpData_t : SchemaClass, IPermEntityLumpData_t {

  public PermEntityLumpData_t(nint handle) : base(handle) {
  }

  public ref CUtlString Name {
    get => ref _Handle.AsRef<CUtlString>(Schema.GetOffset(0x47DA25F14D8F5786));
  }
  public ref CUtlVector ChildLumps {
    get => ref _Handle.AsRef<CUtlVector>(Schema.GetOffset(0x47DA25F1AFDAF56C));
  }
  public ref CUtlLeanVector<EntityKeyValueData_t> EntityKeyValues {
    get => ref _Handle.AsRef<CUtlLeanVector<EntityKeyValueData_t>>(Schema.GetOffset(0x47DA25F1DBD62937));
  }


}