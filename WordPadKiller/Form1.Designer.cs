namespace WordPadKiller
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
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.colorClick = new System.Windows.Forms.Button();
            this.colorDialog1 = new System.Windows.Forms.ColorDialog();
            this.fontDialog1 = new System.Windows.Forms.FontDialog();
            this.saveBtn = new System.Windows.Forms.Button();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.comboBoxFonts = new System.Windows.Forms.ComboBox();
            this.FontLbl = new System.Windows.Forms.Label();
            this.FontStyleLbl = new System.Windows.Forms.Label();
            this.regularFontStyleButton = new System.Windows.Forms.Button();
            this.obliqueFontStyleButton = new System.Windows.Forms.Button();
            this.boldFontStyleButton = new System.Windows.Forms.Button();
            this.alighmentLbl = new System.Windows.Forms.Label();
            this.LButton = new System.Windows.Forms.Button();
            this.CButton = new System.Windows.Forms.Button();
            this.RButton = new System.Windows.Forms.Button();
            this.comboBoxSize = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.sizeLbl = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.Location = new System.Drawing.Point(44, 197);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(1209, 362);
            this.textBox1.TabIndex = 1;
            // 
            // colorClick
            // 
            this.colorClick.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.colorClick.Location = new System.Drawing.Point(802, 41);
            this.colorClick.Name = "colorClick";
            this.colorClick.Size = new System.Drawing.Size(263, 35);
            this.colorClick.TabIndex = 2;
            this.colorClick.Text = "Click to choose color";
            this.colorClick.UseVisualStyleBackColor = true;
            this.colorClick.Click += new System.EventHandler(this.colorClick_Click);
            // 
            // saveBtn
            // 
            this.saveBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.saveBtn.Location = new System.Drawing.Point(1144, 60);
            this.saveBtn.Name = "saveBtn";
            this.saveBtn.Size = new System.Drawing.Size(109, 40);
            this.saveBtn.TabIndex = 4;
            this.saveBtn.Text = "Save";
            this.saveBtn.UseVisualStyleBackColor = true;
            this.saveBtn.Click += new System.EventHandler(this.saveBtn_Click);
            // 
            // comboBoxFonts
            // 
            this.comboBoxFonts.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxFonts.FormattingEnabled = true;
            this.comboBoxFonts.Location = new System.Drawing.Point(412, 75);
            this.comboBoxFonts.Name = "comboBoxFonts";
            this.comboBoxFonts.Size = new System.Drawing.Size(121, 24);
            this.comboBoxFonts.TabIndex = 6;
            this.comboBoxFonts.SelectedIndexChanged += new System.EventHandler(this.comboBoxFonts_SelectedIndexChanged);
            // 
            // FontLbl
            // 
            this.FontLbl.AutoSize = true;
            this.FontLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FontLbl.Location = new System.Drawing.Point(440, 41);
            this.FontLbl.Name = "FontLbl";
            this.FontLbl.Size = new System.Drawing.Size(55, 25);
            this.FontLbl.TabIndex = 7;
            this.FontLbl.Text = "Font";
            // 
            // FontStyleLbl
            // 
            this.FontStyleLbl.AutoSize = true;
            this.FontStyleLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FontStyleLbl.Location = new System.Drawing.Point(238, 41);
            this.FontStyleLbl.Name = "FontStyleLbl";
            this.FontStyleLbl.Size = new System.Drawing.Size(106, 25);
            this.FontStyleLbl.TabIndex = 8;
            this.FontStyleLbl.Text = "Font style";
            // 
            // regularFontStyleButton
            // 
            this.regularFontStyleButton.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.regularFontStyleButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.regularFontStyleButton.Location = new System.Drawing.Point(243, 69);
            this.regularFontStyleButton.Name = "regularFontStyleButton";
            this.regularFontStyleButton.Size = new System.Drawing.Size(24, 36);
            this.regularFontStyleButton.TabIndex = 9;
            this.regularFontStyleButton.Text = "button1";
            this.regularFontStyleButton.UseVisualStyleBackColor = false;
            this.regularFontStyleButton.Click += new System.EventHandler(this.regularFontStyleButton_Click);
            // 
            // obliqueFontStyleButton
            // 
            this.obliqueFontStyleButton.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.obliqueFontStyleButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.obliqueFontStyleButton.Location = new System.Drawing.Point(273, 69);
            this.obliqueFontStyleButton.Name = "obliqueFontStyleButton";
            this.obliqueFontStyleButton.Size = new System.Drawing.Size(24, 36);
            this.obliqueFontStyleButton.TabIndex = 10;
            this.obliqueFontStyleButton.Text = "button2";
            this.obliqueFontStyleButton.UseVisualStyleBackColor = false;
            this.obliqueFontStyleButton.Click += new System.EventHandler(this.obliqueFontStyleButton_Click);
            // 
            // boldFontStyleButton
            // 
            this.boldFontStyleButton.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.boldFontStyleButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.boldFontStyleButton.Location = new System.Drawing.Point(303, 69);
            this.boldFontStyleButton.Name = "boldFontStyleButton";
            this.boldFontStyleButton.Size = new System.Drawing.Size(22, 36);
            this.boldFontStyleButton.TabIndex = 11;
            this.boldFontStyleButton.Text = "button3";
            this.boldFontStyleButton.UseVisualStyleBackColor = false;
            this.boldFontStyleButton.Click += new System.EventHandler(this.boldFontStyleButton_Click);
            // 
            // alighmentLbl
            // 
            this.alighmentLbl.AutoSize = true;
            this.alighmentLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.alighmentLbl.Location = new System.Drawing.Point(597, 41);
            this.alighmentLbl.Name = "alighmentLbl";
            this.alighmentLbl.Size = new System.Drawing.Size(108, 25);
            this.alighmentLbl.TabIndex = 7;
            this.alighmentLbl.Text = "Alighment";
            // 
            // LButton
            // 
            this.LButton.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.LButton.Location = new System.Drawing.Point(611, 69);
            this.LButton.Name = "LButton";
            this.LButton.Size = new System.Drawing.Size(24, 35);
            this.LButton.TabIndex = 12;
            this.LButton.Text = "L";
            this.LButton.UseVisualStyleBackColor = false;
            this.LButton.Click += new System.EventHandler(this.LButton_Click);
            // 
            // CButton
            // 
            this.CButton.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.CButton.Location = new System.Drawing.Point(641, 69);
            this.CButton.Name = "CButton";
            this.CButton.Size = new System.Drawing.Size(24, 35);
            this.CButton.TabIndex = 12;
            this.CButton.Text = "C";
            this.CButton.UseVisualStyleBackColor = false;
            this.CButton.Click += new System.EventHandler(this.CButton_Click);
            // 
            // RButton
            // 
            this.RButton.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.RButton.Location = new System.Drawing.Point(671, 69);
            this.RButton.Name = "RButton";
            this.RButton.Size = new System.Drawing.Size(24, 35);
            this.RButton.TabIndex = 12;
            this.RButton.Text = "R";
            this.RButton.UseVisualStyleBackColor = false;
            this.RButton.Click += new System.EventHandler(this.RButton_Click);
            // 
            // comboBoxSize
            // 
            this.comboBoxSize.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxSize.FormattingEnabled = true;
            this.comboBoxSize.Location = new System.Drawing.Point(56, 75);
            this.comboBoxSize.Name = "comboBoxSize";
            this.comboBoxSize.Size = new System.Drawing.Size(121, 24);
            this.comboBoxSize.TabIndex = 13;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(238, 42);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(106, 25);
            this.label1.TabIndex = 8;
            this.label1.Text = "Font style";
            // 
            // sizeLbl
            // 
            this.sizeLbl.AutoSize = true;
            this.sizeLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sizeLbl.Location = new System.Drawing.Point(71, 41);
            this.sizeLbl.Name = "sizeLbl";
            this.sizeLbl.Size = new System.Drawing.Size(55, 25);
            this.sizeLbl.TabIndex = 8;
            this.sizeLbl.Text = "Size";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1265, 596);
            this.Controls.Add(this.comboBoxSize);
            this.Controls.Add(this.RButton);
            this.Controls.Add(this.CButton);
            this.Controls.Add(this.LButton);
            this.Controls.Add(this.boldFontStyleButton);
            this.Controls.Add(this.obliqueFontStyleButton);
            this.Controls.Add(this.sizeLbl);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.regularFontStyleButton);
            this.Controls.Add(this.FontStyleLbl);
            this.Controls.Add(this.alighmentLbl);
            this.Controls.Add(this.FontLbl);
            this.Controls.Add(this.comboBoxFonts);
            this.Controls.Add(this.saveBtn);
            this.Controls.Add(this.colorClick);
            this.Controls.Add(this.textBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load_1);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button colorClick;
        private System.Windows.Forms.ColorDialog colorDialog1;
        private System.Windows.Forms.FontDialog fontDialog1;
        private System.Windows.Forms.Button saveBtn;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.ComboBox comboBoxFonts;
        private System.Windows.Forms.Label FontLbl;
        private System.Windows.Forms.Label FontStyleLbl;
        private System.Windows.Forms.Button regularFontStyleButton;
        private System.Windows.Forms.Button obliqueFontStyleButton;
        private System.Windows.Forms.Button boldFontStyleButton;
        private System.Windows.Forms.Label alighmentLbl;
        private System.Windows.Forms.Button LButton;
        private System.Windows.Forms.Button CButton;
        private System.Windows.Forms.Button RButton;
        private System.Windows.Forms.ComboBox comboBoxSize;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label sizeLbl;
    }
}

