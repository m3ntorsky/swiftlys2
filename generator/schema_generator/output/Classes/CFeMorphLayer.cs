using SwiftlyS2.Core.Schemas;
using SwiftlyS2.Shared.Schemas;
using SwiftlyS2.Core.Extensions;

namespace SwiftlyS2.Core.SchemaDefinitions;

internal partial class CFeMorphLayer : SchemaClass, IFeMorphLayer {

  public CFeMorphLayer(nint handle) : base(handle) {
  }

  public CFeMorphLayer(nint handle, ulong hash, bool isField, bool isNetworked) : base(handle, hash, isField, isNetworked) {
  }

  public ref CUtlString Name {
    get => ref _Handle.AsRef<CUtlString>(Schema.GetOffset(0xB30F1160CAE8A266));
  }
  public ref uint NameHash {
    get => ref _Handle.AsRef<uint>(Schema.GetOffset(0xB30F1160DE15EEFE));
  }
  public ref CUtlVector< uint16 > Nodes {
    get => ref _Handle.AsRef<CUtlVector< uint16 >>(Schema.GetOffset(0xB30F1160EBA045DA));
  }
  public ref CUtlVector< Vector > InitPos {
    get => ref _Handle.AsRef<CUtlVector< Vector >>(Schema.GetOffset(0xB30F11608D152323));
  }
  public ref CUtlVector< float32 > Gravity {
    get => ref _Handle.AsRef<CUtlVector< float32 >>(Schema.GetOffset(0xB30F1160790C70C5));
  }
  public ref CUtlVector< float32 > GoalStrength {
    get => ref _Handle.AsRef<CUtlVector< float32 >>(Schema.GetOffset(0xB30F1160686343FF));
  }
  public ref CUtlVector< float32 > GoalDamping {
    get => ref _Handle.AsRef<CUtlVector< float32 >>(Schema.GetOffset(0xB30F11600F3CA820));
  }


}