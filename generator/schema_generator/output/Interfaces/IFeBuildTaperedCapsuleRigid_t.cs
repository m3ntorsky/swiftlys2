using SwiftlyS2.Shared.Schemas;

namespace SwiftlyS2.Core.SchemaDefinitions;

public partial interface IFeBuildTaperedCapsuleRigid_t : IFeTaperedCapsuleRigid_t {

  public ref int Priority { get; }
  
  public ref uint VertexMapHash { get; }
  
  public ref uint AntitunnelGroupBits { get; }
  
}