using SwiftlyS2.Core.Natives.NativeObjects;
using SwiftlyS2.Shared.Schemas;

namespace SwiftlyS2.Core.Schemas;

internal abstract class SchemaField : NativeHandle, ISchemaField {

  public bool IsField { get; set; }

  public bool FieldIsNetworked { get; set; }

  public int FieldSize { get; set; }

  public int FieldOffset { get; set; }

  private ulong _hash { get; set; } = 0;

  public abstract void FieldNetworkStateChanged();

  public SchemaField(nint handle, bool isField, bool isNetworked, ulong hash) : base(handle) {
    IsField = isField;
    FieldIsNetworked = isNetworked;
    FieldOffset = GetOffset(hash);
    _hash = hash;
  }

  private int GetOffset(ulong hash) {
    if (IsField) {
      return 0; //TODO: implement this with hash
    }
    return 0;
  }


}
