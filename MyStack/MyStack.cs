namespace CollectionSolutions
{
    /// <summary>
    /// 自定義Stack
    /// </summary>
    public class MyStack
    {
        private MyArray m_Items;

        /// <summary>
        /// 取得Stack保存資料的長度
        /// </summary>
        public int Length => m_Items.Length;

        /// <summary>
        /// 建構子
        /// </summary>
        /// <param name="size">Stack初始大小</param>
        public MyStack(int size = 16)
        {
            m_Items = new MyArray(size);
        }

        /// <summary>
        /// 將一個數字推入Stack
        /// </summary>
        /// <param name="item"></param>
        public void Push(int item)
        {
            m_Items.Insert(m_Items.Length, item);
        }

        /// <summary>
        /// 從Stack取出一個數字
        /// </summary>
        /// <returns></returns>
        public int Pop()
        {
            var lastInex = m_Items.Length - 1;
            var item = m_Items[lastInex];
            m_Items.Remove(lastInex);

            return item;
        }
    }
}
