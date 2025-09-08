using SwiftlyS2.Core.Schemas;
using SwiftlyS2.Shared.Schemas;
using SwiftlyS2.Core.Extensions;

namespace SwiftlyS2.Core.SchemaDefinitions;

internal partial class CAnimScriptBase : SchemaClass, IAnimScriptBase {

  public CAnimScriptBase(nint handle) : base(handle) {
  }

  public ref bool IsValid {
    get => ref _Handle.AsRef<bool>(Schema.GetOffset(0x621CEA890E4A2BC1));
  }


}