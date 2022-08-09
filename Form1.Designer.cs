
namespace Binary_Tree
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblTotalNodes = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnPostorder = new System.Windows.Forms.Button();
            this.btnPreorder = new System.Windows.Forms.Button();
            this.btnInorder = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnFind = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.txtBoxResult = new System.Windows.Forms.TextBox();
            this.txtBoxFind = new System.Windows.Forms.TextBox();
            this.txtBoxDelete = new System.Windows.Forms.TextBox();
            this.txtBoxAdd = new System.Windows.Forms.TextBox();
            this.pnlSimulation = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.LightSteelBlue;
            this.panel1.Controls.Add(this.lblTotalNodes);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.btnPostorder);
            this.panel1.Controls.Add(this.btnPreorder);
            this.panel1.Controls.Add(this.btnInorder);
            this.panel1.Controls.Add(this.btnClear);
            this.panel1.Controls.Add(this.btnFind);
            this.panel1.Controls.Add(this.btnDelete);
            this.panel1.Controls.Add(this.btnAdd);
            this.panel1.Controls.Add(this.txtBoxResult);
            this.panel1.Controls.Add(this.txtBoxFind);
            this.panel1.Controls.Add(this.txtBoxDelete);
            this.panel1.Controls.Add(this.txtBoxAdd);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel1.Location = new System.Drawing.Point(607, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(250, 529);
            this.panel1.TabIndex = 5;
            // 
            // lblTotalNodes
            // 
            this.lblTotalNodes.AutoSize = true;
            this.lblTotalNodes.BackColor = System.Drawing.Color.Transparent;
            this.lblTotalNodes.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalNodes.Location = new System.Drawing.Point(65, 487);
            this.lblTotalNodes.Name = "lblTotalNodes";
            this.lblTotalNodes.Size = new System.Drawing.Size(109, 20);
            this.lblTotalNodes.TabIndex = 4;
            this.lblTotalNodes.Text = "Total Nodes: 0";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(65, 376);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(114, 20);
            this.label1.TabIndex = 3;
            this.label1.Text = "Search Result: ";
            // 
            // btnPostorder
            // 
            this.btnPostorder.BackColor = System.Drawing.Color.DodgerBlue;
            this.btnPostorder.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnPostorder.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPostorder.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPostorder.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnPostorder.Location = new System.Drawing.Point(56, 328);
            this.btnPostorder.Name = "btnPostorder";
            this.btnPostorder.Size = new System.Drawing.Size(140, 34);
            this.btnPostorder.TabIndex = 1;
            this.btnPostorder.Text = "Postorder";
            this.btnPostorder.UseVisualStyleBackColor = false;
            this.btnPostorder.Click += new System.EventHandler(this.btnPostorder_Click);
            // 
            // btnPreorder
            // 
            this.btnPreorder.BackColor = System.Drawing.Color.DodgerBlue;
            this.btnPreorder.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnPreorder.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPreorder.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPreorder.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnPreorder.Location = new System.Drawing.Point(56, 283);
            this.btnPreorder.Name = "btnPreorder";
            this.btnPreorder.Size = new System.Drawing.Size(140, 34);
            this.btnPreorder.TabIndex = 1;
            this.btnPreorder.Text = "Preorder";
            this.btnPreorder.UseVisualStyleBackColor = false;
            this.btnPreorder.Click += new System.EventHandler(this.btnPreorder_Click);
            // 
            // btnInorder
            // 
            this.btnInorder.BackColor = System.Drawing.Color.DodgerBlue;
            this.btnInorder.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnInorder.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnInorder.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnInorder.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnInorder.Location = new System.Drawing.Point(56, 238);
            this.btnInorder.Name = "btnInorder";
            this.btnInorder.Size = new System.Drawing.Size(140, 34);
            this.btnInorder.TabIndex = 1;
            this.btnInorder.Text = "Inorder";
            this.btnInorder.UseVisualStyleBackColor = false;
            this.btnInorder.Click += new System.EventHandler(this.btnInorder_Click);
            // 
            // btnClear
            // 
            this.btnClear.BackColor = System.Drawing.Color.DodgerBlue;
            this.btnClear.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnClear.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClear.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClear.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnClear.Location = new System.Drawing.Point(84, 170);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(75, 34);
            this.btnClear.TabIndex = 1;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = false;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // btnFind
            // 
            this.btnFind.BackColor = System.Drawing.Color.DodgerBlue;
            this.btnFind.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnFind.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFind.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFind.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnFind.Location = new System.Drawing.Point(150, 126);
            this.btnFind.Name = "btnFind";
            this.btnFind.Size = new System.Drawing.Size(85, 33);
            this.btnFind.TabIndex = 1;
            this.btnFind.Text = "Find";
            this.btnFind.UseVisualStyleBackColor = false;
            this.btnFind.Click += new System.EventHandler(this.btnFind_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.BackColor = System.Drawing.Color.DodgerBlue;
            this.btnDelete.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDelete.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDelete.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnDelete.Location = new System.Drawing.Point(150, 87);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(85, 33);
            this.btnDelete.TabIndex = 1;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = false;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.BackColor = System.Drawing.Color.DodgerBlue;
            this.btnAdd.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAdd.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdd.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnAdd.Location = new System.Drawing.Point(150, 46);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(85, 33);
            this.btnAdd.TabIndex = 1;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = false;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // txtBoxResult
            // 
            this.txtBoxResult.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBoxResult.Location = new System.Drawing.Point(15, 412);
            this.txtBoxResult.Multiline = true;
            this.txtBoxResult.Name = "txtBoxResult";
            this.txtBoxResult.ReadOnly = true;
            this.txtBoxResult.Size = new System.Drawing.Size(220, 34);
            this.txtBoxResult.TabIndex = 0;
            this.txtBoxResult.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtBoxFind
            // 
            this.txtBoxFind.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtBoxFind.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBoxFind.Location = new System.Drawing.Point(25, 131);
            this.txtBoxFind.Multiline = true;
            this.txtBoxFind.Name = "txtBoxFind";
            this.txtBoxFind.Size = new System.Drawing.Size(118, 25);
            this.txtBoxFind.TabIndex = 0;
            this.txtBoxFind.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtBoxFind.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtBoxFind_KeyDown);
            // 
            // txtBoxDelete
            // 
            this.txtBoxDelete.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtBoxDelete.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBoxDelete.Location = new System.Drawing.Point(25, 90);
            this.txtBoxDelete.Multiline = true;
            this.txtBoxDelete.Name = "txtBoxDelete";
            this.txtBoxDelete.Size = new System.Drawing.Size(118, 25);
            this.txtBoxDelete.TabIndex = 0;
            this.txtBoxDelete.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtBoxDelete.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtBoxDelete_KeyDown);
            // 
            // txtBoxAdd
            // 
            this.txtBoxAdd.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtBoxAdd.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBoxAdd.Location = new System.Drawing.Point(26, 49);
            this.txtBoxAdd.Multiline = true;
            this.txtBoxAdd.Name = "txtBoxAdd";
            this.txtBoxAdd.Size = new System.Drawing.Size(118, 25);
            this.txtBoxAdd.TabIndex = 0;
            this.txtBoxAdd.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtBoxAdd.TextChanged += new System.EventHandler(this.txtBoxAdd_TextChanged);
            this.txtBoxAdd.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtBoxAdd_KeyDown);
            // 
            // pnlSimulation
            // 
            this.pnlSimulation.BackColor = System.Drawing.Color.AliceBlue;
            this.pnlSimulation.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlSimulation.Font = new System.Drawing.Font("Century Gothic", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pnlSimulation.Location = new System.Drawing.Point(0, 0);
            this.pnlSimulation.Name = "pnlSimulation";
            this.pnlSimulation.Size = new System.Drawing.Size(857, 529);
            this.pnlSimulation.TabIndex = 4;
            this.pnlSimulation.Scroll += new System.Windows.Forms.ScrollEventHandler(this.pnlSimulation_Scroll);
            this.pnlSimulation.Paint += new System.Windows.Forms.PaintEventHandler(this.pnlSimulation_Paint);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(857, 529);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.pnlSimulation);
            this.Name = "Form1";
            this.Text = "Binary Tree";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblTotalNodes;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnPostorder;
        private System.Windows.Forms.Button btnPreorder;
        private System.Windows.Forms.Button btnInorder;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnFind;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnAdd;
        public System.Windows.Forms.TextBox txtBoxResult;
        public System.Windows.Forms.TextBox txtBoxFind;
        public System.Windows.Forms.TextBox txtBoxDelete;
        public System.Windows.Forms.TextBox txtBoxAdd;
        public System.Windows.Forms.Panel pnlSimulation;
    }
}

