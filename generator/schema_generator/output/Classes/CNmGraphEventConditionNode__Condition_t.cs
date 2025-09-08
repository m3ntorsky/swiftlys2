using SwiftlyS2.Core.Schemas;
using SwiftlyS2.Shared.Schemas;
using SwiftlyS2.Core.Extensions;

namespace SwiftlyS2.Core.SchemaDefinitions;

internal partial class CNmGraphEventConditionNode__Condition_t : SchemaClass, INmGraphEventConditionNode__Condition_t {

  public CNmGraphEventConditionNode__Condition_t(nint handle) : base(handle) {
  }

  public ref CGlobalSymbol EventID {
    get => ref _Handle.AsRef<CGlobalSymbol>(Schema.GetOffset(0xA3252A829D798A72));
  }
  public ref NmGraphEventTypeCondition_t EventTypeCondition {
    get => ref _Handle.AsRef<NmGraphEventTypeCondition_t>(Schema.GetOffset(0xA3252A829BED2960));
  }


}