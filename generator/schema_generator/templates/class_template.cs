using SwiftlyS2.Core.Schemas;
using SwiftlyS2.Shared.Schemas;
using SwiftlyS2.Core.Extensions;

namespace SwiftlyS2.Core.SchemaDefinitions;

internal partial class $CLASS_NAME$ : $BASE_CLASS$, $INTERFACE_NAME$ {

  protected override ulong _classHash = $CLASS_HASH$;

  public $CLASS_NAME$(nint handle) : base(handle) {
  }

  public $CLASS_NAME$(nint handle, ulong hash, bool isField, bool isNetworked) : base(handle, hash, isField, isNetworked) {
  }

$FIELDS$

$UPDATORS$
}