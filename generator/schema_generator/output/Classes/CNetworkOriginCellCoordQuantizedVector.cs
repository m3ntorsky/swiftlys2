using SwiftlyS2.Core.Schemas;
using SwiftlyS2.Shared.Schemas;
using SwiftlyS2.Core.Extensions;

namespace SwiftlyS2.Core.SchemaDefinitions;

internal partial class CNetworkOriginCellCoordQuantizedVector : SchemaClass, INetworkOriginCellCoordQuantizedVector {

  public CNetworkOriginCellCoordQuantizedVector(nint handle) : base(handle) {
  }

  public CNetworkOriginCellCoordQuantizedVector(nint handle, ulong hash, bool isField, bool isNetworked) : base(handle, hash, isField, isNetworked) {
  }

  public ref ushort CellX {
    get => ref _Handle.AsRef<ushort>(Schema.GetOffset(0x2D24CA0B02D23477));
  }
  public ref ushort CellY {
    get => ref _Handle.AsRef<ushort>(Schema.GetOffset(0x2D24CA0B01D232E4));
  }
  public ref ushort CellZ {
    get => ref _Handle.AsRef<ushort>(Schema.GetOffset(0x2D24CA0B04D2379D));
  }
  public ref ushort OutsideWorld {
    get => ref _Handle.AsRef<ushort>(Schema.GetOffset(0x2D24CA0B1AFE3ED4));
  }
  public ref CNetworkedQuantizedFloat X {
    get => ref _Handle.AsRef<CNetworkedQuantizedFloat>(Schema.GetOffset(0x2D24CA0B8FEB7867));
  }
  public ref CNetworkedQuantizedFloat Y {
    get => ref _Handle.AsRef<CNetworkedQuantizedFloat>(Schema.GetOffset(0x2D24CA0B8EEB76D4));
  }
  public ref CNetworkedQuantizedFloat Z {
    get => ref _Handle.AsRef<CNetworkedQuantizedFloat>(Schema.GetOffset(0x2D24CA0B91EB7B8D));
  }

  public void CellXUpdated() {
    Schema.Update(_Handle, 0x2D24CA0B02D23477);
  }
  public void CellYUpdated() {
    Schema.Update(_Handle, 0x2D24CA0B01D232E4);
  }
  public void CellZUpdated() {
    Schema.Update(_Handle, 0x2D24CA0B04D2379D);
  }
  public void OutsideWorldUpdated() {
    Schema.Update(_Handle, 0x2D24CA0B1AFE3ED4);
  }
  public void XUpdated() {
    Schema.Update(_Handle, 0x2D24CA0B8FEB7867);
  }
  public void YUpdated() {
    Schema.Update(_Handle, 0x2D24CA0B8EEB76D4);
  }
  public void ZUpdated() {
    Schema.Update(_Handle, 0x2D24CA0B91EB7B8D);
  }
}