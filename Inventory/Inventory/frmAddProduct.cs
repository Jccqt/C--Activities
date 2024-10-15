using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Inventory
{
    public partial class frmAddProduct : Form
    {
        private int _Quantity;
        private double _SellPrice;
        private string _ProductName, _Category, _MfgDate, _ExpDate, _Description;
        bool isProductName = false, isQuantity = false, isSellPrice = false;

        BindingSource showProductList;

        private void frmAddProduct_Load(object sender, EventArgs e)
        {
            string[] ListOfProductCategory = { "Beverages", "Bread/Bakery", "Canned/Jarred Goods", 
                                            "Dairy", "Frozen Goods", "Meat", "Personal Care", "Other"};

            foreach(string productCategory in ListOfProductCategory)
            {
                cbCategory.Items.Add(productCategory);
            }
        }

        private void btnAddProduct_Click(object sender, EventArgs e)
        {
            try
            {
                _ProductName = Product_Name(txtProductName.Text);
                _Quantity = Quantity(txtQuantity.Text);
                _SellPrice = SellingPrice(txtSellPrice.Text);
            }
            catch(NumberFormatException NF)
            {
                MessageBox.Show(NF.Message);
            }
            catch(StringFormatException SF)
            {
                MessageBox.Show(SF.Message);
            }
            catch(CurrencyFormatException CF)
            {
                MessageBox.Show(CF.Message);
            }
            finally
            {
                _Category = cbCategory.Text;
                _MfgDate = dtPickerMfgDate.Value.ToString("yyyy-MM-dd");
                _ExpDate = dtPickerExpDate.Value.ToString("yyyy-MM-dd");
                _Description = richTxtDescription.Text;
            }

            // will add the product to the grid view if they dont throw exception
            if(isProductName && isQuantity && isSellPrice)
            {
                showProductList.Add(new ProductClass(_ProductName, _Category, _MfgDate, _ExpDate,
                        _SellPrice, _Quantity, _Description));
                gridViewProductList.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                gridViewProductList.DataSource = showProductList;
            }
        }

        public string Product_Name(string name)
        {
            if (!Regex.IsMatch(name, @"^[a-z A-Z]+$"))
            {
                isProductName = false;
                throw new StringFormatException("Invalid input for Product Name!");
            }
            else
            {
                isProductName = true;
                return name;
            }   
        }
        public int Quantity(string qty)
        {
            if (!Regex.IsMatch(qty, @"^[0-9]"))
            {
                isQuantity = false;
                throw new NumberFormatException("Invalid input for Quantity!");
            }
            else
            {
                isQuantity = true;
                return Convert.ToInt32(qty);
            }  
        }

        public double SellingPrice(string price)
        {
            if (!Regex.IsMatch(price.ToString(), @"^(\d*\.)?\d+$"))
            {
                isSellPrice = false;
                throw new CurrencyFormatException("Invalid input for Currency!");
            }
            else
            {
                isSellPrice = true;
                return Convert.ToDouble(price);
            }
        }

        public frmAddProduct()
        {
            InitializeComponent();
            showProductList = new BindingSource();
        }
    }
}
