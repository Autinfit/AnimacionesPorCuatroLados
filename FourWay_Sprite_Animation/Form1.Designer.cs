namespace FourWay_Sprite_Animation
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
            components = new System.ComponentModel.Container();
            cantidadMovimientos = new Label();
            temporizador = new System.Windows.Forms.Timer(components);
            SuspendLayout();
            // 
            // cantidadMovimientos
            // 
            cantidadMovimientos.AutoSize = true;
            cantidadMovimientos.BackColor = Color.Transparent;
            cantidadMovimientos.Font = new Font("Segoe UI", 14F, FontStyle.Bold, GraphicsUnit.Point);
            cantidadMovimientos.ForeColor = Color.Red;
            cantidadMovimientos.Location = new Point(10, 495);
            cantidadMovimientos.Name = "cantidadMovimientos";
            cantidadMovimientos.Size = new Size(238, 38);
            cantidadMovimientos.TabIndex = 0;
            cantidadMovimientos.Text = "Movimientos: 00";
            // 
            // temporizador
            // 
            temporizador.Enabled = true;
            temporizador.Interval = 20;
            temporizador.Tick += TiempoEjecucion;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 544);
            Controls.Add(cantidadMovimientos);
            Name = "Form1";
            Text = "Animaciones en 4 lados";
            Paint += EdicionFormulario;
            KeyDown += PresionarCualquierTecla;
            KeyUp += SoltarCualquierTecla;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label cantidadMovimientos;
        private System.Windows.Forms.Timer temporizador;
    }
}