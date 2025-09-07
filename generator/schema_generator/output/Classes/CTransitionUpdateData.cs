using SwiftlyS2.Core.Schemas;
using SwiftlyS2.Shared.Schemas;
using SwiftlyS2.Core.Extensions;

namespace SwiftlyS2.Core.SchemaDefinitions;

internal partial class CTransitionUpdateData : SchemaClass, ITransitionUpdateData {

  public CTransitionUpdateData(nint handle) : base(handle) {
  }

  public CTransitionUpdateData(nint handle, ulong hash, bool isField, bool isNetworked) : base(handle, hash, isField, isNetworked) {
  }

  public ref byte SrcStateIndex {
    get => ref _Handle.AsRef<byte>(Schema.GetOffset(0xF3F18D08D2AF559E));
  }
  public ref byte DestStateIndex {
    get => ref _Handle.AsRef<byte>(Schema.GetOffset(0xF3F18D0876246C8A));
  }
  public ISchemaUntypedField HandshakeMaskToDisableFirst {
    get => new SchemaUntypedField(_Handle + Schema.GetOffset(0xF3F18D08E58422C5));
  }
  public ISchemaUntypedField Disabled {
    get => new SchemaUntypedField(_Handle + Schema.GetOffset(0xF3F18D083A7C5965));
  }


}