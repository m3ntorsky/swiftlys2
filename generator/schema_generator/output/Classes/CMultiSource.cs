using SwiftlyS2.Core.Schemas;
using SwiftlyS2.Shared.Schemas;
using SwiftlyS2.Core.Extensions;

namespace SwiftlyS2.Core.SchemaDefinitions;

internal partial class CMultiSource : CLogicalEntity, IMultiSource {

  public CMultiSource(nint handle) : base(handle) {
  }

  public CMultiSource(nint handle, ulong hash, bool isField, bool isNetworked) : base(handle, hash, isField, isNetworked) {
  }

  public ISchemaFixedArray<CHandle< CBaseEntity >> RgEntities {
    get => new SchemaFixedArray<CHandle< CBaseEntity >>(_Handle + Schema.GetOffset(0x87DC5C660CB2E479));
  }
  public ISchemaFixedArray<int32> RgTriggered {
    get => new SchemaFixedArray<int32>(_Handle + Schema.GetOffset(0x87DC5C664616C37F));
  }
  public IEntityIOOutput OnTrigger {
    get => new CEntityIOOutput(_Handle + Schema.GetOffset(0x87DC5C6681E0BFEC));
  }
  public ref int Total {
    get => ref _Handle.AsRef<int>(Schema.GetOffset(0x87DC5C667223ED06));
  }
  public ref CUtlSymbolLarge Globalstate {
    get => ref _Handle.AsRef<CUtlSymbolLarge>(Schema.GetOffset(0x87DC5C6677A86653));
  }


}