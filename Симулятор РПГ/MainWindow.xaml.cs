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
using Microsoft.Win32;

namespace RPG
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        Hero hero;

        private void create_hero()
        {
            hero = new Hero();
            hero.Name = tb_sett_name.Text;
            hero.Age = Int32.Parse(tb_sett_age.Text);
            if (cb_sett_gender.SelectedIndex == 0)
            {
                hero.Gender = "Мужчина";
            }else if (cb_sett_gender.SelectedIndex == 1)
            {
                hero.Gender = "Женщина";
            }
            else
            {
                hero.Gender = "kekekekekekekek";
            }
            hero.LVL = 1;
            hero.Strength = (int)(sl_strength.Value);
            hero.Intellect = (int)(sl_intellect.Value);
        }

        private void show_hero()
        {
            tb_name.Text = hero.Name;
            tb_age.Text = hero.Age.ToString();
            tb_gender.Text = hero.Gender;
            tb_general.Text = "Уровень: " + hero.LVL.ToString() + '\n';
            tb_abilities.Text = "Сила: " + hero.Strength.ToString() + '\n';
            tb_abilities.Text += "Интеллект: " + hero.Intellect.ToString();
        }

        public MainWindow()
        {
            InitializeComponent();
            tab_control.SelectedIndex = 1;
        }

        private void Btn_apply_settings_Click(object sender, RoutedEventArgs e)
        {
            create_hero();

            show_hero();

            tab_control.SelectedIndex = 0;
        }

        private void Tab_control_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (tab_control.SelectedIndex == 1)
            {
                tb_sett_name.Text = hero.Name;
                tb_sett_age.Text = hero.Age.ToString();
                if (hero.Gender == "Мужчина")
                {
                    cb_sett_gender.SelectedIndex = 0;
                }else if (hero.Gender == "Женщина")
                {
                    cb_sett_gender.SelectedIndex = 1;
                }
                else
                {
                    cb_sett_gender.SelectedIndex = 2;
                }
                sl_strength.Value = (double)hero.Strength;
                sl_intellect.Value = (double)hero.Strength;
            }
            else
            {
                show_hero();
            }
        }
    }
}
