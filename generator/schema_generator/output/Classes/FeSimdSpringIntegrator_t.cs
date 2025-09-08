using SwiftlyS2.Core.Schemas;
using SwiftlyS2.Shared.Schemas;
using SwiftlyS2.Core.Extensions;

namespace SwiftlyS2.Core.SchemaDefinitions;

internal partial class FeSimdSpringIntegrator_t : SchemaClass, IFeSimdSpringIntegrator_t {

  public FeSimdSpringIntegrator_t(nint handle) : base(handle) {
  }

  public ISchemaFixedArray<ushort[4]> Node {
    get => new SchemaFixedArray<ushort[4]>(_Handle, 0xF9413B96CD6694B9, 2, 8, 2);
  }
  public ref fltx4 SpringRestLength {
    get => ref _Handle.AsRef<fltx4>(Schema.GetOffset(0xF9413B9628C609E8));
  }
  public ref fltx4 SpringConstant {
    get => ref _Handle.AsRef<fltx4>(Schema.GetOffset(0xF9413B969346E79E));
  }
  public ref fltx4 SpringDamping {
    get => ref _Handle.AsRef<fltx4>(Schema.GetOffset(0xF9413B9620E775D0));
  }
  public ref fltx4 NodeWeight0 {
    get => ref _Handle.AsRef<fltx4>(Schema.GetOffset(0xF9413B966E62FEA1));
  }


}