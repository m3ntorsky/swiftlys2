using SwiftlyS2.Core.Schemas;
using SwiftlyS2.Shared.Schemas;
using SwiftlyS2.Core.Extensions;

namespace SwiftlyS2.Core.SchemaDefinitions;

internal partial class CEconItemAttribute : SchemaClass, IEconItemAttribute {

  public CEconItemAttribute(nint handle) : base(handle) {
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