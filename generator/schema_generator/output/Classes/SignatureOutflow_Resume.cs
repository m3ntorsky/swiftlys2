using SwiftlyS2.Core.Schemas;
using SwiftlyS2.Shared.Schemas;
using SwiftlyS2.Core.Extensions;

namespace SwiftlyS2.Core.SchemaDefinitions;

internal partial class SignatureOutflow_Resume : CPulse_ResumePoint, ISignatureOutflow_Resume {

  public SignatureOutflow_Resume(nint handle) : base(handle) {
  }

  public SignatureOutflow_Resume(nint handle, ulong hash, bool isField, bool isNetworked) : base(handle, hash, isField, isNetworked) {
  }




}