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
using System.Xml;
using System.Xml.Serialization;
using static System.Windows.Forms.AxHost;

//Eden Eliyahu 208081489
//Daniel Khodyrev 322648965

namespace GUI_DigitalStore
{
    public partial class Digital_Store : Form
    {
        private Store store = new Store();
        private string buyersFilePath = "buyers.txt";
        private string merchantsFilePath = "merchants.txt";
        public Digital_Store()
        {
            InitializeComponent();
            LoadData();
        }

        private void LoadData()
        {
            if (File.Exists(buyersFilePath))
            {
                var buyersLines = File.ReadAllLines(buyersFilePath);
                foreach (var line in buyersLines)
                {
                    var parts = line.Split('|');
                    var adress = new Adress(parts[2], parts[3], parts[4], int.Parse(parts[5]));
                    var buyer = new Buyer(parts[0], parts[1], adress);
                    store.AddBuyer(buyer);
                }
            }

            if (File.Exists(merchantsFilePath))
            {
                var merchantsLines = File.ReadAllLines(merchantsFilePath);
                foreach (var line in merchantsLines)
                {
                    var parts = line.Split('|');
                    var adress = new Adress(parts[2], parts[3], parts[4], int.Parse(parts[5]));
                    var merchant = new Merchant(parts[0], parts[1], adress);
                    store.AddMerchant(merchant);
                }
            }
        }

        private void SaveData()
        {
            var buyersLines = store.GetBuyersList().Select(b => $"{b.Name}|{b.Password}|{b.Adress.Street}|{b.Adress.City}|{b.Adress.Country}|{b.Adress.BuildingNum}");
            File.WriteAllLines(buyersFilePath, buyersLines);

            var merchantsLines = store.GetMerchantsList().Select(m => $"{m.Name}|{m.Password}|{m.Adress.Street}|{m.Adress.City}|{m.Adress.Country}|{m.Adress.BuildingNum}");
            File.WriteAllLines(merchantsFilePath, merchantsLines);
        }

        private void btnCloseApp_Click(object sender, EventArgs e)
        {
            SaveData();
            Application.Exit();
        }

        protected override void OnFormClosing(FormClosingEventArgs e)
        {
            SaveData();
            base.OnFormClosing(e);
        }

        private bool AreBuyerFieldsFilled()
        {
            return !string.IsNullOrWhiteSpace(textBoxbuyername.Text) &&
                   !string.IsNullOrWhiteSpace(textBoxbuyerpassword.Text) &&
                   !string.IsNullOrWhiteSpace(textBoxbuyercountry.Text) &&
                   !string.IsNullOrWhiteSpace(textBoxbuyercity.Text) &&
                   !string.IsNullOrWhiteSpace(textBoxbuyerstreet.Text) &&
                   !string.IsNullOrWhiteSpace(textBoxbuyernumber.Text);
        }

        private bool AreMerchantFieldsFilled()
        {
            return !string.IsNullOrWhiteSpace(textBoxmerchantname.Text) &&
                   !string.IsNullOrWhiteSpace(textBoxmerchantpassword.Text) &&
                   !string.IsNullOrWhiteSpace(textBoxmerchantcoutrey.Text) &&
                   !string.IsNullOrWhiteSpace(textBoxmerchantcity.Text) &&
                   !string.IsNullOrWhiteSpace(textBoxmerchantstreet.Text) &&
                   !string.IsNullOrWhiteSpace(textBoxmerchantnumber.Text);
        }

        private bool AreItemFieldsFilled()
        {
            return !string.IsNullOrWhiteSpace(textBoxitemname.Text) &&
                   !string.IsNullOrWhiteSpace(textBoxitemprice.Text) &&
                   !string.IsNullOrWhiteSpace(textBoxmerchantnameitem.Text) &&
                   (checkBoxyes.Checked ? !string.IsNullOrWhiteSpace(textBoxpackagingprice.Text) : true) &&
                   (checkBoxchildren.Checked || checkBoxelectricity.Checked || checkBoxoffice.Checked || checkBoxclothing.Checked);
        }

