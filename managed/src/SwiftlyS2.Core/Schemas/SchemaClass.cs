using SwiftlyS2.Core.Natives.NativeObjects;
using SwiftlyS2.Shared.Schemas;

namespace SwiftlyS2.Core.Schemas;

internal class SchemaClass : SchemaField {

  public override void FieldNetworkStateChanged() {
    if (FieldIsNetworked) {
      // TODO: implement
    }
  }

  public SchemaClass(nint handle) : base(handle, false, false, 0) {
  }

  public SchemaClass(nint handle, bool isField, bool isNetworked, ulong hash) : base(handle, isField, isNetworked, hash) {
  }

}