using System.Windows;

namespace WpfApp1.View
{
    using ViewModel;

    /// <summary>
    /// Lógica de interacción para DataTableView.xaml
    /// </summary>
    public partial class DataTableView : Window
    {
        public DataTableView()
        {
            InitializeComponent();
            DataContext = new DataTableViewModel();
        }
    }
}
