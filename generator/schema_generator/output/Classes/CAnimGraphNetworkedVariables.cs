using SwiftlyS2.Core.Schemas;
using SwiftlyS2.Shared.Schemas;
using SwiftlyS2.Core.Extensions;

namespace SwiftlyS2.Core.SchemaDefinitions;

internal partial class CAnimGraphNetworkedVariables : SchemaClass, IAnimGraphNetworkedVariables {

  public CAnimGraphNetworkedVariables(nint handle) : base(handle) {
  }

  public CAnimGraphNetworkedVariables(nint handle, ulong hash, bool isField, bool isNetworked) : base(handle, hash, isField, isNetworked) {
  }

  public ref CUtlVector< uint32 > PredNetBoolVariables {
    get => ref _Handle.AsRef<CUtlVector< uint32 >>(Schema.GetOffset(0x1E17B4B906DCE9F6));
  }
  public ref CUtlVector< uint8 > PredNetByteVariables {
    get => ref _Handle.AsRef<CUtlVector< uint8 >>(Schema.GetOffset(0x1E17B4B989E64D04));
  }
  public ref CUtlVector< uint16 > PredNetUInt16Variables {
    get => ref _Handle.AsRef<CUtlVector< uint16 >>(Schema.GetOffset(0x1E17B4B977F08773));
  }
  public ref CUtlVector< int32 > PredNetIntVariables {
    get => ref _Handle.AsRef<CUtlVector< int32 >>(Schema.GetOffset(0x1E17B4B96B8A2ED7));
  }
  public ref CUtlVector< uint32 > PredNetUInt32Variables {
    get => ref _Handle.AsRef<CUtlVector< uint32 >>(Schema.GetOffset(0x1E17B4B9E4E7C391));
  }
  public ref CUtlVector< uint64 > PredNetUInt64Variables {
    get => ref _Handle.AsRef<CUtlVector< uint64 >>(Schema.GetOffset(0x1E17B4B99DAD8E90));
  }
  public ref CUtlVector< float32 > PredNetFloatVariables {
    get => ref _Handle.AsRef<CUtlVector< float32 >>(Schema.GetOffset(0x1E17B4B998D66E5E));
  }
  public ref CUtlVector< Vector > PredNetVectorVariables {
    get => ref _Handle.AsRef<CUtlVector< Vector >>(Schema.GetOffset(0x1E17B4B9181E9E43));
  }
  public ref CUtlVector< Quaternion > PredNetQuaternionVariables {
    get => ref _Handle.AsRef<CUtlVector< Quaternion >>(Schema.GetOffset(0x1E17B4B97DB635DE));
  }
  public ref CUtlVector< CGlobalSymbol > PredNetGlobalSymbolVariables {
    get => ref _Handle.AsRef<CUtlVector< CGlobalSymbol >>(Schema.GetOffset(0x1E17B4B9617FC65F));
  }
  public ref CUtlVector< uint32 > OwnerOnlyPredNetBoolVariables {
    get => ref _Handle.AsRef<CUtlVector< uint32 >>(Schema.GetOffset(0x1E17B4B929EC42ED));
  }
  public ref CUtlVector< uint8 > OwnerOnlyPredNetByteVariables {
    get => ref _Handle.AsRef<CUtlVector< uint8 >>(Schema.GetOffset(0x1E17B4B930A63C33));
  }
  public ref CUtlVector< uint16 > OwnerOnlyPredNetUInt16Variables {
    get => ref _Handle.AsRef<CUtlVector< uint16 >>(Schema.GetOffset(0x1E17B4B9F4141ACC));
  }
  public ref CUtlVector< int32 > OwnerOnlyPredNetIntVariables {
    get => ref _Handle.AsRef<CUtlVector< int32 >>(Schema.GetOffset(0x1E17B4B9334BC692));
  }
  public ref CUtlVector< uint32 > OwnerOnlyPredNetUInt32Variables {
    get => ref _Handle.AsRef<CUtlVector< uint32 >>(Schema.GetOffset(0x1E17B4B92F3399D2));
  }
  public ref CUtlVector< uint64 > OwnerOnlyPredNetUInt64Variables {
    get => ref _Handle.AsRef<CUtlVector< uint64 >>(Schema.GetOffset(0x1E17B4B922F96523));
  }
  public ref CUtlVector< float32 > OwnerOnlyPredNetFloatVariables {
    get => ref _Handle.AsRef<CUtlVector< float32 >>(Schema.GetOffset(0x1E17B4B9BA2D74CB));
  }
  public ref CUtlVector< Vector > OwnerOnlyPredNetVectorVariables {
    get => ref _Handle.AsRef<CUtlVector< Vector >>(Schema.GetOffset(0x1E17B4B91BA357BC));
  }
  public ref CUtlVector< Quaternion > OwnerOnlyPredNetQuaternionVariables {
    get => ref _Handle.AsRef<CUtlVector< Quaternion >>(Schema.GetOffset(0x1E17B4B9D91AD9ED));
  }
  public ref CUtlVector< CGlobalSymbol > OwnerOnlyPredNetGlobalSymbolVariables {
    get => ref _Handle.AsRef<CUtlVector< CGlobalSymbol >>(Schema.GetOffset(0x1E17B4B9F5EB98E4));
  }
  public ref int BoolVariablesCount {
    get => ref _Handle.AsRef<int>(Schema.GetOffset(0x1E17B4B9C49C7BDD));
  }
  public ref int OwnerOnlyBoolVariablesCount {
    get => ref _Handle.AsRef<int>(Schema.GetOffset(0x1E17B4B9CF1E0D52));
  }
  public ref int RandomSeedOffset {
    get => ref _Handle.AsRef<int>(Schema.GetOffset(0x1E17B4B942BA3B9C));
  }
  public ref float LastTeleportTime {
    get => ref _Handle.AsRef<float>(Schema.GetOffset(0x1E17B4B9C1AD2641));
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