using System.Runtime.CompilerServices;
using SwiftlyS2.Core.Natives.NativeObjects;
using SwiftlyS2.Shared.Schemas;
using SwiftlyS2.Core.Extensions;

namespace SwiftlyS2.Core.Schemas;

internal class SchemaValueField<T> : SchemaField, ISchemaValueField<T> where T : unmanaged {

  public SchemaValueField(nint handle, ulong hash, bool isField, bool isNetworked) : base(handle, hash, isField, isNetworked) {
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
