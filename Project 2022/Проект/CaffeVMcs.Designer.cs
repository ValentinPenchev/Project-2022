namespace Проект
{
    partial class CaffeVMcs
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
            this.espreso = new System.Windows.Forms.RadioButton();
            this.americano = new System.Windows.Forms.RadioButton();
            this.capuchino = new System.Windows.Forms.RadioButton();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.macchiato = new System.Windows.Forms.RadioButton();
            this.conpanna = new System.Windows.Forms.RadioButton();
            this.caramel = new System.Windows.Forms.RadioButton();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // espreso
            // 
            this.espreso.Appearance = System.Windows.Forms.Appearance.Button;
            this.espreso.BackColor = System.Drawing.Color.DarkGray;
            this.espreso.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.espreso.Image = global::Проект.Properties.Resources.espresso;
            this.espreso.Location = new System.Drawing.Point(12, 11);
            this.espreso.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.espreso.Name = "espreso";
            this.espreso.Size = new System.Drawing.Size(119, 131);
            this.espreso.TabIndex = 1;
            this.espreso.UseVisualStyleBackColor = false;
            this.espreso.CheckedChanged += new System.EventHandler(this.espreso_CheckedChanged);
            // 
            // americano
            // 
            this.americano.Appearance = System.Windows.Forms.Appearance.Button;
            this.americano.BackColor = System.Drawing.Color.DarkGray;
            this.americano.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.americano.Image = global::Проект.Properties.Resources.coffee_types_concept_23_2148556313__1_;
            this.americano.Location = new System.Drawing.Point(137, 11);
            this.americano.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.americano.Name = "americano";
            this.americano.Size = new System.Drawing.Size(119, 131);
            this.americano.TabIndex = 2;
            this.americano.UseVisualStyleBackColor = false;
            this.americano.CheckedChanged += new System.EventHandler(this.americano_CheckedChanged);
            this.americano.Click += new System.EventHandler(this.americano_CheckedChanged);
            // 
            // capuchino
            // 
            this.capuchino.Appearance = System.Windows.Forms.Appearance.Button;
            this.capuchino.BackColor = System.Drawing.Color.DarkGray;
            this.capuchino.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.capuchino.Image = global::Проект.Properties.Resources.capuchino;
            this.capuchino.Location = new System.Drawing.Point(262, 11);
            this.capuchino.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.capuchino.Name = "capuchino";
            this.capuchino.Size = new System.Drawing.Size(119, 131);
            this.capuchino.TabIndex = 3;
            this.capuchino.UseVisualStyleBackColor = false;
            this.capuchino.CheckedChanged += new System.EventHandler(this.capuchino_CheckedChanged);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.DarkGray;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Location = new System.Drawing.Point(25, 342);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(159, 48);
            this.panel1.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(80, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(60, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Цена";
            this.label1.Visible = false;
            this.label1.VisibleChanged += new System.EventHandler(this.espreso_CheckedChanged);
            this.label1.Click += new System.EventHandler(this.CaffeVMcs_Load);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label2.Location = new System.Drawing.Point(3, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(70, 30);
            this.label2.TabIndex = 1;
            this.label2.Text = "Сума:";
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.button1.Location = new System.Drawing.Point(200, 353);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(125, 27);
            this.button1.TabIndex = 5;
            this.button1.Text = "Поръчай";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // macchiato
            // 
            this.macchiato.Appearance = System.Windows.Forms.Appearance.Button;
            this.macchiato.BackColor = System.Drawing.Color.DarkGray;
            this.macchiato.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.macchiato.Image = global::Проект.Properties.Resources.Screenshot_2023_03_02_192412;
            this.macchiato.Location = new System.Drawing.Point(12, 146);
            this.macchiato.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.macchiato.Name = "macchiato";
            this.macchiato.Size = new System.Drawing.Size(119, 160);
            this.macchiato.TabIndex = 6;
            this.macchiato.UseVisualStyleBackColor = false;
            this.macchiato.CheckedChanged += new System.EventHandler(this.macchiato_CheckedChanged);
            // 
            // conpanna
            // 
            this.conpanna.Appearance = System.Windows.Forms.Appearance.Button;
            this.conpanna.BackColor = System.Drawing.Color.DarkGray;
            this.conpanna.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.conpanna.Image = global::Проект.Properties.Resources.Screenshot_2023_03_02_192615;
            this.conpanna.Location = new System.Drawing.Point(137, 146);
            this.conpanna.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.conpanna.Name = "conpanna";
            this.conpanna.Size = new System.Drawing.Size(119, 160);
            this.conpanna.TabIndex = 7;
            this.conpanna.UseVisualStyleBackColor = false;
            this.conpanna.CheckedChanged += new System.EventHandler(this.conpanna_CheckedChanged);
            // 
            // caramel
            // 
            this.caramel.Appearance = System.Windows.Forms.Appearance.Button;
            this.caramel.BackColor = System.Drawing.Color.DarkGray;
            this.caramel.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.caramel.Image = global::Проект.Properties.Resources.Screenshot_2023_03_02_192630;
            this.caramel.Location = new System.Drawing.Point(262, 146);
            this.caramel.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.caramel.Name = "caramel";
            this.caramel.Size = new System.Drawing.Size(119, 160);
            this.caramel.TabIndex = 8;
            this.caramel.UseVisualStyleBackColor = false;
            this.caramel.CheckedChanged += new System.EventHandler(this.caramel_CheckedChanged);
            // 
            // CaffeVMcs
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImage = global::Проект.Properties.Resources.coffee_break_wallpaper_800x600;
            this.ClientSize = new System.Drawing.Size(682, 402);
            this.Controls.Add(this.caramel);
            this.Controls.Add(this.conpanna);
            this.Controls.Add(this.macchiato);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.capuchino);
            this.Controls.Add(this.americano);
            this.Controls.Add(this.espreso);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "CaffeVMcs";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "CaffeVMcs";
            this.Load += new System.EventHandler(this.CaffeVMcs_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.RadioButton espreso;
        private System.Windows.Forms.RadioButton americano;
        private System.Windows.Forms.RadioButton capuchino;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.RadioButton macchiato;
        private System.Windows.Forms.RadioButton conpanna;
        private System.Windows.Forms.RadioButton caramel;
    }
}