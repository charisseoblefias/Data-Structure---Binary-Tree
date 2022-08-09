using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Binary_Tree
{
    public partial class Form1 : Form
    {
        Binary_Tree Btree = new Binary_Tree();
        Pen line = new Pen(Brushes.Black, (float)3.5);
        private const int nodeSize = 40;
        int[] NUM = new int[1000];
        int nNum = 0;
        public int NodeSize
        {
            get { return nodeSize; }
        }
        public Form1()
        {
            InitializeComponent();
            txtBoxAdd.Focus();
            line.StartCap = System.Drawing.Drawing2D.LineCap.ArrowAnchor;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            btnAdd.Focus();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            try
            {
                int data = Int32.Parse(txtBoxAdd.Text);

                Tree_Node tmp = new Tree_Node();
                tmp = Btree.Root;

                int canAdd = 0;
                tmp.AddNode(ref tmp, data, ref canAdd);

                if (canAdd == 1)
                {
                    NUM[nNum++] = data;

                    Btree.TotalNodes++;
                    lblTotalNodes.Text = $"Total nodes: {Btree.TotalNodes}";

                    int xCoor = 0;
                    DoNode(tmp, ref xCoor);

                    pnlSimulation.Controls.Clear();
                    pnlSimulation.Invalidate();

                    DrawTree(tmp);
                }

            }
            catch (FormatException)
            {
                MessageBox.Show("Input number!", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            txtBoxAdd.Clear();
            txtBoxAdd.Focus();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (Btree.TotalNodes == 0)
            {
                MessageBox.Show("Tree is empty!", "Invalid delete.", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                try
                {
                    int data = Int32.Parse(txtBoxDelete.Text);

                    Tree_Node tmp = new Tree_Node();
                    tmp = Btree.Root;

                    int canDel = 0;
                    tmp.DeleteNode(ref tmp, ref canDel, data);

                    Btree.Root = tmp;

                    if (canDel > 0)
                    {
                        Btree.TotalNodes--;
                        lblTotalNodes.Text = $"Total nodes: {Btree.TotalNodes}";

                        pnlSimulation.Controls.Clear();
                        pnlSimulation.Invalidate();

                        if (canDel != 2)
                        {
                            for (int i = 0; i < nNum; i++)
                            {
                                if (NUM[i] == data)
                                {
                                    for (int j = i; j < nNum - 1; j++)
                                    {
                                        NUM[j] = NUM[j + 1];
                                    }
                                    nNum--;
                                    break;
                                }
                            }
                            int xCoor = 0;
                            DoNode(tmp, ref xCoor);
                            DrawTree(tmp);
                        }
                        else
                        {
                            Btree = new Binary_Tree();
                            NUM = new int[1000];
                            nNum = 0;
                        }
                    }
                }
                catch (FormatException)
                {
                    MessageBox.Show("Input number!", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            txtBoxDelete.Clear();
            txtBoxDelete.Focus();
        }

        private void btnFind_Click(object sender, EventArgs e)
        {
            if (Btree.TotalNodes == 0)
            {
                MessageBox.Show("Tree is empty!", "Invalid find.", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                try
                {
                    int data = Int32.Parse(txtBoxFind.Text);

                    Btree.Root.SearchNode(Btree.Root, data, this);
                }
                catch (FormatException)
                {
                    MessageBox.Show("Input number!", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            txtBoxFind.Clear();
            txtBoxFind.Focus();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            pnlSimulation.Controls.Clear();
            pnlSimulation.Invalidate();
            Btree = new Binary_Tree();
            NUM = new int[1000];
            nNum = 0;
            lblTotalNodes.Text = $"Total nodes: {Btree.TotalNodes}";
            txtBoxResult.Clear();
        }

        private void btnInorder_Click(object sender, EventArgs e)
        {
            try
            {
                if (Btree.TotalNodes != 0)
                {
                    txtBoxResult.Clear();
                    int delay;
                    if (Btree.TotalNodes >= 20)
                        delay = 100;
                    else
                        delay = 400;
                    Btree.Root.Inorder(Btree.Root, this, delay);
                    txtBoxResult.Text = Btree.Root.ResultText;
                    Btree.Root.ResultText = "";
                    pnlSimulation.Invalidate();
                }
                else
                {
                    MessageBox.Show("Tree is empty!", "Invalid delete.", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception)
            {
                btnClear.PerformClick();
                MessageBox.Show("Something wrong just happenned!\nThe application has been refreshed.", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnPreorder_Click(object sender, EventArgs e)
        {
            try
            {
                if (Btree.TotalNodes != 0)
                {
                    txtBoxResult.Clear();
                    int delay;
                    if (Btree.TotalNodes >= 20)
                        delay = 100;
                    else
                        delay = 400;
                    Btree.Root.Preorder(Btree.Root, this, delay);
                    txtBoxResult.Text = Btree.Root.ResultText;
                    Btree.Root.ResultText = "";
                    pnlSimulation.Invalidate();
                }
                else
                {
                    MessageBox.Show("Tree is empty!", "Invalid search.", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception)
            {
                btnClear.PerformClick();
                MessageBox.Show("Something wrong just happenned!\nThe application has been refreshed.", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnPostorder_Click(object sender, EventArgs e)
        {
            try
            {
                if (Btree.TotalNodes != 0)
                {
                    txtBoxResult.Clear();
                    int delay;
                    if (Btree.TotalNodes >= 20)
                        delay = 100;
                    else
                        delay = 400;
                    Btree.Root.Postorder(Btree.Root, this, delay);
                    txtBoxResult.Text = Btree.Root.ResultText;
                    Btree.Root.ResultText = "";
                    pnlSimulation.Invalidate();
                }
                else
                {
                    MessageBox.Show("Tree is empty!", "Invalid delete.", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception)
            {
                btnClear.PerformClick();
                MessageBox.Show("Something wrong just happenned!\nThe application has been refreshed.", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void txtBoxAdd_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btnAdd.PerformClick();
            }
        }

        private void txtBoxDelete_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btnDelete.PerformClick();
            }
        }

        private void txtBoxFind_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btnFind.PerformClick();
            }
        }

        private void txtBoxAdd_TextChanged(object sender, EventArgs e)
        {
            try
            {
                int x = Int32.Parse(txtBoxAdd.Text);
                if (x <= 0)
                    txtBoxAdd.Text = "1";
                else if (x >= 1000)
                    txtBoxAdd.Text = "999";
            }
            catch (FormatException)
            {
            }
        }
        private void DrawArrow(Tree_Node tree)
        {
            if (tree != null)
            {
                if (tree.Level != 0)
                {
                    int x1 = (tree.X + nodeSize / 2) - pnlSimulation.HorizontalScroll.Value;
                    int y1 = tree.Y - pnlSimulation.VerticalScroll.Value;
                    int x2 = (tree.Parent.X + nodeSize / 2) - pnlSimulation.HorizontalScroll.Value;
                    int y2 = (tree.Parent.Y + nodeSize - 1) - pnlSimulation.VerticalScroll.Value;
                    Graphics g = pnlSimulation.CreateGraphics();
                    g.DrawLine(line, x1, y1, x2, y2);
                }

                if (tree.Left != null)
                {
                    DrawArrow(tree.Left);
                }
                if (tree.Right != null)
                {
                    DrawArrow(tree.Right);
                }
            }
        }
        private void DrawTree(Tree_Node tree)
        {
            Label lbl = CreateANode(tree);
            pnlSimulation.Controls.Add(lbl);

            if (tree.Left != null)
            {
                DrawTree(tree.Left);
            }
            if (tree.Right != null)
            {
                DrawTree(tree.Right);
            }

        }
        private Label CreateANode
            (Tree_Node tmp)
        {
            Label lbl = new Label();
            lbl.Text = tmp.Data.ToString();
            lbl.TextAlign = ContentAlignment.MiddleCenter;
            lbl.ForeColor = System.Drawing.Color.Black;
            lbl.Location = new System.Drawing.Point(tmp.X, tmp.Y);
            lbl.BackColor = System.Drawing.Color.PowderBlue;
            lbl.BorderStyle = System.Windows.Forms.BorderStyle.None;
            lbl.Font = new System.Drawing.Font("Century Gothic", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            lbl.Size = new System.Drawing.Size(nodeSize, nodeSize);
            return lbl;
        }
        private void DoNode(Tree_Node tree, ref int xCoor)
        {
            if (tree.Left != null)
                DoNode(tree.Left, ref xCoor);

            tree.X = Btree.RootTreeX + xCoor * (nodeSize + 15);
            tree.Y = Btree.RootTreeY + tree.Level * (nodeSize + 20);
            xCoor++;

            if (tree.Right != null)
                DoNode(tree.Right, ref xCoor);

        }

        private void pnlSimulation_Scroll(object sender, ScrollEventArgs e)
        {
            pnlSimulation.Invalidate();
        }

        private void pnlSimulation_Paint(object sender, PaintEventArgs e)
        {
            DrawArrow(Btree.Root);
        }
    }
    class Binary_Tree
    {
        Tree_Node root;
        int totalNodes = 0;
        const int rootTreeX = 50;
        const int rootTreeY = 15;

        public Binary_Tree()
        {
            Tree_Node tmp = new Tree_Node();
            tmp.Data = 0;
            tmp.Level = 0;
            tmp.X = rootTreeX;
            tmp.Y = rootTreeY;
            root = tmp;
        }
        public Tree_Node Root
        {
            get { return root; }
            set { root = value; }
        }
        public int TotalNodes
        {
            get { return totalNodes; }
            set { totalNodes = value; }
        }
        public int RootTreeX
        {
            get { return rootTreeX; }
        }
        public int RootTreeY
        {
            get { return rootTreeY; }
        }
    }
    class Tree_Node
    {
        int data;
        int level;
        Tree_Node left;
        Tree_Node right;
        Tree_Node parent;

        int x;
        int y;
        string resultText = "";

        public Tree_Node Left
        {
            get { return left; }
            set { left = value; }
        }
        public Tree_Node Right
        {
            get { return right; }
            set { right = value; }
        }
        public Tree_Node Parent
        {
            get { return parent; }
            set { parent = value; }
        }
        public int Data
        {
            get { return data; }
            set { this.data = value; }
        }
        public int Level
        {
            get { return level; }
            set { level = value; }
        }
        public int X
        {
            get { return x; }
            set { x = value; }
        }
        public int Y
        {
            get { return y; }
            set { y = value; }
        }
        public string ResultText
        {
            get { return resultText; }
            set { resultText = value; }
        }

        public Tree_Node()
        {
        }
        public Tree_Node(Tree_Node tree)
        {
            data = 0;
            parent = tree;
            level = tree.level + 1;
        }
        public void AddNode(ref Tree_Node tree, int data, ref int canAdd)
        {
            if (tree.data == 0)
            {
                tree.data = data;
                canAdd = 1;
            }
            else
            {
                if (data < tree.data)
                {
                    if (tree.left == null)
                    {
                        Tree_Node tmp = new Tree_Node(tree);
                        tree.left = tmp;
                    }
                    AddNode(ref tree.left, data, ref canAdd);
                }
                else if (data >= tree.data)
                {
                    if (tree.right == null)
                    {
                        Tree_Node tmp = new Tree_Node(tree);
                        tree.right = tmp;
                    }
                    AddNode(ref tree.right, data, ref canAdd);
                }
                else
                {
                    canAdd = 0;
                    MessageBox.Show($"Node { data } already in tree!", "Warning!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
        }
        public void AddNode(ref Tree_Node tree, int data)
        {
            if (tree.data == 0)
            {
                tree.data = data;
            }
            else
            {
                if (data < tree.data)
                {
                    if (tree.left == null)
                    {
                        Tree_Node tmp = new Tree_Node(tree);
                        tree.left = tmp;
                    }
                    AddNode(ref tree.left, data);
                }
                else if (data > tree.data)
                {
                    if (tree.right == null)
                    {
                        Tree_Node tmp = new Tree_Node(tree);
                        tree.right = tmp;
                    }
                    AddNode(ref tree.right, data);
                }
            }
        }
        public async void SearchNode(Tree_Node tree, int data, Form1 form1)
        {
            if (tree == null)
            {
                MessageBox.Show($"Tree don't have node { data }", "Result", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                if (tree.data != data)
                {
                    CreateNode(tree, Color.Red, form1);
                    await Task.Delay(500);
                }
                else
                {
                    CreateNode(tree, Color.Blue, form1);
                    var result = MessageBox.Show($"Found node {data}", "Result", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    if (result == DialogResult.OK)
                    {
                        form1.pnlSimulation.Invalidate();
                    }
                }
                if (data < tree.data)
                {
                    SearchNode(tree.left, data, form1);
                }

                else if (data > tree.data)
                {
                    SearchNode(tree.right, data, form1);
                }
            }
        }
        public void DeleteNode(ref Tree_Node tree, ref int canDel, int data)
        {
            if (tree == null)
            {
                MessageBox.Show($"Tree don't have node { data } to delete!", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            else
            {
                if (data < tree.data)
                {
                    DeleteNode(ref tree.left, ref canDel, data);
                }

                else if (data > tree.data)
                {
                    DeleteNode(ref tree.right, ref canDel, data);
                }

                else
                {
                    if (tree.left == null && tree.right == null)
                    {
                        if (tree.level != 0)
                        {
                            if (tree.parent.left != null && tree.parent.left.data == tree.data)
                                tree.parent.left = null;
                            else
                                tree.parent.right = null;
                        }
                        else
                        {
                            canDel = 2;
                            return;
                        }
                        canDel = 1;
                    }
                    else if (tree.left == null)
                    {
                        if (tree.level != 0)
                        {
                            tree.right.parent = tree.parent;

                            if (tree.parent.left != null && tree.parent.left.data == tree.data)
                                tree.parent.left = tree.right;
                            else
                                tree.parent.right = tree.right;
                        }
                        else
                        {
                            tree = tree.right;
                            tree.parent = null;
                            tree.level = 0;
                        }

                        correctLevel(ref tree);
                        canDel = 1;
                    }
                    else if (tree.right == null)
                    {
                        if (tree.level != 0)
                        {
                            tree.left.parent = tree.parent;

                            if (tree.parent.left != null && tree.parent.left.data == tree.data)
                                tree.parent.left = tree.left;
                            else
                                tree.parent.right = tree.left;
                        }
                        else
                        {
                            tree = tree.left;
                            tree.parent = null;
                            tree.level = 0;
                        }

                        correctLevel(ref tree);
                        canDel = 1;
                    }
                    else
                    {
                        Tree_Node tmp = tree.right;

                        if (tmp.left == null)
                        {
                            tree.data = tmp.data;

                            if (tmp.right == null)
                                tree.right = null;
                            else
                            {
                                tmp.right.parent = tree;
                                tree.right = tmp.right;
                            }

                            correctLevel(ref tree);
                        }
                        else
                        {
                            while (tmp.left != null)
                            {
                                tmp = tmp.left;
                            }
                            tree.data = tmp.data;

                            if (tmp.right != null)
                            {
                                tmp.right.parent = tmp.parent;
                                tmp.parent.left = tmp.right;
                                correctLevel(ref tmp.right);
                            }
                            else
                            {
                                tmp.parent.left = null;
                            }
                        }
                        canDel = 1;
                    }
                }
            }
        }
        public void Preorder(Tree_Node tree, Form1 form1, int delay)
        {
            if (tree != null)
            {
                CreateNode(tree, Color.Blue, form1);
                resultText += resultText.Equals("") ? tree.data.ToString() : $", {tree.data}";
                Thread.Sleep(delay);
                Preorder(tree.left, form1, delay);
                Preorder(tree.right, form1, delay);

            }
        }
        public void Postorder(Tree_Node tree, Form1 form1, int delay)
        {
            if (tree != null)
            {
                Postorder(tree.left, form1, delay);
                Postorder(tree.right, form1, delay);
                CreateNode(tree, Color.Blue, form1);
                resultText += resultText.Equals("") ? tree.data.ToString() : $", {tree.data}";
                Thread.Sleep(delay);
            }
        }
        public void Inorder(Tree_Node tree, Form1 form1, int delay)
        {
            if (tree != null)
            {
                Inorder(tree.left, form1, delay);
                CreateNode(tree, Color.Blue, form1);
                resultText += resultText.Equals("") ? tree.data.ToString() : $", {tree.data}";
                Thread.Sleep(delay);
                Inorder(tree.right, form1, delay);
            }
        }
        private void correctLevel(ref Tree_Node tree)
        {
            if (tree.level != 0)
                tree.level = tree.parent.level + 1;

            if (tree.left != null)
                correctLevel(ref tree.left);
            if (tree.right != null)
                correctLevel(ref tree.right);
        }
        private void CreateNode(Tree_Node tmp, Color color, Form1 form1)
        {
            SolidBrush mybrush = new SolidBrush(color);
            Pen mypen = new Pen(mybrush, 7);
            Graphics g = form1.pnlSimulation.CreateGraphics();
            g.DrawRectangle(mypen, tmp.x - 1, tmp.y - 1, form1.NodeSize + 2, form1.NodeSize + 2);

        }
    }
}
