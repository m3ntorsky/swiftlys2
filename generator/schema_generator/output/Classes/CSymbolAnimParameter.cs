using SwiftlyS2.Core.Schemas;
using SwiftlyS2.Shared.Schemas;
using SwiftlyS2.Core.Extensions;

namespace SwiftlyS2.Core.SchemaDefinitions;

internal partial class CSymbolAnimParameter : CConcreteAnimParameter, ISymbolAnimParameter {

  public CSymbolAnimParameter(nint handle) : base(handle) {
  }

  public CSymbolAnimParameter(nint handle, ulong hash, bool isField, bool isNetworked) : base(handle, hash, isField, isNetworked) {
  }

  public ref CGlobalSymbol DefaultValue {
    get => ref _Handle.AsRef<CGlobalSymbol>(Schema.GetOffset(0xA3486AA2BBE0341F));
  }


}