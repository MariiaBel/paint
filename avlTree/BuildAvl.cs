using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace Paint1.avlTree
{
    class BuildAvl<TNode>
    {
        AVLTree<int> tree = new AVLTree<int>();
        int levelsSize = 50;
        Text text;

        public BuildAvl (string str) 
        {
            text = new Text();
            tree.Clear();
            AddItemsToTree(str);
        }

        private void AddItemsToTree(string str)
        {
            foreach (var item in Regex.Split(str, @"\s+"))
            {
                if(Int32.TryParse(item, out int itemNumber))
                {
                    tree.Add(Convert.ToInt32(itemNumber));
                }
            }
        }
        public void Build(Bitmap bitmap)
        {
            if (tree.Count == 0) return;
            double levels = Math.Log(tree.Count, 2) + 2;
            levelsSize = bitmap.Height / Convert.ToInt32(levels);
            int pointX = bitmap.Width / 2;
            int pointY = levelsSize / 2;
            int stepSizeX = pointX / 2;
            Point firstPoint = new Point(pointX, pointY);

            DrawItems(bitmap, tree.Head, firstPoint, stepSizeX);          
        }

        private void DrawItems(Bitmap bitmap, AVLTreeNode<int> node, Point centerPoint, int stepSizeX)
        {
            if (node == null) return;

            DrawFigure(new Circle(), bitmap, centerPoint.X, centerPoint.Y, centerPoint.X + settingsAvlBuilding.radius, centerPoint.Y);
            text.Draw(bitmap, node.Value, centerPoint);

            if (node.Left != null)
            {
                Point nextCenterPoint = new Point(centerPoint.X - stepSizeX, centerPoint.Y + levelsSize);
                DrawFigure(new Line(), bitmap, centerPoint.X, centerPoint.Y + settingsAvlBuilding.radius, nextCenterPoint.X, nextCenterPoint.Y - settingsAvlBuilding.radius);
                DrawItems(bitmap, node.Left, nextCenterPoint, stepSizeX / 2);
            }
            if (node.Right != null)
            {
                Point nextCenterPoint = new Point(centerPoint.X + stepSizeX, centerPoint.Y + levelsSize);
                DrawFigure(new Line(), bitmap, centerPoint.X, centerPoint.Y + settingsAvlBuilding.radius, nextCenterPoint.X, nextCenterPoint.Y - settingsAvlBuilding.radius);
                DrawItems(bitmap, node.Right,nextCenterPoint, stepSizeX / 2);
            }
        }

        private void DrawFigure(IFigure figureType, Bitmap bitmap, int x1, int y1, int x2, int y2)
        {
            IFigureBuild figure = new Build(figureType, null);
            figure.MyBitmap = bitmap;
            figure.BuildFigure(x1, y1, x2, y2, true);
        }
    }
}
