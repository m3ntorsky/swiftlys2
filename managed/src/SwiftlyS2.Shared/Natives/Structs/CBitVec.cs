using System.Runtime.InteropServices;

namespace SwiftlyS2.Shared.Natives;

[StructLayout(LayoutKind.Sequential)]
public struct CBitVec
{
    public uint[] Ints;

    public CBitVec(uint bits)
    {
        Ints = new uint[(bits + (32 - 1)) / 32];
    }

    public bool IsFixedSize() => true;
    public uint NumDWords() => (uint)Ints.Length;
    public uint GetNumBits() => (uint)(Ints.Length * 32 - 31);

    public void ClearAll()
    {
        for (int i = 0; i < Ints.Length; i++) Ints[i] = 0;
    }

    public void SetAll()
    {
        for (int i = 0; i < Ints.Length; i++) Ints[i] = uint.MaxValue;
    }

    public void Set(uint index)
    {
        if ((index >> 5) > Ints.Length) throw new IndexOutOfRangeException($"The index provided is out of range, it goes to Ints[{index >> 5}], but the limit is {Ints.Length}");

        unsafe
        {
            fixed (uint* ptr = Ints)
            {
                Ints[index >> 5] |= (uint)(1 << ((int) index & 31));
            }
        }
    }

    public void Set(int index)
    {
        if ((index >> 5) > Ints.Length) throw new IndexOutOfRangeException($"The index provided is out of range, it goes to Ints[{index >> 5}], but the limit is {Ints.Length}");

        unsafe
        {
            fixed (uint* ptr = Ints)
            {
                Ints[index >> 5] |= (uint)(1 << (index & 31));
            }
        }
    }

    public void Clear(uint index)
    {
        if ((index >> 5) > Ints.Length) throw new IndexOutOfRangeException($"The index provided is out of range, it goes to Ints[{index >> 5}], but the limit is {Ints.Length}");

        unsafe
        {
            fixed (uint* ptr = Ints)
            {
                Ints[index >> 5] &= ~(uint)(1 << ((int)index & 31));
            }
        }
    }

    public void Clear(int index)
    {
        if ((index >> 5) > Ints.Length) throw new IndexOutOfRangeException($"The index provided is out of range, it goes to Ints[{index >> 5}], but the limit is {Ints.Length}");

        unsafe
        {
            fixed (uint* ptr = Ints)
            {
                Ints[index >> 5] &= ~(uint)(1 << (index & 31));
            }
        }
    }

    public bool IsSet(uint index)
    {
        if ((index >> 5) > Ints.Length) throw new IndexOutOfRangeException($"The index provided is out of range, it goes to Ints[{index >> 5}], but the limit is {Ints.Length}");

        unsafe
        {
            fixed (uint* ptr = Ints)
            {
                return (Ints[index >> 5] & ((uint)(1 << ((int)index & 31)))) != 0;
            }
        }
    }

    public bool IsSet(int index)
    {
        if ((index >> 5) > Ints.Length) throw new IndexOutOfRangeException($"The index provided is out of range, it goes to Ints[{index >> 5}], but the limit is {Ints.Length}");

        unsafe
        {
            fixed (uint* ptr = Ints)
            {
                return (Ints[index >> 5] & ((uint)(1 << (index & 31)))) != 0;
            }
        }
    }

    public int Count()
    {
        int count = 0;
        for (int i = 0; i < Ints.Length; i++)
        {
            uint v = Ints[i];
            while (v != 0)
            {
                v &= v - 1;
                count++;
            }
        }
        return count;
    }

    public bool IsAllClear()
    {
        return Count() == 0;
    }
};