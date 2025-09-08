using SwiftlyS2.Core.Schemas;
using SwiftlyS2.Shared.Schemas;
using SwiftlyS2.Core.Extensions;

namespace SwiftlyS2.Core.SchemaDefinitions;

internal partial class FeFitWeight_t : SchemaClass, IFeFitWeight_t {

  public FeFitWeight_t(nint handle) : base(handle) {
  }

  public ref float Weight {
    get => ref _Handle.AsRef<float>(Schema.GetOffset(0x292AB604CFFC66CB));
  }
  public ref ushort Node {
    get => ref _Handle.AsRef<ushort>(Schema.GetOffset(0x292AB604CD6694B9));
  }
  public ref ushort Dummy {
    get => ref _Handle.AsRef<ushort>(Schema.GetOffset(0x292AB604CD8BAE5F));
  }


}