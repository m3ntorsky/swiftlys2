using SwiftlyS2.Core.Schemas;
using SwiftlyS2.Shared.Schemas;
using SwiftlyS2.Core.Extensions;

namespace SwiftlyS2.Core.SchemaDefinitions;

internal partial class CFuncMonitor : CFuncBrush, IFuncMonitor {

  public CFuncMonitor(nint handle) : base(handle) {
  }

  public ref bool StartEnabled {
    get => ref _Handle.AsRef<bool>(Schema.GetOffset(0x17F9564A500D5C24));
  }

  public void TargetCameraUpdated() {
    Schema.Update(_Handle, 0x17F9564ADE5A6027);
  }
  public void ResolutionEnumUpdated() {
    Schema.Update(_Handle, 0x17F9564A7A397BAA);
  }
  public void RenderShadowsUpdated() {
    Schema.Update(_Handle, 0x17F9564AB664410E);
  }
  public void UseUniqueColorTargetUpdated() {
    Schema.Update(_Handle, 0x17F9564A53B28E5B);
  }
  public void BrushModelNameUpdated() {
    Schema.Update(_Handle, 0x17F9564A85323213);
  }
  public void TargetCameraUpdated() {
    Schema.Update(_Handle, 0x17F9564ACC7D5969);
  }
  public void EnabledUpdated() {
    Schema.Update(_Handle, 0x17F9564A6154EB7E);
  }
  public void Draw3DSkyboxUpdated() {
    Schema.Update(_Handle, 0x17F9564AA37E21FE);
  }
}