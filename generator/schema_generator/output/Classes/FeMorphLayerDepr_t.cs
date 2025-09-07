using SwiftlyS2.Core.Schemas;
using SwiftlyS2.Shared.Schemas;
using SwiftlyS2.Core.Extensions;

namespace SwiftlyS2.Core.SchemaDefinitions;

internal partial class FeMorphLayerDepr_t : SchemaClass, IFeMorphLayerDepr_t {

  public FeMorphLayerDepr_t(nint handle) : base(handle) {
  }

  public FeMorphLayerDepr_t(nint handle, ulong hash, bool isField, bool isNetworked) : base(handle, hash, isField, isNetworked) {
  }

  public ref CUtlString Name {
    get => ref _Handle.AsRef<CUtlString>(Schema.GetOffset(0x5895C19CAE8A266));
  }
  public ref uint NameHash {
    get => ref _Handle.AsRef<uint>(Schema.GetOffset(0x5895C19DE15EEFE));
  }
  public ref CUtlVector< uint16 > Nodes {
    get => ref _Handle.AsRef<CUtlVector< uint16 >>(Schema.GetOffset(0x5895C19EBA045DA));
  }
  public ref CUtlVector< Vector > InitPos {
    get => ref _Handle.AsRef<CUtlVector< Vector >>(Schema.GetOffset(0x5895C198D152323));
  }
  public ref CUtlVector< float32 > Gravity {
    get => ref _Handle.AsRef<CUtlVector< float32 >>(Schema.GetOffset(0x5895C19790C70C5));
  }
  public ref CUtlVector< float32 > GoalStrength {
    get => ref _Handle.AsRef<CUtlVector< float32 >>(Schema.GetOffset(0x5895C19686343FF));
  }
  public ref CUtlVector< float32 > GoalDamping {
    get => ref _Handle.AsRef<CUtlVector< float32 >>(Schema.GetOffset(0x5895C190F3CA820));
  }
  public ref uint Flags {
    get => ref _Handle.AsRef<uint>(Schema.GetOffset(0x5895C19CE6E9C28));
  }


}