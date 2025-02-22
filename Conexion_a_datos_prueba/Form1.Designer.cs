namespace Conexion_a_datos_prueba
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
            txt_nombre = new TextBox();
            txt_apellido = new TextBox();
            btn_guardar = new Button();
            lbl_nombre = new Label();
            lbl_apellido = new Label();
            SuspendLayout();
            // 
            // txt_nombre
            // 
            txt_nombre.Location = new Point(241, 88);
            txt_nombre.Name = "txt_nombre";
            txt_nombre.Size = new Size(316, 27);
            txt_nombre.TabIndex = 0;
            // 
            // txt_apellido
            // 
            txt_apellido.Location = new Point(241, 136);
            txt_apellido.Name = "txt_apellido";
            txt_apellido.Size = new Size(316, 27);
            txt_apellido.TabIndex = 1;
            // 
            // btn_guardar
            // 
            btn_guardar.Location = new Point(307, 193);
            btn_guardar.Name = "btn_guardar";
            btn_guardar.Size = new Size(154, 59);
            btn_guardar.TabIndex = 2;
            btn_guardar.Text = "Guardar";
            btn_guardar.UseVisualStyleBackColor = true;
            btn_guardar.Click += btn_guardar_Click;
            // 
            // lbl_nombre
            // 
            lbl_nombre.AutoSize = true;
            lbl_nombre.Location = new Point(172, 91);
            lbl_nombre.Name = "lbl_nombre";
            lbl_nombre.Size = new Size(64, 20);
            lbl_nombre.TabIndex = 3;
            lbl_nombre.Text = "Nombre";
            // 
            // lbl_apellido
            // 
            lbl_apellido.AutoSize = true;
            lbl_apellido.Location = new Point(169, 139);
            lbl_apellido.Name = "lbl_apellido";
            lbl_apellido.Size = new Size(66, 20);
            lbl_apellido.TabIndex = 4;
            lbl_apellido.Text = "Apellido";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(778, 349);
            Controls.Add(lbl_apellido);
            Controls.Add(lbl_nombre);
            Controls.Add(btn_guardar);
            Controls.Add(txt_apellido);
            Controls.Add(txt_nombre);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txt_nombre;
        private TextBox txt_apellido;
        private Button btn_guardar;
        private Label lbl_nombre;
        private Label lbl_apellido;
    }
}
