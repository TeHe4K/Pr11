using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
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
using Pr11.Classes;

namespace Pr11
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private StudentList studentList;
        public MainWindow()
        {
            InitializeComponent();
            studentList = new StudentList();
            StudentListBox.ItemsSource = studentList.GetStudents();
        }

        private void CommaButton_Click(object sender, RoutedEventArgs e)
        {
            ResultTextBlock.Text = studentList.DisplayStudents();
        }

        private void CustomButton_Click(object sender, RoutedEventArgs e)
        {
            string Separator = SeparatorTextBox.Text;
            if (string.IsNullOrEmpty(Separator))
            {
                MessageBox.Show("Введите разделитель");
                return;
            }
            ResultTextBlock.Text = studentList.DisplayStudents(Separator);
        }
    }
}
