namespace LendingAdministrator
{
    partial class Login
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Login));
            this.SysPrestamoslabel = new System.Windows.Forms.Label();
            this.CancelarButton = new System.Windows.Forms.Button();
            this.ContrasenaTextBox = new System.Windows.Forms.TextBox();
            this.usuarioTextBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.IniciarButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // SysPrestamoslabel
            // 
            this.SysPrestamoslabel.AutoSize = true;
            this.SysPrestamoslabel.Font = new System.Drawing.Font("Arial Rounded MT Bold", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SysPrestamoslabel.Location = new System.Drawing.Point(9, 19);
            this.SysPrestamoslabel.Name = "SysPrestamoslabel";
            this.SysPrestamoslabel.Size = new System.Drawing.Size(277, 28);
            this.SysPrestamoslabel.TabIndex = 17;
            this.SysPrestamoslabel.Text = "Lending Administrator ";
            // 
            // CancelarButton
            // 
            this.CancelarButton.Font = new System.Drawing.Font("Constantia", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CancelarButton.Image = global::LendingAdministrator.Properties.Resources.Cancel__Red;
            this.CancelarButton.Location = new System.Drawing.Point(201, 399);
            this.CancelarButton.Name = "CancelarButton";
            this.CancelarButton.Size = new System.Drawing.Size(65, 38);
            this.CancelarButton.TabIndex = 16;
            this.CancelarButton.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.CancelarButton.UseVisualStyleBackColor = true;
            this.CancelarButton.Click += new System.EventHandler(this.CancelarButton_Click);
            // 
            // ContrasenaTextBox
            // 
            this.ContrasenaTextBox.Location = new System.Drawing.Point(14, 373);
            this.ContrasenaTextBox.MaxLength = 50;
            this.ContrasenaTextBox.Name = "ContrasenaTextBox";
            this.ContrasenaTextBox.Size = new System.Drawing.Size(252, 20);
            this.ContrasenaTextBox.TabIndex = 14;
            this.ContrasenaTextBox.UseSystemPasswordChar = true;
            this.ContrasenaTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.ContrasenaTextBox_KeyPress);
            // 
            // usuarioTextBox
            // 
            this.usuarioTextBox.Location = new System.Drawing.Point(14, 332);
            this.usuarioTextBox.MaxLength = 40;
            this.usuarioTextBox.Name = "usuarioTextBox";
            this.usuarioTextBox.Size = new System.Drawing.Size(252, 20);
            this.usuarioTextBox.TabIndex = 13;
            this.usuarioTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.usuarioTextBox_KeyPress);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(13, 355);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(100, 15);
            this.label2.TabIndex = 12;
            this.label2.Text = "CONTRASEÑA";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(13, 314);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(68, 15);
            this.label1.TabIndex = 11;
            this.label1.Text = "USUARIO";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::LendingAdministrator.Properties.Resources.personal_information_98356;
            this.pictureBox1.Location = new System.Drawing.Point(14, 63);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(252, 248);
            this.pictureBox1.TabIndex = 18;
            this.pictureBox1.TabStop = false;
            // 
            // IniciarButton
            // 
            this.IniciarButton.Font = new System.Drawing.Font("Constantia", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.IniciarButton.Image = global::LendingAdministrator.Properties.Resources.file_locked;
            this.IniciarButton.Location = new System.Drawing.Point(14, 399);
            this.IniciarButton.Name = "IniciarButton";
            this.IniciarButton.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.IniciarButton.Size = new System.Drawing.Size(67, 38);
            this.IniciarButton.TabIndex = 15;
            this.IniciarButton.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.IniciarButton.UseVisualStyleBackColor = true;
            this.IniciarButton.Click += new System.EventHandler(this.IniciarButton_Click);
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SkyBlue;
            this.ClientSize = new System.Drawing.Size(284, 457);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.SysPrestamoslabel);
            this.Controls.Add(this.CancelarButton);
            this.Controls.Add(this.IniciarButton);
            this.Controls.Add(this.ContrasenaTextBox);
            this.Controls.Add(this.usuarioTextBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Login";
            this.Text = "Login";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label SysPrestamoslabel;
        private System.Windows.Forms.Button CancelarButton;
        private System.Windows.Forms.Button IniciarButton;
        private System.Windows.Forms.TextBox ContrasenaTextBox;
        private System.Windows.Forms.TextBox usuarioTextBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}