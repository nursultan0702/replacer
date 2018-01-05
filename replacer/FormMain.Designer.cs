namespace replacer
{
    partial class FormMain
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
            this.components = new System.ComponentModel.Container();
            this.textBoxDict = new System.Windows.Forms.TextBox();
            this.dg = new System.Windows.Forms.DataGridView();
            this.contextMenuStripDG = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.parseColumnToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.parseAllToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.panel1 = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.checkBoxDebug = new System.Windows.Forms.CheckBox();
            this.buttonParse = new System.Windows.Forms.Button();
            this.checkBoxSetOther = new System.Windows.Forms.CheckBox();
            this.checkBoxAddEmpty = new System.Windows.Forms.CheckBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.buttonOpenDict = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.buttonDict = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.buttonOpenExcel = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.buttonSave = new System.Windows.Forms.Button();
            this.buttonLoad = new System.Windows.Forms.Button();
            this.buttonSource = new System.Windows.Forms.Button();
            this.textBoxInput = new System.Windows.Forms.TextBox();
            this.button2 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dg)).BeginInit();
            this.contextMenuStripDG.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // textBoxDict
            // 
            this.textBoxDict.Location = new System.Drawing.Point(4, 22);
            this.textBoxDict.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.textBoxDict.Name = "textBoxDict";
            this.textBoxDict.ReadOnly = true;
            this.textBoxDict.Size = new System.Drawing.Size(732, 24);
            this.textBoxDict.TabIndex = 3;
            // 
            // dg
            // 
            this.dg.AllowUserToAddRows = false;
            this.dg.AllowUserToDeleteRows = false;
            this.dg.AllowUserToResizeRows = false;
            this.dg.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dg.ContextMenuStrip = this.contextMenuStripDG;
            this.dg.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dg.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dg.Location = new System.Drawing.Point(0, 178);
            this.dg.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dg.Name = "dg";
            this.dg.ReadOnly = true;
            this.dg.RowHeadersVisible = false;
            this.dg.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.dg.Size = new System.Drawing.Size(1452, 752);
            this.dg.TabIndex = 5;
            this.dg.CellMouseDown += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dg_CellMouseDown);
            // 
            // contextMenuStripDG
            // 
            this.contextMenuStripDG.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStripDG.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.parseColumnToolStripMenuItem,
            this.parseAllToolStripMenuItem});
            this.contextMenuStripDG.Name = "contextMenuStripDG";
            this.contextMenuStripDG.Size = new System.Drawing.Size(166, 52);
            // 
            // parseColumnToolStripMenuItem
            // 
            this.parseColumnToolStripMenuItem.Enabled = false;
            this.parseColumnToolStripMenuItem.Name = "parseColumnToolStripMenuItem";
            this.parseColumnToolStripMenuItem.Size = new System.Drawing.Size(165, 24);
            this.parseColumnToolStripMenuItem.Text = "Parse column";
            this.parseColumnToolStripMenuItem.Visible = false;
            // 
            // parseAllToolStripMenuItem
            // 
            this.parseAllToolStripMenuItem.Name = "parseAllToolStripMenuItem";
            this.parseAllToolStripMenuItem.Size = new System.Drawing.Size(165, 24);
            this.parseAllToolStripMenuItem.Text = "Parse All";
            this.parseAllToolStripMenuItem.Click += new System.EventHandler(this.parseAllToolStripMenuItem_Click_1);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.button2);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.checkBoxDebug);
            this.panel1.Controls.Add(this.buttonParse);
            this.panel1.Controls.Add(this.checkBoxSetOther);
            this.panel1.Controls.Add(this.checkBoxAddEmpty);
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Font = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1452, 178);
            this.panel1.TabIndex = 6;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(1145, 104);
            this.button1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(167, 28);
            this.button1.TabIndex = 18;
            this.button1.Text = "Get Data from DB";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // checkBoxDebug
            // 
            this.checkBoxDebug.AutoSize = true;
            this.checkBoxDebug.Location = new System.Drawing.Point(1145, 75);
            this.checkBoxDebug.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.checkBoxDebug.Name = "checkBoxDebug";
            this.checkBoxDebug.Size = new System.Drawing.Size(71, 21);
            this.checkBoxDebug.TabIndex = 17;
            this.checkBoxDebug.Text = "Debug";
            this.checkBoxDebug.UseVisualStyleBackColor = true;
            // 
            // buttonParse
            // 
            this.buttonParse.Location = new System.Drawing.Point(956, 123);
            this.buttonParse.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.buttonParse.Name = "buttonParse";
            this.buttonParse.Size = new System.Drawing.Size(100, 28);
            this.buttonParse.TabIndex = 16;
            this.buttonParse.Text = "Parse";
            this.buttonParse.UseVisualStyleBackColor = true;
            this.buttonParse.Click += new System.EventHandler(this.parseAllToolStripMenuItem_Click_1);
            // 
            // checkBoxSetOther
            // 
            this.checkBoxSetOther.AutoSize = true;
            this.checkBoxSetOther.Location = new System.Drawing.Point(1145, 47);
            this.checkBoxSetOther.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.checkBoxSetOther.Name = "checkBoxSetOther";
            this.checkBoxSetOther.Size = new System.Drawing.Size(187, 21);
            this.checkBoxSetOther.TabIndex = 15;
            this.checkBoxSetOther.Text = "Set other values [OTHER]";
            this.checkBoxSetOther.UseVisualStyleBackColor = true;
            // 
            // checkBoxAddEmpty
            // 
            this.checkBoxAddEmpty.AutoSize = true;
            this.checkBoxAddEmpty.Location = new System.Drawing.Point(1145, 18);
            this.checkBoxAddEmpty.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.checkBoxAddEmpty.Name = "checkBoxAddEmpty";
            this.checkBoxAddEmpty.Size = new System.Drawing.Size(169, 21);
            this.checkBoxAddEmpty.TabIndex = 14;
            this.checkBoxAddEmpty.Text = "Add values if no match";
            this.checkBoxAddEmpty.UseVisualStyleBackColor = true;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.SystemColors.ControlLight;
            this.panel3.Controls.Add(this.buttonOpenDict);
            this.panel3.Controls.Add(this.label2);
            this.panel3.Controls.Add(this.buttonDict);
            this.panel3.Controls.Add(this.textBoxDict);
            this.panel3.Location = new System.Drawing.Point(16, 94);
            this.panel3.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(932, 59);
            this.panel3.TabIndex = 13;
            // 
            // buttonOpenDict
            // 
            this.buttonOpenDict.Location = new System.Drawing.Point(844, 21);
            this.buttonOpenDict.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.buttonOpenDict.Name = "buttonOpenDict";
            this.buttonOpenDict.Size = new System.Drawing.Size(76, 28);
            this.buttonOpenDict.TabIndex = 10;
            this.buttonOpenDict.Text = "Open";
            this.buttonOpenDict.UseVisualStyleBackColor = true;
            this.buttonOpenDict.Click += new System.EventHandler(this.buttonOpenDict_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(0, 2);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(89, 17);
            this.label2.TabIndex = 9;
            this.label2.Text = "Dictionary file";
            // 
            // buttonDict
            // 
            this.buttonDict.Location = new System.Drawing.Point(745, 21);
            this.buttonDict.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.buttonDict.Name = "buttonDict";
            this.buttonDict.Size = new System.Drawing.Size(91, 27);
            this.buttonDict.TabIndex = 7;
            this.buttonDict.Text = "Dictionary";
            this.buttonDict.UseVisualStyleBackColor = true;
            this.buttonDict.Click += new System.EventHandler(this.buttonDict_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.ControlLight;
            this.panel2.Controls.Add(this.buttonOpenExcel);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.buttonSave);
            this.panel2.Controls.Add(this.buttonLoad);
            this.panel2.Controls.Add(this.buttonSource);
            this.panel2.Controls.Add(this.textBoxInput);
            this.panel2.Location = new System.Drawing.Point(16, 15);
            this.panel2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1108, 60);
            this.panel2.TabIndex = 12;
            // 
            // buttonOpenExcel
            // 
            this.buttonOpenExcel.Location = new System.Drawing.Point(844, 21);
            this.buttonOpenExcel.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.buttonOpenExcel.Name = "buttonOpenExcel";
            this.buttonOpenExcel.Size = new System.Drawing.Size(76, 28);
            this.buttonOpenExcel.TabIndex = 11;
            this.buttonOpenExcel.Text = "Open";
            this.buttonOpenExcel.UseVisualStyleBackColor = true;
            this.buttonOpenExcel.Click += new System.EventHandler(this.buttonOpenExcel_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(1, 5);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(70, 17);
            this.label1.TabIndex = 8;
            this.label1.Text = "Source file";
            // 
            // buttonSave
            // 
            this.buttonSave.Location = new System.Drawing.Point(1011, 21);
            this.buttonSave.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.buttonSave.Name = "buttonSave";
            this.buttonSave.Size = new System.Drawing.Size(76, 27);
            this.buttonSave.TabIndex = 6;
            this.buttonSave.Text = "Save";
            this.buttonSave.UseVisualStyleBackColor = true;
            this.buttonSave.Click += new System.EventHandler(this.buttonSave_Click);
            // 
            // buttonLoad
            // 
            this.buttonLoad.Location = new System.Drawing.Point(928, 21);
            this.buttonLoad.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.buttonLoad.Name = "buttonLoad";
            this.buttonLoad.Size = new System.Drawing.Size(75, 27);
            this.buttonLoad.TabIndex = 5;
            this.buttonLoad.Text = "Load";
            this.buttonLoad.UseVisualStyleBackColor = true;
            this.buttonLoad.Click += new System.EventHandler(this.buttonLoad_Click_1);
            // 
            // buttonSource
            // 
            this.buttonSource.Location = new System.Drawing.Point(747, 21);
            this.buttonSource.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.buttonSource.Name = "buttonSource";
            this.buttonSource.Size = new System.Drawing.Size(89, 28);
            this.buttonSource.TabIndex = 1;
            this.buttonSource.Text = "Source";
            this.buttonSource.UseVisualStyleBackColor = true;
            this.buttonSource.Click += new System.EventHandler(this.buttonLoad_Click);
            // 
            // textBoxInput
            // 
            this.textBoxInput.Location = new System.Drawing.Point(5, 25);
            this.textBoxInput.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.textBoxInput.Name = "textBoxInput";
            this.textBoxInput.ReadOnly = true;
            this.textBoxInput.Size = new System.Drawing.Size(732, 24);
            this.textBoxInput.TabIndex = 0;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(1145, 139);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(167, 32);
            this.button2.TabIndex = 19;
            this.button2.Text = "Save as";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1452, 930);
            this.Controls.Add(this.dg);
            this.Controls.Add(this.panel1);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "FormMain";
            this.Text = "Replacer";
            ((System.ComponentModel.ISupportInitialize)(this.dg)).EndInit();
            this.contextMenuStripDG.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxDict;
        private System.Windows.Forms.DataGridView dg;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ContextMenuStrip contextMenuStripDG;
        private System.Windows.Forms.ToolStripMenuItem parseColumnToolStripMenuItem;
        private System.Windows.Forms.Button buttonDict;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button buttonOpenDict;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button buttonOpenExcel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button buttonSave;
        private System.Windows.Forms.Button buttonLoad;
        private System.Windows.Forms.Button buttonSource;
        private System.Windows.Forms.TextBox textBoxInput;
        private System.Windows.Forms.ToolStripMenuItem parseAllToolStripMenuItem;
        private System.Windows.Forms.CheckBox checkBoxAddEmpty;
        private System.Windows.Forms.CheckBox checkBoxSetOther;
        private System.Windows.Forms.Button buttonParse;
        private System.Windows.Forms.CheckBox checkBoxDebug;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
    }
}

