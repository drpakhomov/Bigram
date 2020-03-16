namespace Bigram
{
    partial class Bigram
    {
        /// <summary>
        /// Требуется переменная конструктора.
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
        /// Обязательный метод для поддержки конструктора - не изменяйте
        /// содержимое данного метода при помощи редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Bigram));
            this.decryptButton = new System.Windows.Forms.Button();
            this.keysListBox = new System.Windows.Forms.ListBox();
            this.keyListLabel = new System.Windows.Forms.Label();
            this.arrowLabel = new System.Windows.Forms.Label();
            this.decryptListBox = new System.Windows.Forms.ListBox();
            this.decryptListLabel = new System.Windows.Forms.Label();
            this.decryptGB = new System.Windows.Forms.GroupBox();
            this.useDictionaryCheckBox = new System.Windows.Forms.CheckBox();
            this.encryptGB = new System.Windows.Forms.GroupBox();
            this.encryptButton = new System.Windows.Forms.Button();
            this.keyTextBox = new System.Windows.Forms.TextBox();
            this.keyLabel = new System.Windows.Forms.Label();
            this.encryptTextBox = new System.Windows.Forms.TextBox();
            this.encryptTextLabel = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.справкаToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.оПрограммеToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.decryptGB.SuspendLayout();
            this.encryptGB.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // decryptButton
            // 
            this.decryptButton.Location = new System.Drawing.Point(9, 52);
            this.decryptButton.Name = "decryptButton";
            this.decryptButton.Size = new System.Drawing.Size(130, 60);
            this.decryptButton.TabIndex = 9;
            this.decryptButton.Text = "Загрузить и дешифровать";
            this.decryptButton.UseVisualStyleBackColor = true;
            this.decryptButton.Click += new System.EventHandler(this.decryptButton_Click);
            // 
            // keysListBox
            // 
            this.keysListBox.FormattingEnabled = true;
            this.keysListBox.ItemHeight = 16;
            this.keysListBox.Location = new System.Drawing.Point(149, 39);
            this.keysListBox.Name = "keysListBox";
            this.keysListBox.Size = new System.Drawing.Size(184, 100);
            this.keysListBox.TabIndex = 1;
            this.keysListBox.SelectedIndexChanged += new System.EventHandler(this.keysListBox_SelectedIndexChanged);
            // 
            // keyListLabel
            // 
            this.keyListLabel.AutoSize = true;
            this.keyListLabel.Location = new System.Drawing.Point(146, 19);
            this.keyListLabel.Name = "keyListLabel";
            this.keyListLabel.Size = new System.Drawing.Size(55, 17);
            this.keyListLabel.TabIndex = 2;
            this.keyListLabel.Text = "Ключи:";
            // 
            // arrowLabel
            // 
            this.arrowLabel.AutoSize = true;
            this.arrowLabel.Location = new System.Drawing.Point(341, 76);
            this.arrowLabel.Name = "arrowLabel";
            this.arrowLabel.Size = new System.Drawing.Size(24, 17);
            this.arrowLabel.TabIndex = 3;
            this.arrowLabel.Text = ">>";
            // 
            // decryptListBox
            // 
            this.decryptListBox.FormattingEnabled = true;
            this.decryptListBox.HorizontalScrollbar = true;
            this.decryptListBox.ItemHeight = 16;
            this.decryptListBox.Location = new System.Drawing.Point(370, 39);
            this.decryptListBox.Name = "decryptListBox";
            this.decryptListBox.Size = new System.Drawing.Size(465, 116);
            this.decryptListBox.TabIndex = 4;
            this.decryptListBox.SelectedIndexChanged += new System.EventHandler(this.decryptListBox_SelectedIndexChanged);
            // 
            // decryptListLabel
            // 
            this.decryptListLabel.AutoSize = true;
            this.decryptListLabel.Location = new System.Drawing.Point(367, 19);
            this.decryptListLabel.Name = "decryptListLabel";
            this.decryptListLabel.Size = new System.Drawing.Size(244, 17);
            this.decryptListLabel.TabIndex = 5;
            this.decryptListLabel.Text = "Варианты дешифрованного текста:";
            // 
            // decryptGB
            // 
            this.decryptGB.Controls.Add(this.useDictionaryCheckBox);
            this.decryptGB.Controls.Add(this.decryptButton);
            this.decryptGB.Controls.Add(this.decryptListLabel);
            this.decryptGB.Controls.Add(this.keysListBox);
            this.decryptGB.Controls.Add(this.decryptListBox);
            this.decryptGB.Controls.Add(this.keyListLabel);
            this.decryptGB.Controls.Add(this.arrowLabel);
            this.decryptGB.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.decryptGB.Location = new System.Drawing.Point(12, 159);
            this.decryptGB.Name = "decryptGB";
            this.decryptGB.Size = new System.Drawing.Size(847, 171);
            this.decryptGB.TabIndex = 6;
            this.decryptGB.TabStop = false;
            this.decryptGB.Text = "Дешифрование при помощи метода биграмм";
            // 
            // useDictionaryCheckBox
            // 
            this.useDictionaryCheckBox.AutoSize = true;
            this.useDictionaryCheckBox.Location = new System.Drawing.Point(9, 143);
            this.useDictionaryCheckBox.Name = "useDictionaryCheckBox";
            this.useDictionaryCheckBox.Size = new System.Drawing.Size(295, 21);
            this.useDictionaryCheckBox.TabIndex = 6;
            this.useDictionaryCheckBox.Text = "Использовать словарь для дешифровки";
            this.useDictionaryCheckBox.UseVisualStyleBackColor = true;
            this.useDictionaryCheckBox.CheckedChanged += new System.EventHandler(this.useDictionaryCheckBox_CheckedChanged);
            // 
            // encryptGB
            // 
            this.encryptGB.Controls.Add(this.encryptButton);
            this.encryptGB.Controls.Add(this.keyTextBox);
            this.encryptGB.Controls.Add(this.keyLabel);
            this.encryptGB.Controls.Add(this.encryptTextBox);
            this.encryptGB.Controls.Add(this.encryptTextLabel);
            this.encryptGB.Location = new System.Drawing.Point(12, 28);
            this.encryptGB.Name = "encryptGB";
            this.encryptGB.Size = new System.Drawing.Size(847, 125);
            this.encryptGB.TabIndex = 7;
            this.encryptGB.TabStop = false;
            this.encryptGB.Text = "Шифрование методом простой перестановки";
            // 
            // encryptButton
            // 
            this.encryptButton.Location = new System.Drawing.Point(601, 72);
            this.encryptButton.Name = "encryptButton";
            this.encryptButton.Size = new System.Drawing.Size(231, 39);
            this.encryptButton.TabIndex = 4;
            this.encryptButton.Text = "Зашифровать и сохранить";
            this.encryptButton.UseVisualStyleBackColor = true;
            this.encryptButton.Click += new System.EventHandler(this.encryptButton_Click);
            // 
            // keyTextBox
            // 
            this.keyTextBox.Location = new System.Drawing.Point(9, 88);
            this.keyTextBox.MaxLength = 9;
            this.keyTextBox.Name = "keyTextBox";
            this.keyTextBox.Size = new System.Drawing.Size(586, 22);
            this.keyTextBox.TabIndex = 3;
            this.keyTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.keyTextBox_KeyPress);
            // 
            // keyLabel
            // 
            this.keyLabel.AutoSize = true;
            this.keyLabel.Location = new System.Drawing.Point(6, 68);
            this.keyLabel.Name = "keyLabel";
            this.keyLabel.Size = new System.Drawing.Size(47, 17);
            this.keyLabel.TabIndex = 2;
            this.keyLabel.Text = "Ключ:";
            // 
            // encryptTextBox
            // 
            this.encryptTextBox.Location = new System.Drawing.Point(9, 43);
            this.encryptTextBox.MaxLength = 100;
            this.encryptTextBox.Name = "encryptTextBox";
            this.encryptTextBox.Size = new System.Drawing.Size(823, 22);
            this.encryptTextBox.TabIndex = 1;
            this.encryptTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.encryptTextBox_KeyPress);
            // 
            // encryptTextLabel
            // 
            this.encryptTextLabel.AutoSize = true;
            this.encryptTextLabel.Location = new System.Drawing.Point(6, 22);
            this.encryptTextLabel.Name = "encryptTextLabel";
            this.encryptTextLabel.Size = new System.Drawing.Size(167, 17);
            this.encryptTextLabel.TabIndex = 0;
            this.encryptTextLabel.Text = "Текст для шифрования:";
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.справкаToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(872, 25);
            this.menuStrip1.TabIndex = 8;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // справкаToolStripMenuItem
            // 
            this.справкаToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.оПрограммеToolStripMenuItem});
            this.справкаToolStripMenuItem.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.справкаToolStripMenuItem.Name = "справкаToolStripMenuItem";
            this.справкаToolStripMenuItem.Size = new System.Drawing.Size(75, 21);
            this.справкаToolStripMenuItem.Text = "Справка";
            // 
            // оПрограммеToolStripMenuItem
            // 
            this.оПрограммеToolStripMenuItem.Name = "оПрограммеToolStripMenuItem";
            this.оПрограммеToolStripMenuItem.Size = new System.Drawing.Size(162, 22);
            this.оПрограммеToolStripMenuItem.Text = "О программе";
            this.оПрограммеToolStripMenuItem.Click += new System.EventHandler(this.оПрограммеToolStripMenuItem_Click);
            // 
            // Bigram
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(872, 342);
            this.Controls.Add(this.encryptGB);
            this.Controls.Add(this.decryptGB);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Bigram";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "BIGRAM ENCRYPTOR/DECRYPTOR";
            this.decryptGB.ResumeLayout(false);
            this.decryptGB.PerformLayout();
            this.encryptGB.ResumeLayout(false);
            this.encryptGB.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button decryptButton;
        private System.Windows.Forms.ListBox keysListBox;
        private System.Windows.Forms.Label keyListLabel;
        private System.Windows.Forms.Label arrowLabel;
        private System.Windows.Forms.ListBox decryptListBox;
        private System.Windows.Forms.Label decryptListLabel;
        private System.Windows.Forms.GroupBox decryptGB;
        private System.Windows.Forms.GroupBox encryptGB;
        private System.Windows.Forms.TextBox encryptTextBox;
        private System.Windows.Forms.Label encryptTextLabel;
        private System.Windows.Forms.TextBox keyTextBox;
        private System.Windows.Forms.Label keyLabel;
        private System.Windows.Forms.Button encryptButton;
        private System.Windows.Forms.CheckBox useDictionaryCheckBox;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem справкаToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem оПрограммеToolStripMenuItem;
    }
}

