using System;
using System.Collections.Generic;
using System.Text;

namespace CollectionSolutions
{
	/// <summary>
	/// Link List
	/// </summary>
	public class MyList
	{
		private MyListNode m_Root;

		/// <summary>
		/// 取得串列的第一個 node
		/// </summary>
		public MyListNode First
		{
			get
			{
				if (m_Root.Next == m_Root)
					return null;
				else
					return m_Root.Next;
			}
		}

		/// <summary>
		/// 取得串列的最後一個 node
		/// </summary>
		public MyListNode Last
		{
			get
			{
				if (m_Root.Previous == m_Root)
					return null;
				else
					return m_Root.Previous;
			}
		}

		/// <summary>
		/// 建構子
		/// </summary>
		public MyList()
		{
			m_Root = new MyListNode();
			m_Root.Next = m_Root;
			m_Root.Previous = m_Root;
		}

		/// <summary>
		/// 將數字加到串列的最後
		/// </summary>
		/// <param name="value">數字</param>
		/// <returns></returns>
		public MyListNode Append(int value)
		{
			return InsertAfter(m_Root.Previous, value);
		}

		/// <summary>
		/// 將數字加到指定節點之後
		/// </summary>
		/// <param name="node">指定節點</param>
		/// <param name="value">數字</param>
		/// <returns></returns>
		public MyListNode InsertAfter(MyListNode node, int value)
		{
			var insertNode = new MyListNode
			{
				Value = value
			};

			var pervNode = node;
			var nextNode = node.Next;

			insertNode.Previous = pervNode;
			insertNode.Next = nextNode;

			pervNode.Next = insertNode;
			nextNode.Previous = insertNode;

			return insertNode;
		}

		/// <summary>
		/// 將數字加到指定節點之前
		/// </summary>
		/// <param name="node">指定節點</param>
		/// <param name="value">數字</param>
		/// <returns></returns>
		public MyListNode InsertBefore(MyListNode node, int value)
		{
			return InsertAfter(node.Previous, value);
		}

		/// <summary>
		/// 找到第一個和數值相等的節點，如果找不到會回傳Null
		/// </summary>
		/// <param name="value">數值</param>
		/// <returns></returns>
		public MyListNode Find(int value)
		{
			var currentNode = m_Root.Next;

			while (currentNode != m_Root)
			{
				if (currentNode.Value == value)
					return currentNode;

				currentNode = currentNode.Next;
			}

			return null;
		}
	}
}
