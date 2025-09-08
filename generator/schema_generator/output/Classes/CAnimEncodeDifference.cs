using SwiftlyS2.Core.Schemas;
using SwiftlyS2.Shared.Schemas;
using SwiftlyS2.Core.Extensions;

namespace SwiftlyS2.Core.SchemaDefinitions;

internal partial class CAnimEncodeDifference : SchemaClass, IAnimEncodeDifference {

  public CAnimEncodeDifference(nint handle) : base(handle) {
  }

  public ref CUtlVector BoneArray {
    get => ref _Handle.AsRef<CUtlVector>(Schema.GetOffset(0x65474B2E80273F0C));
  }
  public ref CUtlVector MorphArray {
    get => ref _Handle.AsRef<CUtlVector>(Schema.GetOffset(0x65474B2E8C6827E6));
  }
  public ref CUtlVector UserArray {
    get => ref _Handle.AsRef<CUtlVector>(Schema.GetOffset(0x65474B2EFBDB0C13));
  }
  public ref CUtlVector<byte> HasRotationBitArray {
    get => ref _Handle.AsRef<CUtlVector<byte>>(Schema.GetOffset(0x65474B2E6AD7DEA5));
  }
  public ref CUtlVector<byte> HasMovementBitArray {
    get => ref _Handle.AsRef<CUtlVector<byte>>(Schema.GetOffset(0x65474B2EAD247FA6));
  }
  public ref CUtlVector<byte> HasMorphBitArray {
    get => ref _Handle.AsRef<CUtlVector<byte>>(Schema.GetOffset(0x65474B2E5F84C5D3));
  }
  public ref CUtlVector<byte> HasUserBitArray {
    get => ref _Handle.AsRef<CUtlVector<byte>>(Schema.GetOffset(0x65474B2EB41ED7E0));
  }


}