using SwiftlyS2.Core.Schemas;
using SwiftlyS2.Shared.Schemas;
using SwiftlyS2.Core.Extensions;

namespace SwiftlyS2.Core.SchemaDefinitions;

internal partial class CDestructiblePartsSystemData : SchemaClass, IDestructiblePartsSystemData {

  public CDestructiblePartsSystemData(nint handle) : base(handle) {
  }

  public CDestructiblePartsSystemData(nint handle, ulong hash, bool isField, bool isNetworked) : base(handle, hash, isField, isNetworked) {
  }

  public ISchemaUntypedField PartsDataByHitGroup {
    get => new SchemaUntypedField(_Handle + Schema.GetOffset(0xABDCB98361E96220));
  }
  public IRangeInt MinMaxNumberHitGroupsToDestroyWhenGibbing {
    get => new CRangeInt(_Handle + Schema.GetOffset(0xABDCB9834CA810D8));
  }


}