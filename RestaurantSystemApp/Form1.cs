using Business_Class;
using Repository;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RestaurantSystemApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            AddSnackList();
            AddDrinkList();
        }
        public void AddSnackList()
        {
            FoodRepository foodRepository = new FoodRepository();
            List<Food> snackList = foodRepository.Retrieve();
            for (int i = 0; i < snackList.Count; i++)
            {
                FoodListBox.Items.Add($"\"{snackList[i].Name}\" - {snackList[i].Price}Eu");
            }
        }
        public void AddDrinkList()
        {
            DrinksRepository drinksRepository = new DrinksRepository();
            List<Food> drinkList = drinksRepository.Retrieve();
            for (int i = 0; i < drinkList.Count; i++)
            {
                DrinksLisBox.Items.Add($"\"{drinkList[i].Name}\" - {drinkList[i].Price}Eu");
            }
        }
        private void AddOrderButton_Click(object sender, EventArgs e)
        {
            if (FoodListBox.Text.Length > 0 & DrinksLisBox.Text.Length > 0)
            {
                OrderTextBox.AppendText($"{FoodListBox.Text}\r\n");
                PriceTextBox.AppendText($"{DrinksLisBox.Text}\r\n");
            }else if(FoodListBox.Text.Length > 0)
            {
                OrderTextBox.AppendText($"{FoodListBox.Text}\r\n");
            }else if(DrinksLisBox.Text.Length > 0)
            {
                PriceTextBox.AppendText($"{DrinksLisBox.Text}\r\n");
            }else
            {
                MessageBox.Show("Please choose product from Food or Drinks List.");
            }
            FoodListBox.Text = ("");
            DrinksLisBox.Text = ("");

        }
        public void OnBackgroundImageChanged(Button TableNumberButton)
        {
            Image BackgroundImage = new Bitmap(@"C:\Users\Vartotojas\source\repos\Advanced\RestaurantSystemApp\Images\x.png");
            TableNumberButton.BackgroundImage = BackgroundImage;
        }
        private void Table1Button_Click(object sender, EventArgs e)
        {
            OnBackgroundImageChanged(Table1Button);
        }
        private void PayButton_Click(object sender, EventArgs e)
        {
            //var BuilForRestaurant = File.CreateText(@"c:\Program Files\buil.txt");
            // Table1ButtonWasClicked = false;
        }
    }
}
