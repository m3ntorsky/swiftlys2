using SwiftlyS2.Core.Schemas;
using SwiftlyS2.Shared.Schemas;
using SwiftlyS2.Core.Extensions;

namespace SwiftlyS2.Core.SchemaDefinitions;

internal partial class CAnimEncodeDifference : SchemaClass, IAnimEncodeDifference {

  public CAnimEncodeDifference(nint handle) : base(handle) {
  }

  public CAnimEncodeDifference(nint handle, ulong hash, bool isField, bool isNetworked) : base(handle, hash, isField, isNetworked) {
  }

  public ref CUtlVector< CAnimBoneDifference > BoneArray {
    get => ref _Handle.AsRef<CUtlVector< CAnimBoneDifference >>(Schema.GetOffset(0x65474B2E80273F0C));
  }
  public ref CUtlVector< CAnimMorphDifference > MorphArray {
    get => ref _Handle.AsRef<CUtlVector< CAnimMorphDifference >>(Schema.GetOffset(0x65474B2E8C6827E6));
  }
  public ref CUtlVector< CAnimUserDifference > UserArray {
    get => ref _Handle.AsRef<CUtlVector< CAnimUserDifference >>(Schema.GetOffset(0x65474B2EFBDB0C13));
  }
  public ref CUtlVector< uint8 > HasRotationBitArray {
    get => ref _Handle.AsRef<CUtlVector< uint8 >>(Schema.GetOffset(0x65474B2E6AD7DEA5));
  }
  public ref CUtlVector< uint8 > HasMovementBitArray {
    get => ref _Handle.AsRef<CUtlVector< uint8 >>(Schema.GetOffset(0x65474B2EAD247FA6));
  }
  public ref CUtlVector< uint8 > HasMorphBitArray {
    get => ref _Handle.AsRef<CUtlVector< uint8 >>(Schema.GetOffset(0x65474B2E5F84C5D3));
  }
  public ref CUtlVector< uint8 > HasUserBitArray {
    get => ref _Handle.AsRef<CUtlVector< uint8 >>(Schema.GetOffset(0x65474B2EB41ED7E0));
  }


}