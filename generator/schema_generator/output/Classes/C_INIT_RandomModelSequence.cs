using SwiftlyS2.Core.Schemas;
using SwiftlyS2.Shared.Schemas;
using SwiftlyS2.Core.Extensions;

namespace SwiftlyS2.Core.SchemaDefinitions;

internal partial class C_INIT_RandomModelSequence : CParticleFunctionInitializer, IC_INIT_RandomModelSequence {

  public C_INIT_RandomModelSequence(nint handle) : base(handle) {
  }

  public C_INIT_RandomModelSequence(nint handle, ulong hash, bool isField, bool isNetworked) : base(handle, hash, isField, isNetworked) {
  }

  public ISchemaFixedString ActivityName {
    get => new SchemaFixedString(_Handle + Schema.GetOffset(0x2F450DC3BF0C5087));
  }
  public ISchemaFixedString SequenceName {
    get => new SchemaFixedString(_Handle + Schema.GetOffset(0x2F450DC3A270F66B));
  }
  public ref CStrongHandle< InfoForResourceTypeCModel > Model {
    get => ref _Handle.AsRef<CStrongHandle< InfoForResourceTypeCModel >>(Schema.GetOffset(0x2F450DC3E100C814));
  }


}