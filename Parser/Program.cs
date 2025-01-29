using System;
using System.Linq;
using System.Threading;
using System.Windows.Forms;
using System.Drawing; // Necessário para manipular ícones
using System.IO;
using Parser.Controllers;
using Parser.Localization;

namespace Parser
{
    internal static class Program
    {
        private static bool isRestarted;

        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        private static void Main()
        {
            // Verifica argumentos de linha de comando
            string[] args = Environment.GetCommandLineArgs();
            if (args.Any(arg => arg == $"{ProgramController.ParameterPrefix}restart"))
                isRestarted = true;

            // Garante que apenas uma instância está rodando
            Mutex mutex = new Mutex(true, "LSCParserMini", out bool isUnique);
            if (!isUnique && !isRestarted)
            {
                MessageBox.Show(Strings.OtherInstanceRunning, Strings.Error, MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Configura visual e compatibilidade de renderização
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            // Atualiza configurações na primeira inicialização
            if (Properties.Settings.Default.FirstStart)
                Properties.Settings.Default.Upgrade();

            // Inicializa localizações e configurações do servidor
            LocalizationController.InitializeLocale();
            ProgramController.InitializeServerIp();

            // Cria a janela principal e define o ícone
            UI.Main mainForm = new UI.Main();
            try
            {
                string iconPath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "AppIcon.ico");
                if (File.Exists(iconPath))
                {
                    mainForm.Icon = new Icon(iconPath);
                }
                else
                {
                    MessageBox.Show($"Erro: Ícone não encontrado em {iconPath}", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Erro ao carregar ícone: {ex.Message}", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            // Executa o aplicativo
            Application.Run(mainForm);

            // Mantém a referência do Mutex viva
            GC.KeepAlive(mutex);
        }
    }
}