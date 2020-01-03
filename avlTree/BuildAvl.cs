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
        
        public BuildAvl (string str) 
        {
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
            double levels = Math.Log(tree.Count, 2) + 2;
            settingsAvlBuilding.levelsSize = bitmap.Height / Convert.ToInt32(levels);
            int pointX = bitmap.Width / 2;
            int pointY = settingsAvlBuilding.levelsSize / 2;
            int stepSize = pointX / 2;
            Point firstPoint = new Point(pointX, pointY);

            DrawItem(bitmap, tree.Head, firstPoint, stepSize);          
        }

        private void DrawItem(Bitmap bitmap, AVLTreeNode<int> node, Point centerPoint, int stepSize)
        {
            if (node == null) return;

            DrawFigure(new Circle(), bitmap, centerPoint.X, centerPoint.Y, centerPoint.X + settingsAvlBuilding.radius, centerPoint.Y);
            DrawText(bitmap, node.Value, centerPoint);

            if (node.Left != null)
            {
                Point nextCenterPoint = new Point(centerPoint.X - stepSize, centerPoint.Y + settingsAvlBuilding.levelsSize);
                DrawFigure(new Line(), bitmap, centerPoint.X, centerPoint.Y + settingsAvlBuilding.radius, nextCenterPoint.X, nextCenterPoint.Y - settingsAvlBuilding.radius);
                DrawItem(bitmap, node.Left, nextCenterPoint, stepSize / 2);
            }
            if (node.Right != null)
            {
                Point nextCenterPoint = new Point(centerPoint.X + stepSize, centerPoint.Y + settingsAvlBuilding.levelsSize);
                DrawFigure(new Line(), bitmap, centerPoint.X, centerPoint.Y + settingsAvlBuilding.radius, nextCenterPoint.X, nextCenterPoint.Y - settingsAvlBuilding.radius);
                DrawItem(bitmap, node.Right,nextCenterPoint, stepSize / 2);
            }
        }

        private void DrawText(Bitmap bitmap, int value, Point centerPoint)
        {
            Graphics graphics = Graphics.FromImage(bitmap);
            Font drawFont = new Font(settingsAvlBuilding.fontFamily, settingsAvlBuilding.fontSize);
            SolidBrush drawBrush = new SolidBrush(Brush.BrushColor);
            StringFormat stringFormat = new StringFormat();
            stringFormat.Alignment = StringAlignment.Center;
            stringFormat.LineAlignment = StringAlignment.Center;

            graphics.DrawString(Convert.ToString(value), drawFont, drawBrush, centerPoint, stringFormat);
        }

        private void DrawFigure(IFigure figureType, Bitmap bitmap, int x1, int y1, int x2, int y2)
        {
            IFigureBuild figure = new Build(figureType, null);
            figure.MyBitmap = bitmap;
            figure.BuildFigure(x1, y1, x2, y2, true);
        }
    }
}
