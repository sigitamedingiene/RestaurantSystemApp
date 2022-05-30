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
                OrderToBarTextBox.AppendText($"{DrinksLisBox.Text}\r\n");
            }else if(FoodListBox.Text.Length > 0)
            {
                OrderTextBox.AppendText($"{FoodListBox.Text}\r\n");
            }else if(DrinksLisBox.Text.Length > 0)
            {
                OrderToBarTextBox.AppendText($"{DrinksLisBox.Text}\r\n");
            }else
            {
                MessageBox.Show("Please choose product from Food or Drinks List.");
            }
            FoodListBox.Text = ("");
            DrinksLisBox.Text = ("");

        }
        private void Table1Button_Click(object sender, EventArgs e)
        {
           List<Table> tableList = tablesRepository.Retrieve();
            if (tableList[0].IsOcupied == false)
            {
                Table1Button.Enabled = false;
                tableList[0].IsOcupied = true;                
            }else
            {
                MessageBox.Show("Table is ocupied, please select other table.");
            }
        }
        private void Button1TableIsFreeButton_Click(object sender, EventArgs e)
        {
            List<Table> tableList = tablesRepository.Retrieve();
            if (Table1Button.Enabled == false)
            {
                tableList[0].IsOcupied = false;
                Table1Button.Enabled = true;
            }else
            {
                MessageBox.Show("Table is free. Please click on the Table image.");
            }        
        }
        private void Table2Button_Click(object sender, EventArgs e)
        {
            List<Table> tableList = tablesRepository.Retrieve();
            if (tableList[1].IsOcupied == false)
            {
                Table2Button.Enabled = false;
                tableList[1].IsOcupied = true;
            }
            else
            {
                MessageBox.Show("Table is ocupied, please select other table.");
            }
        }
        private void Button2TableIsFreeButton_Click(object sender, EventArgs e)
        {
            List<Table> tableList = tablesRepository.Retrieve();
            if (Table2Button.Enabled == false)
            {
                tableList[1].IsOcupied = false;
                Table2Button.Enabled = true;
            }else
            {
                MessageBox.Show("Table is free. Please click on the Table image.");
            }
        }
        private void Table3Button_Click(object sender, EventArgs e)
        {
            List<Table> tableList = tablesRepository.Retrieve();
            if (tableList[2].IsOcupied == false)
            {
                Table3Button.Enabled = false;
                tableList[2].IsOcupied = true;
            }else
            {
                MessageBox.Show("Table is ocupied, please select other table.");
            }
        }
        private void Button3TableIsFreeButton_Click(object sender, EventArgs e)
        {
            List<Table> tableList = tablesRepository.Retrieve();
            if (Table3Button.Enabled == false)
            {
                tableList[2].IsOcupied = false;
                Table3Button.Enabled = true;
            }else
            {
                MessageBox.Show("Table is free. Please click on the Table image.");
            }
        }
        private void Table4Button_Click(object sender, EventArgs e)
        {
            List<Table> tableList = tablesRepository.Retrieve();
            if (tableList[3].IsOcupied == false)
            {
                Table4Button.Enabled = false;
                tableList[3].IsOcupied = true;
            }else
            {
                MessageBox.Show("Table is ocupied, please select other table.");
            }
        }
        private void Button4TableIsFreeButton_Click(object sender, EventArgs e)
        {
            List<Table> tableList = tablesRepository.Retrieve();
            if (Table4Button.Enabled == false)
            {
                tableList[3].IsOcupied = false;
                Table4Button.Enabled = true;
            }else
            {
                MessageBox.Show("Table is free. Please click on the Table image.");
            }
        }
        private void Table5Button_Click(object sender, EventArgs e)
        {
            List<Table> tableList = tablesRepository.Retrieve();
            if (tableList[4].IsOcupied == false)
            {
                Table5Button.Enabled = false;
                tableList[4].IsOcupied = true;
            }
            else
            {
                MessageBox.Show("Table is ocupied, please select other table.");
            }
        }
        private void Button5TableIsFreeButton_Click(object sender, EventArgs e)
        {
            List<Table> tableList = tablesRepository.Retrieve();
            if (Table5Button.Enabled == false)
            {
                tableList[4].IsOcupied = false;
                Table5Button.Enabled = true;
            }else
            {
                MessageBox.Show("Table is free. Please click on the Table image.");
            }
        }
        private void SentToKichenButton_Click(object sender, EventArgs e)
        {
            var path = @"C:\Users\Vartotojas\source\repos\Advanced\RestaurantSystemApp\Receipt\KichenOrders\KichenOrder.txt";
            var order = OrderTextBox.Text;
            File.WriteAllText(path, order);
            MessageBox.Show("Order sent successfully");
            OrderTextBox.Clear();
        }
        private void SentToBarButton_Click(object sender, EventArgs e)
        {
            var path = @"C:\Users\Vartotojas\source\repos\Advanced\RestaurantSystemApp\Receipt\BarOrders\BarOrder.txt";
            var order = OrderToBarTextBox.Text;
            File.WriteAllText(path, order);
            MessageBox.Show("Order sent successfully");
            OrderToBarTextBox.Clear();
        }
        private void PayButton_Click(object sender, EventArgs e)
        {
            //var BuilForRestaurant = File.CreateText(@"c:\Program Files\buil.txt");
            // Table1ButtonWasClicked = false;
        }        
    }
}
