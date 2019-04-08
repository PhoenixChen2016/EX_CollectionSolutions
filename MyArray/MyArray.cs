using System;
using System.Linq;

namespace MyArray
{
    public class MyArray
    {
        private const int SizeOfInt = sizeof(int);
        private int[] m_Items;

        public int Length { get; private set; } = 0;

        public MyArray(int size = 16)
        {
            m_Items = new int[size];
        }

        public void Insert(int index, int item)
        {
            if (index < 0 || index > Length)
                throw new IndexOutOfRangeException();

            if (Length == m_Items.Length)
            {
                var incrementSize = m_Items.Length * 2;
                if (incrementSize > 128)
                    incrementSize = 128;

                var newItems = new int[incrementSize];

                Buffer.BlockCopy(m_Items, 0, newItems, 0, (index - 1) * SizeOfInt);
                Buffer.BlockCopy(m_Items, index * SizeOfInt, newItems, (index + 1) * SizeOfInt, (Length - index) * SizeOfInt);
                newItems[index] = item;

                m_Items = newItems;
            }
            else
            {
                Buffer.BlockCopy(m_Items, index * SizeOfInt, m_Items, (index + 1) * SizeOfInt, (Length - index) * SizeOfInt);
                m_Items[index] = item;
            }

            Length += 1;
        }

        public int[] ToArray()
        {
            return m_Items.Take(Length).ToArray();
        }
    }
}
