using SwiftlyS2.Core.Schemas;
using SwiftlyS2.Shared.Schemas;
using SwiftlyS2.Core.Extensions;

namespace SwiftlyS2.Core.SchemaDefinitions;

internal partial class CPairedSequenceComponentUpdater : CAnimComponentUpdater, IPairedSequenceComponentUpdater {

  public CPairedSequenceComponentUpdater(nint handle) : base(handle) {
  }

  public CPairedSequenceComponentUpdater(nint handle, ulong hash, bool isField, bool isNetworked) : base(handle, hash, isField, isNetworked) {
  }




}