using SwiftlyS2.Core.Schemas;
using SwiftlyS2.Shared.Schemas;
using SwiftlyS2.Core.Extensions;

namespace SwiftlyS2.Core.SchemaDefinitions;

internal partial class CInButtonState : SchemaClass, IInButtonState {

  public CInButtonState(nint handle) : base(handle) {
  }

  public CInButtonState(nint handle, ulong hash, bool isField, bool isNetworked) : base(handle, hash, isField, isNetworked) {
  }

  public ISchemaFixedArray<uint64> ButtonStates {
    get => new SchemaFixedArray<uint64>(_Handle + Schema.GetOffset(0x6C8AF06A00121DF9));
  }


}