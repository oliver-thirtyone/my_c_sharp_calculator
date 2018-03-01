using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;

// The Blank Page item template is documented at https://go.microsoft.com/fwlink/?LinkId=402352&clcid=0x409

namespace MyCalculator
{
    public sealed partial class MainPage : Page
    {
        Calculator Calculator;
        InputHandler InputHandler;

        public MainPage()
        {
            InitializeComponent();

            Calculator = new Calculator();
            InputHandler = new InputHandler();

            InputHandler.Updated += OnInputChanged;
        }

        private void OnInputChanged(object sender, EventArgs e)
        {
            ResultView.Text = InputHandler.Input;
        }

        private void Button_CE_Click(object sender, RoutedEventArgs e)
        {
            InputHandler.ResetInput();
        }

        private void Button_C_Click(object sender, RoutedEventArgs e)
        {

        }

        private void Button_Back_Click(object sender, RoutedEventArgs e)
        {

        }

        private void Button_0_Click(object sender, RoutedEventArgs e)
        {

        }

        private void Button_1_Click(object sender, RoutedEventArgs e)
        {

        }

        private void Button_2_Click(object sender, RoutedEventArgs e)
        {

        }

        private void Button_3_Click(object sender, RoutedEventArgs e)
        {

        }

        private void Button_4_Click(object sender, RoutedEventArgs e)
        {

        }

        private void Button_5_Click(object sender, RoutedEventArgs e)
        {

        }

        private void Button_6_Click(object sender, RoutedEventArgs e)
        {

        }

        private void Button_7_Click(object sender, RoutedEventArgs e)
        {

        }

        private void Button_8_Click(object sender, RoutedEventArgs e)
        {

        }

        private void Button_9_Click(object sender, RoutedEventArgs e)
        {

        }

        private void Button_Dot_Click(object sender, RoutedEventArgs e)
        {

        }

        private void Button_Negate_Click(object sender, RoutedEventArgs e)
        {

        }

        private void Button_Plus_Click(object sender, RoutedEventArgs e)
        {

        }

        private void Button_Minus_Click(object sender, RoutedEventArgs e)
        {

        }

        private void Button_Times_Click(object sender, RoutedEventArgs e)
        {

        }

        private void Button_Divide_Click(object sender, RoutedEventArgs e)
        {

        }

        private void Button_Equals_Click(object sender, RoutedEventArgs e)
        {

        }

    }
}
