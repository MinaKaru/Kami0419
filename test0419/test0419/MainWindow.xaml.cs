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

namespace test0419
{
    /// <summary>
    /// MainWindow.xaml 的互動邏輯
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            float height = float.Parse(tb_height.Text);
            float weight = float.Parse(tb_weight.Text);
            float BMI = (weight / (height *height/10000));   
            this.bmi.Text = BMI.ToString();
        }

        private void btn_height_Click(object sender, RoutedEventArgs e)
        {
            this.tb_height.Clear();
        }

        private void btn_weight_Click(object sender, RoutedEventArgs e)
        {
            this.tb_weight.Clear();
        }
    }
}
