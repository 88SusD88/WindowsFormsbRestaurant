using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using WindowsFormsbRestaurant.BuilderBurger;
using WindowsFormsbRestaurant.DBCon;

namespace WindowsFormsbRestaurant
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        Model1 model = new Model1();

        private void Form1_Load(object sender, EventArgs e)
        {
            LoadData();
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            BurgerBuilder burgerBuilder = new BurgerBuilder();
            BurgerDirector burgerDirector = new BurgerDirector(burgerBuilder);

            if (comboBoxBurger.SelectedItem.ToString() == "Стандартный бургер")
                burgerDirector.BuildDefault();
            else burgerDirector.BuildWithBacon();

            try
            {
                model.Burgers.Add(burgerBuilder.GetBurgers());
                model.SaveChanges();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            LoadData();
        }
        private void LoadData()
        {
            comboBoxBurger.SelectedIndex = 0;
            dataGridView1.DataSource = model.Burgers.ToList();
        }
    }
}
