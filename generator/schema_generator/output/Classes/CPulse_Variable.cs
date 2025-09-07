using SwiftlyS2.Core.Schemas;
using SwiftlyS2.Shared.Schemas;
using SwiftlyS2.Core.Extensions;

namespace SwiftlyS2.Core.SchemaDefinitions;

internal partial class CPulse_Variable : SchemaClass, IPulse_Variable {

  public CPulse_Variable(nint handle) : base(handle) {
  }

  public CPulse_Variable(nint handle, ulong hash, bool isField, bool isNetworked) : base(handle, hash, isField, isNetworked) {
  }

  public ISchemaUntypedField Name {
    get => new SchemaUntypedField(_Handle + Schema.GetOffset(0x598DEA5CCAE8A266));
  }
  public ref CUtlString Description {
    get => ref _Handle.AsRef<CUtlString>(Schema.GetOffset(0x598DEA5C678744E9));
  }
  public ISchemaUntypedField Type {
    get => new SchemaUntypedField(_Handle + Schema.GetOffset(0x598DEA5C8ED6D5CD));
  }
  public ISchemaUntypedField DefaultValue {
    get => new SchemaUntypedField(_Handle + Schema.GetOffset(0x598DEA5CC6E9593F));
  }
  public ref PulseVariableKeysSource_t KeysSource {
    get => ref _Handle.AsRef<PulseVariableKeysSource_t>(Schema.GetOffset(0x598DEA5CE4356F4C));
  }
  public ref bool IsPublicBlackboardVariable {
    get => ref _Handle.AsRef<bool>(Schema.GetOffset(0x598DEA5C9CD44561));
  }
  public ref bool IsObservable {
    get => ref _Handle.AsRef<bool>(Schema.GetOffset(0x598DEA5C60684D58));
  }
  public IPulseDocNodeID_t EditorNodeID {
    get => new PulseDocNodeID_t(_Handle + Schema.GetOffset(0x598DEA5C8D964CBD));
  }


}