using System.Runtime.CompilerServices;
using SwiftlyS2.Core.Natives.NativeObjects;
using SwiftlyS2.Shared.Schemas;
using SwiftlyS2.Core.Extensions;

namespace SwiftlyS2.Core.Schemas;

internal class SchemaValueField<T> : SchemaField, ISchemaValueField<T> where T : unmanaged {

  public override void FieldNetworkStateChanged() {
    if (FieldIsNetworked)
    {
      // TODO: implement
    }
  }

  public SchemaValueField(nint handle, bool isField, bool isNetworked, int offset, int size, ulong hash) : base(handle, isField, isNetworked, offset, size, hash) {
  }

  public ref T Raw { get => ref _Handle.AsRef<T>(FieldOffset); }

  public void Set(T value) {
    Raw = value;
    FieldNetworkStateChanged();
  }

  public void SetWithoutUpdate(T value) {
    Raw = value;
  }

  public ref T Get() {
    return ref Raw;
  }

}
