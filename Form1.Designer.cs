namespace Cyanide
{
    partial class CyanideWindow
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CyanideWindow));
            DragBar = new Panel();
            MinimizeBtn = new Button();
            CloseBtn = new Button();
            WindowTitle = new Label();
            ProjectsLabel = new Label();
            ProjectList = new ListBox();
            NewProjectBtn = new Button();
            OpenProjectBtn = new Button();
            BlocklyWindow = new Microsoft.Web.WebView2.WinForms.WebView2();
            DragBar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)BlocklyWindow).BeginInit();
            SuspendLayout();
            // 
            // DragBar
            // 
            DragBar.BackColor = Color.DimGray;
            DragBar.Controls.Add(MinimizeBtn);
            DragBar.Controls.Add(CloseBtn);
            DragBar.Controls.Add(WindowTitle);
            DragBar.Location = new Point(-2, -1);
            DragBar.Name = "DragBar";
            DragBar.Size = new Size(1117, 30);
            DragBar.TabIndex = 0;
            DragBar.MouseDown += DragBar_MouseDown;
            DragBar.MouseMove += DragBar_MouseMove;
            DragBar.MouseUp += DragBar_MouseUp;
            // 
            // MinimizeBtn
            // 
            MinimizeBtn.BackColor = Color.Gray;
            MinimizeBtn.FlatStyle = FlatStyle.Flat;
            MinimizeBtn.Location = new Point(1048, 0);
            MinimizeBtn.Name = "MinimizeBtn";
            MinimizeBtn.Size = new Size(35, 30);
            MinimizeBtn.TabIndex = 2;
            MinimizeBtn.Text = "_";
            MinimizeBtn.UseVisualStyleBackColor = false;
            MinimizeBtn.Click += MinimizeBtn_Click;
            // 
            // CloseBtn
            // 
            CloseBtn.BackColor = Color.Red;
            CloseBtn.FlatStyle = FlatStyle.Flat;
            CloseBtn.Location = new Point(1082, 0);
            CloseBtn.Name = "CloseBtn";
            CloseBtn.Size = new Size(35, 30);
            CloseBtn.TabIndex = 1;
            CloseBtn.Text = "X";
            CloseBtn.UseVisualStyleBackColor = false;
            CloseBtn.Click += CloseBtn_Click;
            // 
            // WindowTitle
            // 
            WindowTitle.AutoSize = true;
            WindowTitle.ForeColor = Color.White;
            WindowTitle.Location = new Point(8, 8);
            WindowTitle.Name = "WindowTitle";
            WindowTitle.Size = new Size(94, 15);
            WindowTitle.TabIndex = 1;
            WindowTitle.Text = "Home - Cyanide";
            // 
            // ProjectsLabel
            // 
            ProjectsLabel.AutoSize = true;
            ProjectsLabel.Font = new Font("Segoe UI", 26.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            ProjectsLabel.ForeColor = Color.White;
            ProjectsLabel.Location = new Point(12, 43);
            ProjectsLabel.Name = "ProjectsLabel";
            ProjectsLabel.Size = new Size(142, 47);
            ProjectsLabel.TabIndex = 1;
            ProjectsLabel.Text = "Projects";
            // 
            // ProjectList
            // 
            ProjectList.BackColor = Color.FromArgb(64, 64, 64);
            ProjectList.BorderStyle = BorderStyle.None;
            ProjectList.Font = new Font("Segoe UI Semibold", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            ProjectList.ForeColor = Color.White;
            ProjectList.FormattingEnabled = true;
            ProjectList.ItemHeight = 30;
            ProjectList.Location = new Point(21, 93);
            ProjectList.Name = "ProjectList";
            ProjectList.Size = new Size(1060, 570);
            ProjectList.TabIndex = 2;
            ProjectList.SelectedIndexChanged += ProjectList_SelectedIndexChanged;
            // 
            // NewProjectBtn
            // 
            NewProjectBtn.BackColor = Color.Gray;
            NewProjectBtn.FlatStyle = FlatStyle.Flat;
            NewProjectBtn.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            NewProjectBtn.ForeColor = Color.White;
            NewProjectBtn.Location = new Point(936, 46);
            NewProjectBtn.Name = "NewProjectBtn";
            NewProjectBtn.Size = new Size(167, 58);
            NewProjectBtn.TabIndex = 3;
            NewProjectBtn.Text = "New Project";
            NewProjectBtn.UseVisualStyleBackColor = false;
            NewProjectBtn.Click += NewProjectBtn_Click;
            // 
            // OpenProjectBtn
            // 
            OpenProjectBtn.BackColor = Color.Gray;
            OpenProjectBtn.FlatStyle = FlatStyle.Flat;
            OpenProjectBtn.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            OpenProjectBtn.ForeColor = Color.White;
            OpenProjectBtn.Location = new Point(936, 110);
            OpenProjectBtn.Name = "OpenProjectBtn";
            OpenProjectBtn.Size = new Size(167, 58);
            OpenProjectBtn.TabIndex = 4;
            OpenProjectBtn.Text = "Open Project";
            OpenProjectBtn.UseVisualStyleBackColor = false;
            OpenProjectBtn.Click += OpenProjectBtn_Click;
            // 
            // BlocklyWindow
            // 
            BlocklyWindow.AllowExternalDrop = true;
            BlocklyWindow.CreationProperties = null;
            BlocklyWindow.DefaultBackgroundColor = Color.White;
            BlocklyWindow.Location = new Point(-2, 25);
            BlocklyWindow.Name = "BlocklyWindow";
            BlocklyWindow.Size = new Size(1117, 684);
            BlocklyWindow.TabIndex = 5;
            BlocklyWindow.ZoomFactor = 1D;
            // 
            // CyanideWindow
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(64, 64, 64);
            ClientSize = new Size(1115, 706);
            Controls.Add(ProjectsLabel);
            Controls.Add(OpenProjectBtn);
            Controls.Add(NewProjectBtn);
            Controls.Add(ProjectList);
            Controls.Add(DragBar);
            Controls.Add(BlocklyWindow);
            FormBorderStyle = FormBorderStyle.None;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "CyanideWindow";
            Text = "Cyanide";
            DragBar.ResumeLayout(false);
            DragBar.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)BlocklyWindow).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel DragBar;
        private Label WindowTitle;
        private Button MinimizeBtn;
        private Button CloseBtn;
        private Label ProjectsLabel;
        private ListBox ProjectList;
        private Button NewProjectBtn;
        private Button OpenProjectBtn;
        private Microsoft.Web.WebView2.WinForms.WebView2 BlocklyWindow;
    }
}
