namespace prototipo1
{
    partial class socio_demog
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(socio_demog));
            this.label_nome_sdm = new System.Windows.Forms.Label();
            this.tb_nome_sdm = new System.Windows.Forms.TextBox();
            this.label_cc_sdm = new System.Windows.Forms.Label();
            this.tb_cc_sdm = new System.Windows.Forms.TextBox();
            this.label_data_nas_sdm = new System.Windows.Forms.Label();
            this.data_nasc = new System.Windows.Forms.DateTimePicker();
            this.label_morada_sdm = new System.Windows.Forms.Label();
            this.tb_morada_sdm = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.label_prof_sdm = new System.Windows.Forms.Label();
            this.tb_prof_sdm = new System.Windows.Forms.TextBox();
            this.label_estado_sdm = new System.Windows.Forms.Label();
            this.tb_estado_sdm = new System.Windows.Forms.TextBox();
            this.label_habil_sdm = new System.Windows.Forms.Label();
            this.hab_lit = new System.Windows.Forms.ListBox();
            this.label_filhos_sdm = new System.Windows.Forms.Label();
            this.domain_filhos_sdm = new System.Windows.Forms.DomainUpDown();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label_nome_sdm
            // 
            this.label_nome_sdm.AutoSize = true;
            this.label_nome_sdm.Location = new System.Drawing.Point(33, 51);
            this.label_nome_sdm.Name = "label_nome_sdm";
            this.label_nome_sdm.Size = new System.Drawing.Size(38, 13);
            this.label_nome_sdm.TabIndex = 0;
            this.label_nome_sdm.Text = "Nome:";
            // 
            // tb_nome_sdm
            // 
            this.tb_nome_sdm.Location = new System.Drawing.Point(78, 51);
            this.tb_nome_sdm.Name = "tb_nome_sdm";
            this.tb_nome_sdm.Size = new System.Drawing.Size(350, 20);
            this.tb_nome_sdm.TabIndex = 1;
            // 
            // label_cc_sdm
            // 
            this.label_cc_sdm.AutoSize = true;
            this.label_cc_sdm.Location = new System.Drawing.Point(33, 88);
            this.label_cc_sdm.Name = "label_cc_sdm";
            this.label_cc_sdm.Size = new System.Drawing.Size(27, 13);
            this.label_cc_sdm.TabIndex = 2;
            this.label_cc_sdm.Text = "C.C:";
            // 
            // tb_cc_sdm
            // 
            this.tb_cc_sdm.Location = new System.Drawing.Point(78, 85);
            this.tb_cc_sdm.Name = "tb_cc_sdm";
            this.tb_cc_sdm.Size = new System.Drawing.Size(128, 20);
            this.tb_cc_sdm.TabIndex = 3;
            // 
            // label_data_nas_sdm
            // 
            this.label_data_nas_sdm.AutoSize = true;
            this.label_data_nas_sdm.Location = new System.Drawing.Point(33, 127);
            this.label_data_nas_sdm.Name = "label_data_nas_sdm";
            this.label_data_nas_sdm.Size = new System.Drawing.Size(92, 13);
            this.label_data_nas_sdm.TabIndex = 4;
            this.label_data_nas_sdm.Text = "Data Nascimento:";
            this.label_data_nas_sdm.Click += new System.EventHandler(this.data_nas_sdm_Click);
            // 
            // data_nasc
            // 
            this.data_nasc.Location = new System.Drawing.Point(131, 120);
            this.data_nasc.Name = "data_nasc";
            this.data_nasc.Size = new System.Drawing.Size(200, 20);
            this.data_nasc.TabIndex = 5;
            // 
            // label_morada_sdm
            // 
            this.label_morada_sdm.AutoSize = true;
            this.label_morada_sdm.Location = new System.Drawing.Point(33, 160);
            this.label_morada_sdm.Name = "label_morada_sdm";
            this.label_morada_sdm.Size = new System.Drawing.Size(46, 13);
            this.label_morada_sdm.TabIndex = 6;
            this.label_morada_sdm.Text = "Morada:";
            // 
            // tb_morada_sdm
            // 
            this.tb_morada_sdm.Location = new System.Drawing.Point(78, 160);
            this.tb_morada_sdm.Name = "tb_morada_sdm";
            this.tb_morada_sdm.Size = new System.Drawing.Size(350, 20);
            this.tb_morada_sdm.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(224, 89);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(45, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "Género:";
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Location = new System.Drawing.Point(275, 88);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(67, 17);
            this.radioButton1.TabIndex = 9;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "Feminino";
            this.radioButton1.UseVisualStyleBackColor = true;
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.Location = new System.Drawing.Point(348, 89);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(73, 17);
            this.radioButton2.TabIndex = 10;
            this.radioButton2.TabStop = true;
            this.radioButton2.Text = "Masculino";
            this.radioButton2.UseVisualStyleBackColor = true;
            // 
            // label_prof_sdm
            // 
            this.label_prof_sdm.AutoSize = true;
            this.label_prof_sdm.Location = new System.Drawing.Point(33, 205);
            this.label_prof_sdm.Name = "label_prof_sdm";
            this.label_prof_sdm.Size = new System.Drawing.Size(53, 13);
            this.label_prof_sdm.TabIndex = 11;
            this.label_prof_sdm.Text = "Profissão:";
            // 
            // tb_prof_sdm
            // 
            this.tb_prof_sdm.Location = new System.Drawing.Point(92, 198);
            this.tb_prof_sdm.Name = "tb_prof_sdm";
            this.tb_prof_sdm.Size = new System.Drawing.Size(336, 20);
            this.tb_prof_sdm.TabIndex = 12;
            // 
            // label_estado_sdm
            // 
            this.label_estado_sdm.AutoSize = true;
            this.label_estado_sdm.Location = new System.Drawing.Point(33, 238);
            this.label_estado_sdm.Name = "label_estado_sdm";
            this.label_estado_sdm.Size = new System.Drawing.Size(65, 13);
            this.label_estado_sdm.TabIndex = 13;
            this.label_estado_sdm.Text = "Estado Civil:";
            // 
            // tb_estado_sdm
            // 
            this.tb_estado_sdm.Location = new System.Drawing.Point(104, 235);
            this.tb_estado_sdm.Name = "tb_estado_sdm";
            this.tb_estado_sdm.Size = new System.Drawing.Size(324, 20);
            this.tb_estado_sdm.TabIndex = 14;
            // 
            // label_habil_sdm
            // 
            this.label_habil_sdm.AutoSize = true;
            this.label_habil_sdm.Location = new System.Drawing.Point(33, 274);
            this.label_habil_sdm.Name = "label_habil_sdm";
            this.label_habil_sdm.Size = new System.Drawing.Size(113, 13);
            this.label_habil_sdm.TabIndex = 15;
            this.label_habil_sdm.Text = "Habilitacoes Literarias:";
            // 
            // hab_lit
            // 
            this.hab_lit.FormattingEnabled = true;
            this.hab_lit.Items.AddRange(new object[] {
            "1º ciclo",
            "básico",
            "secundario",
            "licenciatura",
            "mestrado",
            "doutoramento"});
            this.hab_lit.Location = new System.Drawing.Point(152, 274);
            this.hab_lit.Name = "hab_lit";
            this.hab_lit.Size = new System.Drawing.Size(276, 30);
            this.hab_lit.TabIndex = 16;
            // 
            // label_filhos_sdm
            // 
            this.label_filhos_sdm.AutoSize = true;
            this.label_filhos_sdm.Location = new System.Drawing.Point(33, 326);
            this.label_filhos_sdm.Name = "label_filhos_sdm";
            this.label_filhos_sdm.Size = new System.Drawing.Size(89, 13);
            this.label_filhos_sdm.TabIndex = 17;
            this.label_filhos_sdm.Text = "Numero de filhos:";
            // 
            // domain_filhos_sdm
            // 
            this.domain_filhos_sdm.Location = new System.Drawing.Point(131, 326);
            this.domain_filhos_sdm.Name = "domain_filhos_sdm";
            this.domain_filhos_sdm.Size = new System.Drawing.Size(120, 20);
            this.domain_filhos_sdm.TabIndex = 18;
            this.domain_filhos_sdm.Text = "0";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(489, 392);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 19;
            this.button1.Text = "cancelar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(396, 392);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 20;
            this.button2.Text = "guardar";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // socio_demog
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(605, 450);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.domain_filhos_sdm);
            this.Controls.Add(this.label_filhos_sdm);
            this.Controls.Add(this.hab_lit);
            this.Controls.Add(this.label_habil_sdm);
            this.Controls.Add(this.tb_estado_sdm);
            this.Controls.Add(this.label_estado_sdm);
            this.Controls.Add(this.tb_prof_sdm);
            this.Controls.Add(this.label_prof_sdm);
            this.Controls.Add(this.radioButton2);
            this.Controls.Add(this.radioButton1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.tb_morada_sdm);
            this.Controls.Add(this.label_morada_sdm);
            this.Controls.Add(this.data_nasc);
            this.Controls.Add(this.label_data_nas_sdm);
            this.Controls.Add(this.tb_cc_sdm);
            this.Controls.Add(this.label_cc_sdm);
            this.Controls.Add(this.tb_nome_sdm);
            this.Controls.Add(this.label_nome_sdm);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "socio_demog";
            this.Text = "socio_demog";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label_nome_sdm;
        private System.Windows.Forms.TextBox tb_nome_sdm;
        private System.Windows.Forms.Label label_cc_sdm;
        private System.Windows.Forms.TextBox tb_cc_sdm;
        private System.Windows.Forms.Label label_data_nas_sdm;
        private System.Windows.Forms.DateTimePicker data_nasc;
        private System.Windows.Forms.Label label_morada_sdm;
        private System.Windows.Forms.TextBox tb_morada_sdm;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.Label label_prof_sdm;
        private System.Windows.Forms.TextBox tb_prof_sdm;
        private System.Windows.Forms.Label label_estado_sdm;
        private System.Windows.Forms.TextBox tb_estado_sdm;
        private System.Windows.Forms.Label label_habil_sdm;
        private System.Windows.Forms.ListBox hab_lit;
        private System.Windows.Forms.Label label_filhos_sdm;
        private System.Windows.Forms.DomainUpDown domain_filhos_sdm;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
    }
}