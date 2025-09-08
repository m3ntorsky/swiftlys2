using SwiftlyS2.Core.Schemas;
using SwiftlyS2.Shared.Schemas;
using SwiftlyS2.Core.Extensions;

namespace SwiftlyS2.Core.SchemaDefinitions;

internal partial class thinkfunc_t : SchemaClass, Ithinkfunc_t {

  public thinkfunc_t(nint handle) : base(handle) {
  }

  public ISchemaUntypedField Fn {
    get => new SchemaUntypedField(_Handle + Schema.GetOffset(0x8ED693FAD922E237));
  }
  public ref CUtlStringToken Context {
    get => ref _Handle.AsRef<CUtlStringToken>(Schema.GetOffset(0x8ED693FAB16905F8));
  }
  public IGameTick_t NextThinkTick {
    get => new GameTick_t(_Handle + Schema.GetOffset(0x8ED693FAB7CEF021));
  }
  public IGameTick_t LastThinkTick {
    get => new GameTick_t(_Handle + Schema.GetOffset(0x8ED693FACE8FE7F2));
  }


}