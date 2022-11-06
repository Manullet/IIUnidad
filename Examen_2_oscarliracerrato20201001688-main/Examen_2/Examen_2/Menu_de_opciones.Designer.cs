namespace Examen_2
{
    partial class Menu_de_opciones
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
            this.Repara_Cel = new System.Windows.Forms.Button();
            this.Repara_PC = new System.Windows.Forms.Button();
            this.Ticket = new System.Windows.Forms.Button();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.label1.Location = new System.Drawing.Point(494, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(127, 17);
            this.label1.TabIndex = 2;
            this.label1.Text = "Menu de Opciones";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // Repara_Cel
            // 
            this.Repara_Cel.Location = new System.Drawing.Point(106, 314);
            this.Repara_Cel.Name = "Repara_Cel";
            this.Repara_Cel.Size = new System.Drawing.Size(186, 51);
            this.Repara_Cel.TabIndex = 3;
            this.Repara_Cel.Text = "Reparación de Celulares";
            this.Repara_Cel.UseVisualStyleBackColor = true;
            this.Repara_Cel.Click += new System.EventHandler(this.Repara_Cel_Click);
            // 
            // Repara_PC
            // 
            this.Repara_PC.Location = new System.Drawing.Point(435, 314);
            this.Repara_PC.Name = "Repara_PC";
            this.Repara_PC.Size = new System.Drawing.Size(186, 51);
            this.Repara_PC.TabIndex = 4;
            this.Repara_PC.Text = "Reparación de Computadoras";
            this.Repara_PC.UseVisualStyleBackColor = true;
            this.Repara_PC.Click += new System.EventHandler(this.Repara_PC_Click);
            // 
            // Ticket
            // 
            this.Ticket.Location = new System.Drawing.Point(786, 314);
            this.Ticket.Name = "Ticket";
            this.Ticket.Size = new System.Drawing.Size(186, 51);
            this.Ticket.TabIndex = 5;
            this.Ticket.Text = "Tickets";
            this.Ticket.UseVisualStyleBackColor = true;
            this.Ticket.Click += new System.EventHandler(this.Ticket_Click);
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = global::Examen_2.Properties.Resources.IMG_4256;
            this.pictureBox3.Location = new System.Drawing.Point(738, 70);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(266, 219);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox3.TabIndex = 6;
            this.pictureBox3.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::Examen_2.Properties.Resources.IMG_4255;
            this.pictureBox2.Location = new System.Drawing.Point(376, 70);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(298, 219);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 1;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Examen_2.Properties.Resources.IMG_4254;
            this.pictureBox1.Location = new System.Drawing.Point(87, 60);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(224, 244);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // Menu_de_opciones
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Chocolate;
            this.ClientSize = new System.Drawing.Size(1090, 387);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.Ticket);
            this.Controls.Add(this.Repara_PC);
            this.Controls.Add(this.Repara_Cel);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Name = "Menu_de_opciones";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Menu_de_opciones_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button Repara_Cel;
        private System.Windows.Forms.Button Repara_PC;
        private System.Windows.Forms.Button Ticket;
        private System.Windows.Forms.PictureBox pictureBox3;
    }
}