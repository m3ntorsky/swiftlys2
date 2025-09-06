using SwiftlyS2.Core.Natives.NativeObjects;
using SwiftlyS2.Shared.Schemas;

namespace SwiftlyS2.Core.Schemas;

internal abstract class SchemaField : NativeHandle, ISchemaField {

  public bool IsField { get; set; }

  public bool FieldIsNetworked { get; set; }

  public int FieldOffset { get; set; }

  public int FieldSize { get; set; }

  private ulong _hash { get; set; } = 0;

  public abstract void FieldNetworkStateChanged();

  public SchemaField(nint handle, bool isField, bool isNetworked, int offset, int size, ulong hash) : base(handle) {
    IsField = isField;
    FieldIsNetworked = isNetworked;
    FieldOffset = offset;
    FieldSize = size;
    _hash = hash;
  }


}
