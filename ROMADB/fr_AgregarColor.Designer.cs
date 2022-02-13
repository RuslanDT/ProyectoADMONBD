
namespace ROMADB
{
    partial class fr_AgregarColor
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
            this.btn_agregar = new System.Windows.Forms.Button();
            this.btn_cancelar = new System.Windows.Forms.Button();
            this.lblColor = new System.Windows.Forms.Label();
            this.txtColor = new System.Windows.Forms.TextBox();
            this.chckModificarColor = new System.Windows.Forms.CheckBox();
            this.cBoxColores = new System.Windows.Forms.ComboBox();
            this.lblNuevoColor = new System.Windows.Forms.Label();
            this.txtColor2 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btn_agregar
            // 
            this.btn_agregar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(160)))), ((int)(((byte)(34)))));
            this.btn_agregar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_agregar.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(191)))), ((int)(((byte)(0)))));
            this.btn_agregar.FlatAppearance.BorderSize = 2;
            this.btn_agregar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(191)))), ((int)(((byte)(0)))));
            this.btn_agregar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(120)))), ((int)(((byte)(27)))));
            this.btn_agregar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_agregar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_agregar.ForeColor = System.Drawing.Color.White;
            this.btn_agregar.Location = new System.Drawing.Point(266, 132);
            this.btn_agregar.Name = "btn_agregar";
            this.btn_agregar.Size = new System.Drawing.Size(101, 26);
            this.btn_agregar.TabIndex = 5;
            this.btn_agregar.Text = "AGREGAR";
            this.btn_agregar.UseVisualStyleBackColor = false;
            this.btn_agregar.Click += new System.EventHandler(this.btn_agregar_Click);
            // 
            // btn_cancelar
            // 
            this.btn_cancelar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(160)))), ((int)(((byte)(34)))));
            this.btn_cancelar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_cancelar.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(191)))), ((int)(((byte)(0)))));
            this.btn_cancelar.FlatAppearance.BorderSize = 2;
            this.btn_cancelar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(191)))), ((int)(((byte)(0)))));
            this.btn_cancelar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(120)))), ((int)(((byte)(27)))));
            this.btn_cancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_cancelar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_cancelar.ForeColor = System.Drawing.Color.White;
            this.btn_cancelar.Location = new System.Drawing.Point(132, 132);
            this.btn_cancelar.Name = "btn_cancelar";
            this.btn_cancelar.Size = new System.Drawing.Size(99, 26);
            this.btn_cancelar.TabIndex = 6;
            this.btn_cancelar.Text = "CANCELAR";
            this.btn_cancelar.UseVisualStyleBackColor = false;
            this.btn_cancelar.Click += new System.EventHandler(this.btn_cancelar_Click);
            // 
            // lblColor
            // 
            this.lblColor.AutoSize = true;
            this.lblColor.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblColor.ForeColor = System.Drawing.Color.White;
            this.lblColor.Location = new System.Drawing.Point(12, 52);
            this.lblColor.Name = "lblColor";
            this.lblColor.Size = new System.Drawing.Size(77, 15);
            this.lblColor.TabIndex = 42;
            this.lblColor.Text = "Nuevo Color:";
            // 
            // txtColor
            // 
            this.txtColor.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(91)))), ((int)(((byte)(91)))), ((int)(((byte)(91)))));
            this.txtColor.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtColor.ForeColor = System.Drawing.Color.White;
            this.txtColor.Location = new System.Drawing.Point(95, 49);
            this.txtColor.Name = "txtColor";
            this.txtColor.Size = new System.Drawing.Size(202, 21);
            this.txtColor.TabIndex = 41;
            // 
            // chckModificarColor
            // 
            this.chckModificarColor.AutoSize = true;
            this.chckModificarColor.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chckModificarColor.ForeColor = System.Drawing.Color.White;
            this.chckModificarColor.Location = new System.Drawing.Point(230, 12);
            this.chckModificarColor.Name = "chckModificarColor";
            this.chckModificarColor.Size = new System.Drawing.Size(137, 19);
            this.chckModificarColor.TabIndex = 43;
            this.chckModificarColor.Text = "MODIFICAR COLOR";
            this.chckModificarColor.UseVisualStyleBackColor = true;
            this.chckModificarColor.CheckedChanged += new System.EventHandler(this.chckModificarColor_CheckedChanged);
            // 
            // cBoxColores
            // 
            this.cBoxColores.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cBoxColores.FormattingEnabled = true;
            this.cBoxColores.Location = new System.Drawing.Point(95, 49);
            this.cBoxColores.Name = "cBoxColores";
            this.cBoxColores.Size = new System.Drawing.Size(202, 21);
            this.cBoxColores.TabIndex = 44;
            // 
            // lblNuevoColor
            // 
            this.lblNuevoColor.AutoSize = true;
            this.lblNuevoColor.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNuevoColor.ForeColor = System.Drawing.Color.White;
            this.lblNuevoColor.Location = new System.Drawing.Point(12, 98);
            this.lblNuevoColor.Name = "lblNuevoColor";
            this.lblNuevoColor.Size = new System.Drawing.Size(77, 15);
            this.lblNuevoColor.TabIndex = 45;
            this.lblNuevoColor.Text = "Nuevo Color:";
            // 
            // txtColor2
            // 
            this.txtColor2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(91)))), ((int)(((byte)(91)))), ((int)(((byte)(91)))));
            this.txtColor2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtColor2.ForeColor = System.Drawing.Color.White;
            this.txtColor2.Location = new System.Drawing.Point(95, 92);
            this.txtColor2.Name = "txtColor2";
            this.txtColor2.Size = new System.Drawing.Size(202, 21);
            this.txtColor2.TabIndex = 46;
            // 
            // fr_AgregarColor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(14)))), ((int)(((byte)(56)))));
            this.ClientSize = new System.Drawing.Size(379, 170);
            this.ControlBox = false;
            this.Controls.Add(this.txtColor2);
            this.Controls.Add(this.lblNuevoColor);
            this.Controls.Add(this.cBoxColores);
            this.Controls.Add(this.chckModificarColor);
            this.Controls.Add(this.lblColor);
            this.Controls.Add(this.txtColor);
            this.Controls.Add(this.btn_agregar);
            this.Controls.Add(this.btn_cancelar);
            this.MaximumSize = new System.Drawing.Size(395, 209);
            this.MinimumSize = new System.Drawing.Size(395, 209);
            this.Name = "fr_AgregarColor";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AGREGAR COLOR";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_agregar;
        private System.Windows.Forms.Button btn_cancelar;
        private System.Windows.Forms.Label lblColor;
        private System.Windows.Forms.TextBox txtColor;
        private System.Windows.Forms.CheckBox chckModificarColor;
        private System.Windows.Forms.ComboBox cBoxColores;
        private System.Windows.Forms.Label lblNuevoColor;
        private System.Windows.Forms.TextBox txtColor2;
    }
}