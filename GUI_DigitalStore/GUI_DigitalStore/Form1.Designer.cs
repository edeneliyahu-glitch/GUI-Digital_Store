namespace GUI_DigitalStore
{
    partial class Digital_Store
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.btnaddbuyer = new System.Windows.Forms.Button();
            this.btnaddmerchant = new System.Windows.Forms.Button();
            this.btnadditemmerchant = new System.Windows.Forms.Button();
            this.btnadditembuyer = new System.Windows.Forms.Button();
            this.btnshowbuyersdata = new System.Windows.Forms.Button();
            this.btnshowmerchantsdata = new System.Windows.Forms.Button();
            this.lblbuyername = new System.Windows.Forms.Label();
            this.textBoxbuyername = new System.Windows.Forms.TextBox();
            this.lblbuyerpassword = new System.Windows.Forms.Label();
            this.lblbuyercountery = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.textBoxbuyerpassword = new System.Windows.Forms.TextBox();
            this.textBoxbuyercountry = new System.Windows.Forms.TextBox();
            this.lblbuyercity = new System.Windows.Forms.Label();
            this.lblbuyerstreet = new System.Windows.Forms.Label();
            this.lblbuyernumber = new System.Windows.Forms.Label();
            this.textBoxbuyercity = new System.Windows.Forms.TextBox();
            this.textBoxbuyerstreet = new System.Windows.Forms.TextBox();
            this.textBoxbuyernumber = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnbuyersubmit = new System.Windows.Forms.Button();
            this.dataGridViewBuyers = new System.Windows.Forms.DataGridView();
            this.lblmerchantname = new System.Windows.Forms.Label();
            this.lblmerchantpassword = new System.Windows.Forms.Label();
            this.lblmerchantcoutrey = new System.Windows.Forms.Label();
            this.lblmerchantcity = new System.Windows.Forms.Label();
            this.lblmerchantstreet = new System.Windows.Forms.Label();
            this.lblmerchantnumber = new System.Windows.Forms.Label();
            this.textBoxmerchantnumber = new System.Windows.Forms.TextBox();
            this.textBoxmerchantstreet = new System.Windows.Forms.TextBox();
            this.textBoxmerchantcity = new System.Windows.Forms.TextBox();
            this.textBoxmerchantcoutrey = new System.Windows.Forms.TextBox();
            this.textBoxmerchantpassword = new System.Windows.Forms.TextBox();
            this.textBoxmerchantname = new System.Windows.Forms.TextBox();
            this.btnsubmitmerchantdata = new System.Windows.Forms.Button();
            this.dataGridViewMerchants = new System.Windows.Forms.DataGridView();
            this.lblbuyersdata = new System.Windows.Forms.Label();
            this.lblmerchantsdata = new System.Windows.Forms.Label();
            this.lblmerchantnameforitem = new System.Windows.Forms.Label();
            this.lblitemname = new System.Windows.Forms.Label();
            this.lblitemprice = new System.Windows.Forms.Label();
            this.lblitemcatagory = new System.Windows.Forms.Label();
            this.checkBoxchildren = new System.Windows.Forms.CheckBox();
            this.label3 = new System.Windows.Forms.Label();
            this.checkBoxelectricity = new System.Windows.Forms.CheckBox();
            this.checkBoxoffice = new System.Windows.Forms.CheckBox();
            this.checkBoxclothing = new System.Windows.Forms.CheckBox();
            this.lblspecialpackaging = new System.Windows.Forms.Label();
            this.checkBoxyes = new System.Windows.Forms.CheckBox();
            this.checkBoxno = new System.Windows.Forms.CheckBox();
            this.lblspecialpackagingprice = new System.Windows.Forms.Label();
            this.textBoxpackagingprice = new System.Windows.Forms.TextBox();
            this.btnadditemtomerchant = new System.Windows.Forms.Button();
            this.textBoxmerchantnameitem = new System.Windows.Forms.TextBox();
            this.textBoxitemname = new System.Windows.Forms.TextBox();
            this.textBoxitemprice = new System.Windows.Forms.TextBox();
            this.lblbuyernamecart = new System.Windows.Forms.Label();
            this.lblitemnamecart = new System.Windows.Forms.Label();
            this.lblmerchantnamecart = new System.Windows.Forms.Label();
            this.textBoxbuyernamecart = new System.Windows.Forms.TextBox();
            this.textBoxitemnamecart = new System.Windows.Forms.TextBox();
            this.textBoxmerchantnamecart = new System.Windows.Forms.TextBox();
            this.btnadditemtobuyer = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewBuyers)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewMerchants)).BeginInit();
            this.SuspendLayout();
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // btnaddbuyer
            // 
            this.btnaddbuyer.Location = new System.Drawing.Point(12, 12);
            this.btnaddbuyer.Name = "btnaddbuyer";
            this.btnaddbuyer.Size = new System.Drawing.Size(174, 36);
            this.btnaddbuyer.TabIndex = 1;
            this.btnaddbuyer.Text = "Add Buyer";
            this.btnaddbuyer.UseVisualStyleBackColor = true;
            this.btnaddbuyer.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnaddmerchant
            // 
            this.btnaddmerchant.Location = new System.Drawing.Point(240, 12);
            this.btnaddmerchant.Name = "btnaddmerchant";
            this.btnaddmerchant.Size = new System.Drawing.Size(174, 36);
            this.btnaddmerchant.TabIndex = 2;
            this.btnaddmerchant.Text = "Add Merchant";
            this.btnaddmerchant.UseVisualStyleBackColor = true;
            this.btnaddmerchant.Click += new System.EventHandler(this.btnaddmerchant_Click);
            // 
            // btnadditemmerchant
            // 
            this.btnadditemmerchant.Location = new System.Drawing.Point(475, 12);
            this.btnadditemmerchant.Name = "btnadditemmerchant";
            this.btnadditemmerchant.Size = new System.Drawing.Size(174, 36);
            this.btnadditemmerchant.TabIndex = 3;
            this.btnadditemmerchant.Text = "Add Item To Merchant";
            this.btnadditemmerchant.UseVisualStyleBackColor = true;
            this.btnadditemmerchant.Click += new System.EventHandler(this.btnadditemmerchant_Click);
            // 
            // btnadditembuyer
            // 
            this.btnadditembuyer.Location = new System.Drawing.Point(704, 12);
            this.btnadditembuyer.Name = "btnadditembuyer";
            this.btnadditembuyer.Size = new System.Drawing.Size(174, 36);
            this.btnadditembuyer.TabIndex = 4;
            this.btnadditembuyer.Text = "Add Item To Buyer\'s Cart";
            this.btnadditembuyer.UseVisualStyleBackColor = true;
            this.btnadditembuyer.Click += new System.EventHandler(this.btnadditembuyer_Click);
            // 
            // btnshowbuyersdata
            // 
            this.btnshowbuyersdata.Location = new System.Drawing.Point(10, 365);
            this.btnshowbuyersdata.Name = "btnshowbuyersdata";
            this.btnshowbuyersdata.Size = new System.Drawing.Size(236, 64);
            this.btnshowbuyersdata.TabIndex = 6;
            this.btnshowbuyersdata.Text = "Show All Buyers Data";
            this.btnshowbuyersdata.UseVisualStyleBackColor = true;
            this.btnshowbuyersdata.Click += new System.EventHandler(this.button6_Click);
            // 
            // btnshowmerchantsdata
            // 
            this.btnshowmerchantsdata.Location = new System.Drawing.Point(760, 365);
            this.btnshowmerchantsdata.Name = "btnshowmerchantsdata";
            this.btnshowmerchantsdata.Size = new System.Drawing.Size(236, 64);
            this.btnshowmerchantsdata.TabIndex = 7;
            this.btnshowmerchantsdata.Text = "Show All Merchants Data";
            this.btnshowmerchantsdata.UseVisualStyleBackColor = true;
            this.btnshowmerchantsdata.Click += new System.EventHandler(this.btnshowmerchantsdata_Click);
            // 
            // lblbuyername
            // 
            this.lblbuyername.AutoSize = true;
            this.lblbuyername.Location = new System.Drawing.Point(1, 65);
            this.lblbuyername.Name = "lblbuyername";
            this.lblbuyername.Size = new System.Drawing.Size(115, 16);
            this.lblbuyername.TabIndex = 8;
            this.lblbuyername.Text = "Enter buyer name:";
            this.lblbuyername.Visible = false;
            // 
            // textBoxbuyername
            // 
            this.textBoxbuyername.Location = new System.Drawing.Point(192, 63);
            this.textBoxbuyername.Name = "textBoxbuyername";
            this.textBoxbuyername.Size = new System.Drawing.Size(129, 22);
            this.textBoxbuyername.TabIndex = 9;
            this.textBoxbuyername.Visible = false;
            // 
            // lblbuyerpassword
            // 
            this.lblbuyerpassword.AutoSize = true;
            this.lblbuyerpassword.Location = new System.Drawing.Point(1, 103);
            this.lblbuyerpassword.Name = "lblbuyerpassword";
            this.lblbuyerpassword.Size = new System.Drawing.Size(140, 16);
            this.lblbuyerpassword.TabIndex = 10;
            this.lblbuyerpassword.Text = "Enter buyer password:";
            this.lblbuyerpassword.Visible = false;
            // 
            // lblbuyercountery
            // 
            this.lblbuyercountery.AutoSize = true;
            this.lblbuyercountery.Location = new System.Drawing.Point(1, 142);
            this.lblbuyercountery.Name = "lblbuyercountery";
            this.lblbuyercountery.Size = new System.Drawing.Size(124, 16);
            this.lblbuyercountery.TabIndex = 11;
            this.lblbuyercountery.Text = "Enter buyer country:";
            this.lblbuyercountery.Visible = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(1, 157);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(0, 16);
            this.label4.TabIndex = 12;
            this.label4.Visible = false;
            // 
            // textBoxbuyerpassword
            // 
            this.textBoxbuyerpassword.Location = new System.Drawing.Point(192, 101);
            this.textBoxbuyerpassword.Name = "textBoxbuyerpassword";
            this.textBoxbuyerpassword.Size = new System.Drawing.Size(129, 22);
            this.textBoxbuyerpassword.TabIndex = 13;
            this.textBoxbuyerpassword.Visible = false;
            // 
            // textBoxbuyercountry
            // 
            this.textBoxbuyercountry.Location = new System.Drawing.Point(192, 142);
            this.textBoxbuyercountry.Name = "textBoxbuyercountry";
            this.textBoxbuyercountry.Size = new System.Drawing.Size(129, 22);
            this.textBoxbuyercountry.TabIndex = 14;
            this.textBoxbuyercountry.Visible = false;
            // 
            // lblbuyercity
            // 
            this.lblbuyercity.AutoSize = true;
            this.lblbuyercity.Location = new System.Drawing.Point(1, 181);
            this.lblbuyercity.Name = "lblbuyercity";
            this.lblbuyercity.Size = new System.Drawing.Size(101, 16);
            this.lblbuyercity.TabIndex = 15;
            this.lblbuyercity.Text = "Enter buyer city:";
            this.lblbuyercity.Visible = false;
            // 
            // lblbuyerstreet
            // 
            this.lblbuyerstreet.AutoSize = true;
            this.lblbuyerstreet.Location = new System.Drawing.Point(1, 227);
            this.lblbuyerstreet.Name = "lblbuyerstreet";
            this.lblbuyerstreet.Size = new System.Drawing.Size(114, 16);
            this.lblbuyerstreet.TabIndex = 16;
            this.lblbuyerstreet.Text = "Enter buyer street:";
            this.lblbuyerstreet.Visible = false;
            // 
            // lblbuyernumber
            // 
            this.lblbuyernumber.AutoSize = true;
            this.lblbuyernumber.Location = new System.Drawing.Point(-1, 269);
            this.lblbuyernumber.Name = "lblbuyernumber";
            this.lblbuyernumber.Size = new System.Drawing.Size(176, 16);
            this.lblbuyernumber.TabIndex = 17;
            this.lblbuyernumber.Text = "Enter buyer building number:";
            this.lblbuyernumber.Visible = false;
            // 
            // textBoxbuyercity
            // 
            this.textBoxbuyercity.Location = new System.Drawing.Point(192, 181);
            this.textBoxbuyercity.Name = "textBoxbuyercity";
            this.textBoxbuyercity.Size = new System.Drawing.Size(129, 22);
            this.textBoxbuyercity.TabIndex = 18;
            this.textBoxbuyercity.Visible = false;
            // 
            // textBoxbuyerstreet
            // 
            this.textBoxbuyerstreet.Location = new System.Drawing.Point(192, 221);
            this.textBoxbuyerstreet.Name = "textBoxbuyerstreet";
            this.textBoxbuyerstreet.Size = new System.Drawing.Size(129, 22);
            this.textBoxbuyerstreet.TabIndex = 19;
            this.textBoxbuyerstreet.Visible = false;
            // 
            // textBoxbuyernumber
            // 
            this.textBoxbuyernumber.Location = new System.Drawing.Point(192, 263);
            this.textBoxbuyernumber.Name = "textBoxbuyernumber";
            this.textBoxbuyernumber.Size = new System.Drawing.Size(129, 22);
            this.textBoxbuyernumber.TabIndex = 20;
            this.textBoxbuyernumber.Visible = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 307);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 16);
            this.label1.TabIndex = 21;
            this.label1.Visible = false;
            // 
            // btnbuyersubmit
            // 
            this.btnbuyersubmit.Location = new System.Drawing.Point(78, 307);
            this.btnbuyersubmit.Name = "btnbuyersubmit";
            this.btnbuyersubmit.Size = new System.Drawing.Size(137, 30);
            this.btnbuyersubmit.TabIndex = 22;
            this.btnbuyersubmit.Text = "Submit buyer data";
            this.btnbuyersubmit.UseVisualStyleBackColor = true;
            this.btnbuyersubmit.Visible = false;
            this.btnbuyersubmit.Click += new System.EventHandler(this.btnbuyersubmit_Click);
            // 
            // dataGridViewBuyers
            // 
            this.dataGridViewBuyers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewBuyers.GridColor = System.Drawing.SystemColors.ControlDarkDark;
            this.dataGridViewBuyers.Location = new System.Drawing.Point(128, 435);
            this.dataGridViewBuyers.Name = "dataGridViewBuyers";
            this.dataGridViewBuyers.RowHeadersWidth = 51;
            this.dataGridViewBuyers.RowTemplate.Height = 24;
            this.dataGridViewBuyers.Size = new System.Drawing.Size(574, 222);
            this.dataGridViewBuyers.TabIndex = 23;
            this.dataGridViewBuyers.Visible = false;
            // 
            // lblmerchantname
            // 
            this.lblmerchantname.AutoSize = true;
            this.lblmerchantname.Location = new System.Drawing.Point(388, 63);
            this.lblmerchantname.Name = "lblmerchantname";
            this.lblmerchantname.Size = new System.Drawing.Size(136, 16);
            this.lblmerchantname.TabIndex = 24;
            this.lblmerchantname.Text = "Enter merchant name:";
            this.lblmerchantname.Visible = false;
            // 
            // lblmerchantpassword
            // 
            this.lblmerchantpassword.AutoSize = true;
            this.lblmerchantpassword.Location = new System.Drawing.Point(388, 101);
            this.lblmerchantpassword.Name = "lblmerchantpassword";
            this.lblmerchantpassword.Size = new System.Drawing.Size(161, 16);
            this.lblmerchantpassword.TabIndex = 25;
            this.lblmerchantpassword.Text = "Enter merchant password:";
            this.lblmerchantpassword.Visible = false;
            // 
            // lblmerchantcoutrey
            // 
            this.lblmerchantcoutrey.AutoSize = true;
            this.lblmerchantcoutrey.Location = new System.Drawing.Point(388, 142);
            this.lblmerchantcoutrey.Name = "lblmerchantcoutrey";
            this.lblmerchantcoutrey.Size = new System.Drawing.Size(153, 16);
            this.lblmerchantcoutrey.TabIndex = 26;
            this.lblmerchantcoutrey.Text = "Enter merchant countery:";
            this.lblmerchantcoutrey.Visible = false;
            // 
            // lblmerchantcity
            // 
            this.lblmerchantcity.AutoSize = true;
            this.lblmerchantcity.Location = new System.Drawing.Point(388, 181);
            this.lblmerchantcity.Name = "lblmerchantcity";
            this.lblmerchantcity.Size = new System.Drawing.Size(122, 16);
            this.lblmerchantcity.TabIndex = 27;
            this.lblmerchantcity.Text = "Enter merchant city:";
            this.lblmerchantcity.Visible = false;
            // 
            // lblmerchantstreet
            // 
            this.lblmerchantstreet.AutoSize = true;
            this.lblmerchantstreet.Location = new System.Drawing.Point(388, 227);
            this.lblmerchantstreet.Name = "lblmerchantstreet";
            this.lblmerchantstreet.Size = new System.Drawing.Size(135, 16);
            this.lblmerchantstreet.TabIndex = 28;
            this.lblmerchantstreet.Text = "Enter merchant street:";
            this.lblmerchantstreet.Visible = false;
            this.lblmerchantstreet.Click += new System.EventHandler(this.label7_Click);
            // 
            // lblmerchantnumber
            // 
            this.lblmerchantnumber.AutoSize = true;
            this.lblmerchantnumber.Location = new System.Drawing.Point(388, 269);
            this.lblmerchantnumber.Name = "lblmerchantnumber";
            this.lblmerchantnumber.Size = new System.Drawing.Size(197, 16);
            this.lblmerchantnumber.TabIndex = 29;
            this.lblmerchantnumber.Text = "Enter merchant building number:";
            this.lblmerchantnumber.Visible = false;
            // 
            // textBoxmerchantnumber
            // 
            this.textBoxmerchantnumber.Location = new System.Drawing.Point(600, 263);
            this.textBoxmerchantnumber.Name = "textBoxmerchantnumber";
            this.textBoxmerchantnumber.Size = new System.Drawing.Size(129, 22);
            this.textBoxmerchantnumber.TabIndex = 30;
            this.textBoxmerchantnumber.Visible = false;
            // 
            // textBoxmerchantstreet
            // 
            this.textBoxmerchantstreet.Location = new System.Drawing.Point(600, 221);
            this.textBoxmerchantstreet.Name = "textBoxmerchantstreet";
            this.textBoxmerchantstreet.Size = new System.Drawing.Size(129, 22);
            this.textBoxmerchantstreet.TabIndex = 31;
            this.textBoxmerchantstreet.Visible = false;
            // 
            // textBoxmerchantcity
            // 
            this.textBoxmerchantcity.Location = new System.Drawing.Point(600, 181);
            this.textBoxmerchantcity.Name = "textBoxmerchantcity";
            this.textBoxmerchantcity.Size = new System.Drawing.Size(129, 22);
            this.textBoxmerchantcity.TabIndex = 32;
            this.textBoxmerchantcity.Visible = false;
            // 
            // textBoxmerchantcoutrey
            // 
            this.textBoxmerchantcoutrey.Location = new System.Drawing.Point(600, 139);
            this.textBoxmerchantcoutrey.Name = "textBoxmerchantcoutrey";
            this.textBoxmerchantcoutrey.Size = new System.Drawing.Size(129, 22);
            this.textBoxmerchantcoutrey.TabIndex = 33;
            this.textBoxmerchantcoutrey.Visible = false;
            // 
            // textBoxmerchantpassword
            // 
            this.textBoxmerchantpassword.Location = new System.Drawing.Point(600, 95);
            this.textBoxmerchantpassword.Name = "textBoxmerchantpassword";
            this.textBoxmerchantpassword.Size = new System.Drawing.Size(129, 22);
            this.textBoxmerchantpassword.TabIndex = 34;
            this.textBoxmerchantpassword.Visible = false;
            this.textBoxmerchantpassword.TextChanged += new System.EventHandler(this.textBox5_TextChanged);
            // 
            // textBoxmerchantname
            // 
            this.textBoxmerchantname.Location = new System.Drawing.Point(600, 57);
            this.textBoxmerchantname.Name = "textBoxmerchantname";
            this.textBoxmerchantname.Size = new System.Drawing.Size(129, 22);
            this.textBoxmerchantname.TabIndex = 35;
            this.textBoxmerchantname.Visible = false;
            this.textBoxmerchantname.TextChanged += new System.EventHandler(this.textBoxmerchantname_TextChanged);
            // 
            // btnsubmitmerchantdata
            // 
            this.btnsubmitmerchantdata.Location = new System.Drawing.Point(475, 307);
            this.btnsubmitmerchantdata.Name = "btnsubmitmerchantdata";
            this.btnsubmitmerchantdata.Size = new System.Drawing.Size(145, 30);
            this.btnsubmitmerchantdata.TabIndex = 36;
            this.btnsubmitmerchantdata.Text = "Submit merchant data";
            this.btnsubmitmerchantdata.UseVisualStyleBackColor = true;
            this.btnsubmitmerchantdata.Visible = false;
            this.btnsubmitmerchantdata.Click += new System.EventHandler(this.btnsubmitmerchantdata_Click);
            // 
            // dataGridViewMerchants
            // 
            this.dataGridViewMerchants.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewMerchants.GridColor = System.Drawing.SystemColors.ControlDarkDark;
            this.dataGridViewMerchants.Location = new System.Drawing.Point(883, 435);
            this.dataGridViewMerchants.Name = "dataGridViewMerchants";
            this.dataGridViewMerchants.RowHeadersWidth = 51;
            this.dataGridViewMerchants.RowTemplate.Height = 24;
            this.dataGridViewMerchants.Size = new System.Drawing.Size(574, 222);
            this.dataGridViewMerchants.TabIndex = 37;
            this.dataGridViewMerchants.Visible = false;
            // 
            // lblbuyersdata
            // 
            this.lblbuyersdata.AutoSize = true;
            this.lblbuyersdata.Location = new System.Drawing.Point(7, 450);
            this.lblbuyersdata.Name = "lblbuyersdata";
            this.lblbuyersdata.Size = new System.Drawing.Size(82, 16);
            this.lblbuyersdata.TabIndex = 38;
            this.lblbuyersdata.Text = "Buyers data:";
            this.lblbuyersdata.Visible = false;
            this.lblbuyersdata.Click += new System.EventHandler(this.label2_Click);
            // 
            // lblmerchantsdata
            // 
            this.lblmerchantsdata.AutoSize = true;
            this.lblmerchantsdata.Location = new System.Drawing.Point(757, 450);
            this.lblmerchantsdata.Name = "lblmerchantsdata";
            this.lblmerchantsdata.Size = new System.Drawing.Size(102, 16);
            this.lblmerchantsdata.TabIndex = 39;
            this.lblmerchantsdata.Text = "Merchants data:";
            this.lblmerchantsdata.Visible = false;
            // 
            // lblmerchantnameforitem
            // 
            this.lblmerchantnameforitem.AutoSize = true;
            this.lblmerchantnameforitem.Location = new System.Drawing.Point(769, 63);
            this.lblmerchantnameforitem.Name = "lblmerchantnameforitem";
            this.lblmerchantnameforitem.Size = new System.Drawing.Size(136, 16);
            this.lblmerchantnameforitem.TabIndex = 40;
            this.lblmerchantnameforitem.Text = "Enter merchant name:";
            this.lblmerchantnameforitem.Visible = false;
            // 
            // lblitemname
            // 
            this.lblitemname.AutoSize = true;
            this.lblitemname.Location = new System.Drawing.Point(769, 101);
            this.lblitemname.Name = "lblitemname";
            this.lblitemname.Size = new System.Drawing.Size(106, 16);
            this.lblitemname.TabIndex = 41;
            this.lblitemname.Text = "Enter item name:";
            this.lblitemname.Visible = false;
            // 
            // lblitemprice
            // 
            this.lblitemprice.AutoSize = true;
            this.lblitemprice.Location = new System.Drawing.Point(769, 142);
            this.lblitemprice.Name = "lblitemprice";
            this.lblitemprice.Size = new System.Drawing.Size(102, 16);
            this.lblitemprice.TabIndex = 42;
            this.lblitemprice.Text = "Enter item price:";
            this.lblitemprice.Visible = false;
            // 
            // lblitemcatagory
            // 
            this.lblitemcatagory.AutoSize = true;
            this.lblitemcatagory.Location = new System.Drawing.Point(769, 181);
            this.lblitemcatagory.Name = "lblitemcatagory";
            this.lblitemcatagory.Size = new System.Drawing.Size(141, 16);
            this.lblitemcatagory.TabIndex = 43;
            this.lblitemcatagory.Text = "Choose item catagory:";
            this.lblitemcatagory.Visible = false;
            // 
            // checkBoxchildren
            // 
            this.checkBoxchildren.AutoSize = true;
            this.checkBoxchildren.Location = new System.Drawing.Point(919, 177);
            this.checkBoxchildren.Name = "checkBoxchildren";
            this.checkBoxchildren.Size = new System.Drawing.Size(78, 20);
            this.checkBoxchildren.TabIndex = 44;
            this.checkBoxchildren.Text = "Children";
            this.checkBoxchildren.UseVisualStyleBackColor = true;
            this.checkBoxchildren.Visible = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(913, 204);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(0, 16);
            this.label3.TabIndex = 45;
            this.label3.Visible = false;
            // 
            // checkBoxelectricity
            // 
            this.checkBoxelectricity.AutoSize = true;
            this.checkBoxelectricity.Location = new System.Drawing.Point(919, 200);
            this.checkBoxelectricity.Name = "checkBoxelectricity";
            this.checkBoxelectricity.Size = new System.Drawing.Size(86, 20);
            this.checkBoxelectricity.TabIndex = 46;
            this.checkBoxelectricity.Text = "Electricity";
            this.checkBoxelectricity.UseVisualStyleBackColor = true;
            this.checkBoxelectricity.Visible = false;
            // 
            // checkBoxoffice
            // 
            this.checkBoxoffice.AutoSize = true;
            this.checkBoxoffice.Location = new System.Drawing.Point(1011, 179);
            this.checkBoxoffice.Name = "checkBoxoffice";
            this.checkBoxoffice.Size = new System.Drawing.Size(63, 20);
            this.checkBoxoffice.TabIndex = 47;
            this.checkBoxoffice.Text = "Office";
            this.checkBoxoffice.UseVisualStyleBackColor = true;
            this.checkBoxoffice.Visible = false;
            // 
            // checkBoxclothing
            // 
            this.checkBoxclothing.AutoSize = true;
            this.checkBoxclothing.Location = new System.Drawing.Point(1011, 200);
            this.checkBoxclothing.Name = "checkBoxclothing";
            this.checkBoxclothing.Size = new System.Drawing.Size(77, 20);
            this.checkBoxclothing.TabIndex = 48;
            this.checkBoxclothing.Text = "Clothing";
            this.checkBoxclothing.UseVisualStyleBackColor = true;
            this.checkBoxclothing.Visible = false;
            // 
            // lblspecialpackaging
            // 
            this.lblspecialpackaging.AutoSize = true;
            this.lblspecialpackaging.Location = new System.Drawing.Point(769, 227);
            this.lblspecialpackaging.Name = "lblspecialpackaging";
            this.lblspecialpackaging.Size = new System.Drawing.Size(177, 16);
            this.lblspecialpackaging.TabIndex = 49;
            this.lblspecialpackaging.Text = "Special packaging needed?";
            this.lblspecialpackaging.Visible = false;
            // 
            // checkBoxyes
            // 
            this.checkBoxyes.AutoSize = true;
            this.checkBoxyes.Location = new System.Drawing.Point(963, 227);
            this.checkBoxyes.Name = "checkBoxyes";
            this.checkBoxyes.Size = new System.Drawing.Size(53, 20);
            this.checkBoxyes.TabIndex = 50;
            this.checkBoxyes.Text = "Yes";
            this.checkBoxyes.UseVisualStyleBackColor = true;
            this.checkBoxyes.Visible = false;
            this.checkBoxyes.CheckedChanged += new System.EventHandler(this.checkBoxyes_CheckedChanged);
            // 
            // checkBoxno
            // 
            this.checkBoxno.AutoSize = true;
            this.checkBoxno.Location = new System.Drawing.Point(1037, 227);
            this.checkBoxno.Name = "checkBoxno";
            this.checkBoxno.Size = new System.Drawing.Size(47, 20);
            this.checkBoxno.TabIndex = 51;
            this.checkBoxno.Text = "No";
            this.checkBoxno.UseVisualStyleBackColor = true;
            this.checkBoxno.Visible = false;
            this.checkBoxno.CheckedChanged += new System.EventHandler(this.checkBox2_CheckedChanged);
            // 
            // lblspecialpackagingprice
            // 
            this.lblspecialpackagingprice.AutoSize = true;
            this.lblspecialpackagingprice.Location = new System.Drawing.Point(769, 269);
            this.lblspecialpackagingprice.Name = "lblspecialpackagingprice";
            this.lblspecialpackagingprice.Size = new System.Drawing.Size(188, 16);
            this.lblspecialpackagingprice.TabIndex = 52;
            this.lblspecialpackagingprice.Text = "Enter special packaging price:";
            this.lblspecialpackagingprice.Visible = false;
            // 
            // textBoxpackagingprice
            // 
            this.textBoxpackagingprice.Location = new System.Drawing.Point(974, 266);
            this.textBoxpackagingprice.Name = "textBoxpackagingprice";
            this.textBoxpackagingprice.Size = new System.Drawing.Size(129, 22);
            this.textBoxpackagingprice.TabIndex = 53;
            this.textBoxpackagingprice.Visible = false;
            this.textBoxpackagingprice.TextChanged += new System.EventHandler(this.textBoxpackagingprice_TextChanged);
            // 
            // btnadditemtomerchant
            // 
            this.btnadditemtomerchant.Location = new System.Drawing.Point(849, 307);
            this.btnadditemtomerchant.Name = "btnadditemtomerchant";
            this.btnadditemtomerchant.Size = new System.Drawing.Size(156, 30);
            this.btnadditemtomerchant.TabIndex = 54;
            this.btnadditemtomerchant.Text = "Add item to merchant";
            this.btnadditemtomerchant.UseVisualStyleBackColor = true;
            this.btnadditemtomerchant.Visible = false;
            this.btnadditemtomerchant.Click += new System.EventHandler(this.btnadditemtomerchant_Click);
            // 
            // textBoxmerchantnameitem
            // 
            this.textBoxmerchantnameitem.Location = new System.Drawing.Point(916, 62);
            this.textBoxmerchantnameitem.Name = "textBoxmerchantnameitem";
            this.textBoxmerchantnameitem.Size = new System.Drawing.Size(129, 22);
            this.textBoxmerchantnameitem.TabIndex = 55;
            this.textBoxmerchantnameitem.Visible = false;
            // 
            // textBoxitemname
            // 
            this.textBoxitemname.Location = new System.Drawing.Point(916, 101);
            this.textBoxitemname.Name = "textBoxitemname";
            this.textBoxitemname.Size = new System.Drawing.Size(129, 22);
            this.textBoxitemname.TabIndex = 56;
            this.textBoxitemname.Visible = false;
            // 
            // textBoxitemprice
            // 
            this.textBoxitemprice.Location = new System.Drawing.Point(916, 136);
            this.textBoxitemprice.Name = "textBoxitemprice";
            this.textBoxitemprice.Size = new System.Drawing.Size(129, 22);
            this.textBoxitemprice.TabIndex = 57;
            this.textBoxitemprice.Visible = false;
            // 
            // lblbuyernamecart
            // 
            this.lblbuyernamecart.AutoSize = true;
            this.lblbuyernamecart.Location = new System.Drawing.Point(1108, 65);
            this.lblbuyernamecart.Name = "lblbuyernamecart";
            this.lblbuyernamecart.Size = new System.Drawing.Size(115, 16);
            this.lblbuyernamecart.TabIndex = 58;
            this.lblbuyernamecart.Text = "Enter buyer name:";
            this.lblbuyernamecart.Visible = false;
            // 
            // lblitemnamecart
            // 
            this.lblitemnamecart.AutoSize = true;
            this.lblitemnamecart.Location = new System.Drawing.Point(1108, 104);
            this.lblitemnamecart.Name = "lblitemnamecart";
            this.lblitemnamecart.Size = new System.Drawing.Size(106, 16);
            this.lblitemnamecart.TabIndex = 59;
            this.lblitemnamecart.Text = "Enter item name:";
            this.lblitemnamecart.Visible = false;
            // 
            // lblmerchantnamecart
            // 
            this.lblmerchantnamecart.AutoSize = true;
            this.lblmerchantnamecart.Location = new System.Drawing.Point(1108, 142);
            this.lblmerchantnamecart.Name = "lblmerchantnamecart";
            this.lblmerchantnamecart.Size = new System.Drawing.Size(136, 16);
            this.lblmerchantnamecart.TabIndex = 60;
            this.lblmerchantnamecart.Text = "Enter merchant name:";
            this.lblmerchantnamecart.Visible = false;
            // 
            // textBoxbuyernamecart
            // 
            this.textBoxbuyernamecart.Location = new System.Drawing.Point(1263, 63);
            this.textBoxbuyernamecart.Name = "textBoxbuyernamecart";
            this.textBoxbuyernamecart.Size = new System.Drawing.Size(129, 22);
            this.textBoxbuyernamecart.TabIndex = 61;
            this.textBoxbuyernamecart.Visible = false;
            // 
            // textBoxitemnamecart
            // 
            this.textBoxitemnamecart.Location = new System.Drawing.Point(1263, 101);
            this.textBoxitemnamecart.Name = "textBoxitemnamecart";
            this.textBoxitemnamecart.Size = new System.Drawing.Size(129, 22);
            this.textBoxitemnamecart.TabIndex = 62;
            this.textBoxitemnamecart.Visible = false;
            // 
            // textBoxmerchantnamecart
            // 
            this.textBoxmerchantnamecart.Location = new System.Drawing.Point(1263, 139);
            this.textBoxmerchantnamecart.Name = "textBoxmerchantnamecart";
            this.textBoxmerchantnamecart.Size = new System.Drawing.Size(129, 22);
            this.textBoxmerchantnamecart.TabIndex = 63;
            this.textBoxmerchantnamecart.Visible = false;
            // 
            // btnadditemtobuyer
            // 
            this.btnadditemtobuyer.Location = new System.Drawing.Point(1189, 307);
            this.btnadditemtobuyer.Name = "btnadditemtobuyer";
            this.btnadditemtobuyer.Size = new System.Drawing.Size(145, 30);
            this.btnadditemtobuyer.TabIndex = 64;
            this.btnadditemtobuyer.Text = "Add item to buyer";
            this.btnadditemtobuyer.UseVisualStyleBackColor = true;
            this.btnadditemtobuyer.Visible = false;
            this.btnadditemtobuyer.Click += new System.EventHandler(this.btnadditemtobuyer_Click);
            // 
            // Digital_Store
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.ClientSize = new System.Drawing.Size(1493, 664);
            this.Controls.Add(this.btnadditemtobuyer);
            this.Controls.Add(this.textBoxmerchantnamecart);
            this.Controls.Add(this.textBoxitemnamecart);
            this.Controls.Add(this.textBoxbuyernamecart);
            this.Controls.Add(this.lblmerchantnamecart);
            this.Controls.Add(this.lblitemnamecart);
            this.Controls.Add(this.lblbuyernamecart);
            this.Controls.Add(this.textBoxitemprice);
            this.Controls.Add(this.textBoxitemname);
            this.Controls.Add(this.textBoxmerchantnameitem);
            this.Controls.Add(this.btnadditemtomerchant);
            this.Controls.Add(this.textBoxpackagingprice);
            this.Controls.Add(this.lblspecialpackagingprice);
            this.Controls.Add(this.checkBoxno);
            this.Controls.Add(this.checkBoxyes);
            this.Controls.Add(this.lblspecialpackaging);
            this.Controls.Add(this.checkBoxclothing);
            this.Controls.Add(this.checkBoxoffice);
            this.Controls.Add(this.checkBoxelectricity);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.checkBoxchildren);
            this.Controls.Add(this.lblitemcatagory);
            this.Controls.Add(this.lblitemprice);
            this.Controls.Add(this.lblitemname);
            this.Controls.Add(this.lblmerchantnameforitem);
            this.Controls.Add(this.lblmerchantsdata);
            this.Controls.Add(this.lblbuyersdata);
            this.Controls.Add(this.dataGridViewMerchants);
            this.Controls.Add(this.btnsubmitmerchantdata);
            this.Controls.Add(this.textBoxmerchantname);
            this.Controls.Add(this.textBoxmerchantpassword);
            this.Controls.Add(this.textBoxmerchantcoutrey);
            this.Controls.Add(this.textBoxmerchantcity);
            this.Controls.Add(this.textBoxmerchantstreet);
            this.Controls.Add(this.textBoxmerchantnumber);
            this.Controls.Add(this.lblmerchantnumber);
            this.Controls.Add(this.lblmerchantstreet);
            this.Controls.Add(this.lblmerchantcity);
            this.Controls.Add(this.lblmerchantcoutrey);
            this.Controls.Add(this.lblmerchantpassword);
            this.Controls.Add(this.lblmerchantname);
            this.Controls.Add(this.dataGridViewBuyers);
            this.Controls.Add(this.btnbuyersubmit);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBoxbuyernumber);
            this.Controls.Add(this.textBoxbuyerstreet);
            this.Controls.Add(this.textBoxbuyercity);
            this.Controls.Add(this.lblbuyernumber);
            this.Controls.Add(this.lblbuyerstreet);
            this.Controls.Add(this.lblbuyercity);
            this.Controls.Add(this.textBoxbuyercountry);
            this.Controls.Add(this.textBoxbuyerpassword);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.lblbuyercountery);
            this.Controls.Add(this.lblbuyerpassword);
            this.Controls.Add(this.textBoxbuyername);
            this.Controls.Add(this.lblbuyername);
            this.Controls.Add(this.btnshowmerchantsdata);
            this.Controls.Add(this.btnshowbuyersdata);
            this.Controls.Add(this.btnadditembuyer);
            this.Controls.Add(this.btnadditemmerchant);
            this.Controls.Add(this.btnaddmerchant);
            this.Controls.Add(this.btnaddbuyer);
            this.Name = "Digital_Store";
            this.Text = "Digital Store";
            this.Load += new System.EventHandler(this.Digital_Store_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewBuyers)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewMerchants)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.Button btnaddbuyer;
        private System.Windows.Forms.Button btnaddmerchant;
        private System.Windows.Forms.Button btnadditemmerchant;
        private System.Windows.Forms.Button btnadditembuyer;
        private System.Windows.Forms.Button btnshowbuyersdata;
        private System.Windows.Forms.Button btnshowmerchantsdata;
        private System.Windows.Forms.Label lblbuyername;
        private System.Windows.Forms.TextBox textBoxbuyername;
        private System.Windows.Forms.Label lblbuyerpassword;
        private System.Windows.Forms.Label lblbuyercountery;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBoxbuyerpassword;
        private System.Windows.Forms.TextBox textBoxbuyercountry;
        private System.Windows.Forms.Label lblbuyercity;
        private System.Windows.Forms.Label lblbuyerstreet;
        private System.Windows.Forms.Label lblbuyernumber;
        private System.Windows.Forms.TextBox textBoxbuyercity;
        private System.Windows.Forms.TextBox textBoxbuyerstreet;
        private System.Windows.Forms.TextBox textBoxbuyernumber;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnbuyersubmit;
        private System.Windows.Forms.DataGridView dataGridViewBuyers;
        private System.Windows.Forms.Label lblmerchantname;
        private System.Windows.Forms.Label lblmerchantpassword;
        private System.Windows.Forms.Label lblmerchantcoutrey;
        private System.Windows.Forms.Label lblmerchantcity;
        private System.Windows.Forms.Label lblmerchantstreet;
        private System.Windows.Forms.Label lblmerchantnumber;
        private System.Windows.Forms.TextBox textBoxmerchantnumber;
        private System.Windows.Forms.TextBox textBoxmerchantstreet;
        private System.Windows.Forms.TextBox textBoxmerchantcity;
        private System.Windows.Forms.TextBox textBoxmerchantcoutrey;
        private System.Windows.Forms.TextBox textBoxmerchantpassword;
        private System.Windows.Forms.TextBox textBoxmerchantname;
        private System.Windows.Forms.Button btnsubmitmerchantdata;
        private System.Windows.Forms.DataGridView dataGridViewMerchants;
        private System.Windows.Forms.Label lblbuyersdata;
        private System.Windows.Forms.Label lblmerchantsdata;
        private System.Windows.Forms.Label lblmerchantnameforitem;
        private System.Windows.Forms.Label lblitemname;
        private System.Windows.Forms.Label lblitemprice;
        private System.Windows.Forms.Label lblitemcatagory;
        private System.Windows.Forms.CheckBox checkBoxchildren;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.CheckBox checkBoxelectricity;
        private System.Windows.Forms.CheckBox checkBoxoffice;
        private System.Windows.Forms.CheckBox checkBoxclothing;
        private System.Windows.Forms.Label lblspecialpackaging;
        private System.Windows.Forms.CheckBox checkBoxyes;
        private System.Windows.Forms.CheckBox checkBoxno;
        private System.Windows.Forms.Label lblspecialpackagingprice;
        private System.Windows.Forms.TextBox textBoxpackagingprice;
        private System.Windows.Forms.Button btnadditemtomerchant;
        private System.Windows.Forms.TextBox textBoxmerchantnameitem;
        private System.Windows.Forms.TextBox textBoxitemname;
        private System.Windows.Forms.TextBox textBoxitemprice;
        private System.Windows.Forms.Label lblbuyernamecart;
        private System.Windows.Forms.Label lblitemnamecart;
        private System.Windows.Forms.Label lblmerchantnamecart;
        private System.Windows.Forms.TextBox textBoxbuyernamecart;
        private System.Windows.Forms.TextBox textBoxitemnamecart;
        private System.Windows.Forms.TextBox textBoxmerchantnamecart;
        private System.Windows.Forms.Button btnadditemtobuyer;
    }
}

