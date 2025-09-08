using SwiftlyS2.Core.Schemas;
using SwiftlyS2.Shared.Schemas;
using SwiftlyS2.Core.Extensions;

namespace SwiftlyS2.Core.SchemaDefinitions;

internal partial class CLogicCollisionPair : CLogicalEntity, ILogicCollisionPair {

  public CLogicCollisionPair(nint handle) : base(handle) {
  }

  public ref CUtlSymbolLarge NameAttach1 {
    get => ref _Handle.AsRef<CUtlSymbolLarge>(Schema.GetOffset(0x9E0FC6AC6776530A));
  }
  public ref CUtlSymbolLarge NameAttach2 {
    get => ref _Handle.AsRef<CUtlSymbolLarge>(Schema.GetOffset(0x9E0FC6AC66765177));
  }
  public ref bool SupportMultipleEntitiesWithSameName {
    get => ref _Handle.AsRef<bool>(Schema.GetOffset(0x9E0FC6ACD009870A));
  }
  public ref bool Disabled {
    get => ref _Handle.AsRef<bool>(Schema.GetOffset(0x9E0FC6AC28A745A5));
  }
  public ref bool Succeeded {
    get => ref _Handle.AsRef<bool>(Schema.GetOffset(0x9E0FC6AC48FBF712));
  }


}