namespace Examen_2
{
    partial class Reparación_PC
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
            this.components = new System.ComponentModel.Container();
            this.cancel_cel = new System.Windows.Forms.Button();
            this.menu = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.Des_Res = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.Tipo_de_soporte = new System.Windows.Forms.TextBox();
            this.Celular = new System.Windows.Forms.TextBox();
            this.Precio = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.fecha_date = new System.Windows.Forms.DateTimePicker();
            this.Des_soli = new System.Windows.Forms.TextBox();
            this.Nombre_Client = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // cancel_cel
            // 
            this.cancel_cel.Location = new System.Drawing.Point(637, 297);
            this.cancel_cel.Name = "cancel_cel";
            this.cancel_cel.Size = new System.Drawing.Size(105, 41);
            this.cancel_cel.TabIndex = 38;
            this.cancel_cel.Text = "Cancelar";
            this.cancel_cel.UseVisualStyleBackColor = true;
            this.cancel_cel.Click += new System.EventHandler(this.cancel_cel_Click_1);
            // 
            // menu
            // 
            this.menu.Location = new System.Drawing.Point(637, 372);
            this.menu.Name = "menu";
            this.menu.Size = new System.Drawing.Size(105, 41);
            this.menu.TabIndex = 37;
            this.menu.Text = "Menu";
            this.menu.UseVisualStyleBackColor = true;
            this.menu.Click += new System.EventHandler(this.menu_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(543, 94);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(40, 13);
            this.label3.TabIndex = 36;
            this.label3.Text = "Precio:";
            // 
            // Des_Res
            // 
            this.Des_Res.Location = new System.Drawing.Point(320, 237);
            this.Des_Res.Multiline = true;
            this.Des_Res.Name = "Des_Res";
            this.Des_Res.Size = new System.Drawing.Size(188, 156);
            this.Des_Res.TabIndex = 35;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(338, 202);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(149, 13);
            this.label7.TabIndex = 34;
            this.label7.Text = "Descripción de la Respuesta: ";
            // 
            // Tipo_de_soporte
            // 
            this.Tipo_de_soporte.Location = new System.Drawing.Point(179, 131);
            this.Tipo_de_soporte.Name = "Tipo_de_soporte";
            this.Tipo_de_soporte.Size = new System.Drawing.Size(260, 20);
            this.Tipo_de_soporte.TabIndex = 33;
            // 
            // Celular
            // 
            this.Celular.Location = new System.Drawing.Point(179, 80);
            this.Celular.Name = "Celular";
            this.Celular.Size = new System.Drawing.Size(260, 20);
            this.Celular.TabIndex = 32;
            // 
            // Precio
            // 
            this.Precio.Location = new System.Drawing.Point(589, 94);
            this.Precio.Name = "Precio";
            this.Precio.Size = new System.Drawing.Size(97, 20);
            this.Precio.TabIndex = 31;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(131, 87);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(42, 13);
            this.label6.TabIndex = 30;
            this.label6.Text = "Celular:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(87, 134);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(86, 13);
            this.label5.TabIndex = 29;
            this.label5.Text = "Tipo de Soporte:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(87, 202);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(138, 13);
            this.label4.TabIndex = 28;
            this.label4.Text = "Descripción de la Solicitud: ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.25F);
            this.label2.Location = new System.Drawing.Point(535, 55);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(48, 16);
            this.label2.TabIndex = 27;
            this.label2.Text = "Fecha:";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(637, 217);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(105, 41);
            this.button1.TabIndex = 26;
            this.button1.Text = "Almacenar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // fecha_date
            // 
            this.fecha_date.Location = new System.Drawing.Point(589, 55);
            this.fecha_date.Name = "fecha_date";
            this.fecha_date.Size = new System.Drawing.Size(153, 20);
            this.fecha_date.TabIndex = 25;
            // 
            // Des_soli
            // 
            this.Des_soli.Location = new System.Drawing.Point(58, 237);
            this.Des_soli.Multiline = true;
            this.Des_soli.Name = "Des_soli";
            this.Des_soli.Size = new System.Drawing.Size(188, 156);
            this.Des_soli.TabIndex = 24;
            // 
            // Nombre_Client
            // 
            this.Nombre_Client.Location = new System.Drawing.Point(179, 38);
            this.Nombre_Client.Name = "Nombre_Client";
            this.Nombre_Client.Size = new System.Drawing.Size(260, 20);
            this.Nombre_Client.TabIndex = 23;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(75, 41);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(98, 13);
            this.label1.TabIndex = 22;
            this.label1.Text = "Nombre del cliente:";
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // Reparación_PC
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Examen_2.Properties.Resources.IMG_4257;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.cancel_cel);
            this.Controls.Add(this.menu);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.Des_Res);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.Tipo_de_soporte);
            this.Controls.Add(this.Celular);
            this.Controls.Add(this.Precio);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.fecha_date);
            this.Controls.Add(this.Des_soli);
            this.Controls.Add(this.Nombre_Client);
            this.Controls.Add(this.label1);
            this.Name = "Reparación_PC";
            this.Text = "Form2";
            this.Load += new System.EventHandler(this.Form2_Load);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button cancel_cel;
        private System.Windows.Forms.Button menu;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox Des_Res;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox Tipo_de_soporte;
        private System.Windows.Forms.TextBox Celular;
        private System.Windows.Forms.TextBox Precio;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DateTimePicker fecha_date;
        private System.Windows.Forms.TextBox Des_soli;
        private System.Windows.Forms.TextBox Nombre_Client;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ErrorProvider errorProvider1;
    }
}