using SwiftlyS2.Core.Schemas;
using SwiftlyS2.Shared.Schemas;
using SwiftlyS2.Core.Extensions;

namespace SwiftlyS2.Core.SchemaDefinitions;

internal partial class CInfoInstructorHintBombTargetB : CPointEntity, IInfoInstructorHintBombTargetB {

  public CInfoInstructorHintBombTargetB(nint handle) : base(handle) {
  }

  public CInfoInstructorHintBombTargetB(nint handle, ulong hash, bool isField, bool isNetworked) : base(handle, hash, isField, isNetworked) {
  }




}