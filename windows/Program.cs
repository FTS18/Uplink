namespace BitBar;

static class Program
{
    private static System.Threading.Mutex? mutex = null;

    /// <summary>
    ///  The main entry point for the application.
    /// </summary>
    [STAThread]
    static void Main()
    {
        const string appName = "Global\\BitBarNativeNetMonitor";
        bool createdNew;

        mutex = new System.Threading.Mutex(true, appName, out createdNew);

        if (!createdNew)
        {
            // Application is already running. Exit immediately.
            return;
        }

        // To customize application configuration such as set high DPI settings or default font,
        // see https://aka.ms/applicationconfiguration.
        ApplicationConfiguration.Initialize();
        Application.Run(new Form1());
    }    
}