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

namespace WpfApp23
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
        private void AddTodoButton_click(object sender, RoutedEventArgs e)
        {
            string toDoText = TodoInput.Text;

            if(!string.IsNullOrEmpty(toDoText))
            {
                TextBlock toDoItem = new TextBlock
                {
                    Text = toDoText+"\n" + "--*--*--*--*--*--*--*--*--*--*--*--*--*--*--*--*--*--*--*--*--*--*--",
                    Margin = new Thickness(10,5,0,0),
                    Foreground = new SolidColorBrush(Colors.White)

                };

                TodoList.Children.Add(toDoItem);
                TodoInput.Clear();
            }
            
        }

    }
}
