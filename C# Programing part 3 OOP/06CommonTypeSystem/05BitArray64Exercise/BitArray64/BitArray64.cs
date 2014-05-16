using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

public class BitArray64 : IEnumerable<int>
{
    public ulong Bits { get; private set; }

    public BitArray64(ulong bits = 0)
    {
        this.Bits = bits;
    }

    public int this[int index] 
    {
        get 
        {
            if (index < 0 || index > 63)
            {
                throw new IndexOutOfRangeException("Index must be between 0 and 63!");
            }
            else
            {
                ulong mask = (ulong)(1 << index);

                // find the bit at the given position and return it
                if ((Bits & mask) == 0)
                {
                    return 0;
                }
                else
                {
                    return 1;
                }
            }
        }
        set 
        {
            if (index < 0 || index > 63)
            {
                throw new IndexOutOfRangeException("Index must be between 0 and 63!");
            }

            if (value != 0 && value != 1)
            {
                throw new ArgumentOutOfRangeException("Value must be 0 or 1.");
            }

            ulong mask = (ulong)(1 << index);
            if (value == 1)
            {
                this.Bits = this.Bits | mask;
            }
            else
            {
                this.Bits = this.Bits & mask;
            }
        }
    }

    public override bool Equals(object obj) 
    {
        if (obj == null)
        {
            return false;
        }

        BitArray64 bitArr = obj as BitArray64;
        if (bitArr == null)
        {
            return false;
        }
        return this.Bits == bitArr.Bits;
    }

    public override int GetHashCode()
    {
        return this.Bits.GetHashCode();
    }

    public static bool operator ==(BitArray64 bitArr1, BitArray64 bitArr2)
    {
        return BitArray64.Equals(bitArr1, bitArr2);
    }

    public static bool operator !=(BitArray64 bitArr1, BitArray64 bitArr2)
    {
        return !BitArray64.Equals(bitArr1, bitArr2);
    }

    public override string ToString()
    {
        return Convert.ToString((long)this.Bits, 2).PadLeft(64, '0');
    }

    System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator()
    {
        return (this as IEnumerable<int>).GetEnumerator();
    }

    public IEnumerator<int> GetEnumerator()
    {
        for (int i = 0; i < 64; i++)
        {
            yield return this[i];
        }
    }

}
