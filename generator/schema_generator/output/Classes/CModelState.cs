using SwiftlyS2.Core.Schemas;
using SwiftlyS2.Shared.Schemas;
using SwiftlyS2.Core.Extensions;

namespace SwiftlyS2.Core.SchemaDefinitions;

internal partial class CModelState : SchemaClass, IModelState {

  public CModelState(nint handle) : base(handle) {
  }

  public ref CUtlSymbolLarge ModelName {
    get => ref _Handle.AsRef<CUtlSymbolLarge>(Schema.GetOffset(0xC0A51C0D7A1D881));
  }
  public ref byte ForceLOD {
    get => ref _Handle.AsRef<byte>(Schema.GetOffset(0xC0A51C091D53D5F));
  }
  public ref byte ClothUpdateFlags {
    get => ref _Handle.AsRef<byte>(Schema.GetOffset(0xC0A51C0C74A2B81));
  }

  public void ModelUpdated() {
    Schema.Update(_Handle, 0xC0A51C0E100C814);
  }
  public void ClientClothCreationSuppressedUpdated() {
    Schema.Update(_Handle, 0xC0A51C0953717E1);
  }
  public void MeshGroupMaskUpdated() {
    Schema.Update(_Handle, 0xC0A51C009C93F2B);
  }
  public void BodyGroupChoicesUpdated() {
    Schema.Update(_Handle, 0xC0A51C02395D0B0);
  }
  public void IdealMotionTypeUpdated() {
    Schema.Update(_Handle, 0xC0A51C00A904E94);
  }
}