namespace WindowsFormsApp3
{
    partial class MainForm
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
            System.Windows.Forms.TreeNode treeNode1 = new System.Windows.Forms.TreeNode("Морги для взрослых");
            System.Windows.Forms.TreeNode treeNode2 = new System.Windows.Forms.TreeNode("Морги для детей");
            System.Windows.Forms.TreeNode treeNode3 = new System.Windows.Forms.TreeNode("Морги для животных");
            System.Windows.Forms.TreeNode treeNode4 = new System.Windows.Forms.TreeNode("Морги", new System.Windows.Forms.TreeNode[] {
            treeNode1,
            treeNode2,
            treeNode3});
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.ScreenSplitter = new System.Windows.Forms.SplitContainer();
            this.AppNameLabel = new System.Windows.Forms.Label();
            this.MorgueTreeView = new System.Windows.Forms.TreeView();
            this.MorgueDataGrid = new System.Windows.Forms.DataGridView();
            this.ExitButton = new System.Windows.Forms.Button();
            this.AppLogoPictureBox = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.ScreenSplitter)).BeginInit();
            this.ScreenSplitter.Panel1.SuspendLayout();
            this.ScreenSplitter.Panel2.SuspendLayout();
            this.ScreenSplitter.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.MorgueDataGrid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.AppLogoPictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // ScreenSplitter
            // 
            this.ScreenSplitter.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ScreenSplitter.IsSplitterFixed = true;
            this.ScreenSplitter.Location = new System.Drawing.Point(0, 0);
            this.ScreenSplitter.Name = "ScreenSplitter";
            // 
            // ScreenSplitter.Panel1
            // 
            this.ScreenSplitter.Panel1.Controls.Add(this.AppLogoPictureBox);
            this.ScreenSplitter.Panel1.Controls.Add(this.AppNameLabel);
            this.ScreenSplitter.Panel1.Controls.Add(this.MorgueTreeView);
            // 
            // ScreenSplitter.Panel2
            // 
            this.ScreenSplitter.Panel2.Controls.Add(this.ExitButton);
            this.ScreenSplitter.Panel2.Controls.Add(this.MorgueDataGrid);
            this.ScreenSplitter.Size = new System.Drawing.Size(1091, 584);
            this.ScreenSplitter.SplitterDistance = 391;
            this.ScreenSplitter.TabIndex = 0;
            this.ScreenSplitter.TabStop = false;
            // 
            // AppNameLabel
            // 
            this.AppNameLabel.AutoSize = true;
            this.AppNameLabel.Font = new System.Drawing.Font("SF Pro Display", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AppNameLabel.Location = new System.Drawing.Point(122, 41);
            this.AppNameLabel.Name = "AppNameLabel";
            this.AppNameLabel.Size = new System.Drawing.Size(258, 38);
            this.AppNameLabel.TabIndex = 1;
            this.AppNameLabel.Text = "Данные о моргах";
            // 
            // MorgueTreeView
            // 
            this.MorgueTreeView.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.MorgueTreeView.Font = new System.Drawing.Font("SF Pro Display", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MorgueTreeView.Location = new System.Drawing.Point(0, 113);
            this.MorgueTreeView.Name = "MorgueTreeView";
            treeNode1.Name = "Node1";
            treeNode1.Text = "Морги для взрослых";
            treeNode2.Name = "Node2";
            treeNode2.Text = "Морги для детей";
            treeNode3.Name = "Node3";
            treeNode3.Text = "Морги для животных";
            treeNode4.BackColor = System.Drawing.Color.Silver;
            treeNode4.Name = "Node0";
            treeNode4.Text = "Морги";
            this.MorgueTreeView.Nodes.AddRange(new System.Windows.Forms.TreeNode[] {
            treeNode4});
            this.MorgueTreeView.Size = new System.Drawing.Size(391, 471);
            this.MorgueTreeView.TabIndex = 0;
            this.MorgueTreeView.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.treeView1_AfterSelect);
            // 
            // MorgueDataGrid
            // 
            this.MorgueDataGrid.BackgroundColor = System.Drawing.Color.Silver;
            this.MorgueDataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.MorgueDataGrid.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.MorgueDataGrid.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.MorgueDataGrid.Location = new System.Drawing.Point(0, 113);
            this.MorgueDataGrid.Name = "MorgueDataGrid";
            this.MorgueDataGrid.Size = new System.Drawing.Size(696, 471);
            this.MorgueDataGrid.TabIndex = 0;
            // 
            // ExitButton
            // 
            this.ExitButton.Location = new System.Drawing.Point(562, 41);
            this.ExitButton.Name = "ExitButton";
            this.ExitButton.Size = new System.Drawing.Size(109, 36);
            this.ExitButton.TabIndex = 1;
            this.ExitButton.Text = "Закрыть";
            this.ExitButton.UseVisualStyleBackColor = true;
            this.ExitButton.Click += new System.EventHandler(this.ExitApplication);
            // 
            // AppLogoPictureBox
            // 
            this.AppLogoPictureBox.Image = global::WindowsFormsApp3.Properties.Resources.main;
            this.AppLogoPictureBox.Location = new System.Drawing.Point(20, 25);
            this.AppLogoPictureBox.Name = "AppLogoPictureBox";
            this.AppLogoPictureBox.Size = new System.Drawing.Size(72, 74);
            this.AppLogoPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.AppLogoPictureBox.TabIndex = 2;
            this.AppLogoPictureBox.TabStop = false;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.ClientSize = new System.Drawing.Size(1091, 584);
            this.Controls.Add(this.ScreenSplitter);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MorgueManager";
            this.ScreenSplitter.Panel1.ResumeLayout(false);
            this.ScreenSplitter.Panel1.PerformLayout();
            this.ScreenSplitter.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.ScreenSplitter)).EndInit();
            this.ScreenSplitter.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.MorgueDataGrid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.AppLogoPictureBox)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer ScreenSplitter;
        private System.Windows.Forms.TreeView MorgueTreeView;
        private System.Windows.Forms.DataGridView MorgueDataGrid;
        private System.Windows.Forms.PictureBox AppLogoPictureBox;
        private System.Windows.Forms.Label AppNameLabel;
        private System.Windows.Forms.Button ExitButton;
    }
}

