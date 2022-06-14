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
using System.Runtime.InteropServices;

namespace Matrix_Calculator
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        List<int> number1=new List<int>();

        List<int> number2=new List<int>();

        List<int> result= new List<int>();


        RowDefinition rowDef1;
        ColumnDefinition colDef1;


      //  string operation = "";
        List<TextBox> textBox = new List<TextBox>(1000);
        List<TextBox> textBox2=new List<TextBox>(1000);

        List<TextBox> resultBox=new List<TextBox>(1000);

        int row, col, row2, col2;


        string operation = "";

        public MainWindow()
        {
            InitializeComponent();

        }
        private void Shutdown(object sender, RoutedEventArgs e)
        {
            Application.Current.Shutdown();

        }

        private void Minimize(object sender, RoutedEventArgs e)
        {
            Application.Current.MainWindow.WindowState = WindowState.Minimized;

        }

        private void Minmax(object sender, RoutedEventArgs e)
        {
            if (Application.Current.MainWindow.WindowState != WindowState.Minimized)
            {
                Application.Current.MainWindow.WindowState = WindowState.Maximized;
            }
            else
            {
                Application.Current.MainWindow.WindowState = WindowState.Normal;
            }

        }

        [DllImport("Kernel32")]
        public static extern void AllocConsole();

        [DllImport("Kernel32")]
        public static extern void FreeConsole();


        private void Change(object sender, RoutedEventArgs e)
        {

            int index = 0;

           // AllocConsole();

             row = int.Parse(Row.Text);
             col = int.Parse(Col.Text);


            for(int i=0; i<row*col; i++)
            {
                textBox.Add(new TextBox());


            }

            for (int i = 0; i < row; i++)
            {

                for (int j=0; j<col; j++)
                {
                    Grid.SetRow(textBox[index], i);

                    Grid.SetColumn(textBox[index],j);
                    //Console.WriteLine();

                    index++;


                }
            }



            for(int i = 0; i < row * col; i++)
            {
                grid1.Children.Add(textBox[i]);


            }


            for (int i = 0; i < row; i++)
            {

                rowDef1 = new RowDefinition();

                grid1.RowDefinitions.Add(rowDef1);

            }


            for (int i = 0; i < col; i++)
            {
                colDef1 = new ColumnDefinition();

                grid1.ColumnDefinitions.Add(colDef1);


            }

        }

        private void test(object sender, RoutedEventArgs e)
        {
            int result = 0;
            int result2 = 0;
            int index = 0;
            AllocConsole();
            for (int i = 0; i < textBox.Count; i++)
            {
                if (Int32.TryParse(textBox[i].Text,out result) && Int32.TryParse(textBox2[i].Text,out result2)){
                    Console.WriteLine((int.Parse(textBox[i].Text),int.Parse(textBox2[i].Text)));
                }
            }


        }

        private void Change2(object sender, RoutedEventArgs e)
        {
            int index = 0;

             row2 = int.Parse(Row2.Text);
             col2 = int.Parse(Col2.Text);


            for (int i = 0; i < row2 * col2; i++)
            {
                textBox2.Add(new TextBox());
            }

            for (int i = 0; i < row2; i++)
            {
                for (int j = 0; j < col2; j++)
                {
                    Grid.SetRow(textBox2[index], i);

                    Grid.SetColumn(textBox2[index], j);

                    index++;


                }
            }

            for (int i = 0; i < row2 * col2; i++)
            {
                grid2.Children.Add(textBox2[i]);

            }


            for (int i = 0; i < row2; i++)
            {

                rowDef1 = new RowDefinition();


                grid2.RowDefinitions.Add(rowDef1);

            }


            for (int i = 0; i < col2; i++)
            {
                colDef1 = new ColumnDefinition();

                grid2.ColumnDefinitions.Add(colDef1);


            }

        }

        private void Add(object sender, RoutedEventArgs e)
        {
            int result = 0;
            int two = 0;
            int index = 0;

            int rowResult = row2;
            int colResult=col2;
            
            for (int i = 0; i < textBox.Count; i++)
            {
                if (int.TryParse(textBox[i].Text, out result) && int.TryParse(textBox2[i].Text,out two))
                {
                    resultBox.Add(new TextBox());
                    int val = int.Parse(textBox[i].Text) + int.Parse(textBox2[i].Text);
                    resultBox[i].Text=val.ToString();


                }
            }

            for (int i = 0; i < rowResult * colResult; i++)
            {
                resultBox.Add(new TextBox());


            }

            for (int i = 0; i < rowResult; i++)
            {

                for (int j = 0; j < colResult; j++)
                {
                    Grid.SetRow(resultBox[index], i);

                    Grid.SetColumn(resultBox[index], j);

                    index++;
                }
            }

            for (int i = 0; i < rowResult * colResult; i++)
            {
                grid3.Children.Add(resultBox[i]);


            }

            for (int i = 0; i <rowResult; i++)
            {

                rowDef1 = new RowDefinition();

                grid3.RowDefinitions.Add(rowDef1);

            }

            for (int i = 0; i < colResult; i++)
            {
                colDef1 = new ColumnDefinition();

                grid3.ColumnDefinitions.Add(colDef1);

            }



        }

        private void Subtract (object sender, RoutedEventArgs e)
        {
            int result = 0;
            int two = 0;
            int index = 0;

            int rowResult = row2;
            int colResult = col2;

            for (int i = 0; i < textBox.Count; i++)
            {
                if (int.TryParse(textBox[i].Text, out result) && int.TryParse(textBox2[i].Text, out two))
                {
                    resultBox.Add(new TextBox());
                    int val = int.Parse(textBox[i].Text) - int.Parse(textBox2[i].Text);
                    resultBox[i].Text = val.ToString();


                }
            }

            for (int i = 0; i < rowResult * colResult; i++)
            {
                resultBox.Add(new TextBox());


            }

            for (int i = 0; i < rowResult; i++)
            {

                for (int j = 0; j < colResult; j++)
                {
                    Grid.SetRow(resultBox[index], i);

                    Grid.SetColumn(resultBox[index], j);

                    index++;
                }
            }

            for (int i = 0; i < rowResult * colResult; i++)
            {
                grid3.Children.Add(resultBox[i]);


            }

            for (int i = 0; i < rowResult; i++)
            {

                rowDef1 = new RowDefinition();

                grid3.RowDefinitions.Add(rowDef1);

            }

            for (int i = 0; i < colResult; i++)
            {
                colDef1 = new ColumnDefinition();

                grid3.ColumnDefinitions.Add(colDef1);

            }


        }

        private void Multiply(object sender, RoutedEventArgs e)
        {

            int rowResult = 0;
            int colResult = 0;

            if (col == row2)
            {
                try
                {
                    rowResult = row;
                    colResult = col2;
                }
                catch (Exception ex)
                {
                    ExitEventArgs();
                }
            }


        }
    private void to_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void Border_MouseDown(object sender, MouseButtonEventArgs e)
        {
            if (e.LeftButton == MouseButtonState.Pressed)
            {
                DragMove();
            }

        }

    }
}
