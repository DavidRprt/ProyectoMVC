﻿namespace Vista
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
            this.label_titulo = new System.Windows.Forms.Label();
            this.label_nombre_usuario = new System.Windows.Forms.Label();
            this.txtNombre_de_usuario = new System.Windows.Forms.TextBox();
            this.txtContrasena = new System.Windows.Forms.TextBox();
            this.label_contrasena = new System.Windows.Forms.Label();
            this.txtConcontrasena = new System.Windows.Forms.TextBox();
            this.labelConfirmar_contrasena = new System.Windows.Forms.Label();
            this.checkBoxMosContrasena = new System.Windows.Forms.CheckBox();
            this.btnRegistrar = new System.Windows.Forms.Button();
            this.btnBorrar = new System.Windows.Forms.Button();
            this.labelVolver_log = new System.Windows.Forms.Label();
            this.labelCuenta_existente = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label_titulo
            // 
            this.label_titulo.AutoSize = true;
            this.label_titulo.Font = new System.Drawing.Font("MS UI Gothic", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_titulo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(116)))), ((int)(((byte)(86)))), ((int)(((byte)(174)))));
            this.label_titulo.Location = new System.Drawing.Point(23, 29);
            this.label_titulo.Name = "label_titulo";
            this.label_titulo.Size = new System.Drawing.Size(157, 27);
            this.label_titulo.TabIndex = 0;
            this.label_titulo.Text = "Empecemos";
            // 
            // label_nombre_usuario
            // 
            this.label_nombre_usuario.AutoSize = true;
            this.label_nombre_usuario.Font = new System.Drawing.Font("Bahnschrift", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_nombre_usuario.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(164)))), ((int)(((byte)(165)))), ((int)(((byte)(169)))));
            this.label_nombre_usuario.Location = new System.Drawing.Point(24, 79);
            this.label_nombre_usuario.Name = "label_nombre_usuario";
            this.label_nombre_usuario.Size = new System.Drawing.Size(149, 19);
            this.label_nombre_usuario.TabIndex = 1;
            this.label_nombre_usuario.Text = "Nombre de usuario";
            // 
            // txtNombre_de_usuario
            // 
            this.txtNombre_de_usuario.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(231)))), ((int)(((byte)(233)))));
            this.txtNombre_de_usuario.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtNombre_de_usuario.Location = new System.Drawing.Point(28, 101);
            this.txtNombre_de_usuario.Multiline = true;
            this.txtNombre_de_usuario.Name = "txtNombre_de_usuario";
            this.txtNombre_de_usuario.Size = new System.Drawing.Size(216, 28);
            this.txtNombre_de_usuario.TabIndex = 2;
            // 
            // txtContrasena
            // 
            this.txtContrasena.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(231)))), ((int)(((byte)(233)))));
            this.txtContrasena.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtContrasena.Location = new System.Drawing.Point(28, 168);
            this.txtContrasena.Multiline = true;
            this.txtContrasena.Name = "txtContrasena";
            this.txtContrasena.Size = new System.Drawing.Size(216, 28);
            this.txtContrasena.TabIndex = 4;
            // 
            // label_contrasena
            // 
            this.label_contrasena.AutoSize = true;
            this.label_contrasena.Font = new System.Drawing.Font("Bahnschrift", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_contrasena.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(164)))), ((int)(((byte)(165)))), ((int)(((byte)(169)))));
            this.label_contrasena.Location = new System.Drawing.Point(24, 146);
            this.label_contrasena.Name = "label_contrasena";
            this.label_contrasena.Size = new System.Drawing.Size(93, 19);
            this.label_contrasena.TabIndex = 3;
            this.label_contrasena.Text = "Contraseña";
            // 
            // txtConcontrasena
            // 
            this.txtConcontrasena.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(231)))), ((int)(((byte)(233)))));
            this.txtConcontrasena.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtConcontrasena.Location = new System.Drawing.Point(28, 240);
            this.txtConcontrasena.Multiline = true;
            this.txtConcontrasena.Name = "txtConcontrasena";
            this.txtConcontrasena.Size = new System.Drawing.Size(216, 28);
            this.txtConcontrasena.TabIndex = 6;
            // 
            // labelConfirmar_contrasena
            // 
            this.labelConfirmar_contrasena.AutoSize = true;
            this.labelConfirmar_contrasena.Font = new System.Drawing.Font("Bahnschrift", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelConfirmar_contrasena.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(164)))), ((int)(((byte)(165)))), ((int)(((byte)(169)))));
            this.labelConfirmar_contrasena.Location = new System.Drawing.Point(24, 218);
            this.labelConfirmar_contrasena.Name = "labelConfirmar_contrasena";
            this.labelConfirmar_contrasena.Size = new System.Drawing.Size(169, 19);
            this.labelConfirmar_contrasena.TabIndex = 5;
            this.labelConfirmar_contrasena.Text = "Confirmar contraseña";
            // 
            // checkBoxMosContrasena
            // 
            this.checkBoxMosContrasena.AutoSize = true;
            this.checkBoxMosContrasena.Cursor = System.Windows.Forms.Cursors.Hand;
            this.checkBoxMosContrasena.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.checkBoxMosContrasena.Font = new System.Drawing.Font("Bahnschrift", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBoxMosContrasena.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(164)))), ((int)(((byte)(165)))), ((int)(((byte)(169)))));
            this.checkBoxMosContrasena.Location = new System.Drawing.Point(111, 274);
            this.checkBoxMosContrasena.Name = "checkBoxMosContrasena";
            this.checkBoxMosContrasena.Size = new System.Drawing.Size(138, 20);
            this.checkBoxMosContrasena.TabIndex = 7;
            this.checkBoxMosContrasena.Text = "Mostrar contraseña";
            this.checkBoxMosContrasena.UseVisualStyleBackColor = true;
            // 
            // btnRegistrar
            // 
            this.btnRegistrar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(116)))), ((int)(((byte)(86)))), ((int)(((byte)(174)))));
            this.btnRegistrar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnRegistrar.FlatAppearance.BorderSize = 0;
            this.btnRegistrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRegistrar.Font = new System.Drawing.Font("Bahnschrift", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRegistrar.ForeColor = System.Drawing.Color.White;
            this.btnRegistrar.Location = new System.Drawing.Point(28, 314);
            this.btnRegistrar.Name = "btnRegistrar";
            this.btnRegistrar.Size = new System.Drawing.Size(216, 35);
            this.btnRegistrar.TabIndex = 8;
            this.btnRegistrar.Text = "Registrar";
            this.btnRegistrar.UseVisualStyleBackColor = false;
            // 
            // btnBorrar
            // 
            this.btnBorrar.BackColor = System.Drawing.Color.White;
            this.btnBorrar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnBorrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBorrar.Font = new System.Drawing.Font("Bahnschrift", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBorrar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(116)))), ((int)(((byte)(86)))), ((int)(((byte)(174)))));
            this.btnBorrar.Location = new System.Drawing.Point(28, 355);
            this.btnBorrar.Name = "btnBorrar";
            this.btnBorrar.Size = new System.Drawing.Size(216, 35);
            this.btnBorrar.TabIndex = 9;
            this.btnBorrar.Text = "Borrar";
            this.btnBorrar.UseVisualStyleBackColor = false;
            // 
            // labelVolver_log
            // 
            this.labelVolver_log.AutoSize = true;
            this.labelVolver_log.Cursor = System.Windows.Forms.Cursors.Hand;
            this.labelVolver_log.Font = new System.Drawing.Font("Bahnschrift", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelVolver_log.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(116)))), ((int)(((byte)(86)))), ((int)(((byte)(174)))));
            this.labelVolver_log.Location = new System.Drawing.Point(108, 436);
            this.labelVolver_log.Name = "labelVolver_log";
            this.labelVolver_log.Size = new System.Drawing.Size(50, 18);
            this.labelVolver_log.TabIndex = 11;
            this.labelVolver_log.Text = "Volver";
            // 
            // labelCuenta_existente
            // 
            this.labelCuenta_existente.AutoSize = true;
            this.labelCuenta_existente.Font = new System.Drawing.Font("Bahnschrift", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelCuenta_existente.Location = new System.Drawing.Point(65, 408);
            this.labelCuenta_existente.Name = "labelCuenta_existente";
            this.labelCuenta_existente.Size = new System.Drawing.Size(145, 18);
            this.labelCuenta_existente.TabIndex = 12;
            this.labelCuenta_existente.Text = "Ya tienes una cuenta";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(269, 477);
            this.Controls.Add(this.labelCuenta_existente);
            this.Controls.Add(this.labelVolver_log);
            this.Controls.Add(this.btnBorrar);
            this.Controls.Add(this.btnRegistrar);
            this.Controls.Add(this.checkBoxMosContrasena);
            this.Controls.Add(this.txtConcontrasena);
            this.Controls.Add(this.labelConfirmar_contrasena);
            this.Controls.Add(this.txtContrasena);
            this.Controls.Add(this.label_contrasena);
            this.Controls.Add(this.txtNombre_de_usuario);
            this.Controls.Add(this.label_nombre_usuario);
            this.Controls.Add(this.label_titulo);
            this.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = " ";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label_titulo;
        private System.Windows.Forms.Label label_nombre_usuario;
        private System.Windows.Forms.TextBox txtNombre_de_usuario;
        private System.Windows.Forms.TextBox txtContrasena;
        private System.Windows.Forms.Label label_contrasena;
        private System.Windows.Forms.TextBox txtConcontrasena;
        private System.Windows.Forms.Label labelConfirmar_contrasena;
        private System.Windows.Forms.CheckBox checkBoxMosContrasena;
        private System.Windows.Forms.Button btnRegistrar;
        private System.Windows.Forms.Button btnBorrar;
        private System.Windows.Forms.Label labelVolver_log;
        private System.Windows.Forms.Label labelCuenta_existente;
    }
}

