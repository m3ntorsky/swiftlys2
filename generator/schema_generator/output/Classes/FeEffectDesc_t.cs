using SwiftlyS2.Core.Schemas;
using SwiftlyS2.Shared.Schemas;
using SwiftlyS2.Core.Extensions;

namespace SwiftlyS2.Core.SchemaDefinitions;

internal partial class FeEffectDesc_t : SchemaClass, IFeEffectDesc_t {

  public FeEffectDesc_t(nint handle) : base(handle) {
  }

  public FeEffectDesc_t(nint handle, ulong hash, bool isField, bool isNetworked) : base(handle, hash, isField, isNetworked) {
  }

  public ref CUtlString Name {
    get => ref _Handle.AsRef<CUtlString>(Schema.GetOffset(0x3462F54326980769));
  }
  public ref uint NameHash {
    get => ref _Handle.AsRef<uint>(Schema.GetOffset(0x3462F543BA4B2BDE));
  }
  public ref int Type {
    get => ref _Handle.AsRef<int>(Schema.GetOffset(0x3462F543EEF036F9));
  }
  public ISchemaUntypedField Params {
    get => new SchemaUntypedField(_Handle + Schema.GetOffset(0x3462F543900020D3));
  }


}