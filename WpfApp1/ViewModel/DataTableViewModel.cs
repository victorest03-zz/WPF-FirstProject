namespace WpfApp1.ViewModel
{
    using Helper;
    using System.Collections.ObjectModel;
    using System.ComponentModel;
    using System.Runtime.CompilerServices;

    public class DataTableViewModel : BaseViewModel
    {
        private ObservableCollection<RowData> _listSuma = new ObservableCollection<RowData>();

        public ObservableCollection<RowData> ListSuma
        {
            get => _listSuma;
            set => SetProperty(ref _listSuma, value);
        }

        public DataTableViewModel()
        {
            Title = "Data Table";

            ListSuma.Add(new RowData
            {
                Id = 1,
                Parameter1 = 5,
                Parameter2 = 10
            });


            ListSuma.Add(new RowData
            {
                Id = 2,
                Parameter1 = 1,
                Parameter2 = 5
            });


            ListSuma.Add(new RowData
            {
                Id = 3,
                Parameter1 = 2,
                Parameter2 = 7
            });
        }


    }

    public class RowData : INotifyPropertyChanged
    {
        public int Id { get; set; }

        private int _parameter1;
        private int _parameter2;

        public int Parameter1
        {
            get => _parameter1;
            set {
                _parameter1 = value;
                OnPropertyChanged();
                OnPropertyChanged($"Suma");
            }
        }

        public int Parameter2
        {
            get => _parameter2;
            set
            {
                _parameter2 = value;
                OnPropertyChanged();
                OnPropertyChanged($"Suma");
            }
        }
        public int Suma => Parameter1 + Parameter2;

        public event PropertyChangedEventHandler PropertyChanged;

        protected virtual void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
