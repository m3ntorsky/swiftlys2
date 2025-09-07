using SwiftlyS2.Core.Schemas;
using SwiftlyS2.Shared.Schemas;
using SwiftlyS2.Core.Extensions;

namespace SwiftlyS2.Core.SchemaDefinitions;

internal partial class CPropDoorRotatingBreakable : CPropDoorRotating, IPropDoorRotatingBreakable {

  public CPropDoorRotatingBreakable(nint handle) : base(handle) {
  }

  public CPropDoorRotatingBreakable(nint handle, ulong hash, bool isField, bool isNetworked) : base(handle, hash, isField, isNetworked) {
  }

  public ref bool Breakable {
    get => ref _Handle.AsRef<bool>(Schema.GetOffset(0xCB925ACA549B5310));
  }
  public ref bool IsAbleToCloseAreaPortals {
    get => ref _Handle.AsRef<bool>(Schema.GetOffset(0xCB925ACAAC381C84));
  }
  public ref int CurrentDamageState {
    get => ref _Handle.AsRef<int>(Schema.GetOffset(0xCB925ACA29591458));
  }
  public ref CUtlVector< CUtlSymbolLarge > DamageStates {
    get => ref _Handle.AsRef<CUtlVector< CUtlSymbolLarge >>(Schema.GetOffset(0xCB925ACA4FD16F52));
  }


}