using System.Windows;

namespace UI.Services
{
    public static class NavigationService
    {
        /// <summary>
        /// Abre uma nova janela e fecha a atual.
        /// </summary>
        /// <typeparam name="T">Tipo da nova janela</typeparam>
        /// <param name="currentWindow">Janela atual (a fechar)</param>
        public static void NavigateTo<T>(Window currentWindow) where T : Window, new()
        {
            var nextWindow = new T();
            nextWindow.Show();
            currentWindow.Close();
        }

        /// <summary>
        /// Apenas abre uma nova janela (sem fechar a atual).
        /// </summary>
        /// <typeparam name="T">Tipo da nova janela</typeparam>
        public static void OpenWindow<T>() where T : Window, new()
        {
            var window = new T();
            window.Show();
        }
    }
}
