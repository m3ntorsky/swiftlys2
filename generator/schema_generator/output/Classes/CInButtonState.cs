using SwiftlyS2.Core.Schemas;
using SwiftlyS2.Shared.Schemas;
using SwiftlyS2.Core.Extensions;

namespace SwiftlyS2.Core.SchemaDefinitions;

internal partial class CInButtonState : SchemaClass, IInButtonState {

  public CInButtonState(nint handle) : base(handle) {
  }

  public ISchemaFixedArray<ulong> ButtonStates {
    get => new SchemaFixedArray<ulong>(_Handle, 0x6C8AF06A00121DF9, 3, 8, 8);
  }


}