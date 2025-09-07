using SwiftlyS2.Core.Schemas;
using SwiftlyS2.Shared.Schemas;
using SwiftlyS2.Core.Extensions;

namespace SwiftlyS2.Core.SchemaDefinitions;

internal partial class ViewAngleServerChange_t : SchemaClass, IViewAngleServerChange_t {

  public ViewAngleServerChange_t(nint handle) : base(handle) {
  }

  public ViewAngleServerChange_t(nint handle, ulong hash, bool isField, bool isNetworked) : base(handle, hash, isField, isNetworked) {
  }

  public ref FixAngleSet_t Type {
    get => ref _Handle.AsRef<FixAngleSet_t>(Schema.GetOffset(0x84AFC64BEEF036F9));
  }
  public ref QAngle Angle {
    get => ref _Handle.AsRef<QAngle>(Schema.GetOffset(0x84AFC64B64F7DFC7));
  }
  public ref uint Index {
    get => ref _Handle.AsRef<uint>(Schema.GetOffset(0x84AFC64BA1A45087));
  }

  public void TypeUpdated() {
    Schema.Update(_Handle, 0x84AFC64BEEF036F9);
  }
  public void AngleUpdated() {
    Schema.Update(_Handle, 0x84AFC64B64F7DFC7);
  }
  public void IndexUpdated() {
    Schema.Update(_Handle, 0x84AFC64BA1A45087);
  }
}