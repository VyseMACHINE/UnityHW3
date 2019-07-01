namespace WindowsFormsApp2
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
            this.txtSourceFile = new System.Windows.Forms.TextBox();
            this.txtKey = new System.Windows.Forms.TextBox();
            this.btnSourceFile = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.pbFileCopy = new System.Windows.Forms.ProgressBar();
            this.btnStart = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.rdXorAdd = new System.Windows.Forms.RadioButton();
            this.rdXorRem = new System.Windows.Forms.RadioButton();
            this.SuspendLayout();
            // 
            // txtSourceFile
            // 
            this.txtSourceFile.Location = new System.Drawing.Point(80, 17);
            this.txtSourceFile.Name = "txtSourceFile";
            this.txtSourceFile.Size = new System.Drawing.Size(382, 20);
            this.txtSourceFile.TabIndex = 0;
            // 
            // txtKey
            // 
            this.txtKey.Location = new System.Drawing.Point(80, 43);
            this.txtKey.Name = "txtKey";
            this.txtKey.Size = new System.Drawing.Size(57, 20);
            this.txtKey.TabIndex = 1;
            this.txtKey.UseSystemPasswordChar = true;
            // 
            // btnSourceFile
            // 
            this.btnSourceFile.Location = new System.Drawing.Point(468, 17);
            this.btnSourceFile.Name = "btnSourceFile";
            this.btnSourceFile.Size = new System.Drawing.Size(75, 20);
            this.btnSourceFile.TabIndex = 2;
            this.btnSourceFile.Text = "Browse";
            this.btnSourceFile.UseVisualStyleBackColor = true;
            this.btnSourceFile.Click += new System.EventHandler(this.btnBrowse_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Source";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 47);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Password";
            // 
            // pbFileCopy
            // 
            this.pbFileCopy.Location = new System.Drawing.Point(12, 90);
            this.pbFileCopy.Name = "pbFileCopy";
            this.pbFileCopy.Size = new System.Drawing.Size(531, 23);
            this.pbFileCopy.TabIndex = 6;
            // 
            // btnStart
            // 
            this.btnStart.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnStart.Location = new System.Drawing.Point(15, 138);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(75, 23);
            this.btnStart.TabIndex = 7;
            this.btnStart.Text = "&Start";
            this.btnStart.UseVisualStyleBackColor = true;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // btnClose
            // 
            this.btnClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnClose.Location = new System.Drawing.Point(468, 138);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(75, 23);
            this.btnClose.TabIndex = 9;
            this.btnClose.Text = "&Close";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(260, 74);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(48, 13);
            this.label3.TabIndex = 10;
            this.label3.Text = "Progress";
            // 
            // rdXorAdd
            // 
            this.rdXorAdd.AutoSize = true;
            this.rdXorAdd.Location = new System.Drawing.Point(320, 47);
            this.rdXorAdd.Name = "rdXorAdd";
            this.rdXorAdd.Size = new System.Drawing.Size(95, 17);
            this.rdXorAdd.TabIndex = 12;
            this.rdXorAdd.TabStop = true;
            this.rdXorAdd.Text = "Зашифровать";
            this.rdXorAdd.UseVisualStyleBackColor = true;
            // 
            // rdXorRem
            // 
            this.rdXorRem.AutoSize = true;
            this.rdXorRem.Location = new System.Drawing.Point(431, 47);
            this.rdXorRem.Name = "rdXorRem";
            this.rdXorRem.Size = new System.Drawing.Size(101, 17);
            this.rdXorRem.TabIndex = 13;
            this.rdXorRem.TabStop = true;
            this.rdXorRem.Text = "Расшифровать";
            this.rdXorRem.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(559, 178);
            this.Controls.Add(this.rdXorRem);
            this.Controls.Add(this.rdXorAdd);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnStart);
            this.Controls.Add(this.pbFileCopy);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnSourceFile);
            this.Controls.Add(this.txtKey);
            this.Controls.Add(this.txtSourceFile);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

    }

    #endregion

    private System.Windows.Forms.TextBox txtSourceFile;
    private System.Windows.Forms.TextBox txtKey;
    private System.Windows.Forms.Button btnSourceFile;
    private System.Windows.Forms.Label label1;
    private System.Windows.Forms.Label label2;
    private System.Windows.Forms.ProgressBar pbFileCopy;
    private System.Windows.Forms.Button btnStart;
    private System.Windows.Forms.Button btnClose;
    private System.Windows.Forms.Label label3;
        private System.Windows.Forms.RadioButton rdXorAdd;
        private System.Windows.Forms.RadioButton rdXorRem;
    }
}

