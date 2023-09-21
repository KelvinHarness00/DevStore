using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.Diagnostics;
using static System.Net.WebRequestMethods;

namespace WPFStore.MVVM.View
{
    /// <summary>
    /// Interação lógica para HomeView.xam
    /// </summary>
    public partial class HomeView : UserControl
    {
        #region Consts
        const string gh = "https://github.com/KelvinHarness00";
        const string educandus = "https://educandus.com.br";
        const string progClasses = "https://www.superprof.com.br/aulas-programacao-logica-para-iniciantes-tenho-tecnico-programacao-jogos-completo-curso-bacharelado-ciencias.html";
        const string samsungProject = "https://portal.cin.ufpe.br/?s=Projeto+Samsung";
        #endregion

        public HomeView()
        {
            InitializeComponent();
        }

        #region Mouse Left Down
        private void Contact_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            OpenEmail("kelvin.alves.harness@gmail.com", "Dev Store Contact", "");

        }
        private void Github_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            OpenLinkWeb(gh);

        }
        private void Educandus_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            OpenLinkWeb(educandus);
        }
        private void ProgrammingClasses_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            OpenLinkWeb(progClasses);
        }
        private void SamsungProject_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            OpenLinkWeb(samsungProject);
        }
        #endregion

        #region Methods
        public static void OpenEmail(string destinatario, string assunto, string corpo)
        {
            if (!string.IsNullOrEmpty(destinatario))
            {
                string uri = $"mailto:{destinatario}?subject={Uri.EscapeDataString(assunto)}&body={Uri.EscapeDataString(corpo)}";

                Process.Start(uri);
            }
        }
        public static void OpenLinkWeb(string url)
        {
            if (!string.IsNullOrEmpty(url))
            {
                Process.Start(url);
            }
        }
        #endregion

    }
}
