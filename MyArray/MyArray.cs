﻿using System;
using System.Linq;

namespace MyArray
{
    /// <summary>
    /// 自訂義陣列
    /// </summary>
    public class MyArray
    {
        private const int SizeOfInt = sizeof(int);
        private int[] m_Items;

        /// <summary>
        /// 自訂義陣列存放的元素長度
        /// </summary>
        public int Length { get; private set; } = 0;

        /// <summary>
        /// 取得或設定指定索引的元素
        /// </summary>
        /// <param name="index">索引</param>
        public int this[int index]
        {
            get
            {
                if (index < 0 || index > Length)
                    throw new IndexOutOfRangeException();

                return m_Items[index];
            }

            set
            {
                if (index < 0 || index > Length)
                    throw new IndexOutOfRangeException();

                m_Items[index] = value;
            }
        }

        /// <summary>
        /// 建構子
        /// </summary>
        /// <param name="size">內存的陣列初始大小</param>
        public MyArray(int size = 16)
        {
            m_Items = new int[size];
        }

        /// <summary>
        /// 將數字插入到自定義陣列中
        /// </summary>
        /// <param name="index">索引</param>
        /// <param name="item">數字</param>
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

        /// <summary>
        /// 將自定義陣列的內容輸出成陣列
        /// </summary>
        /// <returns></returns>
        public int[] ToArray()
        {
            return m_Items.Take(Length).ToArray();
        }
    }
}
