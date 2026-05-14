namespace Ejercicio3_Refactorizacion
{
    partial class FormRefactorizacion
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
                components.Dispose();
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            this.lblTitulo         = new System.Windows.Forms.Label();
            this.tabControl1       = new System.Windows.Forms.TabControl();
            this.tabErrores        = new System.Windows.Forms.TabPage();
            this.dgvErrores        = new System.Windows.Forms.DataGridView();
            this.colNum            = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colCategoria      = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colError          = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colCorreccion     = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tabOriginal       = new System.Windows.Forms.TabPage();
            this.txtOriginal       = new System.Windows.Forms.RichTextBox();
            this.tabRefactorizado  = new System.Windows.Forms.TabPage();
            this.txtRefactorizado  = new System.Windows.Forms.RichTextBox();
            this.tabControl1.SuspendLayout();
            this.tabErrores.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvErrores)).BeginInit();
            this.tabOriginal.SuspendLayout();
            this.tabRefactorizado.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblTitulo
            // 
            this.lblTitulo.BackColor = System.Drawing.Color.FromArgb(52, 73, 94);
            this.lblTitulo.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblTitulo.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitulo.ForeColor = System.Drawing.Color.White;
            this.lblTitulo.Location = new System.Drawing.Point(0, 0);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(984, 48);
            this.lblTitulo.TabIndex = 0;
            this.lblTitulo.Text = "  Ejercicio 3 — Refactorizacion: 10 Errores Detectados y Corregidos";
            this.lblTitulo.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // tabControl1
            // 
            this.tabControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right)));
            this.tabControl1.Controls.Add(this.tabErrores);
            this.tabControl1.Controls.Add(this.tabOriginal);
            this.tabControl1.Controls.Add(this.tabRefactorizado);
            this.tabControl1.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabControl1.Location = new System.Drawing.Point(0, 48);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(984, 574);
            this.tabControl1.TabIndex = 1;
            // 
            // tabErrores
            // 
            this.tabErrores.BackColor = System.Drawing.Color.WhiteSmoke;
            this.tabErrores.Controls.Add(this.dgvErrores);
            this.tabErrores.Location = new System.Drawing.Point(4, 26);
            this.tabErrores.Name = "tabErrores";
            this.tabErrores.Padding = new System.Windows.Forms.Padding(3);
            this.tabErrores.Size = new System.Drawing.Size(976, 544);
            this.tabErrores.TabIndex = 0;
            this.tabErrores.Text = "  Lista de 10 Errores  ";
            // 
            // dgvErrores
            // 
            this.dgvErrores.AllowUserToAddRows = false;
            this.dgvErrores.AllowUserToDeleteRows = false;
            this.dgvErrores.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvErrores.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgvErrores.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvErrores.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colNum, this.colCategoria, this.colError, this.colCorreccion});
            this.dgvErrores.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvErrores.EnableHeadersVisualStyles = false;
            this.dgvErrores.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgvErrores.Location = new System.Drawing.Point(3, 3);
            this.dgvErrores.Name = "dgvErrores";
            this.dgvErrores.ReadOnly = true;
            this.dgvErrores.RowHeadersVisible = false;
            this.dgvErrores.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvErrores.Size = new System.Drawing.Size(970, 538);
            this.dgvErrores.TabIndex = 0;
            this.dgvErrores.ColumnHeadersDefaultCellStyle.BackColor = System.Drawing.Color.FromArgb(52, 73, 94);
            this.dgvErrores.ColumnHeadersDefaultCellStyle.ForeColor = System.Drawing.Color.White;
            this.dgvErrores.ColumnHeadersDefaultCellStyle.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgvErrores.AlternatingRowsDefaultCellStyle.BackColor = System.Drawing.Color.AliceBlue;
            // 
            // colNum
            // 
            this.colNum.FillWeight = 5F;
            this.colNum.HeaderText = "#";
            this.colNum.Name = "colNum";
            this.colNum.ReadOnly = true;
            // 
            // colCategoria
            // 
            this.colCategoria.FillWeight = 16F;
            this.colCategoria.HeaderText = "Categoria";
            this.colCategoria.Name = "colCategoria";
            this.colCategoria.ReadOnly = true;
            // 
            // colError
            // 
            this.colError.FillWeight = 40F;
            this.colError.HeaderText = "Error detectado";
            this.colError.Name = "colError";
            this.colError.ReadOnly = true;
            this.colError.DefaultCellStyle.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            // 
            // colCorreccion
            // 
            this.colCorreccion.FillWeight = 39F;
            this.colCorreccion.HeaderText = "Correccion aplicada";
            this.colCorreccion.Name = "colCorreccion";
            this.colCorreccion.ReadOnly = true;
            this.colCorreccion.DefaultCellStyle.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.colCorreccion.DefaultCellStyle.Font = new System.Drawing.Font("Courier New", 8.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.colCorreccion.DefaultCellStyle.ForeColor = System.Drawing.Color.DarkGreen;
            // 
            // tabOriginal
            // 
            this.tabOriginal.BackColor = System.Drawing.Color.WhiteSmoke;
            this.tabOriginal.Controls.Add(this.txtOriginal);
            this.tabOriginal.Location = new System.Drawing.Point(4, 26);
            this.tabOriginal.Name = "tabOriginal";
            this.tabOriginal.Padding = new System.Windows.Forms.Padding(3);
            this.tabOriginal.Size = new System.Drawing.Size(976, 544);
            this.tabOriginal.TabIndex = 1;
            this.tabOriginal.Text = "  Codigo Original (errores)  ";
            // 
            // txtOriginal
            // 
            this.txtOriginal.BackColor = System.Drawing.Color.FromArgb(255, 243, 243);
            this.txtOriginal.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtOriginal.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtOriginal.Font = new System.Drawing.Font("Courier New", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtOriginal.ForeColor = System.Drawing.Color.Maroon;
            this.txtOriginal.Location = new System.Drawing.Point(3, 3);
            this.txtOriginal.Name = "txtOriginal";
            this.txtOriginal.ReadOnly = true;
            this.txtOriginal.Size = new System.Drawing.Size(970, 538);
            this.txtOriginal.TabIndex = 0;
            this.txtOriginal.Text = "";
            // 
            // tabRefactorizado
            // 
            this.tabRefactorizado.BackColor = System.Drawing.Color.WhiteSmoke;
            this.tabRefactorizado.Controls.Add(this.txtRefactorizado);
            this.tabRefactorizado.Location = new System.Drawing.Point(4, 26);
            this.tabRefactorizado.Name = "tabRefactorizado";
            this.tabRefactorizado.Padding = new System.Windows.Forms.Padding(3);
            this.tabRefactorizado.Size = new System.Drawing.Size(976, 544);
            this.tabRefactorizado.TabIndex = 2;
            this.tabRefactorizado.Text = "  Codigo Refactorizado (correcto)  ";
            // 
            // txtRefactorizado
            // 
            this.txtRefactorizado.BackColor = System.Drawing.Color.FromArgb(240, 255, 240);
            this.txtRefactorizado.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtRefactorizado.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtRefactorizado.Font = new System.Drawing.Font("Courier New", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtRefactorizado.ForeColor = System.Drawing.Color.DarkGreen;
            this.txtRefactorizado.Location = new System.Drawing.Point(3, 3);
            this.txtRefactorizado.Name = "txtRefactorizado";
            this.txtRefactorizado.ReadOnly = true;
            this.txtRefactorizado.Size = new System.Drawing.Size(970, 538);
            this.txtRefactorizado.TabIndex = 0;
            this.txtRefactorizado.Text = "";
            // 
            // FormRefactorizacion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(984, 622);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.lblTitulo);
            this.Name = "FormRefactorizacion";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Ejercicio 3 — Refactorizacion de Codigo";
            this.tabControl1.ResumeLayout(false);
            this.tabErrores.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvErrores)).EndInit();
            this.tabOriginal.ResumeLayout(false);
            this.tabRefactorizado.ResumeLayout(false);
            this.ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabErrores;
        private System.Windows.Forms.DataGridView dgvErrores;
        private System.Windows.Forms.DataGridViewTextBoxColumn colNum;
        private System.Windows.Forms.DataGridViewTextBoxColumn colCategoria;
        private System.Windows.Forms.DataGridViewTextBoxColumn colError;
        private System.Windows.Forms.DataGridViewTextBoxColumn colCorreccion;
        private System.Windows.Forms.TabPage tabOriginal;
        private System.Windows.Forms.RichTextBox txtOriginal;
        private System.Windows.Forms.TabPage tabRefactorizado;
        private System.Windows.Forms.RichTextBox txtRefactorizado;
    }
}
