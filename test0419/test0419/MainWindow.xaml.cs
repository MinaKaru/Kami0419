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
            bmi.Foreground = Brushes.Red;
            float height = float.Parse(tb_height.Text);
            float weight = float.Parse(tb_weight.Text);
            float BMI = (weight / (height * height / 10000));
            this.bmi.Text = BMI.ToString();

            if (BMI < 18.5)
            {
                strings.Text = "過輕！你需要再吃營養些！";
                strings.Foreground = Brushes.Red;
            }
            else if (18.5 <= BMI && BMI < 24)
            {
                strings.Text = "標準！請您繼續保持！";
                strings.Foreground = Brushes.Red;
            }
            else if (24 <= BMI && BMI < 27)
            {
                strings.Text = "過重！肥胖容易引起疾病！";
                strings.Foreground = Brushes.Red;
            }
            else if (27 <= BMI && BMI < 30)
            {
                strings.Text = "輕度肥胖！肥胖容易引起疾病！";
                strings.Foreground = Brushes.Red;
            }
            else if (30 <= BMI && BMI < 35)
            {
                strings.Text = "中度肥胖！肥胖容易引起疾病！";
                strings.Foreground = Brushes.Red;
            }
            else
            {
                strings.Text = "重度肥胖！肥胖容易引起疾病！";
                strings.Foreground = Brushes.Red;
            }
        }

        private void btn_height_Click(object sender, RoutedEventArgs e)
        {
                this.tb_height.Clear();
                tb_height.Background = Brushes.Red;
        }

        private void btn_weight_Click(object sender, RoutedEventArgs e)
        {
                this.tb_weight.Clear();
                tb_weight.Background = Brushes.Red;
        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            if (IsInitialized)
            {
                tb_height.Background = Brushes.White;
                tb_weight.Background = Brushes.White;
                bmi.Text = "";
                strings.Text = "";
            }
        }

        private void Slider_ValueChanged(object sender, RoutedPropertyChangedEventArgs<double> e)
        {
            if (IsInitialized)
            {
                tb_height.Text = HeightSlider.Value.ToString();
                tb_weight.Text = WeightSlider.Value.ToString();
                bmi.Foreground = Brushes.Red;
                float height = float.Parse(tb_height.Text);
                float weight = float.Parse(tb_weight.Text);
                float BMI = (weight / (height * height / 10000));
                this.bmi.Text = BMI.ToString();

                if (BMI < 18.5)
                {
                    strings.Text = "過輕！你需要再吃營養些！";
                    strings.Foreground = Brushes.Red;
                }
                else if (18.5 <= BMI && BMI < 24)
                {
                    strings.Text = "標準！請您繼續保持！";
                    strings.Foreground = Brushes.Red;
                }
                else if (24 <= BMI && BMI < 27)
                {
                    strings.Text = "過重！肥胖容易引起疾病！";
                    strings.Foreground = Brushes.Red;
                }
                else if (27 <= BMI && BMI < 30)
                {
                    strings.Text = "輕度肥胖！肥胖容易引起疾病！";
                    strings.Foreground = Brushes.Red;
                }
                else if (30 <= BMI && BMI < 35)
                {
                    strings.Text = "中度肥胖！肥胖容易引起疾病！";
                    strings.Foreground = Brushes.Red;
                }
                else
                {
                    strings.Text = "重度肥胖！肥胖容易引起疾病！";
                    strings.Foreground = Brushes.Red;
                }     
            }
        }

        private void WeightSlider_IsMouseCapturedChanged(object sender, DependencyPropertyChangedEventArgs e)
        {

        }

        private void HeightSlider_IsHitTestVisibleChanged(object sender, DependencyPropertyChangedEventArgs e)
        {
    
        }
    }
}

