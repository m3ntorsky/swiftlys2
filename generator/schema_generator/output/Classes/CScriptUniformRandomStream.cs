using SwiftlyS2.Core.Schemas;
using SwiftlyS2.Shared.Schemas;
using SwiftlyS2.Core.Extensions;

namespace SwiftlyS2.Core.SchemaDefinitions;

internal partial class CScriptUniformRandomStream : SchemaClass, IScriptUniformRandomStream {

  public CScriptUniformRandomStream(nint handle) : base(handle) {
  }

  public CScriptUniformRandomStream(nint handle, ulong hash, bool isField, bool isNetworked) : base(handle, hash, isField, isNetworked) {
  }

  public ISchemaUntypedField ScriptScope {
    get => new SchemaUntypedField(_Handle + Schema.GetOffset(0xF6699588B14F90D4));
  }
  public ref int InitialSeed {
    get => ref _Handle.AsRef<int>(Schema.GetOffset(0xF6699588944D5EB2));
  }


}