using Microsoft.Win32;
using System;
using System.IO;
using System.Windows;

namespace WpfApp1
{
    /// <summary>
    /// Interaktionslogik für MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            int height = 100;
            int width = 200;
            int length = 300;
            string file_content = "";
            int.TryParse(this.height_box.Text, out height);
            int.TryParse(this.width_box.Text, out width);
            int.TryParse(this.length_box.Text, out length);
            String option = geometry_selection.SelectedValue?.ToString() ?? "Quader" ;
            if (option.Contains("Quader"))
            {
                file_content = SVGDesigner.makeQuader(height, length, width);
                //SvgTemplate=
            }
            else
            {
                file_content = SVGDesigner.makeZylinder(height, length, width);
            }
            SaveFileDialog dlg = new SaveFileDialog()
            {
                FileName = "schnittmuster", // Default file name
                DefaultExt = ".svg", // Default file extension
                Filter = "SVG Grafiken (.svg)|*.svg" // Filter files by extension
            };

            // Show save file dialog box
            Nullable<bool> result = dlg.ShowDialog();

            // Process save file dialog box results
            if (result == true)
            {
                File.WriteAllText(dlg.FileName, file_content);
            }
        }
    }
}
