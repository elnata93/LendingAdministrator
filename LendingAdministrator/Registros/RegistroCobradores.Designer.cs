namespace LendingAdministrator.Registros
{
    partial class RegistroCobradores
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
            this.CobradorerrorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            this.CedulatextBox = new System.Windows.Forms.MaskedTextBox();
            this.CelulartextBox = new System.Windows.Forms.MaskedTextBox();
            this.TelefonotextBox = new System.Windows.Forms.MaskedTextBox();
            this.Registrolabel = new System.Windows.Forms.Label();
            this.BuscarButton = new System.Windows.Forms.Button();
            this.EliminarButton = new System.Windows.Forms.Button();
            this.GuardarButton = new System.Windows.Forms.Button();
            this.NuevoButton = new System.Windows.Forms.Button();
            this.Cedulalabel = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.DirecciontextBox = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.ApellidotextBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.NombretextBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.IdTextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.CobradorerrorProvider)).BeginInit();
            this.SuspendLayout();
            // 
            // CobradorerrorProvider
            // 
            this.CobradorerrorProvider.ContainerControl = this;
            // 
            // CedulatextBox
            // 
            this.CedulatextBox.Location = new System.Drawing.Point(443, 261);
            this.CedulatextBox.Mask = "000-0000000-0";
            this.CedulatextBox.Name = "CedulatextBox";
            this.CedulatextBox.Size = new System.Drawing.Size(360, 20);
            this.CedulatextBox.TabIndex = 32;
            // 
            // CelulartextBox
            // 
            this.CelulartextBox.Location = new System.Drawing.Point(444, 201);
            this.CelulartextBox.Mask = "(999)-000-0000";
            this.CelulartextBox.Name = "CelulartextBox";
            this.CelulartextBox.Size = new System.Drawing.Size(357, 20);
            this.CelulartextBox.TabIndex = 30;
            // 
            // TelefonotextBox
            // 
            this.TelefonotextBox.Location = new System.Drawing.Point(444, 145);
            this.TelefonotextBox.Mask = "(999)-000-0000";
            this.TelefonotextBox.Name = "TelefonotextBox";
            this.TelefonotextBox.Size = new System.Drawing.Size(357, 20);
            this.TelefonotextBox.TabIndex = 29;
            // 
            // Registrolabel
            // 
            this.Registrolabel.AutoSize = true;
            this.Registrolabel.Font = new System.Drawing.Font("Arial Rounded MT Bold", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Registrolabel.Location = new System.Drawing.Point(278, 9);
            this.Registrolabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Registrolabel.Name = "Registrolabel";
            this.Registrolabel.Size = new System.Drawing.Size(291, 28);
            this.Registrolabel.TabIndex = 42;
            this.Registrolabel.Text = "Registro de Cobradores";
            // 
            // BuscarButton
            // 
            this.BuscarButton.Image = global::LendingAdministrator.Properties.Resources._1442277587_search;
            this.BuscarButton.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.BuscarButton.Location = new System.Drawing.Point(367, 66);
            this.BuscarButton.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.BuscarButton.Name = "BuscarButton";
            this.BuscarButton.Size = new System.Drawing.Size(53, 41);
            this.BuscarButton.TabIndex = 38;
            this.BuscarButton.Text = "Buscar";
            this.BuscarButton.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.BuscarButton.UseVisualStyleBackColor = true;
            this.BuscarButton.Click += new System.EventHandler(this.BuscarButton_Click);
            // 
            // EliminarButton
            // 
            this.EliminarButton.Image = global::LendingAdministrator.Properties.Resources.eliminar;
            this.EliminarButton.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.EliminarButton.Location = new System.Drawing.Point(437, 306);
            this.EliminarButton.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.EliminarButton.Name = "EliminarButton";
            this.EliminarButton.Size = new System.Drawing.Size(60, 67);
            this.EliminarButton.TabIndex = 36;
            this.EliminarButton.Text = "Eliminar";
            this.EliminarButton.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.EliminarButton.UseVisualStyleBackColor = true;
            this.EliminarButton.Click += new System.EventHandler(this.Eliminarbutton_Click);
            // 
            // GuardarButton
            // 
            this.GuardarButton.Image = global::LendingAdministrator.Properties.Resources.save;
            this.GuardarButton.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.GuardarButton.Location = new System.Drawing.Point(367, 306);
            this.GuardarButton.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.GuardarButton.Name = "GuardarButton";
            this.GuardarButton.Size = new System.Drawing.Size(53, 65);
            this.GuardarButton.TabIndex = 35;
            this.GuardarButton.Text = "Guardar";
            this.GuardarButton.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.GuardarButton.UseVisualStyleBackColor = true;
            this.GuardarButton.Click += new System.EventHandler(this.Guardarbutton_Click);
            // 
            // NuevoButton
            // 
            this.NuevoButton.Image = global::LendingAdministrator.Properties.Resources.nuevo;
            this.NuevoButton.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.NuevoButton.Location = new System.Drawing.Point(283, 307);
            this.NuevoButton.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.NuevoButton.Name = "NuevoButton";
            this.NuevoButton.Size = new System.Drawing.Size(59, 65);
            this.NuevoButton.TabIndex = 33;
            this.NuevoButton.Text = "Nuevo";
            this.NuevoButton.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.NuevoButton.UseVisualStyleBackColor = true;
            this.NuevoButton.Click += new System.EventHandler(this.Nuevobutton_Click);
            // 
            // Cedulalabel
            // 
            this.Cedulalabel.AutoSize = true;
            this.Cedulalabel.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Cedulalabel.Location = new System.Drawing.Point(441, 243);
            this.Cedulalabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Cedulalabel.Name = "Cedulalabel";
            this.Cedulalabel.Size = new System.Drawing.Size(53, 15);
            this.Cedulalabel.TabIndex = 41;
            this.Cedulalabel.Text = "Cedula";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(441, 183);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(55, 15);
            this.label7.TabIndex = 40;
            this.label7.Text = "Celular";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(440, 127);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(63, 15);
            this.label6.TabIndex = 39;
            this.label6.Text = "Telefono";
            // 
            // DirecciontextBox
            // 
            this.DirecciontextBox.Location = new System.Drawing.Point(12, 261);
            this.DirecciontextBox.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.DirecciontextBox.MaxLength = 100;
            this.DirecciontextBox.Name = "DirecciontextBox";
            this.DirecciontextBox.Size = new System.Drawing.Size(350, 20);
            this.DirecciontextBox.TabIndex = 28;
            this.DirecciontextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.DirecciontextBox_KeyPress);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(12, 243);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(71, 15);
            this.label4.TabIndex = 34;
            this.label4.Text = "Direccion";
            // 
            // ApellidotextBox
            // 
            this.ApellidotextBox.Location = new System.Drawing.Point(13, 200);
            this.ApellidotextBox.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.ApellidotextBox.MaxLength = 30;
            this.ApellidotextBox.Name = "ApellidotextBox";
            this.ApellidotextBox.Size = new System.Drawing.Size(349, 20);
            this.ApellidotextBox.TabIndex = 26;
            this.ApellidotextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.ApellidotextBox_KeyPress);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(12, 182);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(60, 15);
            this.label3.TabIndex = 31;
            this.label3.Text = "Apellido";
            // 
            // NombretextBox
            // 
            this.NombretextBox.Location = new System.Drawing.Point(12, 140);
            this.NombretextBox.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.NombretextBox.MaxLength = 30;
            this.NombretextBox.Name = "NombretextBox";
            this.NombretextBox.Size = new System.Drawing.Size(350, 20);
            this.NombretextBox.TabIndex = 24;
            this.NombretextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.NombretextBox_KeyPress);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(9, 122);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(59, 15);
            this.label2.TabIndex = 27;
            this.label2.Text = "Nombre";
            // 
            // IdTextBox
            // 
            this.IdTextBox.Location = new System.Drawing.Point(12, 84);
            this.IdTextBox.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.IdTextBox.MaxLength = 10;
            this.IdTextBox.Name = "IdTextBox";
            this.IdTextBox.Size = new System.Drawing.Size(350, 20);
            this.IdTextBox.TabIndex = 37;
            this.IdTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.CobradorIdtextBox_KeyPress);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(9, 66);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(81, 15);
            this.label1.TabIndex = 25;
            this.label1.Text = "CobradorId";
            // 
            // RegistroCobradores
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(815, 385);
            this.Controls.Add(this.CedulatextBox);
            this.Controls.Add(this.CelulartextBox);
            this.Controls.Add(this.TelefonotextBox);
            this.Controls.Add(this.Registrolabel);
            this.Controls.Add(this.BuscarButton);
            this.Controls.Add(this.EliminarButton);
            this.Controls.Add(this.GuardarButton);
            this.Controls.Add(this.NuevoButton);
            this.Controls.Add(this.Cedulalabel);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.DirecciontextBox);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.ApellidotextBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.NombretextBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.IdTextBox);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "RegistroCobradores";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "RegistroCobradores";
            this.Load += new System.EventHandler(this.RegistroCobradores_Load);
            ((System.ComponentModel.ISupportInitialize)(this.CobradorerrorProvider)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ErrorProvider CobradorerrorProvider;
        private System.Windows.Forms.MaskedTextBox CedulatextBox;
        private System.Windows.Forms.MaskedTextBox CelulartextBox;
        private System.Windows.Forms.MaskedTextBox TelefonotextBox;
        private System.Windows.Forms.Label Registrolabel;
        private System.Windows.Forms.Button BuscarButton;
        private System.Windows.Forms.Button EliminarButton;
        private System.Windows.Forms.Button GuardarButton;
        private System.Windows.Forms.Button NuevoButton;
        private System.Windows.Forms.Label Cedulalabel;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox DirecciontextBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox ApellidotextBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox NombretextBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox IdTextBox;
        private System.Windows.Forms.Label label1;
    }
}