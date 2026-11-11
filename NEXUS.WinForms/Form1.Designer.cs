namespace NEXUS.WinForms
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
            btnIniciar = new Button();
            btnExploradores = new Button();
            btnAcercaDe = new Button();
            btnSalir = new Button();
            lblTitulo = new Label();
            SuspendLayout();
            // 
            // btnIniciar
            // 
            btnIniciar.Location = new Point(346, 159);
            btnIniciar.Name = "btnIniciar";
            btnIniciar.Size = new Size(112, 34);
            btnIniciar.TabIndex = 1;
            btnIniciar.Text = "Iniciar entrenamiento";
            btnIniciar.UseVisualStyleBackColor = true;
            btnIniciar.Click += btnIniciar_Click;
            // 
            // btnExploradores
            // 
            btnExploradores.Location = new Point(346, 199);
            btnExploradores.Name = "btnExploradores";
            btnExploradores.Size = new Size(112, 34);
            btnExploradores.TabIndex = 2;
            btnExploradores.Text = "Explorador";
            btnExploradores.UseVisualStyleBackColor = true;
            btnExploradores.Click += btnExploradores_Click;
            // 
            // btnAcercaDe
            // 
            btnAcercaDe.Location = new Point(346, 239);
            btnAcercaDe.Name = "btnAcercaDe";
            btnAcercaDe.Size = new Size(112, 34);
            btnAcercaDe.TabIndex = 3;
            btnAcercaDe.Text = "Acerca de";
            btnAcercaDe.UseVisualStyleBackColor = true;
            btnAcercaDe.Click += btnAcercaDe_Click;
            // 
            // btnSalir
            // 
            btnSalir.Location = new Point(346, 279);
            btnSalir.Name = "btnSalir";
            btnSalir.Size = new Size(112, 34);
            btnSalir.TabIndex = 4;
            btnSalir.Text = "Salir";
            btnSalir.UseVisualStyleBackColor = true;
            btnSalir.Click += button4_Click;
            // 
            // lblTitulo
            // 
            lblTitulo.AutoSize = true;
            lblTitulo.Location = new Point(311, 107);
            lblTitulo.Name = "lblTitulo";
            lblTitulo.Size = new Size(200, 25);
            lblTitulo.TabIndex = 5;
            lblTitulo.Text = "NEXUS - Menú Principal";
            lblTitulo.Click += lblTitulo_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(lblTitulo);
            Controls.Add(btnSalir);
            Controls.Add(btnAcercaDe);
            Controls.Add(btnExploradores);
            Controls.Add(btnIniciar);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Button btnIniciar;
        private Button btnExploradores;
        private Button btnAcercaDe;
        private Button btnSalir;
        private Label lblTitulo;
    }
}
