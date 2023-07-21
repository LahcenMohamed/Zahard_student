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
    /// Interaction logic for add_edit.xaml
    /// </summary>
    public partial class add_edit : Window
    {
        double test_mark;
        double exam_mark;
        bool its_edit;
        int id;
        ZSDBEntities db1 = new ZSDBEntities();
        students std = new students();

        public add_edit(students ae)
        {
            InitializeComponent();

            its_edit = true;
            text_first_name.Text = ae.first_name;
            text_last_name.Text = ae.last_name;
            text_email.Text = ae.email;
            text_exam.Text = Convert.ToString(ae.exam);
            text_test.Text = Convert.ToString(ae.test);
            text_rate.Text = Convert.ToString(ae.rate);
            text_group.Text = Convert.ToString(ae.groups);
            id = ae.student_id;
            button_add_or_edit.Content = "Edit";
        }
        public add_edit()
        {
            InitializeComponent();

            button_add_or_edit.Content = "Add";
            its_edit = false;
        }

        private void Window_Activated(object sender, EventArgs e)
        {
            //IsDarkTheme = IsDarkTheme1;

            
        }

        private void Text_test_TextChanged(object sender, TextChangedEventArgs e)
        {
            
                try
                {
                    test_mark = Convert.ToDouble(text_test.Text);
                    text_rate.Text = Convert.ToString(test_mark * 0.4 + exam_mark * 0.6);
                }
                catch { }
            
        }

        private void Text_exam_TextChanged(object sender, TextChangedEventArgs e)
        {
                try
                {
                    exam_mark = Convert.ToDouble(text_exam.Text);
                    text_rate.Text = Convert.ToString(test_mark * 0.4 + exam_mark * 0.6);
                }
                catch { }
            
        }

        private void Button_add_or_edit_Click(object sender, RoutedEventArgs e)
        {
            if (its_edit)
            {
                try
                {
                    std.student_id = id;
                    std.first_name = text_first_name.Text;
                    std.last_name = text_last_name.Text;
                    std.email = text_email.Text;
                    std.test = Convert.ToDecimal(text_test.Text);
                    std.exam = Convert.ToDecimal(text_exam.Text);
                    std.rate = Convert.ToDecimal(text_rate.Text);
                    std.groups = Convert.ToInt32(text_group.Text);
                    db1.Entry(std).State = System.Data.Entity.EntityState.Modified;
                    db1.SaveChanges();
                    MessageBox.Show("Edit is successful");
                }
                catch {
                    MessageBox.Show("Edit isn't successful,please check all information");
                }
               
            }
            else
            {
                try
                {
                    
                    std.first_name = text_first_name.Text;
                    std.last_name = text_last_name.Text;
                    std.email = text_email.Text;
                    std.test = Convert.ToDecimal(text_test.Text);
                    std.exam = Convert.ToDecimal(text_exam.Text);
                    std.rate = Convert.ToDecimal(text_rate.Text);
                    std.groups = Convert.ToInt32(text_group.Text);
                    db1.Entry(std).State = System.Data.Entity.EntityState.Added;
                    db1.SaveChanges();
                    MessageBox.Show("Add is successful");
                }
                catch
                {
                    MessageBox.Show("Add isn't successful,please check all information");
                }
            }
        }
    }
}
