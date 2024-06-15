namespace ItemEditor.Forms
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.SideOptionPanel = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.button5 = new System.Windows.Forms.Button();
            this.TableEditorButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.InventoryEditorPanel = new System.Windows.Forms.Panel();
            this.PlayerInnHonestBtn = new System.Windows.Forms.Button();
            this.PlayerInventoryBtn = new System.Windows.Forms.Button();
            this.InvetoryEditorBtn = new System.Windows.Forms.Button();
            this.CenterPanel = new System.Windows.Forms.Panel();
            this.V1098 = new System.Windows.Forms.CheckBox();
            this.button3 = new System.Windows.Forms.Button();
            this.dbConnectionControl = new ItemEditor.CustomControls.DbConnectionControl();
            this.panel1.SuspendLayout();
            this.SideOptionPanel.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel2.SuspendLayout();
            this.InventoryEditorPanel.SuspendLayout();
            this.CenterPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Maroon;
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1287, 104);
            this.panel1.TabIndex = 0;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.Transparent;
            this.panel3.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel3.BackgroundImage")));
            this.panel3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel3.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(250, 104);
            this.panel3.TabIndex = 2;
            // 
            // SideOptionPanel
            // 
            this.SideOptionPanel.AutoScroll = true;
            this.SideOptionPanel.BackColor = System.Drawing.Color.Maroon;
            this.SideOptionPanel.Controls.Add(this.panel4);
            this.SideOptionPanel.Controls.Add(this.panel2);
            this.SideOptionPanel.Controls.Add(this.InventoryEditorPanel);
            this.SideOptionPanel.Dock = System.Windows.Forms.DockStyle.Left;
            this.SideOptionPanel.Location = new System.Drawing.Point(0, 104);
            this.SideOptionPanel.Name = "SideOptionPanel";
            this.SideOptionPanel.Padding = new System.Windows.Forms.Padding(0, 5, 0, 0);
            this.SideOptionPanel.Size = new System.Drawing.Size(250, 663);
            this.SideOptionPanel.TabIndex = 1;
            // 
            // panel4
            // 
            this.panel4.AutoSize = true;
            this.panel4.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.panel4.BackColor = System.Drawing.Color.Transparent;
            this.panel4.Controls.Add(this.label2);
            this.panel4.Controls.Add(this.button2);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel4.Location = new System.Drawing.Point(0, 285);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(250, 50);
            this.panel4.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label2.BackColor = System.Drawing.Color.Black;
            this.label2.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.ForeColor = System.Drawing.Color.Red;
            this.label2.Location = new System.Drawing.Point(157, 15);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(87, 24);
            this.label2.TabIndex = 2;
            this.label2.Text = "(Disabled)";
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.Maroon;
            this.button2.Dock = System.Windows.Forms.DockStyle.Top;
            this.button2.Enabled = false;
            this.button2.FlatAppearance.BorderSize = 0;
            this.button2.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.button2.ForeColor = System.Drawing.Color.DarkOrange;
            this.button2.Location = new System.Drawing.Point(0, 0);
            this.button2.MinimumSize = new System.Drawing.Size(0, 50);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(250, 50);
            this.button2.TabIndex = 2;
            this.button2.Text = "   Change Drop Rate";
            this.button2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button2.UseVisualStyleBackColor = false;
            // 
            // panel2
            // 
            this.panel2.AutoSize = true;
            this.panel2.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.panel2.BackColor = System.Drawing.Color.Transparent;
            this.panel2.Controls.Add(this.button5);
            this.panel2.Controls.Add(this.TableEditorButton);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.button1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 135);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(250, 150);
            this.panel2.TabIndex = 3;
            // 
            // button5
            // 
            this.button5.BackColor = System.Drawing.Color.Maroon;
            this.button5.Dock = System.Windows.Forms.DockStyle.Top;
            this.button5.FlatAppearance.BorderSize = 0;
            this.button5.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.button5.ForeColor = System.Drawing.Color.DarkOrange;
            this.button5.Location = new System.Drawing.Point(0, 100);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(250, 50);
            this.button5.TabIndex = 3;
            this.button5.Text = "   Item Creator";
            this.button5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button5.UseVisualStyleBackColor = false;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // TableEditorButton
            // 
            this.TableEditorButton.BackColor = System.Drawing.Color.Maroon;
            this.TableEditorButton.Dock = System.Windows.Forms.DockStyle.Top;
            this.TableEditorButton.FlatAppearance.BorderSize = 0;
            this.TableEditorButton.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.TableEditorButton.ForeColor = System.Drawing.Color.DarkOrange;
            this.TableEditorButton.Location = new System.Drawing.Point(0, 50);
            this.TableEditorButton.Name = "TableEditorButton";
            this.TableEditorButton.Size = new System.Drawing.Size(250, 50);
            this.TableEditorButton.TabIndex = 2;
            this.TableEditorButton.Text = "   Table Editor";
            this.TableEditorButton.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.TableEditorButton.UseVisualStyleBackColor = false;
            this.TableEditorButton.Click += new System.EventHandler(this.SelectTableEditorForm_Click);
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.BackColor = System.Drawing.Color.Black;
            this.label1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(157, 90);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(83, 24);
            this.label1.TabIndex = 1;
            this.label1.Text = "(Disabled)";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Maroon;
            this.button1.Dock = System.Windows.Forms.DockStyle.Top;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.button1.ForeColor = System.Drawing.Color.DarkOrange;
            this.button1.Location = new System.Drawing.Point(0, 0);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(250, 50);
            this.button1.TabIndex = 0;
            this.button1.Text = "   Search Character";
            this.button1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // InventoryEditorPanel
            // 
            this.InventoryEditorPanel.AutoSize = true;
            this.InventoryEditorPanel.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.InventoryEditorPanel.BackColor = System.Drawing.Color.Maroon;
            this.InventoryEditorPanel.Controls.Add(this.PlayerInnHonestBtn);
            this.InventoryEditorPanel.Controls.Add(this.PlayerInventoryBtn);
            this.InventoryEditorPanel.Controls.Add(this.InvetoryEditorBtn);
            this.InventoryEditorPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.InventoryEditorPanel.Location = new System.Drawing.Point(0, 5);
            this.InventoryEditorPanel.MinimumSize = new System.Drawing.Size(250, 55);
            this.InventoryEditorPanel.Name = "InventoryEditorPanel";
            this.InventoryEditorPanel.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.InventoryEditorPanel.Size = new System.Drawing.Size(250, 130);
            this.InventoryEditorPanel.TabIndex = 2;
            // 
            // PlayerInnHonestBtn
            // 
            this.PlayerInnHonestBtn.BackColor = System.Drawing.Color.Transparent;
            this.PlayerInnHonestBtn.Dock = System.Windows.Forms.DockStyle.Top;
            this.PlayerInnHonestBtn.Enabled = false;
            this.PlayerInnHonestBtn.FlatAppearance.BorderSize = 2;
            this.PlayerInnHonestBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.PlayerInnHonestBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.PlayerInnHonestBtn.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.PlayerInnHonestBtn.ForeColor = System.Drawing.Color.Bisque;
            this.PlayerInnHonestBtn.Location = new System.Drawing.Point(0, 90);
            this.PlayerInnHonestBtn.Name = "PlayerInnHonestBtn";
            this.PlayerInnHonestBtn.Size = new System.Drawing.Size(250, 40);
            this.PlayerInnHonestBtn.TabIndex = 4;
            this.PlayerInnHonestBtn.Text = "Player Inn Honest";
            this.PlayerInnHonestBtn.UseVisualStyleBackColor = false;
            this.PlayerInnHonestBtn.Visible = false;
            this.PlayerInnHonestBtn.MouseLeave += new System.EventHandler(this.SidePanelOptionButton_MouseLeave);
            this.PlayerInnHonestBtn.MouseHover += new System.EventHandler(this.SidePanelOptionButton_MouseHover);
            // 
            // PlayerInventoryBtn
            // 
            this.PlayerInventoryBtn.BackColor = System.Drawing.Color.Transparent;
            this.PlayerInventoryBtn.Dock = System.Windows.Forms.DockStyle.Top;
            this.PlayerInventoryBtn.FlatAppearance.BorderSize = 2;
            this.PlayerInventoryBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.PlayerInventoryBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.PlayerInventoryBtn.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.PlayerInventoryBtn.ForeColor = System.Drawing.Color.Bisque;
            this.PlayerInventoryBtn.Location = new System.Drawing.Point(0, 50);
            this.PlayerInventoryBtn.Name = "PlayerInventoryBtn";
            this.PlayerInventoryBtn.Size = new System.Drawing.Size(250, 40);
            this.PlayerInventoryBtn.TabIndex = 3;
            this.PlayerInventoryBtn.Text = "Player Inventory";
            this.PlayerInventoryBtn.UseVisualStyleBackColor = false;
            this.PlayerInventoryBtn.Visible = false;
            this.PlayerInventoryBtn.Click += new System.EventHandler(this.PlayerInventoryBtn_Click);
            this.PlayerInventoryBtn.MouseLeave += new System.EventHandler(this.SidePanelOptionButton_MouseLeave);
            this.PlayerInventoryBtn.MouseHover += new System.EventHandler(this.SidePanelOptionButton_MouseHover);
            // 
            // InvetoryEditorBtn
            // 
            this.InvetoryEditorBtn.BackColor = System.Drawing.Color.Maroon;
            this.InvetoryEditorBtn.Dock = System.Windows.Forms.DockStyle.Top;
            this.InvetoryEditorBtn.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.InvetoryEditorBtn.ForeColor = System.Drawing.Color.DarkOrange;
            this.InvetoryEditorBtn.Location = new System.Drawing.Point(0, 0);
            this.InvetoryEditorBtn.MinimumSize = new System.Drawing.Size(0, 50);
            this.InvetoryEditorBtn.Name = "InvetoryEditorBtn";
            this.InvetoryEditorBtn.Size = new System.Drawing.Size(250, 50);
            this.InvetoryEditorBtn.TabIndex = 2;
            this.InvetoryEditorBtn.Text = "   Invetory Editor/Search Item";
            this.InvetoryEditorBtn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.InvetoryEditorBtn.UseVisualStyleBackColor = false;
            this.InvetoryEditorBtn.Click += new System.EventHandler(this.InventoryPanelOptionToggle_Click);
            // 
            // CenterPanel
            // 
            this.CenterPanel.AutoScroll = true;
            this.CenterPanel.BackColor = System.Drawing.Color.Transparent;
            this.CenterPanel.Controls.Add(this.V1098);
            this.CenterPanel.Controls.Add(this.button3);
            this.CenterPanel.Controls.Add(this.dbConnectionControl);
            this.CenterPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.CenterPanel.Location = new System.Drawing.Point(250, 104);
            this.CenterPanel.Name = "CenterPanel";
            this.CenterPanel.Size = new System.Drawing.Size(1037, 663);
            this.CenterPanel.TabIndex = 2;
            // 
            // V1098
            // 
            this.V1098.AutoSize = true;
            this.V1098.Location = new System.Drawing.Point(243, 328);
            this.V1098.Name = "V1098";
            this.V1098.Size = new System.Drawing.Size(72, 24);
            this.V1098.TabIndex = 5;
            this.V1098.Text = "V1098";
            this.V1098.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.SystemColors.Menu;
            this.button3.FlatAppearance.BorderSize = 3;
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button3.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.button3.Location = new System.Drawing.Point(243, 386);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(249, 55);
            this.button3.TabIndex = 1;
            this.button3.Text = "Connect";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // dbConnectionControl
            // 
            this.dbConnectionControl.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.dbConnectionControl.Location = new System.Drawing.Point(226, 55);
            this.dbConnectionControl.Name = "dbConnectionControl";
            this.dbConnectionControl.Size = new System.Drawing.Size(295, 234);
            this.dbConnectionControl.TabIndex = 0;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.BackColor = System.Drawing.Color.Gray;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1287, 767);
            this.Controls.Add(this.CenterPanel);
            this.Controls.Add(this.SideOptionPanel);
            this.Controls.Add(this.panel1);
            this.DoubleBuffered = true;
            this.Name = "MainForm";
            this.Text = "Horrus Multitool ";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.panel1.ResumeLayout(false);
            this.SideOptionPanel.ResumeLayout(false);
            this.SideOptionPanel.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.InventoryEditorPanel.ResumeLayout(false);
            this.CenterPanel.ResumeLayout(false);
            this.CenterPanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Panel panel1;
        private Panel panel3;
        private Panel SideOptionPanel;
        private Button button1;
        private Panel panel4;
        private Button button2;
        private Panel panel2;
        private Panel InventoryEditorPanel;
        private Button PlayerInnHonestBtn;
        private Button PlayerInventoryBtn;
        private Button InvetoryEditorBtn;
        private Label label1;
        private Label label2;
        private Panel CenterPanel;
        private Button button3;
        private CustomControls.DbConnectionControl dbConnectionControl;
        private CheckBox V1098;
        private Button TableEditorButton;
        private Button button5;
    }
}