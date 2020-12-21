using Ch.Elca.Iiop;
using Models;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Runtime.Remoting;
using System.Runtime.Remoting.Channels;
using System.ServiceModel;
using System.Windows;
using System.Windows.Input;

namespace WpfClient
{
    public class MainViewModel : INotifyPropertyChanged
    {
        IEmployeeRepository _repository;

        public ObservableCollection<Employee> _rows;
        public ObservableCollection<Employee> Rows { get => _rows; set { _rows = value; OnPropertyChanged(); } }

        private Employee _selectedRow;
        public Employee SelectedRow
        {
            get => _selectedRow; set { _selectedRow = value;OnPropertyChanged(); }
        }


        private ICommand _saveSelectedRowCommand;
        public ICommand SaveSelectedRowCommand { get => _saveSelectedRowCommand; private set { _saveSelectedRowCommand = value; OnPropertyChanged(); } }

       
        private ICommand _deleteSelectedRowCommand;
        public ICommand DeleteSelectedRowCommand { get => _deleteSelectedRowCommand; private set { _deleteSelectedRowCommand = value; OnPropertyChanged(); } }


        private ICommand _addNewRowCommand;
        public ICommand AddNewRowCommand { get => _addNewRowCommand; private set { _addNewRowCommand = value;OnPropertyChanged(); } }

        private bool _isInsertMode = false;


        public MainViewModel()
        {
            try
            {
                AddNewRowCommand = new RelayCommand(AddNew);
                SaveSelectedRowCommand = new RelayCommand(SaveSelected);
                DeleteSelectedRowCommand = new RelayCommand(DeleteSelected);

                // Регистрируем канал IIOP.
                IiopClientChannel channel = new IiopClientChannel();
                ChannelServices.RegisterChannel(channel);

                // Адрес CORBA-сервера.
                string addressString = "iiop://localhost:1234/hello";
                // Получаем ссылку на клиентский прокси.
                _repository = (IEmployeeRepository)RemotingServices.Connect(typeof(IEmployeeRepository), addressString);

                var objectsSerialized = _repository.GetObjects();
                Rows = new ObservableCollection<Employee>(JsonConvert.DeserializeObject<IList<Employee>>(objectsSerialized) );
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }


        private void SaveSelected(object obj = null)
        {
            if (SelectedRow == null)
            {
                MessageBox.Show("Can`t save.  Row doesn`t selected");
                return;
            }
            else if (_isInsertMode)
            {
                _repository.Create(SelectedRow);
                _isInsertMode = false;
                MessageBox.Show("Item created");
            }
            else
            {
                _repository.Update(SelectedRow);
                MessageBox.Show("Item updated");
            }
        }

        public void AddNew(object obj = null)
        {
            _isInsertMode = true;
            Rows.Add(new Employee());
        }

        private void DeleteSelected(object obj = null)
        {
            _repository.Remove(SelectedRow);
            Rows.Remove(SelectedRow);
            MessageBox.Show("Item deleted");
        }

        public event PropertyChangedEventHandler PropertyChanged;
        public void OnPropertyChanged([CallerMemberName]string prop = "")
        {
            if (PropertyChanged != null)
                PropertyChanged(this, new PropertyChangedEventArgs(prop));
        }
    }
}
