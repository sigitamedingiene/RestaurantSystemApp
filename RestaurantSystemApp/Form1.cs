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
        FoodRepository foodRepository = new FoodRepository();
        DrinksRepository drinksRepository = new DrinksRepository();
        TablesRepository tablesRepository = new TablesRepository();
        public Form1()
        {   
            InitializeComponent();
            ShowOccupiedTables();
            AddSnackList();
            AddDrinkList();
        }
        private void ShowOccupiedTables()
        {   List<Table> tableList = tablesRepository.Retrieve();
            for (int i = 0; i < tableList.Count; i++)
            {
                if (tableList[i].IsOcupied)
                {
                    MessageBox.Show($"At this moment ocupied table is Nr. {tableList[i].Number}.");
                }
            }
        }
        public void AddSnackList()
        {
            List<Food> snackList = foodRepository.Retrieve();
            for (int i = 0; i < snackList.Count; i++)
            {
                FoodListBox.Items.Add($"\"{snackList[i].Name}\" - {snackList[i].Price}Eu");
            }
        }
        public void AddDrinkList()
        {
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
            List<Table> tableList = tablesRepository.Retrieve();
            if (tableList[1].IsOcupied == false)
            {
                OnBackgroundImageChanged(Table1Button);
                tableList[1].IsOcupied = true;
            }
            else
            {
                MessageBox.Show("Table Nr.1 is ocupied, please select other table.");
            }            
        }
        private void Table2Button_Click(object sender, EventArgs e)
        {
            List<Table> tableList = tablesRepository.Retrieve();
            if (tableList[2].IsOcupied == false)
            {
                OnBackgroundImageChanged(Table1Button);
                tableList[2].IsOcupied = true;
            }
            else
            {
                MessageBox.Show("Table Nr.2 is ocupied, please select other table.");
            }
        }
        private void PayButton_Click(object sender, EventArgs e)
        {
            //var BuilForRestaurant = File.CreateText(@"c:\Program Files\buil.txt");
            // Table1ButtonWasClicked = false;
        }

        
    }
}
