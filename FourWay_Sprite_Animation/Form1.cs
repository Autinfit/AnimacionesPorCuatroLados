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
        int jugadorY; // POSICI�N DEL JUGADOR EN Y DE MANERA VERTICAL.
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

            // EN INSTANTES...
        }

        private void SoltarCualquierTecla(object sender, KeyEventArgs e)
        {
            // M�TODO CUANDO EL JUGADOR SUELTA UNA TECLA...

            // EN INSTANTES...
        }

        private void EdicionFormulario(object sender, PaintEventArgs e)
        {
            // M�TODO PARA EDITAR EL FORMULARIO MEDIANTE FUNCIONES GR�FICAS...

            // EN INSTANTES...
        }

        private void TiempoEjecucion(object sender, EventArgs e)
        {
            // M�TODO PARA INICIALIZAR LA EJECUCI�N DEL PROYECTO EN GENERAL...

            // EN INSTANTES...
        }

        // HASTA AHORA DIN�MICAMENTE SE AGREGARON ESTOS EVENTOS...

        // AHORA VAMOS A ESTABLECER AQU� LOS SIGUIENTES M�TODOS DE MANERA EST�TICA...

        private void Configuracion()
        {
            // M�TODO SECUENCIAL PARA CONFIGURACIONES POSTERIORES...

            // EN INSTANTES...
        }

        private void AnimarJugador(int inicial, int final)
        {
            // M�TODO PARA ANIMAR AL JUGADOR SEG�N LOS TIEMPOS DE EJECUCI�N DEL PROGRAMA...

            // EN INSTANTES...
        }
    }
}