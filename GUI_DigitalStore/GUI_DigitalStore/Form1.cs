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

        private bool AreBuyerFieldsFilled() //בדיקה האם מולאו כל השדות הנדרשים
        {
            return !string.IsNullOrWhiteSpace(textBoxbuyername.Text) &&
                   !string.IsNullOrWhiteSpace(textBoxbuyerpassword.Text) &&
                   !string.IsNullOrWhiteSpace(textBoxbuyercountry.Text) &&
                   !string.IsNullOrWhiteSpace(textBoxbuyercity.Text) &&
                   !string.IsNullOrWhiteSpace(textBoxbuyerstreet.Text) &&
                   !string.IsNullOrWhiteSpace(textBoxbuyernumber.Text);
        }

        private bool AreMerchantFieldsFilled() //בדיקה האם מולאו כל השדות הנדרשים
        {
            return !string.IsNullOrWhiteSpace(textBoxmerchantname.Text) &&
                   !string.IsNullOrWhiteSpace(textBoxmerchantpassword.Text) &&
                   !string.IsNullOrWhiteSpace(textBoxmerchantcoutrey.Text) &&
                   !string.IsNullOrWhiteSpace(textBoxmerchantcity.Text) &&
                   !string.IsNullOrWhiteSpace(textBoxmerchantstreet.Text) &&
                   !string.IsNullOrWhiteSpace(textBoxmerchantnumber.Text);
        }

        private bool AreItemFieldsFilled() //בדיקה האם מולאו כל השדות הנדרשים
        {
            return !string.IsNullOrWhiteSpace(textBoxitemname.Text) &&
                   !string.IsNullOrWhiteSpace(textBoxitemprice.Text) &&
                   !string.IsNullOrWhiteSpace(textBoxmerchantnameitem.Text) &&
                   (checkBoxyes.Checked ? !string.IsNullOrWhiteSpace(textBoxpackagingprice.Text) : true) &&
                   (checkBoxchildren.Checked || checkBoxelectricity.Checked || checkBoxoffice.Checked || checkBoxclothing.Checked);
        }

        private bool AreAddItemToBuyerFieldsFilled()// מוודא שדות מולאו כראוי
        {
            return !string.IsNullOrWhiteSpace(textBoxbuyernamecart.Text) &&
                   !string.IsNullOrWhiteSpace(textBoxitemnamecart.Text) &&
                   !string.IsNullOrWhiteSpace(textBoxmerchantnamecart.Text);
        }

        private void ShowHideSections(string section)
        {
            // הסתרת כל השדות והלייבלים
            lblbuyername.Visible = false;
            lblbuyerpassword.Visible = false;
            lblbuyercountery.Visible = false;
            lblbuyercity.Visible = false;
            lblbuyerstreet.Visible = false;
            lblbuyernumber.Visible = false;
            textBoxbuyername.Visible = false;
            textBoxbuyerpassword.Visible = false;
            textBoxbuyercountry.Visible = false;
            textBoxbuyercity.Visible = false;
            textBoxbuyerstreet.Visible = false;
            textBoxbuyernumber.Visible = false;
            btnbuyersubmit.Visible = false;

            lblmerchantname.Visible = false;
            lblmerchantpassword.Visible = false;
            lblmerchantcoutrey.Visible = false;
            lblmerchantcity.Visible = false;
            lblmerchantstreet.Visible = false;
            lblmerchantnumber.Visible = false;
            textBoxmerchantname.Visible = false;
            textBoxmerchantpassword.Visible = false;
            textBoxmerchantcoutrey.Visible = false;
            textBoxmerchantcity.Visible = false;
            textBoxmerchantstreet.Visible = false;
            textBoxmerchantnumber.Visible = false;
            btnsubmitmerchantdata.Visible = false;

            lblitemname.Visible = false;
            lblitemprice.Visible = false;
            lblspecialpackagingprice.Visible = false;
            lblmerchantnameforitem.Visible = false;
            lblitemcatagory.Visible = false;
            lblspecialpackaging.Visible = false;
            textBoxitemname.Visible = false;
            textBoxitemprice.Visible = false;
            textBoxpackagingprice.Visible = false;
            textBoxmerchantnameitem.Visible = false;
            checkBoxchildren.Visible = false;
            checkBoxelectricity.Visible = false;
            checkBoxoffice.Visible = false;
            checkBoxclothing.Visible = false;
            checkBoxyes.Visible = false;
            checkBoxno.Visible = false;
            btnadditemtomerchant.Visible = false;

            lblbuyernamecart.Visible = false;
            lblitemnamecart.Visible = false;
            lblmerchantnamecart.Visible = false;
            textBoxbuyernamecart.Visible = false;
            textBoxitemnamecart.Visible = false;
            textBoxmerchantnamecart.Visible = false;
            btnadditemtobuyer.Visible = false;

            // הצגת השדות והלייבלים הרלוונטיים בהתאם לפרמטר
            switch (section)
            {
                case "AddBuyer":
                    lblbuyername.Visible = true;
                    lblbuyerpassword.Visible = true;
                    lblbuyercountery.Visible = true;
                    lblbuyercity.Visible = true;
                    lblbuyerstreet.Visible = true;
                    lblbuyernumber.Visible = true;
                    textBoxbuyername.Visible = true;
                    textBoxbuyerpassword.Visible = true;
                    textBoxbuyercountry.Visible = true;
                    textBoxbuyercity.Visible = true;
                    textBoxbuyerstreet.Visible = true;
                    textBoxbuyernumber.Visible = true;
                    btnbuyersubmit.Visible = true;
                    break;
                case "AddMerchant":
                    lblmerchantname.Visible = true;
                    lblmerchantpassword.Visible = true;
                    lblmerchantcoutrey.Visible = true;
                    lblmerchantcity.Visible = true;
                    lblmerchantstreet.Visible = true;
                    lblmerchantnumber.Visible = true;
                    textBoxmerchantname.Visible = true;
                    textBoxmerchantpassword.Visible = true;
                    textBoxmerchantcoutrey.Visible = true;
                    textBoxmerchantcity.Visible = true;
                    textBoxmerchantstreet.Visible = true;
                    textBoxmerchantnumber.Visible = true;
                    btnsubmitmerchantdata.Visible = true;
                    break;
                case "AddItemToMerchant":
                    lblitemname.Visible = true;
                    lblitemprice.Visible = true;
                    lblspecialpackagingprice.Visible = true;
                    lblmerchantnameforitem.Visible = true;
                    lblitemcatagory.Visible = true;
                    lblspecialpackaging.Visible = true;
                    textBoxitemname.Visible = true;
                    textBoxitemprice.Visible = true;
                    textBoxpackagingprice.Visible = true;
                    textBoxmerchantnameitem.Visible = true;
                    checkBoxchildren.Visible = true;
                    checkBoxelectricity.Visible = true;
                    checkBoxoffice.Visible = true;
                    checkBoxclothing.Visible = true;
                    checkBoxyes.Visible = true;
                    checkBoxno.Visible = true;
                    btnadditemtomerchant.Visible = true;
                    break;
                case "AddItemToBuyer":
                    lblbuyernamecart.Visible = true;
                    lblitemnamecart.Visible = true;
                    lblmerchantnamecart.Visible = true;
                    textBoxbuyernamecart.Visible = true;
                    textBoxitemnamecart.Visible = true;
                    textBoxmerchantnamecart.Visible = true;
                    btnadditemtobuyer.Visible = true;
                    break;
            }
        }

        private bool IsValidName(string name) //בדיקה האם השם מורכב רק מאותיות
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
            ShowHideSections("AddBuyer");
        }

        private void btnaddmerchant_Click(object sender, EventArgs e)
        {
            ShowHideSections("AddMerchant");
        }

        private void btnadditemmerchant_Click(object sender, EventArgs e)
        {
            ShowHideSections("AddItemToMerchant");
        }

        private void btnadditembuyer_Click(object sender, EventArgs e)
        {
            ShowHideSections("AddItemToBuyer");
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

        private void btnbuyersubmit_Click(object sender, EventArgs e)// הוספת לקוח למערכת
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

        private void button6_Click(object sender, EventArgs e) //הצגת הטבלת מידע עבור לקוחות
        {
            dataGridViewBuyers.Visible = true;
            lblbuyersdata.Visible = true;   
            ShowAllBuyersData();
        }

        private void btnshowmerchantsdata_Click(object sender, EventArgs e) //הצגת הטבלת מידע עבור מוכרים
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

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void Digital_Store_Load(object sender, EventArgs e)
        {

        }

        private void btnsubmitmerchantdata_Click(object sender, EventArgs e) //הוספת מוכר למערכת
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


        private void textBoxpackagingprice_TextChanged(object sender, EventArgs e)
        {

        }


        private void btnadditemtomerchant_Click(object sender, EventArgs e) //הוספת מוצר לרשימה של מוכר
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


        private void btnadditemtobuyer_Click(object sender, EventArgs e)// הוספת מוצר לעגלת קניות של לקוח
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