        private bool IsValidName(string name)
        {
            foreach (char c in name)
            {
                if (!char.IsLetter(c) && !char.IsWhiteSpace(c))
                {
                    return false;
                }
            }
            return true;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            lblbuyercity.Visible = true;   
            lblbuyercountery.Visible = true;    
            lblbuyername.Visible = true;    
            lblbuyernumber.Visible = true;  
            lblbuyerpassword.Visible = true;    
            lblbuyerstreet.Visible = true;  
            textBoxbuyercity.Visible=true;  
            textBoxbuyercountry.Visible=true;   
            textBoxbuyername.Visible=true;  
            textBoxbuyernumber.Visible=true;    
            textBoxbuyerpassword.Visible=true;  
            textBoxbuyerstreet.Visible=true;    
            btnbuyersubmit.Visible=true;
        }

        private void button8_Click(object sender, EventArgs e)
        {

        }

        private void button9_Click(object sender, EventArgs e)
        {

        }

        private bool IsNumber(string text)
        {
            return int.TryParse(text, out _);
        }

        private void btnbuyersubmit_Click(object sender, EventArgs e)
        {
            if (!AreBuyerFieldsFilled())
            {
                MessageBox.Show("Please fill all buyer fields.");
                return;
            }

            string buyer_name = textBoxbuyername.Text;
            if (!IsValidName(buyer_name))
            {
                MessageBox.Show("Invalid name. Only letters and spaces are allowed.");
                return;
            }
            string buyer_number_str = textBoxbuyernumber.Text.Trim();
            if (!IsNumber(buyer_number_str))
            {
                MessageBox.Show("Invalid building number. Only numbers are allowed.");
                return;
            }
            int buyer_number = int.Parse(buyer_number_str);
            string buyer_city = textBoxbuyercity.Text;
            string buyer_country = textBoxbuyercountry.Text;    
            string buyer_street = textBoxbuyerstreet.Text;  
            string buyer_password= textBoxbuyerpassword.Text;   

            Adress adress = new Adress(buyer_street, buyer_city, buyer_country,  buyer_number);
            Buyer buyer = new Buyer(buyer_name, buyer_password, adress);

            store += buyer;
            MessageBox.Show("Buyer added successfully");

        }

        private void ShowAllBuyersData()
        {
            var buyers = store.GetBuyersList();
            var table = new DataTable();

            table.Columns.Add("Name", typeof(string));
            table.Columns.Add("Password", typeof(string));
            table.Columns.Add("Street", typeof(string));
            table.Columns.Add("City", typeof(string));
            table.Columns.Add("Country", typeof(string));
            table.Columns.Add("BuildingNum", typeof(int));
            table.Columns.Add("Cart Items", typeof(string));

            foreach (var buyer in buyers)
            {
                string cartItems = string.Join(", ", buyer.shoppingCart.Select(p => $"{p.Name} (${p.Price})"));
                table.Rows.Add(
                    buyer.Name,
                    buyer.Password,
                    buyer.Adress.Street,
                    buyer.Adress.City,
                    buyer.Adress.Country,
                    buyer.Adress.BuildingNum,
                    cartItems
                );
            }

            dataGridViewBuyers.DataSource = table;
        }

        private void button6_Click(object sender, EventArgs e)
        {
            dataGridViewBuyers.Visible = true;
            lblbuyersdata.Visible = true;   
            ShowAllBuyersData();
        }

        private void btnshowmerchantsdata_Click(object sender, EventArgs e)
        {
            dataGridViewMerchants.Visible = true;
            lblmerchantsdata.Visible = true;
            ShowAllMerchantsData();
        }

