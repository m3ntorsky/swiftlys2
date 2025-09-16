using SwiftlyS2.Core.Natives;
using SwiftlyS2.Core.Natives.NativeObjects;
using SwiftlyS2.Core.SchemaDefinitions;
using SwiftlyS2.Shared.SchemaDefinitions;

namespace SwiftlyS2.Core.SchemaDefinitions;

internal partial class CCSWeaponBaseImpl : CCSWeaponBase {

  public CCSWeaponBaseVData VData { 
    get {
      return new CCSWeaponBaseVDataImpl((nint)NativeSchema.GetVData(_Handle));
    }
  }
}