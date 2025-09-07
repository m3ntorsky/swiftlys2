using SwiftlyS2.Core.Schemas;
using SwiftlyS2.Shared.Schemas;
using SwiftlyS2.Core.Extensions;

namespace SwiftlyS2.Core.SchemaDefinitions;

internal partial class ConfigIndex : SchemaClass, IConfigIndex {

  public ConfigIndex(nint handle) : base(handle) {
  }

  public ConfigIndex(nint handle, ulong hash, bool isField, bool isNetworked) : base(handle, hash, isField, isNetworked) {
  }

  public ref ushort Group {
    get => ref _Handle.AsRef<ushort>(Schema.GetOffset(0x193FE40D0CD16308));
  }
  public ref ushort Config {
    get => ref _Handle.AsRef<ushort>(Schema.GetOffset(0x193FE40D8BD1DF73));
  }


}