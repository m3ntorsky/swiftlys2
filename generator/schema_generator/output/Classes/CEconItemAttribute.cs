using SwiftlyS2.Core.Schemas;
using SwiftlyS2.Shared.Schemas;
using SwiftlyS2.Core.Extensions;

namespace SwiftlyS2.Core.SchemaDefinitions;

internal partial class CEconItemAttribute : SchemaClass, IEconItemAttribute {

  public CEconItemAttribute(nint handle) : base(handle) {
  }

  public CEconItemAttribute(nint handle, ulong hash, bool isField, bool isNetworked) : base(handle, hash, isField, isNetworked) {
  }

  public ref ushort AttributeDefinitionIndex {
    get => ref _Handle.AsRef<ushort>(Schema.GetOffset(0xBB0F80FC8DAFCD73));
  }
  public ref float Value {
    get => ref _Handle.AsRef<float>(Schema.GetOffset(0xBB0F80FC8DFCB984));
  }
  public ref float InitialValue {
    get => ref _Handle.AsRef<float>(Schema.GetOffset(0xBB0F80FCE2DBFFF2));
  }
  public ref int RefundableCurrency {
    get => ref _Handle.AsRef<int>(Schema.GetOffset(0xBB0F80FC1021E694));
  }
  public ref bool SetBonus {
    get => ref _Handle.AsRef<bool>(Schema.GetOffset(0xBB0F80FCA5E9EA96));
  }

  public void AttributeDefinitionIndexUpdated() {
    Schema.Update(_Handle, 0xBB0F80FC8DAFCD73);
  }
  public void ValueUpdated() {
    Schema.Update(_Handle, 0xBB0F80FC8DFCB984);
  }
  public void InitialValueUpdated() {
    Schema.Update(_Handle, 0xBB0F80FCE2DBFFF2);
  }
  public void RefundableCurrencyUpdated() {
    Schema.Update(_Handle, 0xBB0F80FC1021E694);
  }
  public void SetBonusUpdated() {
    Schema.Update(_Handle, 0xBB0F80FCA5E9EA96);
  }
}