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
using System.Windows.Shapes;
using MaterialDesignThemes.Wpf;


namespace Zahard_Student
{
    /// <summary>
    /// Interaction logic for Program.xaml
    /// </summary>
    public partial class Program : Window
    {
        
        students std = new students();
        ZSDBEntities db = new ZSDBEntities();

        public Program()
        {
            InitializeComponent();

            ZSDBEntities db = new ZSDBEntities();
            canvas_statics.Visibility = Visibility.Collapsed;
        }


        public bool IsDarkTheme { get; set; }
        private readonly PaletteHelper paletteHelper = new PaletteHelper();


        private void Btu_exit_Click(object sender, RoutedEventArgs e)
        {
            Environment.Exit(0);
        }

        private void Btu_max_Click(object sender, RoutedEventArgs e)
        {
            if (this.WindowState != WindowState.Maximized)
            {
                this.WindowState = WindowState.Maximized;
                
                datax.Width = this.Width - 165;
               
                return;
            }
            this.WindowState = WindowState.Normal;
            
            datax.Width = 945;
            
        }




        private void Btu_min_Click(object sender, RoutedEventArgs e)
        {
            this.WindowState = WindowState.Minimized;
        }

        private void Btu_theme_Click(object sender, RoutedEventArgs e)
        {
            ITheme theme = paletteHelper.GetTheme();
            if (IsDarkTheme = theme.GetBaseTheme() == BaseTheme.Dark)
            {
                IsDarkTheme = false;
                theme.SetBaseTheme(Theme.Light);
            }
            else
            {
                IsDarkTheme = true;
                theme.SetBaseTheme(Theme.Dark);
            }

            paletteHelper.SetTheme(theme);
        }

        private void Btu_Home_Click(object sender, RoutedEventArgs e)
        {
            canvas_statics.Visibility = Visibility.Collapsed;

        }


        private void Window_Activated(object sender, EventArgs e)
        {


            
            using (var db1 = new ZSDBEntities()) // replace with your DbContext class name
            {
                var students = db1.students.ToList(); // replace with your DbSet property name
                datax.ItemsSource = students; // replace "dataGrid" with your DataGrid name

            }

            decimal averageTestScore = db.students.Average(s => s.test);
            decimal averageExamScore = db.students.Average(s => s.exam);
            decimal averageRateScore = db.students.Average(s => s.rate);

            int count = db.students.Count(s => s.rate >= 10);
            int count1 = db.students.Count(s => s.rate < 10);


            ATS.Text = Convert.ToString(averageTestScore);
            AES.Text = Convert.ToString(averageExamScore);
            ARS.Text = Convert.ToString(averageRateScore);

            RMT.Text = Convert.ToString(count);
            RLT.Text = Convert.ToString(count1);

        }
        private void EditButton_Click(object sender, RoutedEventArgs e)
        {
            add_edit edit = new add_edit(std);
            edit.Owner = this;
            edit.Show();
            
           
        }


        private void DeleteButton_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                MessageBoxResult result = MessageBox.Show("Are you sure you want to delete "+ std.first_name+ " " + std.last_name+"?", "Delete Confirmation", MessageBoxButton.YesNo, MessageBoxImage.Warning);

                if (result == MessageBoxResult.Yes)
                {
                    db.Entry(std).State = System.Data.Entity.EntityState.Deleted;
                    db.SaveChanges();
                    MessageBox.Show("Delete is successful");
                }
            }
            catch
            { }
        }

        private void Datax_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            try
            {
                var row = datax.SelectedItem;
                int id = Convert.ToInt32((datax.SelectedCells[0].Column.GetCellContent(row) as TextBlock).Text);
                std = db.students.Where(x => x.student_id == id).FirstOrDefault();
            }
            catch
            { }
        }

        private void Btu_add_Click(object sender, RoutedEventArgs e)
        {
            add_edit add = new add_edit();
            add.Owner = this;
            add.Show();
        }

        private void Btu_statics_Click(object sender, RoutedEventArgs e)
        {
            if (canvas_statics.Visibility == Visibility.Collapsed)
            {
                // Show canvas2 and set its ZIndex to be above canvas1
                Canvas.SetZIndex(canvas_statics, 1);
                canvas_statics.Visibility = Visibility.Visible;
            }
           
        }

        private void TextBox_TextChanged(object sender, TextChangedEventArgs e)
        {
            int searchID = 0;
            int searchGroup = 0;
            decimal searchTest = 0;
            decimal searchExam = 0;
            decimal searchRate = 0;

            // Parse input values
            int.TryParse(text_search.Text, out searchID);
            int.TryParse(text_search.Text, out searchGroup);
            decimal.TryParse(text_search.Text, out searchTest);
            decimal.TryParse(text_search.Text, out searchExam);
            decimal.TryParse(text_search.Text, out searchRate);

            string searchTerms = text_search.Text;

            var students = db.students.Where(s => s.first_name.Contains(searchTerms) || s.last_name.Contains(searchTerms) || s.email.Contains(searchTerms) || s.student_id == searchID || searchGroup == 0 || s.groups == searchGroup || s.test == searchTest).ToList(); // replace with your DbSet property name and search criteria

            datax.ItemsSource = students;
        }

        private void Grid_Loaded(object sender, RoutedEventArgs e)
        {
           
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {

        }
    }
}
