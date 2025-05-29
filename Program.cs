namespace ProyectoDeCursoE_commerce
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            // Metodo para que cuando se abra el form PaginaPrincipal, se cierre el form FormInicio, y vicebersa, y que cuando se entre al form DatoaDeEcommerce se cierre FormInicio y pase este como pricipal.
            string siguienteForm = "FormInicio";

            while (true)
            {
                Form formularioActual = siguienteForm switch
                {
                    "FormInicio" => new FormInicio(),
                    "PaginaPrincipal" => new PaginaPrincipal(),
                    "Administrador" => new Administrador(),
                    _ => null
                };

                if (formularioActual == null)
                    break;

                DialogResult resultado = formularioActual.ShowDialog();

                // Si el formulario indica cuál sigue, lo tomamos
                if (formularioActual.Tag is string siguiente && !string.IsNullOrEmpty(siguiente))
                {
                    siguienteForm = siguiente;
                }
                else
                {
                    break; // salir de la aplicación
                }
            }
        }
    }
}