using SwiftlyS2.Core.Schemas;
using SwiftlyS2.Shared.Schemas;
using SwiftlyS2.Core.Extensions;

namespace SwiftlyS2.Core.SchemaDefinitions;

internal partial class CPulseGraphInstance_TurtleGraphics : CBasePulseGraphInstance, IPulseGraphInstance_TurtleGraphics {

  public CPulseGraphInstance_TurtleGraphics(nint handle) : base(handle) {
  }

  public CPulseGraphInstance_TurtleGraphics(nint handle, ulong hash, bool isField, bool isNetworked) : base(handle, hash, isField, isNetworked) {
  }




}