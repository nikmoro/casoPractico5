namespace Clases
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnPrueba = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnPost = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.txtNombreGET = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtApellidoGET = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtTrabajador = new System.Windows.Forms.TextBox();
            this.txtNombresPost = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.txtpokemon = new System.Windows.Forms.TextBox();
            this.lblpokemon = new System.Windows.Forms.Label();
            this.txtpoke = new System.Windows.Forms.TextBox();
            this.lblpoke = new System.Windows.Forms.Label();
            this.btnJoke = new System.Windows.Forms.Button();
            this.btnanimar = new System.Windows.Forms.Button();
            this.lblnombre = new System.Windows.Forms.Label();
            this.lblstatus = new System.Windows.Forms.Label();
            this.lblgenre = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnPrueba
            // 
            this.btnPrueba.Location = new System.Drawing.Point(15, 277);
            this.btnPrueba.Name = "btnPrueba";
            this.btnPrueba.Size = new System.Drawing.Size(295, 53);
            this.btnPrueba.TabIndex = 0;
            this.btnPrueba.Text = "GET";
            this.btnPrueba.UseVisualStyleBackColor = true;
            this.btnPrueba.Click += new System.EventHandler(this.btnPrueba_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(88, 24);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(157, 146);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // btnPost
            // 
            this.btnPost.Location = new System.Drawing.Point(333, 277);
            this.btnPost.Name = "btnPost";
            this.btnPost.Size = new System.Drawing.Size(295, 53);
            this.btnPost.TabIndex = 2;
            this.btnPost.Text = "post";
            this.btnPost.UseVisualStyleBackColor = true;
            this.btnPost.Click += new System.EventHandler(this.btnPost_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 202);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Email:";
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(70, 199);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(237, 20);
            this.txtEmail.TabIndex = 4;
            // 
            // txtNombreGET
            // 
            this.txtNombreGET.Location = new System.Drawing.Point(70, 225);
            this.txtNombreGET.Name = "txtNombreGET";
            this.txtNombreGET.Size = new System.Drawing.Size(237, 20);
            this.txtNombreGET.TabIndex = 6;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 228);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Nombres:";
            // 
            // txtApellidoGET
            // 
            this.txtApellidoGET.Location = new System.Drawing.Point(70, 251);
            this.txtApellidoGET.Name = "txtApellidoGET";
            this.txtApellidoGET.Size = new System.Drawing.Size(237, 20);
            this.txtApellidoGET.TabIndex = 8;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 254);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(52, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Apellidos:";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtTrabajador);
            this.groupBox1.Controls.Add(this.txtNombresPost);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Location = new System.Drawing.Point(333, 194);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(295, 74);
            this.groupBox1.TabIndex = 9;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Agregar Trabajador:";
            // 
            // txtTrabajador
            // 
            this.txtTrabajador.Location = new System.Drawing.Point(66, 45);
            this.txtTrabajador.Name = "txtTrabajador";
            this.txtTrabajador.Size = new System.Drawing.Size(225, 20);
            this.txtTrabajador.TabIndex = 13;
            // 
            // txtNombresPost
            // 
            this.txtNombresPost.Location = new System.Drawing.Point(66, 19);
            this.txtNombresPost.Name = "txtNombresPost";
            this.txtNombresPost.Size = new System.Drawing.Size(225, 20);
            this.txtNombresPost.TabIndex = 11;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(5, 48);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(61, 13);
            this.label4.TabIndex = 12;
            this.label4.Text = "Trabajador:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(5, 22);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(47, 13);
            this.label5.TabIndex = 10;
            this.label5.Text = "Nombre:";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(529, 67);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(93, 34);
            this.button1.TabIndex = 10;
            this.button1.Text = "Pokemon";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // txtpokemon
            // 
            this.txtpokemon.Location = new System.Drawing.Point(423, 75);
            this.txtpokemon.Name = "txtpokemon";
            this.txtpokemon.Size = new System.Drawing.Size(100, 20);
            this.txtpokemon.TabIndex = 11;
            // 
            // lblpokemon
            // 
            this.lblpokemon.AutoSize = true;
            this.lblpokemon.Location = new System.Drawing.Point(273, 88);
            this.lblpokemon.Name = "lblpokemon";
            this.lblpokemon.Size = new System.Drawing.Size(0, 13);
            this.lblpokemon.TabIndex = 12;
            // 
            // txtpoke
            // 
            this.txtpoke.Location = new System.Drawing.Point(423, 147);
            this.txtpoke.Name = "txtpoke";
            this.txtpoke.Size = new System.Drawing.Size(100, 20);
            this.txtpoke.TabIndex = 13;
            // 
            // lblpoke
            // 
            this.lblpoke.AutoSize = true;
            this.lblpoke.Location = new System.Drawing.Point(273, 67);
            this.lblpoke.Name = "lblpoke";
            this.lblpoke.Size = new System.Drawing.Size(0, 13);
            this.lblpoke.TabIndex = 14;
            // 
            // btnJoke
            // 
            this.btnJoke.Location = new System.Drawing.Point(529, 147);
            this.btnJoke.Name = "btnJoke";
            this.btnJoke.Size = new System.Drawing.Size(75, 23);
            this.btnJoke.TabIndex = 15;
            this.btnJoke.Text = "Joke";
            this.btnJoke.UseVisualStyleBackColor = true;
            this.btnJoke.Click += new System.EventHandler(this.btnJoke_Click);
            // 
            // btnanimar
            // 
            this.btnanimar.Location = new System.Drawing.Point(293, 130);
            this.btnanimar.Name = "btnanimar";
            this.btnanimar.Size = new System.Drawing.Size(75, 23);
            this.btnanimar.TabIndex = 16;
            this.btnanimar.Text = "Animar";
            this.btnanimar.UseVisualStyleBackColor = true;
            this.btnanimar.Click += new System.EventHandler(this.btnanimar_Click);
            // 
            // lblnombre
            // 
            this.lblnombre.AutoSize = true;
            this.lblnombre.Location = new System.Drawing.Point(12, 34);
            this.lblnombre.Name = "lblnombre";
            this.lblnombre.Size = new System.Drawing.Size(35, 13);
            this.lblnombre.TabIndex = 17;
            this.lblnombre.Text = "label6";
            // 
            // lblstatus
            // 
            this.lblstatus.AutoSize = true;
            this.lblstatus.Location = new System.Drawing.Point(12, 67);
            this.lblstatus.Name = "lblstatus";
            this.lblstatus.Size = new System.Drawing.Size(35, 13);
            this.lblstatus.TabIndex = 18;
            this.lblstatus.Text = "label7";
            // 
            // lblgenre
            // 
            this.lblgenre.AutoSize = true;
            this.lblgenre.Location = new System.Drawing.Point(12, 102);
            this.lblgenre.Name = "lblgenre";
            this.lblgenre.Size = new System.Drawing.Size(35, 13);
            this.lblgenre.TabIndex = 19;
            this.lblgenre.Text = "label8";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(646, 350);
            this.Controls.Add(this.lblgenre);
            this.Controls.Add(this.lblstatus);
            this.Controls.Add(this.lblnombre);
            this.Controls.Add(this.btnanimar);
            this.Controls.Add(this.btnJoke);
            this.Controls.Add(this.lblpoke);
            this.Controls.Add(this.txtpoke);
            this.Controls.Add(this.lblpokemon);
            this.Controls.Add(this.txtpokemon);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.txtApellidoGET);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtNombreGET);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtEmail);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnPost);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btnPrueba);
            this.Name = "Form1";
            this.Text = "Calculadora";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnPrueba;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btnPost;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.TextBox txtNombreGET;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtApellidoGET;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtTrabajador;
        private System.Windows.Forms.TextBox txtNombresPost;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox txtpokemon;
        private System.Windows.Forms.Label lblpokemon;
        private System.Windows.Forms.TextBox txtpoke;
        private System.Windows.Forms.Label lblpoke;
        private System.Windows.Forms.Button btnJoke;
        private System.Windows.Forms.Button btnanimar;
        private System.Windows.Forms.Label lblnombre;
        private System.Windows.Forms.Label lblstatus;
        private System.Windows.Forms.Label lblgenre;
    }
}

