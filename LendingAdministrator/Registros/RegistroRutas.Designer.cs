namespace LendingAdministrator.Registros
{
    partial class RegistroRutas
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
            this.BuscarButton = new System.Windows.Forms.Button();
            this.CobradorIdcomboBox = new System.Windows.Forms.ComboBox();
            this.CobradorIdlabel = new System.Windows.Forms.Label();
            this.NombreRutatextBox = new System.Windows.Forms.TextBox();
            this.NombreRutalabel = new System.Windows.Forms.Label();
            this.IdTextBox = new System.Windows.Forms.TextBox();
            this.RutaIdlabel = new System.Windows.Forms.Label();
            this.Registrolabel = new System.Windows.Forms.Label();
            this.GuardarButton = new System.Windows.Forms.Button();
            this.NuevoButton = new System.Windows.Forms.Button();
            this.EliminarButton = new System.Windows.Forms.Button();
            this.RutaerrorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.RutaerrorProvider)).BeginInit();
            this.SuspendLayout();
            // 
            // BuscarButton
            // 
            this.BuscarButton.Image = global::LendingAdministrator.Properties.Resources._1442277587_search;
            this.BuscarButton.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.BuscarButton.Location = new System.Drawing.Point(308, 60);
            this.BuscarButton.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.BuscarButton.Name = "BuscarButton";
            this.BuscarButton.Size = new System.Drawing.Size(49, 41);
            this.BuscarButton.TabIndex = 35;
            this.BuscarButton.Text = "Buscar";
            this.BuscarButton.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.BuscarButton.UseVisualStyleBackColor = true;
            this.BuscarButton.Click += new System.EventHandler(this.BuscarButton_Click);
            // 
            // CobradorIdcomboBox
            // 
            this.CobradorIdcomboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CobradorIdcomboBox.FormattingEnabled = true;
            this.CobradorIdcomboBox.Location = new System.Drawing.Point(21, 198);
            this.CobradorIdcomboBox.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.CobradorIdcomboBox.Name = "CobradorIdcomboBox";
            this.CobradorIdcomboBox.Size = new System.Drawing.Size(336, 21);
            this.CobradorIdcomboBox.TabIndex = 38;
            this.CobradorIdcomboBox.SelectedIndexChanged += new System.EventHandler(this.CobradorIdcomboBox_SelectedIndexChanged);
            // 
            // CobradorIdlabel
            // 
            this.CobradorIdlabel.AutoSize = true;
            this.CobradorIdlabel.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CobradorIdlabel.Location = new System.Drawing.Point(21, 180);
            this.CobradorIdlabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.CobradorIdlabel.Name = "CobradorIdlabel";
            this.CobradorIdlabel.Size = new System.Drawing.Size(69, 15);
            this.CobradorIdlabel.TabIndex = 47;
            this.CobradorIdlabel.Text = "Cobrador";
            // 
            // NombreRutatextBox
            // 
            this.NombreRutatextBox.Location = new System.Drawing.Point(21, 142);
            this.NombreRutatextBox.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.NombreRutatextBox.MaxLength = 100;
            this.NombreRutatextBox.Multiline = true;
            this.NombreRutatextBox.Name = "NombreRutatextBox";
            this.NombreRutatextBox.Size = new System.Drawing.Size(336, 35);
            this.NombreRutatextBox.TabIndex = 36;
            this.NombreRutatextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.NombreRutatextBox_KeyPress);
            // 
            // NombreRutalabel
            // 
            this.NombreRutalabel.AutoSize = true;
            this.NombreRutalabel.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NombreRutalabel.Location = new System.Drawing.Point(21, 124);
            this.NombreRutalabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.NombreRutalabel.Name = "NombreRutalabel";
            this.NombreRutalabel.Size = new System.Drawing.Size(111, 15);
            this.NombreRutalabel.TabIndex = 45;
            this.NombreRutalabel.Text = "Nombre de Ruta";
            // 
            // IdTextBox
            // 
            this.IdTextBox.Location = new System.Drawing.Point(21, 79);
            this.IdTextBox.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.IdTextBox.MaxLength = 10;
            this.IdTextBox.Name = "IdTextBox";
            this.IdTextBox.Size = new System.Drawing.Size(271, 20);
            this.IdTextBox.TabIndex = 34;
            this.IdTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.RutaIdtextBox_KeyPress);
            // 
            // RutaIdlabel
            // 
            this.RutaIdlabel.AutoSize = true;
            this.RutaIdlabel.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RutaIdlabel.Location = new System.Drawing.Point(21, 60);
            this.RutaIdlabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.RutaIdlabel.Name = "RutaIdlabel";
            this.RutaIdlabel.Size = new System.Drawing.Size(21, 15);
            this.RutaIdlabel.TabIndex = 44;
            this.RutaIdlabel.Text = "ID";
            // 
            // Registrolabel
            // 
            this.Registrolabel.AutoSize = true;
            this.Registrolabel.Font = new System.Drawing.Font("Arial Rounded MT Bold", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Registrolabel.Location = new System.Drawing.Point(76, 9);
            this.Registrolabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Registrolabel.Name = "Registrolabel";
            this.Registrolabel.Size = new System.Drawing.Size(218, 28);
            this.Registrolabel.TabIndex = 43;
            this.Registrolabel.Text = "Registro de Rutas";
            // 
            // GuardarButton
            // 
            this.GuardarButton.Image = global::LendingAdministrator.Properties.Resources.save;
            this.GuardarButton.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.GuardarButton.Location = new System.Drawing.Point(160, 236);
            this.GuardarButton.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.GuardarButton.Name = "GuardarButton";
            this.GuardarButton.Size = new System.Drawing.Size(62, 62);
            this.GuardarButton.TabIndex = 41;
            this.GuardarButton.Text = "Guardar";
            this.GuardarButton.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.GuardarButton.UseVisualStyleBackColor = true;
            this.GuardarButton.Click += new System.EventHandler(this.GuardarButton_Click);
            // 
            // NuevoButton
            // 
            this.NuevoButton.Image = global::LendingAdministrator.Properties.Resources.nuevo;
            this.NuevoButton.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.NuevoButton.Location = new System.Drawing.Point(70, 236);
            this.NuevoButton.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.NuevoButton.Name = "NuevoButton";
            this.NuevoButton.Size = new System.Drawing.Size(62, 62);
            this.NuevoButton.TabIndex = 40;
            this.NuevoButton.Text = "Nuevo";
            this.NuevoButton.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.NuevoButton.UseVisualStyleBackColor = true;
            this.NuevoButton.Click += new System.EventHandler(this.NuevoButton_Click);
            // 
            // EliminarButton
            // 
            this.EliminarButton.Image = global::LendingAdministrator.Properties.Resources.eliminar;
            this.EliminarButton.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.EliminarButton.Location = new System.Drawing.Point(250, 236);
            this.EliminarButton.Name = "EliminarButton";
            this.EliminarButton.Size = new System.Drawing.Size(62, 62);
            this.EliminarButton.TabIndex = 48;
            this.EliminarButton.Text = "Eliminar";
            this.EliminarButton.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.EliminarButton.UseVisualStyleBackColor = true;
            this.EliminarButton.Click += new System.EventHandler(this.EliminarButton_Click);
            // 
            // RutaerrorProvider
            // 
            this.RutaerrorProvider.ContainerControl = this;
            // 
            // RegistroRutas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(380, 314);
            this.Controls.Add(this.EliminarButton);
            this.Controls.Add(this.BuscarButton);
            this.Controls.Add(this.CobradorIdcomboBox);
            this.Controls.Add(this.CobradorIdlabel);
            this.Controls.Add(this.NombreRutatextBox);
            this.Controls.Add(this.NombreRutalabel);
            this.Controls.Add(this.IdTextBox);
            this.Controls.Add(this.RutaIdlabel);
            this.Controls.Add(this.Registrolabel);
            this.Controls.Add(this.GuardarButton);
            this.Controls.Add(this.NuevoButton);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "RegistroRutas";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "RegistroRutas";
            this.Load += new System.EventHandler(this.RegistroRutas_Load);
            ((System.ComponentModel.ISupportInitialize)(this.RutaerrorProvider)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button BuscarButton;
        private System.Windows.Forms.ComboBox CobradorIdcomboBox;
        private System.Windows.Forms.Label CobradorIdlabel;
        private System.Windows.Forms.TextBox NombreRutatextBox;
        private System.Windows.Forms.Label NombreRutalabel;
        private System.Windows.Forms.TextBox IdTextBox;
        private System.Windows.Forms.Label RutaIdlabel;
        private System.Windows.Forms.Label Registrolabel;
        private System.Windows.Forms.Button GuardarButton;
        private System.Windows.Forms.Button NuevoButton;
        private System.Windows.Forms.Button EliminarButton;
        private System.Windows.Forms.ErrorProvider RutaerrorProvider;
    }
}