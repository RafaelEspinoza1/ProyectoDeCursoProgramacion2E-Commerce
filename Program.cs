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

            // Metodo para que cuando se abra el form PaginaPrincipal, se cierre el form FormInicio, y vicebersa.
            while (true)
            {
                FormInicio form1 = new FormInicio();
                if (form1.ShowDialog() == DialogResult.OK)
                {
                    PaginaPrincipal form2 = new PaginaPrincipal();
                    if (form2.ShowDialog() != DialogResult.OK)
                        break;
                }
                else
                {
                    break;
                }
            }
        }
    }
}