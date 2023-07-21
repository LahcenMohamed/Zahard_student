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

namespace Zahard_Student
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        static bool check;
        public MainWindow()
        {
            InitializeComponent();
            check = true;
        }

        private void Btu_log_or_sign1_Click(object sender, RoutedEventArgs e)
        {
            Button clickedButton = sender as Button;


            if (check)
            {
                

                btu_log_or_sign1.Content = "Sign Up";
                Rpb_password.Visibility = Rpb_password.Visibility == Visibility.Visible ? Visibility.Collapsed : Visibility.Visible;
                btu_log_or_sign.Content = "Log in";
                text1.Content = "Log in";
                text10.Text = "username and password to Log in";
                textw.Text = "Hello,Friend!";
                text2.Text = "Entre your personal details";
                text3.Text = "and start journy with us";


                text1.RenderTransform = new TranslateTransform(43, 0);
                textw.RenderTransform = new TranslateTransform(17, 0);
                text2.RenderTransform = new TranslateTransform(17, 0);
                text3.RenderTransform = new TranslateTransform(17, 0);
                text2.RenderTransform = new TranslateTransform(17, 0);
                btu_log_or_sign.RenderTransform = new TranslateTransform(0, -53);

            }
            else
            {
                btu_log_or_sign1.Content = "Login";
                Rpb_password.Visibility = Visibility.Visible;
                btu_log_or_sign.Content = "Sign up";
                text1.Content = "Create Account";
                text10.Text = "username and password to registry";
                textw.Text = "Welcom Back!";
                text2.Text = "to keep conacted with us please";
                text3.Text = "login with your personal into";


                text1.RenderTransform = new TranslateTransform(0, 0);
                textw.RenderTransform = new TranslateTransform(0, 0);
                text2.RenderTransform = new TranslateTransform(0, 0);
                text3.RenderTransform = new TranslateTransform(0, 0);
                btu_log_or_sign.RenderTransform = new TranslateTransform(0, 0);

            }
                check = !check;
            txt_username.Text = "";
            Pb_password.Password = "";
            Rpb_password.Password = "";
        }

        private void Btu_log_or_sign_Click(object sender, RoutedEventArgs e)
        {
            if (check)
            {
                if (txt_username.Text == "" || Pb_password.Password == "" || Rpb_password.Password == "")
                {
                    text10_Copy.Text = "Please fill in all the blanks";
                    return;
                }


                else if (Pb_password.Password != Rpb_password.Password)
                { 
                    text10_Copy.Text = "Password and Repassword are not same";
                return;
                }


                ZSDBEntities add = new ZSDBEntities();
                professor p = new professor();

                p.professor_name = txt_username.Text;
                p.password = Pb_password.Password;


                add.professor.Add(p);
                add.SaveChanges();

                MessageBox.Show("sign up successful");

                text10_Copy.Text = "";



                text10_Copy.RenderTransform = new TranslateTransform(0, 0);
            }
            else
            {
                if (txt_username.Text == "" || Pb_password.Password == "")
                {  
                    text10_Copy.Text = "Please fill in all the blanks";
                return;
                }



                using (var context = new ZSDBEntities())
                {
                    var username = txt_username.Text;
                    var password = Pb_password.Password;

                    var user = context.professor.FirstOrDefault(u=> u.professor_name == username && u.password == password);  
                    if (user != null)
                    {
                        Program ps = new Program();
                        ps.Show();
                        this.Close();
                    }
                    else
                    {
                        MessageBox.Show("login failed, user name or password is not true");
                        // login failed, display error message
                    }
                }



                text10_Copy.RenderTransform = new TranslateTransform(0, -53);
            }
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Program ps = new Program();
            ps.Show();
            this.Close();
        }
    }
}
