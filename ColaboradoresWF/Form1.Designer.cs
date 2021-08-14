
namespace ColaboradoresWF
{
    partial class Form1
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.ID_label = new System.Windows.Forms.Label();
            this.ID_textBox = new System.Windows.Forms.TextBox();
            this.numero_textBox = new System.Windows.Forms.TextBox();
            this.numero_label = new System.Windows.Forms.Label();
            this.Nome_label = new System.Windows.Forms.Label();
            this.nome_TextBox = new System.Windows.Forms.TextBox();
            this.novo_button = new System.Windows.Forms.Button();
            this.editar_button = new System.Windows.Forms.Button();
            this.consultar_button = new System.Windows.Forms.Button();
            this.exibir_button = new System.Windows.Forms.Button();
            this.dados_dataGridView = new System.Windows.Forms.DataGridView();
            this.excluir_button = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dados_dataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // ID_label
            // 
            this.ID_label.AutoSize = true;
            this.ID_label.Location = new System.Drawing.Point(73, 46);
            this.ID_label.Name = "ID_label";
            this.ID_label.Size = new System.Drawing.Size(21, 17);
            this.ID_label.TabIndex = 0;
            this.ID_label.Text = "ID";
            // 
            // ID_textBox
            // 
            this.ID_textBox.Location = new System.Drawing.Point(100, 43);
            this.ID_textBox.Name = "ID_textBox";
            this.ID_textBox.Size = new System.Drawing.Size(100, 22);
            this.ID_textBox.TabIndex = 1;
            // 
            // numero_textBox
            // 
            this.numero_textBox.Location = new System.Drawing.Point(100, 111);
            this.numero_textBox.Name = "numero_textBox";
            this.numero_textBox.Size = new System.Drawing.Size(100, 22);
            this.numero_textBox.TabIndex = 3;
            // 
            // numero_label
            // 
            this.numero_label.AutoSize = true;
            this.numero_label.Location = new System.Drawing.Point(36, 111);
            this.numero_label.Name = "numero_label";
            this.numero_label.Size = new System.Drawing.Size(58, 17);
            this.numero_label.TabIndex = 2;
            this.numero_label.Text = "Número";
            // 
            // Nome_label
            // 
            this.Nome_label.AutoSize = true;
            this.Nome_label.Location = new System.Drawing.Point(49, 78);
            this.Nome_label.Name = "Nome_label";
            this.Nome_label.Size = new System.Drawing.Size(45, 17);
            this.Nome_label.TabIndex = 2;
            this.Nome_label.Text = "Nome";
            // 
            // nome_TextBox
            // 
            this.nome_TextBox.Location = new System.Drawing.Point(100, 75);
            this.nome_TextBox.Name = "nome_TextBox";
            this.nome_TextBox.Size = new System.Drawing.Size(100, 22);
            this.nome_TextBox.TabIndex = 3;
            // 
            // novo_button
            // 
            this.novo_button.Location = new System.Drawing.Point(100, 159);
            this.novo_button.Name = "novo_button";
            this.novo_button.Size = new System.Drawing.Size(75, 23);
            this.novo_button.TabIndex = 4;
            this.novo_button.Text = "Novo";
            this.novo_button.UseVisualStyleBackColor = true;
            this.novo_button.Click += new System.EventHandler(this.novo_button_Click);
            // 
            // editar_button
            // 
            this.editar_button.Location = new System.Drawing.Point(181, 159);
            this.editar_button.Name = "editar_button";
            this.editar_button.Size = new System.Drawing.Size(75, 23);
            this.editar_button.TabIndex = 4;
            this.editar_button.Text = "Editar";
            this.editar_button.UseVisualStyleBackColor = true;
            this.editar_button.Click += new System.EventHandler(this.editar_button_Click);
            // 
            // consultar_button
            // 
            this.consultar_button.Location = new System.Drawing.Point(262, 159);
            this.consultar_button.Name = "consultar_button";
            this.consultar_button.Size = new System.Drawing.Size(75, 23);
            this.consultar_button.TabIndex = 4;
            this.consultar_button.Text = "Consultar";
            this.consultar_button.UseVisualStyleBackColor = true;
            this.consultar_button.Click += new System.EventHandler(this.consultar_button_Click);
            // 
            // exibir_button
            // 
            this.exibir_button.Location = new System.Drawing.Point(650, 268);
            this.exibir_button.Name = "exibir_button";
            this.exibir_button.Size = new System.Drawing.Size(75, 23);
            this.exibir_button.TabIndex = 4;
            this.exibir_button.Text = "Exibir";
            this.exibir_button.UseVisualStyleBackColor = true;
            this.exibir_button.Click += new System.EventHandler(this.exibir_button_Click);
            // 
            // dados_dataGridView
            // 
            this.dados_dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dados_dataGridView.Location = new System.Drawing.Point(100, 212);
            this.dados_dataGridView.Name = "dados_dataGridView";
            this.dados_dataGridView.RowHeadersWidth = 51;
            this.dados_dataGridView.RowTemplate.Height = 24;
            this.dados_dataGridView.Size = new System.Drawing.Size(544, 138);
            this.dados_dataGridView.TabIndex = 5;
            // 
            // excluir_button
            // 
            this.excluir_button.Location = new System.Drawing.Point(343, 159);
            this.excluir_button.Name = "excluir_button";
            this.excluir_button.Size = new System.Drawing.Size(75, 23);
            this.excluir_button.TabIndex = 6;
            this.excluir_button.Text = "Excluir";
            this.excluir_button.UseVisualStyleBackColor = true;
            this.excluir_button.Click += new System.EventHandler(this.excluir_button_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.excluir_button);
            this.Controls.Add(this.dados_dataGridView);
            this.Controls.Add(this.exibir_button);
            this.Controls.Add(this.consultar_button);
            this.Controls.Add(this.editar_button);
            this.Controls.Add(this.novo_button);
            this.Controls.Add(this.nome_TextBox);
            this.Controls.Add(this.numero_textBox);
            this.Controls.Add(this.Nome_label);
            this.Controls.Add(this.numero_label);
            this.Controls.Add(this.ID_textBox);
            this.Controls.Add(this.ID_label);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.dados_dataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label ID_label;
        private System.Windows.Forms.TextBox ID_textBox;
        private System.Windows.Forms.TextBox numero_textBox;
        private System.Windows.Forms.Label numero_label;
        private System.Windows.Forms.Label Nome_label;
        private System.Windows.Forms.TextBox nome_TextBox;
        private System.Windows.Forms.Button novo_button;
        private System.Windows.Forms.Button editar_button;
        private System.Windows.Forms.Button consultar_button;
        private System.Windows.Forms.Button exibir_button;
        private System.Windows.Forms.DataGridView dados_dataGridView;
        private System.Windows.Forms.Button excluir_button;
    }
}

