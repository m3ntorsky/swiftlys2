#pragma warning disable CS0649

using System.Buffers;
using System.Text;

namespace SwiftlyS2.Core.Natives;

internal static class NativeLogger {
  private unsafe static delegate* unmanaged<int, byte*, void> _Log;
  public unsafe static void Log(int logType, string message) {
    var pool = ArrayPool<byte>.Shared;
    var messageLength = Encoding.UTF8.GetByteCount(message);
    var messageBuffer = pool.Rent(messageLength + 1);
    Encoding.UTF8.GetBytes(message, messageBuffer);
    messageBuffer[messageLength] = 0;
    fixed (byte* messageBufferPtr = messageBuffer) {
    _Log(logType, messageBufferPtr);
    pool.Return(messageBuffer);

  }
  }
  private unsafe static delegate* unmanaged<int, byte*, byte*, void> _LogCategory;
  public unsafe static void LogCategory(int logType, string category, string message) {
    var pool = ArrayPool<byte>.Shared;
    var categoryLength = Encoding.UTF8.GetByteCount(category);
    var categoryBuffer = pool.Rent(categoryLength + 1);
    Encoding.UTF8.GetBytes(category, categoryBuffer);
    categoryBuffer[categoryLength] = 0;
    fixed (byte* categoryBufferPtr = categoryBuffer) {

    var messageLength = Encoding.UTF8.GetByteCount(message);
    var messageBuffer = pool.Rent(messageLength + 1);
    Encoding.UTF8.GetBytes(message, messageBuffer);
    messageBuffer[messageLength] = 0;
    fixed (byte* messageBufferPtr = messageBuffer) {
    _LogCategory(logType, categoryBufferPtr, messageBufferPtr);
    pool.Return(categoryBuffer);

    pool.Return(messageBuffer);

  }
  }
  }
  private unsafe static delegate* unmanaged<byte*, void> _Info;
  public unsafe static void Info(string message) {
    var pool = ArrayPool<byte>.Shared;
    var messageLength = Encoding.UTF8.GetByteCount(message);
    var messageBuffer = pool.Rent(messageLength + 1);
    Encoding.UTF8.GetBytes(message, messageBuffer);
    messageBuffer[messageLength] = 0;
    fixed (byte* messageBufferPtr = messageBuffer) {
    _Info(messageBufferPtr);
    pool.Return(messageBuffer);

  }
  }
  private unsafe static delegate* unmanaged<byte*, void> _Warning;
  public unsafe static void Warning(string message) {
    var pool = ArrayPool<byte>.Shared;
    var messageLength = Encoding.UTF8.GetByteCount(message);
    var messageBuffer = pool.Rent(messageLength + 1);
    Encoding.UTF8.GetBytes(message, messageBuffer);
    messageBuffer[messageLength] = 0;
    fixed (byte* messageBufferPtr = messageBuffer) {
    _Warning(messageBufferPtr);
    pool.Return(messageBuffer);

  }
  }
  private unsafe static delegate* unmanaged<byte*, void> _Error;
  public unsafe static void Error(string message) {
    var pool = ArrayPool<byte>.Shared;
    var messageLength = Encoding.UTF8.GetByteCount(message);
    var messageBuffer = pool.Rent(messageLength + 1);
    Encoding.UTF8.GetBytes(message, messageBuffer);
    messageBuffer[messageLength] = 0;
    fixed (byte* messageBufferPtr = messageBuffer) {
    _Error(messageBufferPtr);
    pool.Return(messageBuffer);

  }
  }
  private unsafe static delegate* unmanaged<byte*, void> _Debug;
  public unsafe static void Debug(string message) {
    var pool = ArrayPool<byte>.Shared;
    var messageLength = Encoding.UTF8.GetByteCount(message);
    var messageBuffer = pool.Rent(messageLength + 1);
    Encoding.UTF8.GetBytes(message, messageBuffer);
    messageBuffer[messageLength] = 0;
    fixed (byte* messageBufferPtr = messageBuffer) {
    _Debug(messageBufferPtr);
    pool.Return(messageBuffer);

  }
  }
  private unsafe static delegate* unmanaged<byte*, byte*, void> _InfoCategory;
  public unsafe static void InfoCategory(string category, string message) {
    var pool = ArrayPool<byte>.Shared;
    var categoryLength = Encoding.UTF8.GetByteCount(category);
    var categoryBuffer = pool.Rent(categoryLength + 1);
    Encoding.UTF8.GetBytes(category, categoryBuffer);
    categoryBuffer[categoryLength] = 0;
    fixed (byte* categoryBufferPtr = categoryBuffer) {

    var messageLength = Encoding.UTF8.GetByteCount(message);
    var messageBuffer = pool.Rent(messageLength + 1);
    Encoding.UTF8.GetBytes(message, messageBuffer);
    messageBuffer[messageLength] = 0;
    fixed (byte* messageBufferPtr = messageBuffer) {
    _InfoCategory(categoryBufferPtr, messageBufferPtr);
    pool.Return(categoryBuffer);

    pool.Return(messageBuffer);

  }
  }
  }
  private unsafe static delegate* unmanaged<byte*, byte*, void> _WarningCategory;
  public unsafe static void WarningCategory(string category, string message) {
    var pool = ArrayPool<byte>.Shared;
    var categoryLength = Encoding.UTF8.GetByteCount(category);
    var categoryBuffer = pool.Rent(categoryLength + 1);
    Encoding.UTF8.GetBytes(category, categoryBuffer);
    categoryBuffer[categoryLength] = 0;
    fixed (byte* categoryBufferPtr = categoryBuffer) {

    var messageLength = Encoding.UTF8.GetByteCount(message);
    var messageBuffer = pool.Rent(messageLength + 1);
    Encoding.UTF8.GetBytes(message, messageBuffer);
    messageBuffer[messageLength] = 0;
    fixed (byte* messageBufferPtr = messageBuffer) {
    _WarningCategory(categoryBufferPtr, messageBufferPtr);
    pool.Return(categoryBuffer);

    pool.Return(messageBuffer);

  }
  }
  }
  private unsafe static delegate* unmanaged<byte*, byte*, void> _ErrorCategory;
  public unsafe static void ErrorCategory(string category, string message) {
    var pool = ArrayPool<byte>.Shared;
    var categoryLength = Encoding.UTF8.GetByteCount(category);
    var categoryBuffer = pool.Rent(categoryLength + 1);
    Encoding.UTF8.GetBytes(category, categoryBuffer);
    categoryBuffer[categoryLength] = 0;
    fixed (byte* categoryBufferPtr = categoryBuffer) {

    var messageLength = Encoding.UTF8.GetByteCount(message);
    var messageBuffer = pool.Rent(messageLength + 1);
    Encoding.UTF8.GetBytes(message, messageBuffer);
    messageBuffer[messageLength] = 0;
    fixed (byte* messageBufferPtr = messageBuffer) {
    _ErrorCategory(categoryBufferPtr, messageBufferPtr);
    pool.Return(categoryBuffer);

    pool.Return(messageBuffer);

  }
  }
  }
  private unsafe static delegate* unmanaged<byte*, byte*, void> _DebugCategory;
  public unsafe static void DebugCategory(string category, string message) {
    var pool = ArrayPool<byte>.Shared;
    var categoryLength = Encoding.UTF8.GetByteCount(category);
    var categoryBuffer = pool.Rent(categoryLength + 1);
    Encoding.UTF8.GetBytes(category, categoryBuffer);
    categoryBuffer[categoryLength] = 0;
    fixed (byte* categoryBufferPtr = categoryBuffer) {

    var messageLength = Encoding.UTF8.GetByteCount(message);
    var messageBuffer = pool.Rent(messageLength + 1);
    Encoding.UTF8.GetBytes(message, messageBuffer);
    messageBuffer[messageLength] = 0;
    fixed (byte* messageBufferPtr = messageBuffer) {
    _DebugCategory(categoryBufferPtr, messageBufferPtr);
    pool.Return(categoryBuffer);

    pool.Return(messageBuffer);

  }
  }
  }
  private unsafe static delegate* unmanaged<int, byte*, void> _SetLogFile;
  public unsafe static void SetLogFile(int logType, string path) {
    var pool = ArrayPool<byte>.Shared;
    var pathLength = Encoding.UTF8.GetByteCount(path);
    var pathBuffer = pool.Rent(pathLength + 1);
    Encoding.UTF8.GetBytes(path, pathBuffer);
    pathBuffer[pathLength] = 0;
    fixed (byte* pathBufferPtr = pathBuffer) {
    _SetLogFile(logType, pathBufferPtr);
    pool.Return(pathBuffer);

  }
  }
  private unsafe static delegate* unmanaged<int, bool, void> _ShouldOutputToFile;
  public unsafe static void ShouldOutputToFile(int logType, bool enabled) {
    _ShouldOutputToFile(logType, enabled);
  }
  private unsafe static delegate* unmanaged<byte*, bool, void> _ShouldColorCategoryInConsole;
  public unsafe static void ShouldColorCategoryInConsole(string category, bool enabled) {
    var pool = ArrayPool<byte>.Shared;
    var categoryLength = Encoding.UTF8.GetByteCount(category);
    var categoryBuffer = pool.Rent(categoryLength + 1);
    Encoding.UTF8.GetBytes(category, categoryBuffer);
    categoryBuffer[categoryLength] = 0;
    fixed (byte* categoryBufferPtr = categoryBuffer) {
    _ShouldColorCategoryInConsole(categoryBufferPtr, enabled);
    pool.Return(categoryBuffer);

  }
  }
  private unsafe static delegate* unmanaged<int, bool, void> _ShouldOutputToConsole;
  public unsafe static void ShouldOutputToConsole(int logType, bool enabled) {
    _ShouldOutputToConsole(logType, enabled);
  }
}
