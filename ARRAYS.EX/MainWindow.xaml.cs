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

namespace ARRAYS.EX
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

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            int parsedArraySize;
            float large;
            float small;
            int[] arrayOfInts;

            string sizeOfArrayInstructction = "Please enter the size of the array";

            string sizeOfArray = "";
            parsedArraySize = Int32.Parse(sizeOfArray);
            arrayOfInts = new int[parsedArraySize];

            string enterElementsInstruction = "Please specify the elements of the array";

            for (int i = 0; i < parsedArraySize; i++)
            {
                string userInput = "Convert to ruser input of form";
                arrayOfInts[i] = Int32.Parse(userInput);
            }

            string formatString = " "; //todo convert to WPF controls

            large = arrayOfInts[0];
            small = arrayOfInts[0];

            for (int i = 0; i < parsedArraySize; i++)
            {
                if (arrayOfInts[i] > large)
                    large = arrayOfInts[i];
                else if (arrayOfInts[i] < small)
                    small = arrayOfInts[i];
            }

            string firstResult = string.Format("Largest element in the array is {0}", large);
            string secondResult = string.Format("Smallest elemnt in the array is {0}", small);
        }
    }
}
