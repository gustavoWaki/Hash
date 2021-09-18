
namespace _20124_20137_Hash
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.dgvAluno = new System.Windows.Forms.DataGridView();
            this.posicao = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ra = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nome = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnAdd = new System.Windows.Forms.Button();
            this.txtRa = new System.Windows.Forms.TextBox();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.lblRa = new System.Windows.Forms.Label();
            this.lblNome = new System.Windows.Forms.Label();
            this.btnDel = new System.Windows.Forms.Button();
            this.rbLin = new System.Windows.Forms.RadioButton();
            this.rbQuad = new System.Windows.Forms.RadioButton();
            this.rbDuplo = new System.Windows.Forms.RadioButton();
            this.gbTipo = new System.Windows.Forms.GroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAluno)).BeginInit();
            this.gbTipo.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvAluno
            // 
            this.dgvAluno.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvAluno.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.posicao,
            this.ra,
            this.nome});
            this.dgvAluno.Location = new System.Drawing.Point(12, 157);
            this.dgvAluno.Name = "dgvAluno";
            this.dgvAluno.RowTemplate.Height = 25;
            this.dgvAluno.Size = new System.Drawing.Size(807, 317);
            this.dgvAluno.TabIndex = 0;
            // 
            // posicao
            // 
            this.posicao.HeaderText = "Posição";
            this.posicao.Name = "posicao";
            this.posicao.ReadOnly = true;
            // 
            // ra
            // 
            this.ra.HeaderText = "RA";
            this.ra.MaxInputLength = 5;
            this.ra.Name = "ra";
            this.ra.ReadOnly = true;
            // 
            // nome
            // 
            this.nome.HeaderText = "Nome";
            this.nome.Name = "nome";
            this.nome.ReadOnly = true;
            this.nome.Width = 500;
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(494, 36);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(91, 29);
            this.btnAdd.TabIndex = 2;
            this.btnAdd.Text = "Adicionar";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // txtRa
            // 
            this.txtRa.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtRa.Location = new System.Drawing.Point(25, 36);
            this.txtRa.MaxLength = 5;
            this.txtRa.Name = "txtRa";
            this.txtRa.Size = new System.Drawing.Size(95, 29);
            this.txtRa.TabIndex = 3;
            // 
            // txtNome
            // 
            this.txtNome.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtNome.Location = new System.Drawing.Point(136, 36);
            this.txtNome.MaxLength = 50;
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(341, 29);
            this.txtNome.TabIndex = 4;
            // 
            // lblRa
            // 
            this.lblRa.AutoSize = true;
            this.lblRa.Location = new System.Drawing.Point(25, 13);
            this.lblRa.Name = "lblRa";
            this.lblRa.Size = new System.Drawing.Size(25, 15);
            this.lblRa.TabIndex = 5;
            this.lblRa.Text = "RA:";
            // 
            // lblNome
            // 
            this.lblNome.AutoSize = true;
            this.lblNome.Location = new System.Drawing.Point(136, 13);
            this.lblNome.Name = "lblNome";
            this.lblNome.Size = new System.Drawing.Size(43, 15);
            this.lblNome.TabIndex = 6;
            this.lblNome.Text = "Nome:";
            // 
            // btnDel
            // 
            this.btnDel.Location = new System.Drawing.Point(592, 36);
            this.btnDel.Name = "btnDel";
            this.btnDel.Size = new System.Drawing.Size(94, 29);
            this.btnDel.TabIndex = 7;
            this.btnDel.Text = "Deletar";
            this.btnDel.UseVisualStyleBackColor = true;
            this.btnDel.Click += new System.EventHandler(this.btnDel_Click);
            // 
            // rbLin
            // 
            this.rbLin.AutoSize = true;
            this.rbLin.Checked = true;
            this.rbLin.Location = new System.Drawing.Point(6, 22);
            this.rbLin.Name = "rbLin";
            this.rbLin.Size = new System.Drawing.Size(117, 19);
            this.rbLin.TabIndex = 8;
            this.rbLin.TabStop = true;
            this.rbLin.Text = "Sondagem Linear";
            this.rbLin.UseVisualStyleBackColor = true;
            this.rbLin.CheckedChanged += new System.EventHandler(this.rbLin_CheckedChanged);
            // 
            // rbQuad
            // 
            this.rbQuad.AutoSize = true;
            this.rbQuad.Location = new System.Drawing.Point(129, 22);
            this.rbQuad.Name = "rbQuad";
            this.rbQuad.Size = new System.Drawing.Size(143, 19);
            this.rbQuad.TabIndex = 9;
            this.rbQuad.Text = "Sondagem Quadrática";
            this.rbQuad.UseVisualStyleBackColor = true;
            this.rbQuad.CheckedChanged += new System.EventHandler(this.rbQuad_CheckedChanged);
            // 
            // rbDuplo
            // 
            this.rbDuplo.AutoSize = true;
            this.rbDuplo.Location = new System.Drawing.Point(278, 22);
            this.rbDuplo.Name = "rbDuplo";
            this.rbDuplo.Size = new System.Drawing.Size(104, 19);
            this.rbDuplo.TabIndex = 10;
            this.rbDuplo.Text = "Hashing Duplo";
            this.rbDuplo.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            this.rbDuplo.UseVisualStyleBackColor = true;
            this.rbDuplo.CheckedChanged += new System.EventHandler(this.rbDuplo_CheckedChanged);
            // 
            // gbTipo
            // 
            this.gbTipo.Controls.Add(this.rbLin);
            this.gbTipo.Controls.Add(this.rbDuplo);
            this.gbTipo.Controls.Add(this.rbQuad);
            this.gbTipo.Location = new System.Drawing.Point(25, 71);
            this.gbTipo.Name = "gbTipo";
            this.gbTipo.Size = new System.Drawing.Size(403, 61);
            this.gbTipo.TabIndex = 11;
            this.gbTipo.TabStop = false;
            this.gbTipo.Text = "Tipo de Endereçamento Aberto";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(831, 486);
            this.Controls.Add(this.gbTipo);
            this.Controls.Add(this.btnDel);
            this.Controls.Add(this.lblNome);
            this.Controls.Add(this.lblRa);
            this.Controls.Add(this.txtNome);
            this.Controls.Add(this.txtRa);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.dgvAluno);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.dgvAluno)).EndInit();
            this.gbTipo.ResumeLayout(false);
            this.gbTipo.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvAluno;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.TextBox txtRa;
        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.Label lblRa;
        private System.Windows.Forms.Label lblNome;
        private System.Windows.Forms.DataGridViewTextBoxColumn posicao;
        private System.Windows.Forms.DataGridViewTextBoxColumn ra;
        private System.Windows.Forms.DataGridViewTextBoxColumn nome;
        private System.Windows.Forms.Button btnDel;
        private System.Windows.Forms.RadioButton rbLin;
        private System.Windows.Forms.RadioButton rbQuad;
        private System.Windows.Forms.RadioButton rbDuplo;
        private System.Windows.Forms.GroupBox gbTipo;
    }
}

