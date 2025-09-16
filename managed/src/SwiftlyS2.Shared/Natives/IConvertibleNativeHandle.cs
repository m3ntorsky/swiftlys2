namespace SwiftlyS2.Shared.Natives;

public interface IConvertibleNativeHandle<T> : INativeHandle where T : INativeHandle {
  internal static abstract T From(nint handle);
}