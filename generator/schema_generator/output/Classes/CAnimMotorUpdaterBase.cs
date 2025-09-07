using SwiftlyS2.Core.Schemas;
using SwiftlyS2.Shared.Schemas;
using SwiftlyS2.Core.Extensions;

namespace SwiftlyS2.Core.SchemaDefinitions;

internal partial class CAnimMotorUpdaterBase : SchemaClass, IAnimMotorUpdaterBase {

  public CAnimMotorUpdaterBase(nint handle) : base(handle) {
  }

  public CAnimMotorUpdaterBase(nint handle, ulong hash, bool isField, bool isNetworked) : base(handle, hash, isField, isNetworked) {
  }

  public ref CUtlString Name {
    get => ref _Handle.AsRef<CUtlString>(Schema.GetOffset(0x3FB6E1144D8F5786));
  }
  public ref bool Default {
    get => ref _Handle.AsRef<bool>(Schema.GetOffset(0x3FB6E11485F067BE));
  }


}