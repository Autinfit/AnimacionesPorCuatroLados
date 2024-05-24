namespace FourWay_Sprite_Animation
{
    public partial class Form1 : Form
    {
        // ESTE ES UNA CLASE DEL FORMULARIO POR DEFECTO...

        // CREAREMOS ALGUNAS DE SUS VARIABLES PARA ESTE PROYECTO...

        Image jugador; // PARA EL JUGADOR.
        List<string> movimientosPersonaje = new List<string>(); // MOVIMIENTOS DEL PERSONAJE MEDIANTE UNA LISTA.
        int pasos = 0; // CANTIDAD DE PASOS QUE MUEVE AQUELLO PERSONAJE.
        int reducirFrecuenciaPatrones = 0; // REDUCCIÓN DE FRECUENCIA DE PATRONES DEL PROYECTO.
        bool izquierda, derecha, arriba, abajo; // DECISIÓN DEL USUARIO HACIA DONDE MUEVE EL PERSONAJE.
        int jugadorEnX; // POSICIÓN DEL JUGADOR EN X DE MANERA HORIZONTAL.
        int jugadorEnY; // POSICIÓN DEL JUGADOR EN Y DE MANERA VERTICAL.
        int alturaJugador = 100; // ALTURA DEL JUGADOR EN EL JUEGO DE MANERA DINÁMICA AQUÍ.
        int anchoJugador = 100; // ANCHO DEL JUGADOR EN EL JUEGO DE MANERA DINÁMICA AQUÍ.
        int velocidadJugador = 8; // LA VELOCIDAD DEL JUGADOR SERÁ DE 8 KM.

        public Form1()
        {
            InitializeComponent();
            Configuracion(); // NO OLVIDAR EL LLAMADO DE ESTE MÉTODO AQUÍ.
        }

        private void PresionarCualquierTecla(object sender, KeyEventArgs e)
        {
            // MÉTODO CUANDO EL JUGADOR PRESIONA UNA TECLA...

            // VAMOS A CREAR UN ALGORITMO SENCILLO MEDIANTE LAS CONDICIONES "if" AL PRESIONAR UNA TECLA...

            if (e.KeyCode == Keys.Left) // SI SE PRESIONA LA TECLA IZQUIERDA DEL TECLADO...
            {
                izquierda = true; // EL JUGADOR VA HACIA LA IZQUIERDA.
            }

            if (e.KeyCode == Keys.Right) // SI SE PRESIONA LA TECLA DERECHA DEL TECLADO...
            {
                derecha = true; // EL JUGADOR VA HACIA LA DERECHA.
            }

            if (e.KeyCode == Keys.Up) // SI SE PRESIONA LA TECLA DE ARRIBA DEL TECLADO...
            {
                arriba = true; // EL JUGADOR VA HACIA ARRIBA.
            }

            if (e.KeyCode == Keys.Down) // SI SE PRESIONA LA TECLA DE ABAJO DEL TECLADO...
            {
                abajo = true; // EL JUGADOR VA HACIA ABAJO.
            }
        }

        private void SoltarCualquierTecla(object sender, KeyEventArgs e)
        {
            // MÉTODO CUANDO EL JUGADOR SUELTA UNA TECLA...

            // HAREMOS EL MISMO PROCEDIMIENTO PERO LO CONTRARIO QUE AL PRESIONAR UNA TECLA (MISMO ALGORITMO DE CÓDIGO)...

            if (e.KeyCode == Keys.Left) // SI SE SUELTA LA TECLA IZQUIERDA DEL TECLADO...
            {
                izquierda = false; // EL JUGADOR YA NO VA HACIA LA IZQUIERDA.
            }

            if (e.KeyCode == Keys.Right) // SI SE SUELTA LA TECLA DERECHA DEL TECLADO...
            {
                derecha = false; // EL JUGADOR YA NO VA HACIA LA DERECHA.
            }

            if (e.KeyCode == Keys.Up) // SI SE SUELTA LA TECLA DE ARRIBA DEL TECLADO...
            {
                arriba = false; // EL JUGADOR YA NO VA HACIA ARRIBA.
            }

            if (e.KeyCode == Keys.Down) // SI SE SUELTA LA TECLA DE ABAJO DEL TECLADO...
            {
                abajo = false; // EL JUGADOR YA NO VA HACIA ABAJO.
            }
        }

        private void EdicionFormulario(object sender, PaintEventArgs e)
        {
            // MÉTODO PARA EDITAR EL FORMULARIO MEDIANTE FUNCIONES GRÁFICAS...

            // ES SÚPER CORTO EL PROCEDIMIENTO (2 LÍNEAS DE CÓDIGO EN ESTE MÉTODO)...

            Graphics Canvas = e.Graphics; // IMPORTAREMOS GRÁFICAS DEL LIENZO PARA EDICIONES POSTERIORES DE LA INTERFAZ DEL FORMULARIO.
            Canvas.DrawImage(jugador, jugadorEnX, jugadorEnY, anchoJugador, alturaJugador); // INCORPORAREMOS AL PERSONAJE EN LA INTERFAZ CON SUS RESPECTIVAS CARACTERÍSTICAS.
        }

        private void TiempoEjecucion(object sender, EventArgs e)
        {
            // MÉTODO PARA INICIALIZAR LA EJECUCIÓN DEL PROYECTO EN GENERAL...

            // MEDIANTE MOVIMIENTOS DEL PERSONAJE, VAMOS A CONFIGURAR SUS DIRECCIONES RESPECTIVAS MEDIANTE UNA CONDICIÓN ("if")...

            if (izquierda && jugadorEnX > 0) // SI EL JUGADOR VA HACIA LA IZQUIERDA...
            {
                jugadorEnX -= velocidadJugador; // LA VELOCIDAD SE DIRIGE HACIA EL LADO CONTRARIO.
                AnimarJugador(4, 7); // LAS ANIMACIONES VAN A SER DEFINIDAS MEDIANTE SUS CANTIDADES RESPECTIVAS PARA CADA CLON DEL JUGADOR.
            }

            else if (derecha && jugadorEnX + anchoJugador < this.ClientSize.Width) // SI EL JUGADOR VA HACIA LA DERECHA...
            {
                jugadorEnX += velocidadJugador; // LA VELOCIDAD SE DIRIGE HACIA EL LADO DIRECTO.
                AnimarJugador(8, 11); // LAS ANIMACIONES VAN A SER DEFINIDAS MEDIANTE SUS CANTIDADES RESPECTIVAS PARA CADA CLON DEL JUGADOR.
            }

            else if (arriba && jugadorEnY > 0) // SI EL JUGADOR VA HACIA ARRIBA...
            {
                jugadorEnY -= velocidadJugador; // LA VELOCIDAD SE DIRIGE HACIA EL LADO CONTRARIO.
                AnimarJugador(12, 15); // LAS ANIMACIONES VAN A SER DEFINIDAS MEDIANTE SUS CANTIDADES RESPECTIVAS PARA CADA CLON DEL JUGADOR.
            }

            else if (abajo && jugadorEnY + alturaJugador < this.ClientSize.Height) // SI EL JUGADOR VA HACIA ABAJO...
            {
                jugadorEnX += velocidadJugador; // LA VELOCIDAD SE DIRIGE HACIA EL LADO DIRECTO.
                AnimarJugador(0, 3); // LAS ANIMACIONES VAN A SER DEFINIDAS MEDIANTE SUS CANTIDADES RESPECTIVAS PARA CADA CLON DEL JUGADOR.
            }

            else
            {
                AnimarJugador(0, 0);
            }

            this.Invalidate();
            cantidadMovimientos.Text = "Movimientos: " + pasos;
        }

        // HASTA AHORA DINÁMICAMENTE SE AGREGARON ESTOS EVENTOS...

        // AHORA VAMOS A ESTABLECER AQUÍ LOS SIGUIENTES MÉTODOS DE MANERA ESTÁTICA...

        private void Configuracion()
        {
            // MÉTODO SECUENCIAL PARA CONFIGURACIONES POSTERIORES...

            // VAMOS A IMPORTAR IMÁGENES DE MANERA DINÁMICA AQUÍ...

            this.BackgroundImage = Image.FromFile("bg.jpg");
            this.BackgroundImageLayout = ImageLayout.Stretch;
            this.DoubleBuffered = true;

            // SE CARGAN LOS RECURSOS GRÁFICOS DEL JUGADOR MEDIANTE UNA LISTA DE RECURSOS IMPORTADOS AQUÍ...

            movimientosPersonaje = Directory.GetFiles("player", "*.png").ToList();
            jugador = Image.FromFile(movimientosPersonaje[0]);
        }

        private void AnimarJugador(int inicial, int final)
        {
            // MÉTODO PARA ANIMAR AL JUGADOR SEGÚN LOS TIEMPOS DE EJECUCIÓN DEL PROGRAMA...

            // EN INSTANTES...
        }
    }
}