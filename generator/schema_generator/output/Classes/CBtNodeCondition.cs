using SwiftlyS2.Core.Schemas;
using SwiftlyS2.Shared.Schemas;
using SwiftlyS2.Core.Extensions;

namespace SwiftlyS2.Core.SchemaDefinitions;

internal partial class CBtNodeCondition : CBtNodeDecorator, IBtNodeCondition {

  public CBtNodeCondition(nint handle) : base(handle) {
  }

  public ref bool Negated {
    get => ref _Handle.AsRef<bool>(Schema.GetOffset(0xD9C2E7ED3803BF0D));
  }


}