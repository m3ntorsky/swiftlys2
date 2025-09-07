using SwiftlyS2.Core.Schemas;
using SwiftlyS2.Shared.Schemas;
using SwiftlyS2.Core.Extensions;

namespace SwiftlyS2.Core.SchemaDefinitions;

internal partial class NmCompressionSettings_t : SchemaClass, INmCompressionSettings_t {

  public NmCompressionSettings_t(nint handle) : base(handle) {
  }

  public NmCompressionSettings_t(nint handle, ulong hash, bool isField, bool isNetworked) : base(handle, hash, isField, isNetworked) {
  }

  public INmCompressionSettings_t::QuantizationRange_t TranslationRangeX {
    get => new NmCompressionSettings_t::QuantizationRange_t(_Handle + Schema.GetOffset(0xA8EC8858BF2C2B));
  }
  public INmCompressionSettings_t::QuantizationRange_t TranslationRangeY {
    get => new NmCompressionSettings_t::QuantizationRange_t(_Handle + Schema.GetOffset(0xA8EC8857BF2A98));
  }
  public INmCompressionSettings_t::QuantizationRange_t TranslationRangeZ {
    get => new NmCompressionSettings_t::QuantizationRange_t(_Handle + Schema.GetOffset(0xA8EC885ABF2F51));
  }
  public INmCompressionSettings_t::QuantizationRange_t ScaleRange {
    get => new NmCompressionSettings_t::QuantizationRange_t(_Handle + Schema.GetOffset(0xA8EC88E96F803E));
  }
  public ref Quaternion ConstantRotation {
    get => ref _Handle.AsRef<Quaternion>(Schema.GetOffset(0xA8EC88C609717F));
  }
  public ref bool IsRotationStatic {
    get => ref _Handle.AsRef<bool>(Schema.GetOffset(0xA8EC88D75373C5));
  }
  public ref bool IsTranslationStatic {
    get => ref _Handle.AsRef<bool>(Schema.GetOffset(0xA8EC888ABDF382));
  }
  public ref bool IsScaleStatic {
    get => ref _Handle.AsRef<bool>(Schema.GetOffset(0xA8EC88FDB26607));
  }


}