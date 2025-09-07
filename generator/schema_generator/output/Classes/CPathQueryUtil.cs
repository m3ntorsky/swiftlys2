using SwiftlyS2.Core.Schemas;
using SwiftlyS2.Shared.Schemas;
using SwiftlyS2.Core.Extensions;

namespace SwiftlyS2.Core.SchemaDefinitions;

internal partial class CPathQueryUtil : SchemaClass, IPathQueryUtil {

  public CPathQueryUtil(nint handle) : base(handle) {
  }

  public CPathQueryUtil(nint handle, ulong hash, bool isField, bool isNetworked) : base(handle, hash, isField, isNetworked) {
  }

  public ref CTransform PathToEntityTransform {
    get => ref _Handle.AsRef<CTransform>(Schema.GetOffset(0x52D1B6431A6FA220));
  }
  public ref CUtlVector< Vector > PathSamplePositions {
    get => ref _Handle.AsRef<CUtlVector< Vector >>(Schema.GetOffset(0x52D1B643099F5ECC));
  }
  public ref CUtlVector< float32 > PathSampleParameters {
    get => ref _Handle.AsRef<CUtlVector< float32 >>(Schema.GetOffset(0x52D1B6431D6E0D08));
  }
  public ref CUtlVector< float32 > PathSampleDistances {
    get => ref _Handle.AsRef<CUtlVector< float32 >>(Schema.GetOffset(0x52D1B6435680B274));
  }
  public ref bool IsClosedLoop {
    get => ref _Handle.AsRef<bool>(Schema.GetOffset(0x52D1B6430806319B));
  }


}