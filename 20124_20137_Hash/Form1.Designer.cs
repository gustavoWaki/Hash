
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
            ((System.ComponentModel.ISupportInitialize)(this.dgvAluno)).BeginInit();
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
            this.txtRa.Location = new System.Drawing.Point(25, 36);
            this.txtRa.MaxLength = 5;
            this.txtRa.Multiline = true;
            this.txtRa.Name = "txtRa";
            this.txtRa.Size = new System.Drawing.Size(95, 29);
            this.txtRa.TabIndex = 3;
            // 
            // txtNome
            // 
            this.txtNome.Location = new System.Drawing.Point(136, 36);
            this.txtNome.Multiline = true;
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
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(831, 486);
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
    }
}

