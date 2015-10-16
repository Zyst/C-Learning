using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BinaryTree
{
    /// <summary>
    /// A binary tree implementation that uses generics and the IComparable interface.
    /// </summary>
    public class Tree<TItem> where TItem : IComparable<TItem>
    {
        public TItem NodeData { get; set; }
        public Tree<TItem> LeftTree { get; set; }
        public Tree<TItem> RightTree { get; set; }

        /// <summary>
        /// Tree constructor, creates the node.
        /// </summary>
        /// <param name="nodeValue">Value the node will take.</param>
        public Tree(TItem nodeValue)
        {
            this.NodeData = nodeValue;
            this.LeftTree = null;
            this.RightTree = null;
        }

        /// <summary>
        /// Inserts a new item into our binary tree using the IComparable interface to determine position.
        /// </summary>
        /// <param name="newItem">The new item to create.</param>
        public void Insert(TItem newItem)
        {
            TItem currentNodeValue = this.NodeData;

            if (currentNodeValue.CompareTo(newItem) > 0)
            {
                // Insert the new item into the left subtree
                if (this.LeftTree == null)
                {
                    this.LeftTree = new Tree<TItem>(newItem);
                }
                else
                {
                    this.LeftTree.Insert(newItem);
                }
            }
            else
            {
                // Insert the new item into the right subtree
                if (this.RightTree == null)
                {
                    this.RightTree = new Tree<TItem>(newItem);
                }
                else
                {
                    this.RightTree.Insert(newItem);
                }
            }
        }

        /// <summary>
        /// Walks through the tree visiting each node in sequence.
        /// </summary>
        /// <returns>Generates a string representation of the data that the tree contains.</returns>
        public string WalkTree()
        {
            string result = "";

            if (this.LeftTree != null)
            {
                result = this.LeftTree.WalkTree();
            }

            result += String.Format(" {0} ", this.NodeData.ToString());

            if (this.RightTree != null)
            {
                result += this.RightTree.WalkTree();
            }

            return result;
        }
    }
}
