namespace WordPadWinForm
{
    partial class Form1
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
            fontLabel = new Label();
            sizeLabel = new Label();
            fontStyleLabel = new Label();
            alignmentLabel = new Label();
            colorLabel = new Label();
            loadtb = new TextBox();
            savetb = new TextBox();
            loadbtn = new Button();
            savebtn = new Button();
            fontcb = new ComboBox();
            sizecb = new ComboBox();
            boldbtn = new Button();
            underlinebtn = new Button();
            italicbtn = new Button();
            rightalg = new Button();
            centrealg = new Button();
            leftalg = new Button();
            colorcb = new ComboBox();
            richTextBox1 = new RichTextBox();
            SuspendLayout();
            // 
            // fontLabel
            // 
            fontLabel.AutoSize = true;
            fontLabel.Location = new Point(53, 9);
            fontLabel.Name = "fontLabel";
            fontLabel.Size = new Size(38, 20);
            fontLabel.TabIndex = 0;
            fontLabel.Text = "Font";
            // 
            // sizeLabel
            // 
            sizeLabel.AutoSize = true;
            sizeLabel.Location = new Point(156, 9);
            sizeLabel.Name = "sizeLabel";
            sizeLabel.Size = new Size(36, 20);
            sizeLabel.TabIndex = 1;
            sizeLabel.Text = "Size";
            // 
            // fontStyleLabel
            // 
            fontStyleLabel.AutoSize = true;
            fontStyleLabel.Location = new Point(238, 9);
            fontStyleLabel.Name = "fontStyleLabel";
            fontStyleLabel.Size = new Size(74, 20);
            fontStyleLabel.TabIndex = 2;
            fontStyleLabel.Text = "Font Style";
            // 
            // alignmentLabel
            // 
            alignmentLabel.AutoSize = true;
            alignmentLabel.Location = new Point(359, 9);
            alignmentLabel.Name = "alignmentLabel";
            alignmentLabel.Size = new Size(78, 20);
            alignmentLabel.TabIndex = 3;
            alignmentLabel.Text = "Alignment";
            // 
            // colorLabel
            // 
            colorLabel.AutoSize = true;
            colorLabel.Location = new Point(511, 9);
            colorLabel.Name = "colorLabel";
            colorLabel.Size = new Size(45, 20);
            colorLabel.TabIndex = 4;
            colorLabel.Text = "Color";
            // 
            // loadtb
            // 
            loadtb.Font = new Font("Segoe UI", 7.8F, FontStyle.Regular, GraphicsUnit.Point);
            loadtb.ForeColor = Color.LightGray;
            loadtb.Location = new Point(615, 9);
            loadtb.Name = "loadtb";
            loadtb.Size = new Size(167, 25);
            loadtb.TabIndex = 5;
            loadtb.Text = "Enter name and load file.";
            loadtb.Click += loadtb_Click;
            loadtb.TextChanged += loadtb_TextChanged;
            // 
            // savetb
            // 
            savetb.Font = new Font("Segoe UI", 7.8F, FontStyle.Regular, GraphicsUnit.Point);
            savetb.ForeColor = Color.LightGray;
            savetb.Location = new Point(615, 52);
            savetb.Name = "savetb";
            savetb.Size = new Size(167, 25);
            savetb.TabIndex = 6;
            savetb.Text = "Tap enter name and save.";
            savetb.Click += savetb_Click;
            // 
            // loadbtn
            // 
            loadbtn.Location = new Point(803, 5);
            loadbtn.Name = "loadbtn";
            loadbtn.Size = new Size(96, 29);
            loadbtn.TabIndex = 7;
            loadbtn.Text = "Load";
            loadbtn.UseVisualStyleBackColor = true;
            loadbtn.Click += loadbtn_Click;
            // 
            // savebtn
            // 
            savebtn.Location = new Point(803, 50);
            savebtn.Name = "savebtn";
            savebtn.Size = new Size(96, 29);
            savebtn.TabIndex = 8;
            savebtn.Text = "Save";
            savebtn.UseVisualStyleBackColor = true;
            savebtn.Click += savebtn_Click;
            // 
            // fontcb
            // 
            fontcb.FormattingEnabled = true;
            fontcb.Location = new Point(12, 51);
            fontcb.Name = "fontcb";
            fontcb.Size = new Size(109, 28);
            fontcb.TabIndex = 9;
            fontcb.SelectedIndexChanged += fontcb_SelectedIndexChanged;
            // 
            // sizecb
            // 
            sizecb.FormattingEnabled = true;
            sizecb.Location = new Point(137, 51);
            sizecb.Name = "sizecb";
            sizecb.Size = new Size(75, 28);
            sizecb.TabIndex = 10;
            sizecb.SelectedIndexChanged += sizecb_SelectedIndexChanged;
            // 
            // boldbtn
            // 
            boldbtn.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            boldbtn.ForeColor = SystemColors.ActiveCaptionText;
            boldbtn.Location = new Point(218, 50);
            boldbtn.Name = "boldbtn";
            boldbtn.Size = new Size(31, 29);
            boldbtn.TabIndex = 11;
            boldbtn.Text = "B";
            boldbtn.UseVisualStyleBackColor = true;
            // 
            // underlinebtn
            // 
            underlinebtn.Font = new Font("Segoe UI", 9F, FontStyle.Underline, GraphicsUnit.Point);
            underlinebtn.ForeColor = SystemColors.ActiveCaptionText;
            underlinebtn.Location = new Point(255, 50);
            underlinebtn.Name = "underlinebtn";
            underlinebtn.Size = new Size(31, 29);
            underlinebtn.TabIndex = 12;
            underlinebtn.Text = "U";
            underlinebtn.UseVisualStyleBackColor = true;
            // 
            // italicbtn
            // 
            italicbtn.Font = new Font("Segoe UI Semilight", 9F, FontStyle.Italic, GraphicsUnit.Point);
            italicbtn.ForeColor = SystemColors.ActiveCaptionText;
            italicbtn.Location = new Point(292, 52);
            italicbtn.Name = "italicbtn";
            italicbtn.Size = new Size(31, 29);
            italicbtn.TabIndex = 13;
            italicbtn.Text = "I";
            italicbtn.UseVisualStyleBackColor = true;
            // 
            // rightalg
            // 
            rightalg.BackColor = SystemColors.AppWorkspace;
            rightalg.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            rightalg.ForeColor = SystemColors.ActiveCaptionText;
            rightalg.Location = new Point(417, 53);
            rightalg.Name = "rightalg";
            rightalg.Size = new Size(31, 29);
            rightalg.TabIndex = 16;
            rightalg.Text = "R";
            rightalg.UseVisualStyleBackColor = false;
            // 
            // centrealg
            // 
            centrealg.BackColor = SystemColors.AppWorkspace;
            centrealg.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            centrealg.ForeColor = SystemColors.ActiveCaptionText;
            centrealg.Location = new Point(380, 52);
            centrealg.Name = "centrealg";
            centrealg.Size = new Size(31, 29);
            centrealg.TabIndex = 15;
            centrealg.Text = "C";
            centrealg.UseVisualStyleBackColor = false;
            // 
            // leftalg
            // 
            leftalg.BackColor = SystemColors.AppWorkspace;
            leftalg.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            leftalg.ForeColor = SystemColors.ActiveCaptionText;
            leftalg.Location = new Point(343, 53);
            leftalg.Name = "leftalg";
            leftalg.Size = new Size(31, 29);
            leftalg.TabIndex = 14;
            leftalg.Text = "L";
            leftalg.UseVisualStyleBackColor = false;
            // 
            // colorcb
            // 
            colorcb.FormattingEnabled = true;
            colorcb.Location = new Point(474, 52);
            colorcb.Name = "colorcb";
            colorcb.Size = new Size(125, 28);
            colorcb.TabIndex = 17;
            colorcb.SelectedIndexChanged += colorcb_SelectedIndexChanged;
            // 
            // richTextBox1
            // 
            richTextBox1.Font = new Font("Segoe UI Light", 9F, FontStyle.Regular, GraphicsUnit.Point);
            richTextBox1.ForeColor = Color.DimGray;
            richTextBox1.Location = new Point(0, 115);
            richTextBox1.Name = "richTextBox1";
            richTextBox1.Size = new Size(929, 336);
            richTextBox1.TabIndex = 18;
            richTextBox1.Text = "";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(929, 450);
            Controls.Add(richTextBox1);
            Controls.Add(colorcb);
            Controls.Add(rightalg);
            Controls.Add(centrealg);
            Controls.Add(leftalg);
            Controls.Add(italicbtn);
            Controls.Add(underlinebtn);
            Controls.Add(boldbtn);
            Controls.Add(sizecb);
            Controls.Add(fontcb);
            Controls.Add(savebtn);
            Controls.Add(loadbtn);
            Controls.Add(savetb);
            Controls.Add(loadtb);
            Controls.Add(colorLabel);
            Controls.Add(alignmentLabel);
            Controls.Add(fontStyleLabel);
            Controls.Add(sizeLabel);
            Controls.Add(fontLabel);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }



        #endregion

        private Label fontLabel;
        private Label sizeLabel;
        private Label fontStyleLabel;
        private Label alignmentLabel;
        private Label colorLabel;
        private TextBox loadtb;
        private TextBox savetb;
        private Button loadbtn;
        private Button savebtn;
        private ComboBox fontcb;
        private ComboBox sizecb;
        private Button boldbtn;
        private Button underlinebtn;
        private Button italicbtn;
        private Button rightalg;
        private Button centrealg;
        private Button leftalg;
        private ComboBox colorcb;
        private RichTextBox richTextBox1;
    }
}