using System;
using System.ComponentModel;
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
using System.Windows.Shapes;
using WpfApp3.Models;
using WpfApp3.Services;

namespace WpfApp3
{
    /// <summary>
    /// Логика взаимодействия для MissionWindow.xaml
    /// </summary>
    public partial class MissionWindow : Window
    {
        private readonly string PATH = $"{Environment.CurrentDirectory}\\bookDataList";
        private BindingList<DateBook> _dateBooks;
        private FileIO _fileIO;
        public MissionWindow()
        {
            InitializeComponent();
        }

        private void dgDateBook_Loaded(object sender, RoutedEventArgs e)
        {
            _fileIO = new FileIO(PATH);

            try
            {
                _dateBooks = _fileIO.LoadData();
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
                Close();
            }
           

            dgDateBook.ItemsSource = _dateBooks;
            _dateBooks.ListChanged += _dateBooks_ListChanged;
        }

        private void _dateBooks_ListChanged(object sender, ListChangedEventArgs e)
        {
            if(e.ListChangedType == ListChangedType.ItemAdded || e.ListChangedType == ListChangedType.ItemDeleted || e.ListChangedType == ListChangedType.ItemChanged)
            {
                try
                {
                    _fileIO.SaveData(sender);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                    Close();
                }

            }
        }
     
    }
}
