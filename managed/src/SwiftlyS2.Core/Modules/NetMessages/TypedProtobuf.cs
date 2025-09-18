using SwiftlyS2.Core.Natives;
using SwiftlyS2.Core.Natives.NativeObjects;
using SwiftlyS2.Shared.Natives;
using SwiftlyS2.Shared.NetMessages;

namespace SwiftlyS2.Core.NetMessages;

internal class TypedProtobuf<T> : INativeHandle where T : ITypedProtobuf<T>
{

  public IProtobufAccessor Accessor { get; private init; }

  public TypedProtobuf()
  {
    Accessor = new ProtobufAccessor();
  }

  public nint GetHandle()
  {
    return Accessor.GetHandle();
  }

  public bool IsValid => Accessor.IsValid;
}