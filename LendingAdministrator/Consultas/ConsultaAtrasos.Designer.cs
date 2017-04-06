namespace LendingAdministrator.Consultas
{
    partial class ConsultaAtrasos
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
            this.AtrasodataGridView = new System.Windows.Forms.DataGridView();
            this.BuscarButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.AtrasotextBox = new System.Windows.Forms.TextBox();
            this.AtrasocomboBox = new System.Windows.Forms.ComboBox();
            this.ImprimirButton = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.AtrasodataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // AtrasodataGridView
            // 
            this.AtrasodataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.AtrasodataGridView.Location = new System.Drawing.Point(15, 86);
            this.AtrasodataGridView.Name = "AtrasodataGridView";
            this.AtrasodataGridView.Size = new System.Drawing.Size(547, 150);
            this.AtrasodataGridView.TabIndex = 9;
            // 
            // BuscarButton
            // 
            this.BuscarButton.Image = global::LendingAdministrator.Properties.Resources._1442277587_search;
            this.BuscarButton.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.BuscarButton.Location = new System.Drawing.Point(501, 38);
            this.BuscarButton.Name = "BuscarButton";
            this.BuscarButton.Size = new System.Drawing.Size(61, 42);
            this.BuscarButton.TabIndex = 8;
            this.BuscarButton.Text = "Consultar";
            this.BuscarButton.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.BuscarButton.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 53);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(83, 15);
            this.label1.TabIndex = 7;
            this.label1.Text = "Buscar Por:";
            // 
            // AtrasotextBox
            // 
            this.AtrasotextBox.Location = new System.Drawing.Point(243, 50);
            this.AtrasotextBox.Name = "AtrasotextBox";
            this.AtrasotextBox.Size = new System.Drawing.Size(252, 20);
            this.AtrasotextBox.TabIndex = 6;
            // 
            // AtrasocomboBox
            // 
            this.AtrasocomboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.AtrasocomboBox.FormattingEnabled = true;
            this.AtrasocomboBox.Items.AddRange(new object[] {
            "AtrasoId",
            "Atraso"});
            this.AtrasocomboBox.Location = new System.Drawing.Point(101, 50);
            this.AtrasocomboBox.Name = "AtrasocomboBox";
            this.AtrasocomboBox.Size = new System.Drawing.Size(136, 21);
            this.AtrasocomboBox.TabIndex = 5;
            // 
            // ImprimirButton
            // 
            this.ImprimirButton.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ImprimirButton.Image = global::LendingAdministrator.Properties.Resources._1490820793_print_icon;
            this.ImprimirButton.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.ImprimirButton.Location = new System.Drawing.Point(15, 242);
            this.ImprimirButton.Name = "ImprimirButton";
            this.ImprimirButton.Size = new System.Drawing.Size(52, 42);
            this.ImprimirButton.TabIndex = 10;
            this.ImprimirButton.Text = "Imprimir";
            this.ImprimirButton.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.ImprimirButton.UseVisualStyleBackColor = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(174, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(225, 25);
            this.label2.TabIndex = 11;
            this.label2.Text = "Consulta de Atrasos";
            // 
            // ConsultaAtrasos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(577, 243);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.ImprimirButton);
            this.Controls.Add(this.AtrasodataGridView);
            this.Controls.Add(this.BuscarButton);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.AtrasotextBox);
            this.Controls.Add(this.AtrasocomboBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "ConsultaAtrasos";
            this.Text = "Consulta de Atrasos";
            ((System.ComponentModel.ISupportInitialize)(this.AtrasodataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView AtrasodataGridView;
        private System.Windows.Forms.Button BuscarButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox AtrasotextBox;
        private System.Windows.Forms.ComboBox AtrasocomboBox;
        private System.Windows.Forms.Button ImprimirButton;
        private System.Windows.Forms.Label label2;
    }
}