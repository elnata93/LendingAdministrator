namespace LendingAdministrator.Registros
{
    partial class RegistroPrestamos
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
            this.PrestamoserrorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            this.SemanaNotextBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.ClientecomboBox = new System.Windows.Forms.ComboBox();
            this.EliminarButton = new System.Windows.Forms.Button();
            this.GuardarButton = new System.Windows.Forms.Button();
            this.NuevoButton = new System.Windows.Forms.Button();
            this.InterestextBox = new System.Windows.Forms.TextBox();
            this.label = new System.Windows.Forms.Label();
            this.CantidadCuotatextBox = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.FechaFdateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.FechaIdateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.MontotextBox = new System.Windows.Forms.TextBox();
            this.BuscarButton = new System.Windows.Forms.Button();
            this.IdTextBox = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.CuotaPtextBox = new System.Windows.Forms.TextBox();
            this.PagoTotaltextBox = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.PrestamoserrorProvider)).BeginInit();
            this.SuspendLayout();
            // 
            // PrestamoserrorProvider
            // 
            this.PrestamoserrorProvider.ContainerControl = this;
            // 
            // SemanaNotextBox
            // 
            this.SemanaNotextBox.Location = new System.Drawing.Point(12, 315);
            this.SemanaNotextBox.MaxLength = 2;
            this.SemanaNotextBox.Multiline = true;
            this.SemanaNotextBox.Name = "SemanaNotextBox";
            this.SemanaNotextBox.Size = new System.Drawing.Size(277, 29);
            this.SemanaNotextBox.TabIndex = 57;
            this.SemanaNotextBox.Text = "1";
            this.SemanaNotextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.SemanaNotextBox_KeyPress);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(12, 296);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(74, 15);
            this.label2.TabIndex = 56;
            this.label2.Text = "Semana #:";
            // 
            // ClientecomboBox
            // 
            this.ClientecomboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ClientecomboBox.FormattingEnabled = true;
            this.ClientecomboBox.Location = new System.Drawing.Point(12, 161);
            this.ClientecomboBox.Name = "ClientecomboBox";
            this.ClientecomboBox.Size = new System.Drawing.Size(570, 21);
            this.ClientecomboBox.TabIndex = 53;
            // 
            // EliminarButton
            // 
            this.EliminarButton.Image = global::LendingAdministrator.Properties.Resources.eliminar;
            this.EliminarButton.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.EliminarButton.Location = new System.Drawing.Point(350, 361);
            this.EliminarButton.Name = "EliminarButton";
            this.EliminarButton.Size = new System.Drawing.Size(60, 60);
            this.EliminarButton.TabIndex = 52;
            this.EliminarButton.Text = "Eliminar";
            this.EliminarButton.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.EliminarButton.UseVisualStyleBackColor = true;
            this.EliminarButton.Click += new System.EventHandler(this.EliminarButton_Click);
            // 
            // GuardarButton
            // 
            this.GuardarButton.Image = global::LendingAdministrator.Properties.Resources.save;
            this.GuardarButton.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.GuardarButton.Location = new System.Drawing.Point(267, 361);
            this.GuardarButton.Name = "GuardarButton";
            this.GuardarButton.Size = new System.Drawing.Size(60, 60);
            this.GuardarButton.TabIndex = 51;
            this.GuardarButton.Text = "Guardar";
            this.GuardarButton.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.GuardarButton.UseVisualStyleBackColor = true;
            this.GuardarButton.Click += new System.EventHandler(this.GuardarButton_Click);
            // 
            // NuevoButton
            // 
            this.NuevoButton.Image = global::LendingAdministrator.Properties.Resources.nuevo;
            this.NuevoButton.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.NuevoButton.Location = new System.Drawing.Point(181, 361);
            this.NuevoButton.Name = "NuevoButton";
            this.NuevoButton.Size = new System.Drawing.Size(60, 60);
            this.NuevoButton.TabIndex = 50;
            this.NuevoButton.Text = "Nuevo";
            this.NuevoButton.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.NuevoButton.UseVisualStyleBackColor = true;
            this.NuevoButton.Click += new System.EventHandler(this.NuevoButton_Click);
            // 
            // InterestextBox
            // 
            this.InterestextBox.Enabled = false;
            this.InterestextBox.Location = new System.Drawing.Point(436, 254);
            this.InterestextBox.MaxLength = 5;
            this.InterestextBox.Multiline = true;
            this.InterestextBox.Name = "InterestextBox";
            this.InterestextBox.Size = new System.Drawing.Size(146, 27);
            this.InterestextBox.TabIndex = 49;
            this.InterestextBox.Text = "0.10";
            // 
            // label
            // 
            this.label.AutoSize = true;
            this.label.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label.Location = new System.Drawing.Point(12, 144);
            this.label.Name = "label";
            this.label.Size = new System.Drawing.Size(54, 15);
            this.label.TabIndex = 47;
            this.label.Text = "Cliente";
            // 
            // CantidadCuotatextBox
            // 
            this.CantidadCuotatextBox.Enabled = false;
            this.CantidadCuotatextBox.Location = new System.Drawing.Point(292, 254);
            this.CantidadCuotatextBox.MaxLength = 2;
            this.CantidadCuotatextBox.Multiline = true;
            this.CantidadCuotatextBox.Name = "CantidadCuotatextBox";
            this.CantidadCuotatextBox.Size = new System.Drawing.Size(138, 27);
            this.CantidadCuotatextBox.TabIndex = 46;
            this.CantidadCuotatextBox.Text = "13";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(292, 236);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(70, 15);
            this.label8.TabIndex = 45;
            this.label8.Text = "Cantidad:";
            // 
            // FechaFdateTimePicker
            // 
            this.FechaFdateTimePicker.Location = new System.Drawing.Point(310, 110);
            this.FechaFdateTimePicker.Name = "FechaFdateTimePicker";
            this.FechaFdateTimePicker.Size = new System.Drawing.Size(272, 20);
            this.FechaFdateTimePicker.TabIndex = 44;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(221, 110);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(86, 15);
            this.label7.TabIndex = 43;
            this.label7.Text = "Fecha Final:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(213, 74);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(94, 15);
            this.label6.TabIndex = 42;
            this.label6.Text = "Fecha Inicial:";
            // 
            // FechaIdateTimePicker
            // 
            this.FechaIdateTimePicker.Location = new System.Drawing.Point(310, 74);
            this.FechaIdateTimePicker.Name = "FechaIdateTimePicker";
            this.FechaIdateTimePicker.Size = new System.Drawing.Size(272, 20);
            this.FechaIdateTimePicker.TabIndex = 41;
            // 
            // MontotextBox
            // 
            this.MontotextBox.Location = new System.Drawing.Point(12, 204);
            this.MontotextBox.MaxLength = 10;
            this.MontotextBox.Multiline = true;
            this.MontotextBox.Name = "MontotextBox";
            this.MontotextBox.Size = new System.Drawing.Size(570, 29);
            this.MontotextBox.TabIndex = 40;
            this.MontotextBox.TextChanged += new System.EventHandler(this.MontotextBox_TextChanged);
            this.MontotextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.MontotextBox_KeyPress);
            // 
            // BuscarButton
            // 
            this.BuscarButton.Image = global::LendingAdministrator.Properties.Resources._1442277587_search;
            this.BuscarButton.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.BuscarButton.Location = new System.Drawing.Point(157, 58);
            this.BuscarButton.Name = "BuscarButton";
            this.BuscarButton.Size = new System.Drawing.Size(50, 39);
            this.BuscarButton.TabIndex = 39;
            this.BuscarButton.Text = "Buscar";
            this.BuscarButton.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.BuscarButton.UseVisualStyleBackColor = true;
            this.BuscarButton.Click += new System.EventHandler(this.BuscarButton_Click);
            // 
            // IdTextBox
            // 
            this.IdTextBox.Location = new System.Drawing.Point(12, 74);
            this.IdTextBox.MaxLength = 10;
            this.IdTextBox.Name = "IdTextBox";
            this.IdTextBox.Size = new System.Drawing.Size(129, 20);
            this.IdTextBox.TabIndex = 38;
            this.IdTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.PrestamoIdtextBox_KeyPress);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(12, 187);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(47, 15);
            this.label5.TabIndex = 37;
            this.label5.Text = "Monto";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 55);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(92, 15);
            this.label1.TabIndex = 36;
            this.label1.Text = "Prestamos Id";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(436, 236);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(57, 15);
            this.label3.TabIndex = 58;
            this.label3.Text = "Interes:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(12, 235);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(50, 15);
            this.label4.TabIndex = 59;
            this.label4.Text = "Cuota:";
            // 
            // CuotaPtextBox
            // 
            this.CuotaPtextBox.Location = new System.Drawing.Point(12, 254);
            this.CuotaPtextBox.Multiline = true;
            this.CuotaPtextBox.Name = "CuotaPtextBox";
            this.CuotaPtextBox.Size = new System.Drawing.Size(277, 27);
            this.CuotaPtextBox.TabIndex = 60;
            this.CuotaPtextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.CuotaPtextBox_KeyPress);
            // 
            // PagoTotaltextBox
            // 
            this.PagoTotaltextBox.Enabled = false;
            this.PagoTotaltextBox.Location = new System.Drawing.Point(292, 314);
            this.PagoTotaltextBox.Multiline = true;
            this.PagoTotaltextBox.Name = "PagoTotaltextBox";
            this.PagoTotaltextBox.Size = new System.Drawing.Size(290, 30);
            this.PagoTotaltextBox.TabIndex = 61;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(295, 298);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(0, 13);
            this.label9.TabIndex = 62;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(292, 298);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(80, 15);
            this.label10.TabIndex = 63;
            this.label10.Text = "Pago Total:";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(176, 9);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(251, 25);
            this.label11.TabIndex = 64;
            this.label11.Text = "Registro de Prestamos";
            // 
            // RegistroPrestamos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(595, 433);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.PagoTotaltextBox);
            this.Controls.Add(this.CuotaPtextBox);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.SemanaNotextBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.ClientecomboBox);
            this.Controls.Add(this.EliminarButton);
            this.Controls.Add(this.GuardarButton);
            this.Controls.Add(this.NuevoButton);
            this.Controls.Add(this.InterestextBox);
            this.Controls.Add(this.label);
            this.Controls.Add(this.CantidadCuotatextBox);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.FechaFdateTimePicker);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.FechaIdateTimePicker);
            this.Controls.Add(this.MontotextBox);
            this.Controls.Add(this.BuscarButton);
            this.Controls.Add(this.IdTextBox);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "RegistroPrestamos";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "RegistroPrestamos";
            this.Load += new System.EventHandler(this.RegistroPrestamos_Load);
            ((System.ComponentModel.ISupportInitialize)(this.PrestamoserrorProvider)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ErrorProvider PrestamoserrorProvider;
        private System.Windows.Forms.TextBox SemanaNotextBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox ClientecomboBox;
        private System.Windows.Forms.Button EliminarButton;
        private System.Windows.Forms.Button GuardarButton;
        private System.Windows.Forms.Button NuevoButton;
        private System.Windows.Forms.TextBox InterestextBox;
        private System.Windows.Forms.Label label;
        private System.Windows.Forms.TextBox CantidadCuotatextBox;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.DateTimePicker FechaFdateTimePicker;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DateTimePicker FechaIdateTimePicker;
        private System.Windows.Forms.TextBox MontotextBox;
        private System.Windows.Forms.Button BuscarButton;
        private System.Windows.Forms.TextBox IdTextBox;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox PagoTotaltextBox;
        private System.Windows.Forms.TextBox CuotaPtextBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label11;
    }
}