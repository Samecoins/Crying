using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Note
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        // Обработчик команды для добавления новой заметки
        private void NewCommand_Executed(object sender, ExecutedRoutedEventArgs e)
        {
            // Логика для создания новой заметки
            MessageBox.Show("New command executed! Creating new note.");
        }

        // Обработчик команды для открытия настроек
        private void OpenCommand_Executed(object sender, ExecutedRoutedEventArgs e)
        {
            // Логика для открытия настроек
            MessageBox.Show("Open command executed! Opening settings.");
        }
    }
}