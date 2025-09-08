using SwiftlyS2.Core.Schemas;
using SwiftlyS2.Shared.Schemas;
using SwiftlyS2.Core.Extensions;

namespace SwiftlyS2.Core.SchemaDefinitions;

internal partial class CDynamicLight : CBaseModelEntity, IDynamicLight {

  public CDynamicLight(nint handle) : base(handle) {
  }

  public ref byte ActualFlags {
    get => ref _Handle.AsRef<byte>(Schema.GetOffset(0x5256F8E9E685EDEE));
  }
  public ref bool On {
    get => ref _Handle.AsRef<bool>(Schema.GetOffset(0x5256F8E9DF026050));
  }

  public void FlagsUpdated() {
    Schema.Update(_Handle, 0x5256F8E936B92FAC);
  }
  public void LightStyleUpdated() {
    Schema.Update(_Handle, 0x5256F8E965232F30);
  }
  public void RadiusUpdated() {
    Schema.Update(_Handle, 0x5256F8E97C5B0533);
  }
  public void ExponentUpdated() {
    Schema.Update(_Handle, 0x5256F8E99BCA80C6);
  }
  public void InnerAngleUpdated() {
    Schema.Update(_Handle, 0x5256F8E91D12DC0E);
  }
  public void OuterAngleUpdated() {
    Schema.Update(_Handle, 0x5256F8E9328680EF);
  }
  public void SpotRadiusUpdated() {
    Schema.Update(_Handle, 0x5256F8E993FBE5BB);
  }
}