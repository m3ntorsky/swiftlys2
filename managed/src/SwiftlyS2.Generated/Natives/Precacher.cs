#pragma warning disable CS0649

using System.Buffers;
using System.Text;

namespace SwiftlyS2.Core.Natives;

internal static class NativePrecacher {
  private unsafe static delegate* unmanaged<byte*, void> _AddItem;
  public unsafe static void AddItem(string itemPath) {
    var pool = ArrayPool<byte>.Shared;
    var itemPathLength = Encoding.UTF8.GetByteCount(itemPath);
    var itemPathBuffer = pool.Rent(itemPathLength + 1);
    Encoding.UTF8.GetBytes(itemPath, itemPathBuffer);
    itemPathBuffer[itemPathLength] = 0;
    fixed (byte* itemPathBufferPtr = itemPathBuffer) {
    _AddItem(itemPathBufferPtr);
    pool.Return(itemPathBuffer);

  }
  }
  private unsafe static delegate* unmanaged<byte*, bool> _HasItemInList;
  /// <summary>
  /// if the item is in the list of all the items that need to be precached
  /// </summary>
  public unsafe static bool HasItemInList(string itemPath) {
    var pool = ArrayPool<byte>.Shared;
    var itemPathLength = Encoding.UTF8.GetByteCount(itemPath);
    var itemPathBuffer = pool.Rent(itemPathLength + 1);
    Encoding.UTF8.GetBytes(itemPath, itemPathBuffer);
    itemPathBuffer[itemPathLength] = 0;
    fixed (byte* itemPathBufferPtr = itemPathBuffer) {
    var ret = _HasItemInList(itemPathBufferPtr);
    pool.Return(itemPathBuffer);

    return ret;
  }
  }
  private unsafe static delegate* unmanaged<byte*, bool> _IsItemCached;
  public unsafe static bool IsItemCached(string itemPath) {
    var pool = ArrayPool<byte>.Shared;
    var itemPathLength = Encoding.UTF8.GetByteCount(itemPath);
    var itemPathBuffer = pool.Rent(itemPathLength + 1);
    Encoding.UTF8.GetBytes(itemPath, itemPathBuffer);
    itemPathBuffer[itemPathLength] = 0;
    fixed (byte* itemPathBufferPtr = itemPathBuffer) {
    var ret = _IsItemCached(itemPathBufferPtr);
    pool.Return(itemPathBuffer);

    return ret;
  }
  }
  private unsafe static delegate* unmanaged<byte*, void> _RemoveItem;
  public unsafe static void RemoveItem(string itemPath) {
    var pool = ArrayPool<byte>.Shared;
    var itemPathLength = Encoding.UTF8.GetByteCount(itemPath);
    var itemPathBuffer = pool.Rent(itemPathLength + 1);
    Encoding.UTF8.GetBytes(itemPath, itemPathBuffer);
    itemPathBuffer[itemPathLength] = 0;
    fixed (byte* itemPathBufferPtr = itemPathBuffer) {
    _RemoveItem(itemPathBufferPtr);
    pool.Return(itemPathBuffer);

  }
  }
}
