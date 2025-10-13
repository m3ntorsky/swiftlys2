using System.Runtime.InteropServices;

namespace SwiftlyS2.Shared.Natives;

[StructLayout(LayoutKind.Sequential)]
public struct CUtlMap<TKey, TValue> : IDisposable
    where TKey : unmanaged
    where TValue : unmanaged
{
    public CUtlRBTree<CUtlMapTreeNode<TKey, TValue>, int> Tree;

    public CUtlMap(int growSize, int initSize, CUtlRBTree<CUtlMapTreeNode<TKey, TValue>, int>.LessFunc func)
    {
        Tree = new CUtlRBTree<CUtlMapTreeNode<TKey, TValue>, int>(growSize, initSize, func);
    }

    public CUtlMap(CUtlRBTree<CUtlMapTreeNode<TKey, TValue>, int>.LessFunc func)
    {
        Tree = new CUtlRBTree<CUtlMapTreeNode<TKey, TValue>, int>(func);
    }

    public void EnsureCapacity(int num)
    {
        Tree.EnsureCapacity(num);
    }

    public ref TValue this[int idx] => ref Tree[idx].Element;
    public ref TKey Key(int idx) => ref Tree[idx].Key;
    public int Count => (int)Tree.Count;
    public int MaxElement => (int)Tree.MaxElement;
    public bool IsValidIndex(int idx) => Tree.IsValidIndex(idx);
    public bool IsValid() => Tree.IsValid();
    public int InvalidIndex() => Tree.InvalidIndex();
    public void SetLessFunc(CUtlRBTree<CUtlMapTreeNode<TKey, TValue>, int>.LessFunc func) => Tree.SetLessFunc(func);
    public int Insert(TKey key, TValue element) => Tree.Insert(new CUtlMapTreeNode<TKey, TValue> { Key = key, Element = element });
    public int Insert(TKey key) => Tree.Insert(new CUtlMapTreeNode<TKey, TValue> { Key = key });
    public int Find(TKey key)
    {
        var node = new CUtlMapTreeNode<TKey, TValue> { Key = key };
        return Tree.Find(node);
    }
    public void RemoveAt(int idx) => Tree.RemoveAt(idx);
    public bool Remove(TKey key)
    {
        var node = new CUtlMapTreeNode<TKey, TValue> { Key = key };
        return Tree.Remove(node);
    }
    public void RemoveAll() => Tree.RemoveAll();
    public void Purge() => Tree.Purge();
    public int FirstInOrdered() => Tree.FirstInorder();
    public int NextInOrdered(int idx) => Tree.NextInorder(idx);
    public int PrevInOrdered(int idx) => Tree.PrevInorder(idx);
    public int LastInOrdered() => Tree.LastInorder();

    public void Reinsert(TKey key, int idx)
    {
        Tree[idx].Key = key;
        Tree.Reinsert(idx);
    }

    public int InsertOrReplace(TKey key, TValue element)
    {
        var node = new CUtlMapTreeNode<TKey, TValue> { Key = key };
        var idx = Tree.Find(node);
        if (idx != Tree.InvalidIndex())
        {
            Tree[idx].Element = element;
            return idx;
        }
        return Tree.Insert(new CUtlMapTreeNode<TKey, TValue> { Key = key, Element = element });
    }

    public void Dispose()
    {
        Purge();
    }
}