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
            string siguienteForm = "PaginaPrincipal";

            while (true)
            {
                Form formularioActual = siguienteForm switch
                {
                    "FormInicio" => new FormInicio(),
                    "PaginaPrincipal" => new PaginaPrincipal(),
                    "Administracion" => new Administracion(),
                    _ => null
                };

                if (formularioActual == null)
                    break;
                if (siguienteForm == "Administracion")
                {
                    formularioActual.Size = new Size(309, 184); // Tamaño especial para Administrador
                }

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