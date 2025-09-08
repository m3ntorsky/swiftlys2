using SwiftlyS2.Core.Schemas;
using SwiftlyS2.Shared.Schemas;
using SwiftlyS2.Core.Extensions;

namespace SwiftlyS2.Core.SchemaDefinitions;

internal partial class CAnimGraphNetworkedVariables : SchemaClass, IAnimGraphNetworkedVariables {

  public CAnimGraphNetworkedVariables(nint handle) : base(handle) {
  }



  public void PredNetBoolVariablesUpdated() {
    Schema.Update(_Handle, 0x1E17B4B906DCE9F6);
  }
  public void PredNetByteVariablesUpdated() {
    Schema.Update(_Handle, 0x1E17B4B989E64D04);
  }
  public void PredNetUInt16VariablesUpdated() {
    Schema.Update(_Handle, 0x1E17B4B977F08773);
  }
  public void PredNetIntVariablesUpdated() {
    Schema.Update(_Handle, 0x1E17B4B96B8A2ED7);
  }
  public void PredNetUInt32VariablesUpdated() {
    Schema.Update(_Handle, 0x1E17B4B9E4E7C391);
  }
  public void PredNetUInt64VariablesUpdated() {
    Schema.Update(_Handle, 0x1E17B4B99DAD8E90);
  }
  public void PredNetFloatVariablesUpdated() {
    Schema.Update(_Handle, 0x1E17B4B998D66E5E);
  }
  public void PredNetVectorVariablesUpdated() {
    Schema.Update(_Handle, 0x1E17B4B9181E9E43);
  }
  public void PredNetQuaternionVariablesUpdated() {
    Schema.Update(_Handle, 0x1E17B4B97DB635DE);
  }
  public void PredNetGlobalSymbolVariablesUpdated() {
    Schema.Update(_Handle, 0x1E17B4B9617FC65F);
  }
  public void OwnerOnlyPredNetBoolVariablesUpdated() {
    Schema.Update(_Handle, 0x1E17B4B929EC42ED);
  }
  public void OwnerOnlyPredNetByteVariablesUpdated() {
    Schema.Update(_Handle, 0x1E17B4B930A63C33);
  }
  public void OwnerOnlyPredNetUInt16VariablesUpdated() {
    Schema.Update(_Handle, 0x1E17B4B9F4141ACC);
  }
  public void OwnerOnlyPredNetIntVariablesUpdated() {
    Schema.Update(_Handle, 0x1E17B4B9334BC692);
  }
  public void OwnerOnlyPredNetUInt32VariablesUpdated() {
    Schema.Update(_Handle, 0x1E17B4B92F3399D2);
  }
  public void OwnerOnlyPredNetUInt64VariablesUpdated() {
    Schema.Update(_Handle, 0x1E17B4B922F96523);
  }
  public void OwnerOnlyPredNetFloatVariablesUpdated() {
    Schema.Update(_Handle, 0x1E17B4B9BA2D74CB);
  }
  public void OwnerOnlyPredNetVectorVariablesUpdated() {
    Schema.Update(_Handle, 0x1E17B4B91BA357BC);
  }
  public void OwnerOnlyPredNetQuaternionVariablesUpdated() {
    Schema.Update(_Handle, 0x1E17B4B9D91AD9ED);
  }
  public void OwnerOnlyPredNetGlobalSymbolVariablesUpdated() {
    Schema.Update(_Handle, 0x1E17B4B9F5EB98E4);
  }
  public void BoolVariablesCountUpdated() {
    Schema.Update(_Handle, 0x1E17B4B9C49C7BDD);
  }
  public void OwnerOnlyBoolVariablesCountUpdated() {
    Schema.Update(_Handle, 0x1E17B4B9CF1E0D52);
  }
  public void RandomSeedOffsetUpdated() {
    Schema.Update(_Handle, 0x1E17B4B942BA3B9C);
  }
  public void LastTeleportTimeUpdated() {
    Schema.Update(_Handle, 0x1E17B4B9C1AD2641);
  }
}