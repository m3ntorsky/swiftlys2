using SwiftlyS2.Core.Schemas;
using SwiftlyS2.Shared.Schemas;
using SwiftlyS2.Core.Extensions;

namespace SwiftlyS2.Core.SchemaDefinitions;

internal partial class CPathParameters : SchemaClass, IPathParameters {

  public CPathParameters(nint handle) : base(handle) {
  }

  public ref int StartControlPointNumber {
    get => ref _Handle.AsRef<int>(Schema.GetOffset(0xE2D8E825CA0E0087));
  }
  public ref int EndControlPointNumber {
    get => ref _Handle.AsRef<int>(Schema.GetOffset(0xE2D8E825A9FAEC22));
  }
  public ref int BulgeControl {
    get => ref _Handle.AsRef<int>(Schema.GetOffset(0xE2D8E8257C6B6E5D));
  }
  public ref float Bulge {
    get => ref _Handle.AsRef<float>(Schema.GetOffset(0xE2D8E825E9AF7E9A));
  }
  public ref float MidPoint {
    get => ref _Handle.AsRef<float>(Schema.GetOffset(0xE2D8E825427785A3));
  }
  public ref Vector StartPointOffset {
    get => ref _Handle.AsRef<Vector>(Schema.GetOffset(0xE2D8E82516897120));
  }
  public ref Vector MidPointOffset {
    get => ref _Handle.AsRef<Vector>(Schema.GetOffset(0xE2D8E8252888EB92));
  }
  public ref Vector EndOffset {
    get => ref _Handle.AsRef<Vector>(Schema.GetOffset(0xE2D8E8255BBD1959));
  }


}