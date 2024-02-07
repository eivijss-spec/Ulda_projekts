namespace Ulda_problemas
{
    partial class Form1
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
            this.tb_vards = new System.Windows.Forms.TextBox();
            this.tb_veltijums = new System.Windows.Forms.TextBox();
            this.tb_platums = new System.Windows.Forms.TextBox();
            this.tb_cena = new System.Windows.Forms.TextBox();
            this.tb_garums = new System.Windows.Forms.TextBox();
            this.tb_augstums = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.rtb_reikins = new System.Windows.Forms.RichTextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.Dzest = new System.Windows.Forms.Button();
            this.dz_id = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // tb_vards
            // 
            this.tb_vards.BackColor = System.Drawing.SystemColors.Info;
            this.tb_vards.Location = new System.Drawing.Point(35, 35);
            this.tb_vards.Name = "tb_vards";
            this.tb_vards.Size = new System.Drawing.Size(100, 20);
            this.tb_vards.TabIndex = 0;
            this.tb_vards.TextChanged += new System.EventHandler(this.tb_vards_TextChanged);
            // 
            // tb_veltijums
            // 
            this.tb_veltijums.BackColor = System.Drawing.SystemColors.Info;
            this.tb_veltijums.Location = new System.Drawing.Point(35, 112);
            this.tb_veltijums.Name = "tb_veltijums";
            this.tb_veltijums.Size = new System.Drawing.Size(100, 20);
            this.tb_veltijums.TabIndex = 1;
            this.tb_veltijums.TextChanged += new System.EventHandler(this.tb_veltijums_TextChanged);
            // 
            // tb_platums
            // 
            this.tb_platums.BackColor = System.Drawing.SystemColors.Info;
            this.tb_platums.Location = new System.Drawing.Point(35, 178);
            this.tb_platums.Name = "tb_platums";
            this.tb_platums.Size = new System.Drawing.Size(100, 20);
            this.tb_platums.TabIndex = 2;
            this.tb_platums.TextChanged += new System.EventHandler(this.tb_platums_TextChanged);
            // 
            // tb_cena
            // 
            this.tb_cena.BackColor = System.Drawing.SystemColors.Info;
            this.tb_cena.Location = new System.Drawing.Point(35, 272);
            this.tb_cena.Name = "tb_cena";
            this.tb_cena.Size = new System.Drawing.Size(100, 20);
            this.tb_cena.TabIndex = 3;
            this.tb_cena.TextChanged += new System.EventHandler(this.tb_cena_TextChanged);
            // 
            // tb_garums
            // 
            this.tb_garums.BackColor = System.Drawing.SystemColors.Info;
            this.tb_garums.Location = new System.Drawing.Point(152, 178);
            this.tb_garums.Name = "tb_garums";
            this.tb_garums.Size = new System.Drawing.Size(119, 20);
            this.tb_garums.TabIndex = 4;
            this.tb_garums.TextChanged += new System.EventHandler(this.tb_garums_TextChanged);
            // 
            // tb_augstums
            // 
            this.tb_augstums.BackColor = System.Drawing.SystemColors.Info;
            this.tb_augstums.Location = new System.Drawing.Point(286, 178);
            this.tb_augstums.Name = "tb_augstums";
            this.tb_augstums.Size = new System.Drawing.Size(100, 20);
            this.tb_augstums.TabIndex = 5;
            this.tb_augstums.TextChanged += new System.EventHandler(this.textBox6_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.Info;
            this.label1.Location = new System.Drawing.Point(50, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(68, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "Klienta vārds";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.SystemColors.Info;
            this.label2.Location = new System.Drawing.Point(38, 96);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(80, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "vēlējuma teksts";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.SystemColors.Info;
            this.label3.Location = new System.Drawing.Point(50, 162);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(62, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "platums mm";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.SystemColors.Info;
            this.label4.Location = new System.Drawing.Point(174, 162);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(60, 13);
            this.label4.TabIndex = 9;
            this.label4.Text = "garums mm";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.SystemColors.Info;
            this.label5.Location = new System.Drawing.Point(297, 162);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(71, 13);
            this.label5.TabIndex = 10;
            this.label5.Text = "augstums mm";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.SystemColors.Info;
            this.label6.Location = new System.Drawing.Point(38, 242);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(88, 13);
            this.label6.TabIndex = 11;
            this.label6.Text = "kokmatriāla cena";
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // rtb_reikins
            // 
            this.rtb_reikins.BackColor = System.Drawing.SystemColors.Info;
            this.rtb_reikins.Location = new System.Drawing.Point(456, 72);
            this.rtb_reikins.Name = "rtb_reikins";
            this.rtb_reikins.Size = new System.Drawing.Size(327, 289);
            this.rtb_reikins.TabIndex = 13;
            this.rtb_reikins.Text = "";
            this.rtb_reikins.TextChanged += new System.EventHandler(this.rtb_reikins_TextChanged);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.Info;
            this.button1.Location = new System.Drawing.Point(508, 18);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(216, 44);
            this.button1.TabIndex = 14;
            this.button1.Text = "Reiķins";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.SystemColors.Info;
            this.button2.Location = new System.Drawing.Point(456, 367);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(327, 44);
            this.button2.TabIndex = 15;
            this.button2.Text = "Saglabat faila";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.SystemColors.Info;
            this.button3.Location = new System.Drawing.Point(456, 418);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(327, 47);
            this.button3.TabIndex = 17;
            this.button3.Text = "Saglabat datubaze";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.SystemColors.Info;
            this.label7.Location = new System.Drawing.Point(83, 398);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(35, 13);
            this.label7.TabIndex = 18;
            this.label7.Text = "dz_ID";
            // 
            // Dzest
            // 
            this.Dzest.BackColor = System.Drawing.SystemColors.Info;
            this.Dzest.Location = new System.Drawing.Point(159, 418);
            this.Dzest.Name = "Dzest";
            this.Dzest.Size = new System.Drawing.Size(75, 23);
            this.Dzest.TabIndex = 19;
            this.Dzest.Text = "dzēst";
            this.Dzest.UseVisualStyleBackColor = false;
            this.Dzest.Click += new System.EventHandler(this.Dzest_Click);
            // 
            // dz_id
            // 
            this.dz_id.BackColor = System.Drawing.SystemColors.Info;
            this.dz_id.Location = new System.Drawing.Point(53, 418);
            this.dz_id.Name = "dz_id";
            this.dz_id.Size = new System.Drawing.Size(100, 20);
            this.dz_id.TabIndex = 20;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightCoral;
            this.BackgroundImage = global::Ulda_problemas.Properties.Resources.c31e0028ff648a5cd3f262e4b2a6085b;
            this.ClientSize = new System.Drawing.Size(815, 501);
            this.Controls.Add(this.dz_id);
            this.Controls.Add(this.Dzest);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.rtb_reikins);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tb_augstums);
            this.Controls.Add(this.tb_garums);
            this.Controls.Add(this.tb_cena);
            this.Controls.Add(this.tb_platums);
            this.Controls.Add(this.tb_veltijums);
            this.Controls.Add(this.tb_vards);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tb_vards;
        private System.Windows.Forms.TextBox tb_veltijums;
        private System.Windows.Forms.TextBox tb_platums;
        private System.Windows.Forms.TextBox tb_cena;
        private System.Windows.Forms.TextBox tb_garums;
        private System.Windows.Forms.TextBox tb_augstums;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.RichTextBox rtb_reikins;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button Dzest;
        private System.Windows.Forms.TextBox dz_id;
    }
}

