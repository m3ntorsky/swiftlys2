using SwiftlyS2.Core.Schemas;
using SwiftlyS2.Shared.Schemas;
using SwiftlyS2.Core.Extensions;

namespace SwiftlyS2.Core.SchemaDefinitions;

internal partial class CItem_Healthshot : CWeaponBaseItem, IItem_Healthshot {

  public CItem_Healthshot(nint handle) : base(handle) {
  }

  public CItem_Healthshot(nint handle, ulong hash, bool isField, bool isNetworked) : base(handle, hash, isField, isNetworked) {
  }




}