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

namespace AlexWPFTest
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

    private void MouseEnter1 (object sender, RoutedEventArgs e)
    {
      ListBox1.Visibility = Visibility.Visible;
    }

    private void Button_Click(object sender, RoutedEventArgs e)
    {
      ListBox1.Visibility = Visibility.Hidden;
    }

    static EnvironmentVariableTarget NewWindow = new AK74;

    private void ListBoxItem_MouseEnter(object sender, MouseEventArgs e)
    {
      NewWindow
    }

    private void ListBox1_MouseLeave(object sender, MouseEventArgs e)
    {
      
    }
  }
}
