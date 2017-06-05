namespace PanMonopoly
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.Console_CommandBtn = new System.Windows.Forms.Button();
            this.Console_Console = new System.Windows.Forms.RichTextBox();
            this.Console_InputBox = new System.Windows.Forms.TextBox();
            this.checkedListBox1 = new System.Windows.Forms.CheckedListBox();
            this.SuspendLayout();
            // 
            // Console_CommandBtn
            // 
            this.Console_CommandBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.Console_CommandBtn.Location = new System.Drawing.Point(890, 12);
            this.Console_CommandBtn.Name = "Console_CommandBtn";
            this.Console_CommandBtn.Size = new System.Drawing.Size(30, 30);
            this.Console_CommandBtn.TabIndex = 0;
            this.Console_CommandBtn.UseVisualStyleBackColor = true;
            this.Console_CommandBtn.Click += new System.EventHandler(this.Console_CommandBtn_Click);
            // 
            // Console_Console
            // 
            this.Console_Console.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Console_Console.BackColor = System.Drawing.Color.White;
            this.Console_Console.Font = new System.Drawing.Font("Courier New", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Console_Console.Location = new System.Drawing.Point(529, 48);
            this.Console_Console.Name = "Console_Console";
            this.Console_Console.ReadOnly = true;
            this.Console_Console.Size = new System.Drawing.Size(391, 409);
            this.Console_Console.TabIndex = 2;
            this.Console_Console.Text = "";
            // 
            // Console_InputBox
            // 
            this.Console_InputBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.Console_InputBox.Font = new System.Drawing.Font("Courier New", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Console_InputBox.Location = new System.Drawing.Point(529, 12);
            this.Console_InputBox.Name = "Console_InputBox";
            this.Console_InputBox.Size = new System.Drawing.Size(355, 30);
            this.Console_InputBox.TabIndex = 3;
            this.Console_InputBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Console_InputBox_KeyPress);
            // 
            // checkedListBox1
            // 
            this.checkedListBox1.FormattingEnabled = true;
            this.checkedListBox1.Location = new System.Drawing.Point(12, 12);
            this.checkedListBox1.Name = "checkedListBox1";
            this.checkedListBox1.Size = new System.Drawing.Size(235, 106);
            this.checkedListBox1.TabIndex = 4;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(932, 469);
            this.Controls.Add(this.checkedListBox1);
            this.Controls.Add(this.Console_InputBox);
            this.Controls.Add(this.Console_Console);
            this.Controls.Add(this.Console_CommandBtn);
            this.Name = "Form1";
            this.Text = "PanMonopoly";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Console_CommandBtn;
        private System.Windows.Forms.RichTextBox Console_Console;
        private System.Windows.Forms.TextBox Console_InputBox;
        private System.Windows.Forms.CheckedListBox checkedListBox1;
    }
}

