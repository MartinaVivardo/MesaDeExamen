namespace MesaDeExamen
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
            ApplicationConfiguration.Initialize();
            Application.Run(new Menu_principal());

        }
        public class Estudiante
        {
            public int Id = 0;
            public string Nombre = ""; 
            public string Apellido = "";
            public int Matricula = 0;
        }


    }
}