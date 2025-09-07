using SwiftlyS2.Core.Schemas;
using SwiftlyS2.Shared.Schemas;
using SwiftlyS2.Core.Extensions;

namespace SwiftlyS2.Core.SchemaDefinitions;

internal partial class audioparams_t : SchemaClass, Iaudioparams_t {

  public audioparams_t(nint handle) : base(handle) {
  }

  public audioparams_t(nint handle, ulong hash, bool isField, bool isNetworked) : base(handle, hash, isField, isNetworked) {
  }

  public ISchemaFixedArray<Vector> LocalSound {
    get => new SchemaFixedArray<Vector>(_Handle + Schema.GetOffset(0x6D349E3CCE184A47));
  }
  public ref int SoundscapeIndex {
    get => ref _Handle.AsRef<int>(Schema.GetOffset(0x6D349E3C046FCFEE));
  }
  public ref byte LocalBits {
    get => ref _Handle.AsRef<byte>(Schema.GetOffset(0x6D349E3C1DE85B60));
  }
  public ref int SoundscapeEntityListIndex {
    get => ref _Handle.AsRef<int>(Schema.GetOffset(0x6D349E3CA4E4FB9B));
  }
  public ref uint SoundEventHash {
    get => ref _Handle.AsRef<uint>(Schema.GetOffset(0x6D349E3C335E17CC));
  }

  public void LocalSoundUpdated() {
    Schema.Update(_Handle, 0x6D349E3CCE184A47);
  }
  public void SoundscapeIndexUpdated() {
    Schema.Update(_Handle, 0x6D349E3C046FCFEE);
  }
  public void LocalBitsUpdated() {
    Schema.Update(_Handle, 0x6D349E3C1DE85B60);
  }
  public void SoundscapeEntityListIndexUpdated() {
    Schema.Update(_Handle, 0x6D349E3CA4E4FB9B);
  }
  public void SoundEventHashUpdated() {
    Schema.Update(_Handle, 0x6D349E3C335E17CC);
  }
}