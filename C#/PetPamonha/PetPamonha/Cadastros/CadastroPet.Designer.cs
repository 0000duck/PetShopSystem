﻿namespace PetPamonha
{
    partial class CadastroPet
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
            this.label1 = new System.Windows.Forms.Label();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.mkdDatadeNascimento = new System.Windows.Forms.MaskedTextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtRaca = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.cmbDono = new System.Windows.Forms.ComboBox();
            this.btnEnviar = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.mktRGA = new System.Windows.Forms.MaskedTextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nome: ";
            // 
            // txtNome
            // 
            this.txtNome.Location = new System.Drawing.Point(125, 10);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(216, 20);
            this.txtNome.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 43);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(107, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Data de Nascimento:";
            // 
            // mkdDatadeNascimento
            // 
            this.mkdDatadeNascimento.Location = new System.Drawing.Point(125, 40);
            this.mkdDatadeNascimento.Mask = "00/00/0000";
            this.mkdDatadeNascimento.Name = "mkdDatadeNascimento";
            this.mkdDatadeNascimento.Size = new System.Drawing.Size(80, 20);
            this.mkdDatadeNascimento.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 72);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(39, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Raça: ";
            // 
            // txtRaca
            // 
            this.txtRaca.Location = new System.Drawing.Point(125, 69);
            this.txtRaca.Name = "txtRaca";
            this.txtRaca.Size = new System.Drawing.Size(145, 20);
            this.txtRaca.TabIndex = 3;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(13, 135);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(36, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Dono:";
            // 
            // cmbDono
            // 
            this.cmbDono.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbDono.FormattingEnabled = true;
            this.cmbDono.Location = new System.Drawing.Point(125, 135);
            this.cmbDono.Name = "cmbDono";
            this.cmbDono.Size = new System.Drawing.Size(216, 21);
            this.cmbDono.TabIndex = 5;
            this.cmbDono.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // btnEnviar
            // 
            this.btnEnviar.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnEnviar.Location = new System.Drawing.Point(116, 176);
            this.btnEnviar.Name = "btnEnviar";
            this.btnEnviar.Size = new System.Drawing.Size(108, 44);
            this.btnEnviar.TabIndex = 6;
            this.btnEnviar.Text = "Enviar";
            this.btnEnviar.UseVisualStyleBackColor = false;
            this.btnEnviar.Click += new System.EventHandler(this.btnEnviar_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(13, 103);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(33, 13);
            this.label5.TabIndex = 9;
            this.label5.Text = "RGA:";
            // 
            // mktRGA
            // 
            this.mktRGA.Location = new System.Drawing.Point(125, 103);
            this.mktRGA.Mask = "000.000";
            this.mktRGA.Name = "mktRGA";
            this.mktRGA.Size = new System.Drawing.Size(59, 20);
            this.mktRGA.TabIndex = 4;
            this.mktRGA.MaskInputRejected += new System.Windows.Forms.MaskInputRejectedEventHandler(this.mktRGA_MaskInputRejected);
            // 
            // CadastroPet
            // 
            this.AcceptButton = this.btnEnviar;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(353, 232);
            this.Controls.Add(this.mktRGA);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.btnEnviar);
            this.Controls.Add(this.cmbDono);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtRaca);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.mkdDatadeNascimento);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtNome);
            this.Controls.Add(this.label1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "CadastroPet";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Cadastro de Pet";
            this.Load += new System.EventHandler(this.CadastroPet_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.MaskedTextBox mkdDatadeNascimento;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtRaca;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cmbDono;
        private System.Windows.Forms.Button btnEnviar;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.MaskedTextBox mktRGA;
    }
}