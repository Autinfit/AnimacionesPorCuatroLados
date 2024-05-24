namespace FourWay_Sprite_Animation
{
    public partial class Form1 : Form
    {
        // ESTE ES UNA CLASE DEL FORMULARIO POR DEFECTO...

        // CREAREMOS ALGUNAS DE SUS VARIABLES PARA ESTE PROYECTO...

        Image jugador; // PARA EL JUGADOR.
        List<string> movimientosPersonaje = new List<string>(); // MOVIMIENTOS DEL PERSONAJE MEDIANTE UNA LISTA.
        int pasos = 0; // CANTIDAD DE PASOS QUE MUEVE AQUELLO PERSONAJE.
        int reducirFrecuenciaPatrones = 0; // REDUCCI�N DE FRECUENCIA DE PATRONES DEL PROYECTO.
        bool izquierda, derecha, arriba, abajo; // DECISI�N DEL USUARIO HACIA DONDE MUEVE EL PERSONAJE.
        int jugadorEnX; // POSICI�N DEL JUGADOR EN X DE MANERA HORIZONTAL.
        int jugadorEnY; // POSICI�N DEL JUGADOR EN Y DE MANERA VERTICAL.
        int alturaJugador = 100; // ALTURA DEL JUGADOR EN EL JUEGO DE MANERA DIN�MICA AQU�.
        int anchoJugador = 100; // ANCHO DEL JUGADOR EN EL JUEGO DE MANERA DIN�MICA AQU�.
        int velocidadJugador = 8; // LA VELOCIDAD DEL JUGADOR SER� DE 8 KM.

        public Form1()
        {
            InitializeComponent();
            Configuracion(); // NO OLVIDAR EL LLAMADO DE ESTE M�TODO AQU�.
        }

        private void PresionarCualquierTecla(object sender, KeyEventArgs e)
        {
            // M�TODO CUANDO EL JUGADOR PRESIONA UNA TECLA...

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
            // M�TODO CUANDO EL JUGADOR SUELTA UNA TECLA...

            // HAREMOS EL MISMO PROCEDIMIENTO PERO LO CONTRARIO QUE AL PRESIONAR UNA TECLA (MISMO ALGORITMO DE C�DIGO)...

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
            // M�TODO PARA EDITAR EL FORMULARIO MEDIANTE FUNCIONES GR�FICAS...

            // ES S�PER CORTO EL PROCEDIMIENTO (2 L�NEAS DE C�DIGO EN ESTE M�TODO)...

            Graphics Canvas = e.Graphics; // IMPORTAREMOS GR�FICAS DEL LIENZO PARA EDICIONES POSTERIORES DE LA INTERFAZ DEL FORMULARIO.
            Canvas.DrawImage(jugador, jugadorEnX, jugadorEnY, anchoJugador, alturaJugador); // INCORPORAREMOS AL PERSONAJE EN LA INTERFAZ CON SUS RESPECTIVAS CARACTER�STICAS.
        }

        private void TiempoEjecucion(object sender, EventArgs e)
        {
            // M�TODO PARA INICIALIZAR LA EJECUCI�N DEL PROYECTO EN GENERAL...

            // MEDIANTE MOVIMIENTOS DEL PERSONAJE, VAMOS A CONFIGURAR SUS DIRECCIONES RESPECTIVAS MEDIANTE UNA CONDICI�N ("if")...

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

        // HASTA AHORA DIN�MICAMENTE SE AGREGARON ESTOS EVENTOS...

        // AHORA VAMOS A ESTABLECER AQU� LOS SIGUIENTES M�TODOS DE MANERA EST�TICA...

        private void Configuracion()
        {
            // M�TODO SECUENCIAL PARA CONFIGURACIONES POSTERIORES...

            // VAMOS A IMPORTAR IM�GENES DE MANERA DIN�MICA AQU�...

            this.BackgroundImage = Image.FromFile("bg.jpg");
            this.BackgroundImageLayout = ImageLayout.Stretch;
            this.DoubleBuffered = true;

            // SE CARGAN LOS RECURSOS GR�FICOS DEL JUGADOR MEDIANTE UNA LISTA DE RECURSOS IMPORTADOS AQU�...

            movimientosPersonaje = Directory.GetFiles("player", "*.png").ToList();
            jugador = Image.FromFile(movimientosPersonaje[0]);
        }

        private void AnimarJugador(int inicial, int final)
        {
            // M�TODO PARA ANIMAR AL JUGADOR SEG�N LOS TIEMPOS DE EJECUCI�N DEL PROGRAMA...

            // EN INSTANTES...
        }
    }
}