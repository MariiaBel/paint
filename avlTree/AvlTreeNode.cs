using System;

namespace Paint1.avlTree
{
    class AVLTreeNode<TNode> : IComparable<TNode> where TNode : IComparable
    {
        AVLTree<TNode> tree;
        AVLTreeNode<TNode> left,
                           right;

        public AVLTreeNode(TNode value, AVLTreeNode<TNode> parent, AVLTree<TNode> tree)
        {
            this.Value = value;
            this.Parent = parent;
            this.tree = tree;
        }

        public AVLTreeNode<TNode> Left
        {
            get
            {
                return left;
            }
            internal set
            {
                left = value;
                if (left != null) left.Parent = this;
            }
        }

        public AVLTreeNode<TNode> Right
        {
            get
            {
                return right;
            }
            internal set
            {
                right = value;
                if (right != null) right.Parent = this;
            }

        }

        public AVLTreeNode<TNode> Parent
        {
            get;
            internal set;
        }

        public TNode Value
        {
            get;
            private set;
        }

        private int LeftHeight
        {
            get
            {
                return MaxChildHeight(Left);
            }
        }

        private int RightHeight
        {
            get
            {
                return MaxChildHeight(Right);
            }
        }

        private int MaxChildHeight(AVLTreeNode<TNode> node)
        {
            if (node != null) return 1 + Math.Max(MaxChildHeight(node.Left), MaxChildHeight(node.Right));
            return 0;
        }

        private TreeState State
        {
            get
            {
                if (LeftHeight - RightHeight > 1) return TreeState.LeftHeavy;
                if (RightHeight - LeftHeight > 1) return TreeState.RightHeavy;
                return TreeState.Balanced;

            }
        }

        private int BalanceFactory
        {
            get
            {
                return RightHeight - LeftHeight;
            }
        }

        enum TreeState
        {
            Balanced,
            LeftHeavy,
            RightHeavy,
        }

        internal void Balance()
        {
            if (State == TreeState.RightHeavy)
            {
                if (Right != null && Right.BalanceFactory < 0) LeftRightBalance();
                else LeftRotation();
            }
            else if (State == TreeState.LeftHeavy)
            {
                if (Left != null && Left.BalanceFactory > 0) RightLeftBalance();
                else RightRotation();
            }
        }

        private void RightRotation()
        {
            //throw new NotImplementedException();
        }

        private void RightLeftBalance()
        {
            //throw new NotImplementedException();
        }

        private void LeftRotation()
        {
            AVLTreeNode<TNode> newRoot = Right;
            ReplaceRoot(newRoot);
            Right = newRoot.Left;
            newRoot.Left = this;
        }

        private void LeftRightBalance()
        {
            //throw new NotImplementedException();
        }

        private void ReplaceRoot(AVLTreeNode<TNode> newRoot)
        {
            if (this.Parent != null)
            {
                if (this.Parent.Left == this) this.Parent.Left = newRoot;
                else if (this.Parent.Right == this) this.Parent.Right = newRoot;
            }
            else tree.Head = newRoot;
            newRoot.Parent = this.Parent;
            this.Parent = newRoot;
        }

        public int CompareTo(TNode other)
        {
            return Value.CompareTo(other);
        }
    }
}
