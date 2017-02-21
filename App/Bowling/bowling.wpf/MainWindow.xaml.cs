using System;
using System.Windows;
using Microsoft.FSharp.Core;

namespace bowling.wpf
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

        private void SubmitButton_OnClick(object sender, RoutedEventArgs e)
        {
            var input = textBox.Text;
            var result = 0;

            var score = Bowling.TryGetBowlingScore(input, ref result);
            textBlock.Text =
                score
                    ? "Score: " + result
                    : "Wrong score!";
        }
    }
}
