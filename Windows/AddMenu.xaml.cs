﻿using System;
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
using Otlob_WPF_Project.Classes;
using otlob.Windows;
namespace otlob.Windows
{
    /// <summary>
    /// Interaction logic for AddMenu.xaml
    /// </summary>
    public partial class AddMenu : Window
    {
        Otlob_WPF_Project.Classes.System system ;
        public AddMenu()
        {
            InitializeComponent();
            system = Otlob_WPF_Project.Classes.System.getInstance();
            AddRestraunt.newRestraunt.menu = new Otlob_WPF_Project.Classes.FullMenu();
            for (int i = 0; i < 5; i++)
                ItemRatingComboBox.Items.Add(i + 1);
        }

        private void AddSectionButton_Click(object sender, RoutedEventArgs e)
        {
            SectionItem newSection = new SectionItem();
            newSection.sectionName = SectionNameTextBox.Text;

            AddRestraunt.newRestraunt.menu.addChildern(newSection);
            ItemSectionComboBox.Items.Add(newSection.sectionName);

            SectionNameTextBox.Clear();

        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            if (ItemSectionComboBox.SelectedIndex == -1)
                return;
            Otlob_WPF_Project.Classes.MenuItem newItem = new Otlob_WPF_Project.Classes.MenuItem();
            newItem.description = ItemDescription.Text;
            newItem.imagePath = ImagePathTextBox.Text;
            newItem.name = ItemNameTextBox.Text;
            newItem.price = Convert.ToInt32(ItemPriceTextBox.Text);
            newItem.rating =Convert.ToInt32(ItemRatingComboBox.SelectedItem.ToString());
            ((SectionItem)AddRestraunt.newRestraunt.menu.childern[ItemSectionComboBox.SelectedIndex]).addChildern(newItem);
        }
    }
}
