using System.Linq;
using Caique_D7_avaliacao.Data;
using System.Windows;


namespace Caique_D7_avaliacao
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private readonly Context context;
        Register newRegister = new();

        public MainWindow(Context context)
        {
            this.context = context;
            InitializeComponent();
        }

        private bool CompareRegisters(string user, string pass)
        {
            return context.Registers.Any(Register => Register.Email == user && Register.Password == pass);
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            if (CompareRegisters(UserNameText.Text, PasswordText.Text))
            {
                MessageBox.Show("Usuário autenticado!", "", MessageBoxButton.OK);
            }
            else
            {
                MessageBox.Show("Credenciais Inválidas!", "", MessageBoxButton.OK);
            }
        }
    }
}
