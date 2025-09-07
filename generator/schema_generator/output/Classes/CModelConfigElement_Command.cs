using SwiftlyS2.Core.Schemas;
using SwiftlyS2.Shared.Schemas;
using SwiftlyS2.Core.Extensions;

namespace SwiftlyS2.Core.SchemaDefinitions;

internal partial class CModelConfigElement_Command : CModelConfigElement, IModelConfigElement_Command {

  public CModelConfigElement_Command(nint handle) : base(handle) {
  }

  public CModelConfigElement_Command(nint handle, ulong hash, bool isField, bool isNetworked) : base(handle, hash, isField, isNetworked) {
  }

  public ref CUtlString Command {
    get => ref _Handle.AsRef<CUtlString>(Schema.GetOffset(0x89334ED93A5BBC32));
  }
  public ISchemaUntypedField Args {
    get => new SchemaUntypedField(_Handle + Schema.GetOffset(0x89334ED9DAB98BBC));
  }


}