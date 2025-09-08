using SwiftlyS2.Core.Schemas;
using SwiftlyS2.Shared.Schemas;
using SwiftlyS2.Core.Extensions;

namespace SwiftlyS2.Core.SchemaDefinitions;

internal partial class CStateActionUpdater : SchemaClass, IStateActionUpdater {

  public CStateActionUpdater(nint handle) : base(handle) {
  }

  public ISchemaUntypedField Action {
    get => new SchemaUntypedField(_Handle + Schema.GetOffset(0xCA33DCAAE9CB47D5));
  }
  public ref StateActionBehavior Behavior {
    get => ref _Handle.AsRef<StateActionBehavior>(Schema.GetOffset(0xCA33DCAA436DB10A));
  }


}