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
        int jugadorY; // POSICIÓN DEL JUGADOR EN Y DE MANERA VERTICAL.
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

            // EN INSTANTES...
        }

        private void TiempoEjecucion(object sender, EventArgs e)
        {
            // MÉTODO PARA INICIALIZAR LA EJECUCIÓN DEL PROYECTO EN GENERAL...

            // EN INSTANTES...
        }

        // HASTA AHORA DINÁMICAMENTE SE AGREGARON ESTOS EVENTOS...

        // AHORA VAMOS A ESTABLECER AQUÍ LOS SIGUIENTES MÉTODOS DE MANERA ESTÁTICA...

        private void Configuracion()
        {
            // MÉTODO SECUENCIAL PARA CONFIGURACIONES POSTERIORES...

            // EN INSTANTES...
        }

        private void AnimarJugador(int inicial, int final)
        {
            // MÉTODO PARA ANIMAR AL JUGADOR SEGÚN LOS TIEMPOS DE EJECUCIÓN DEL PROGRAMA...

            // EN INSTANTES...
        }
    }
}