        private void ShowAllMerchantsData()
        {
            var merchants = store.GetMerchantsList();
            var table = new DataTable();

            table.Columns.Add("Name", typeof(string));
            table.Columns.Add("Password", typeof(string));
            table.Columns.Add("Street", typeof(string));
            table.Columns.Add("City", typeof(string));
            table.Columns.Add("Country", typeof(string));
            table.Columns.Add("BuildingNum", typeof(int));
            table.Columns.Add("Products", typeof(string));

            foreach (var merchant in merchants)
            {
                string products = string.Join(", ", merchant.ProductsList.Select(p => $"{p.Name} (${p.Price})"));
                table.Rows.Add(
                    merchant.Name,
                    merchant.Password,
                    merchant.Adress.Street,
                    merchant.Adress.City,
                    merchant.Adress.Country,
                    merchant.Adress.BuildingNum,
                    products
                );
            }

            dataGridViewMerchants.DataSource = table;
        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void btnaddmerchant_Click(object sender, EventArgs e)
        {
            lblmerchantcity.Visible = true;
            lblmerchantname.Visible = true;
            lblmerchantcoutrey.Visible = true;  
            lblmerchantstreet.Visible = true; 
            lblmerchantnumber.Visible = true;
            lblmerchantpassword.Visible = true;
            textBoxmerchantcity.Visible = true;
            textBoxmerchantcoutrey.Visible=true;
            textBoxmerchantname.Visible = true;
            textBoxmerchantnumber.Visible=true;
            textBoxmerchantpassword.Visible=true;
            textBoxmerchantstreet.Visible=true; 
            btnsubmitmerchantdata.Visible = true;
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void Digital_Store_Load(object sender, EventArgs e)
        {

        }

        private void btnsubmitmerchantdata_Click(object sender, EventArgs e)
        {
            if (!AreMerchantFieldsFilled())
            {
                MessageBox.Show("Please fill all merchant fields.");
                return;
            }

            string merchant_name = textBoxmerchantname.Text;
            if (!IsValidName(merchant_name))
            {
                MessageBox.Show("Invalid name. Only letters and spaces are allowed.");
                return;
            }
            string merchant_number_str = textBoxmerchantnumber.Text.Trim();
            if (!IsNumber(merchant_number_str))
            {
                MessageBox.Show("Invalid building number. Only numbers are allowed.");
                return;
            }
            int merchant_number = int.Parse(merchant_number_str);
            string merchant_city = textBoxmerchantcity.Text;
            string merchant_country = textBoxmerchantcoutrey.Text;
            string merchant_street = textBoxmerchantstreet.Text;
            string merchant_password = textBoxmerchantpassword.Text;

            Adress adress = new Adress(merchant_street, merchant_city, merchant_country, merchant_number);
            Merchant merchant = new Merchant(merchant_name, merchant_password, adress);

            store += merchant;
            MessageBox.Show("Merchant added successfully");
        }

        private void checkedListBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void textBoxmerchantname_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnadditemmerchant_Click(object sender, EventArgs e)
        {
            lblitemname.Visible = true;
            lblmerchantnameforitem.Visible = true;
            lblitemprice.Visible = true;
            lblspecialpackaging.Visible = true;
            lblitemcatagory.Visible = true; 
            textBoxitemname.Visible = true;
            textBoxitemprice.Visible = true;
            textBoxmerchantnameitem.Visible = true;
            btnadditemmerchant.Visible = true;
            checkBoxchildren.Visible = true;
            checkBoxclothing.Visible = true;
            checkBoxelectricity.Visible = true;
            checkBoxno.Visible = true;
            checkBoxoffice.Visible = true;  
            checkBoxyes.Visible = true;
            btnadditemtomerchant.Visible = true;
        }

        private void textBoxpackagingprice_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnadditembuyer_Click(object sender, EventArgs e)
        {
            lblitemnamecart.Visible = true;
            lblmerchantnamecart.Visible = true;
            lblbuyernamecart.Visible = true;
            btnadditemtobuyer.Visible = true;
            textBoxitemnamecart.Visible = true;
            textBoxmerchantnamecart.Visible = true;
            textBoxbuyernamecart.Visible=true;
        }

        private void btnadditemtomerchant_Click(object sender, EventArgs e)
        {
            if (!AreItemFieldsFilled())
            {
                MessageBox.Show("Please fill all item fields.");
                return;
            }

            try
            {
                
                int selectedCategoryCount = (checkBoxchildren.Checked ? 1 : 0) +
                                            (checkBoxelectricity.Checked ? 1 : 0) +
                                            (checkBoxoffice.Checked ? 1 : 0) +
                                            (checkBoxclothing.Checked ? 1 : 0);

                if (selectedCategoryCount != 1)
                {
                    MessageBox.Show("Please select exactly one category.");
                    return;
                }

                
                string itemName = textBoxitemname.Text;
                double itemPrice = double.Parse(textBoxitemprice.Text);
                double packagingPrice = checkBoxyes.Checked ? double.Parse(textBoxpackagingprice.Text) : 0;
                string merchantName = textBoxmerchantnameitem.Text;

                
                Item.ProductCategory category = Item.ProductCategory.Children; 
                if (checkBoxelectricity.Checked)
                    category = Item.ProductCategory.Electricity;
                else if (checkBoxoffice.Checked)
                    category = Item.ProductCategory.Office;
                else if (checkBoxclothing.Checked)
                    category = Item.ProductCategory.Clothing;

                
                Merchant merchant = store.FindMerchantByName(merchantName);
                if (merchant != null)
                {
                    Item item;
                    if (checkBoxyes.Checked)
                    {
                        item = new PackagedItem(itemName, itemPrice, category, packagingPrice);
                    }
                    else
                    {
                        item = new Item(itemName, itemPrice, category);
                    }
                    merchant.AddProduct(ref item);
                    MessageBox.Show("Item added successfully");
                }
                else
                {
                    MessageBox.Show("Merchant not found");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}");
            }
        }

        private void checkBoxyes_CheckedChanged(object sender, EventArgs e)
        {
            lblspecialpackagingprice.Visible = checkBoxyes.Checked;
            textBoxpackagingprice.Visible = checkBoxyes.Checked;
        }

        private void CategoryCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            if (sender is CheckBox checkBox)
            {
                if (checkBox.Checked)
                {
                    
                    if (checkBox != checkBoxchildren) checkBoxchildren.Checked = false;
                    if (checkBox != checkBoxelectricity) checkBoxelectricity.Checked = false;
                    if (checkBox != checkBoxoffice) checkBoxoffice.Checked = false;
                    if (checkBox != checkBoxclothing) checkBoxclothing.Checked = false;
                }
            }
        }

        private bool AreAddItemToBuyerFieldsFilled()
        {
            return !string.IsNullOrWhiteSpace(textBoxbuyernamecart.Text) &&
                   !string.IsNullOrWhiteSpace(textBoxitemnamecart.Text) &&
                   !string.IsNullOrWhiteSpace(textBoxmerchantnamecart.Text);
        }

        private void btnadditemtobuyer_Click(object sender, EventArgs e)
        {
            if (!AreAddItemToBuyerFieldsFilled())
            {
                MessageBox.Show("Please fill all fields.");
                return;
            }

            string buyerName = textBoxbuyernamecart.Text;
            string itemName = textBoxitemnamecart.Text;
            string merchantName = textBoxmerchantnamecart.Text;

            
            Buyer buyer = store.FindBuyerByName(buyerName);
            if (buyer == null)
            {
                MessageBox.Show("Buyer not found");
                return;
            }

            
            Merchant merchant = store.FindMerchantByName(merchantName);
            if (merchant == null)
            {
                MessageBox.Show("Merchant not found");
                return;
            }

           
            Item item = merchant.FindProductByName(itemName);
            if (item == null)
            {
                MessageBox.Show("Item not found with the specified merchant");
                return;
            }

            
            buyer.AddToCart(item);
            MessageBox.Show("Item added to buyer's cart successfully");
        }
    }
 }

