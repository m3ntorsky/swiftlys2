using SwiftlyS2.Core.Schemas;
using SwiftlyS2.Shared.Schemas;
using SwiftlyS2.Core.Extensions;

namespace SwiftlyS2.Core.SchemaDefinitions;

internal partial class CAnimEventDefinition : SchemaClass, IAnimEventDefinition {

  public CAnimEventDefinition(nint handle) : base(handle) {
  }

  public ref int Frame {
    get => ref _Handle.AsRef<int>(Schema.GetOffset(0x27C8C8BC494AFF02));
  }
  public ref int EndFrame {
    get => ref _Handle.AsRef<int>(Schema.GetOffset(0x27C8C8BCEA91BD07));
  }
  public ref float Cycle {
    get => ref _Handle.AsRef<float>(Schema.GetOffset(0x27C8C8BC0C77829F));
  }
  public ref float Duration {
    get => ref _Handle.AsRef<float>(Schema.GetOffset(0x27C8C8BCBC5E3BAB));
  }
  public ISchemaUntypedField EventData {
    get => new SchemaUntypedField(_Handle + Schema.GetOffset(0x27C8C8BC03E547A7));
  }
  public ref CBufferString LegacyOptions {
    get => ref _Handle.AsRef<CBufferString>(Schema.GetOffset(0x27C8C8BCD613D4A1));
  }
  public ref CGlobalSymbol EventName {
    get => ref _Handle.AsRef<CGlobalSymbol>(Schema.GetOffset(0x27C8C8BC464F847D));
  }


}