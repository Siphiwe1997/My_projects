using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.VisualBasic;

namespace Stock_v2
{
    public partial class CfmStockList : Form
    {
        List<CItems> lststock;
        CItems items;
        public CfmStockList()
        {
            InitializeComponent();
            lststock = new List<CItems>();
        }

        void ClearFields()
        {
            txtItemCode.Text = txtItemName.Text = txtCostPrice.Text = txtRetailPrice.Text = txtQuantity.Text = "";
            txtItemCode.Focus();
        }
        private void btnAddItem_Click(object sender, EventArgs e)
        {
            try
            {
                items = new CItems(txtItemCode.Text, txtItemName.Text, decimal.Parse(txtCostPrice.Text), decimal.Parse(txtRetailPrice.Text), int.Parse(txtQuantity.Text));
                lststock.Add(items);
                MessageBox.Show("Item added successfully.");
                ClearFields();
            }
            catch
            {
                MessageBox.Show(CItems.Instructions());
            }
            
        }

        private void btnListItems_Click(object sender, EventArgs e)
        {
            if (radItemCode.Checked)
                lststock.Sort(CompareByItemCode);
            if (radItemName.Checked)
                lststock.Sort(CompareByItemName);
            if (radItemPrice.Checked)
                lststock.Sort(CompareByRetailPrice);


            string sMsg = "ItemCode  ItemName  CostPrice  RetailPrice  Quantity" + "\n==================================\n";
            foreach(CItems item in lststock)
            {
                sMsg += item.ItemCode + "\t  " + item.ItemName + "\t     " + item.CostPrice + "\t      " + item.RetailPrice + "\t\t  " + item.Quantity + "\n";
            }
            MessageBox.Show(sMsg, "STOCK LIST");
        }

        private CItems GetItem(string _sItemCode)
        {
            return lststock.Find(i => i.ItemCode == _sItemCode);
        }

        private void btnRemoveItem_Click(object sender, EventArgs e)
        {
            string sItemCode = Interaction.InputBox("Enter Item Code to remove", "REMOVE ITEM");
            CItems item = GetItem(sItemCode);

            if(item != null)
            {
                if(MessageBox.Show("Are you sure you want to remove item?","Confirmation",MessageBoxButtons.YesNo,MessageBoxIcon.Warning)==DialogResult.Yes)
                {
                    lststock.Remove(item);
                    MessageBox.Show("Item removed successfully.");
                }

            }
            else
            {
                MessageBox.Show("Item not found", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnMarkUp_Click(object sender, EventArgs e)
        {
            CItems.Markup = double.Parse(Interaction.InputBox("Please enter a markup as %: ", "MARKUP", CItems.Markup.ToString("0.0")));
            MessageBox.Show("Markup has been set to" + CItems.Markup.ToString("0.0") + "%");
        }

        private void btnSetRetailPrice_Click(object sender, EventArgs e)
        {
            foreach(CItems item in lststock)
            {
                item.SetRetailPrice();
                MessageBox.Show("Retail price has been set");
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSale_Click(object sender, EventArgs e)
        {
            string sItemCode = Interaction.InputBox("Item code of item to be sold.");
            CItems item = GetItem(sItemCode);

            if(item != null)
            {
                if (item.Sale())
                    MessageBox.Show("Item was sold.");
                else
                    MessageBox.Show("Out of stock");
            }
            else
            {
                MessageBox.Show("Item is not available.");
            }
        }
        private int CompareByItemCode(CItems _item1, CItems _item2)
        {
            return string.Compare(_item1.ItemCode, _item2.ItemCode);
        }
        
        private int CompareByItemName(CItems _item1, CItems _item2)
        {
            return string.Compare(_item1.ItemName, _item2.ItemName);
        }
        private int CompareByRetailPrice(CItems _item1, CItems _item2)
        {
            if (_item1.RetailPrice > _item2.RetailPrice)
                return 1;
            else if (_item1.RetailPrice < _item2.RetailPrice)
                return -1;
            else
                return 0;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {


            digSave.InitialDirectory = Application.StartupPath;
            digSave.FileName = "StockList.csv";
            digSave.OverwritePrompt = false;

            if (digSave.ShowDialog() == DialogResult.OK)
            {
                StreamWriter sw = new StreamWriter(digSave.FileName, false);
                foreach(CItems items in lststock)
                {
                    sw.Write(items.ItemName);
                    sw.Write(items.ItemCode);
                    sw.Write(items.Quantity);
                    sw.Write(items.RetailPrice);
                    sw.Write(items.CostPrice);
                }
                sw.Close();
            }


            //digSave.InitialDirectory = Application.StartupPath;
            //digSave.FileName = "StockList.bin";
            //digSave.OverwritePrompt = false;
            //if (digSave.ShowDialog() == DialogResult.OK)
            //{
            //    FileStream fs = new FileStream(digSave.FileName, FileMode.Create);
            //    IFormatter bf = new BinaryFormatter();
            //    bf.Serialize(fs, lststock);
            //    fs.Close();
            //}



            //if(digSave.ShowDialog()==DialogResult.OK)
            //{
            //    try
            //    {
            //        items.Save(digSave.FileName);
            //    }
            //    catch(Exception x)
            //    {
            //        MessageBox.Show(x.Message);
            //    }
            //}
        }

        private void btnRead_Click(object sender, EventArgs e)
        {
            digOpen.InitialDirectory = Application.StartupPath;
            digOpen.FileName = "StockList.csv";

            if (digOpen.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    StreamReader sr = new StreamReader(digOpen.FileName);
                    while(!sr.EndOfStream)
                    {
                        string[] sLine = sr.ReadLine().Split(',');
  
                    }
                    sr.Close();


                    //FileStream fs = new FileStream(digOpen.FileName, FileMode.Open);
                    //IFormatter bf = new BinaryFormatter();
                    //lststock =(List<CItems>) bf.Deserialize(fs);
                    //fs.Close();
                }
                catch (Exception x)
                {
                    MessageBox.Show(x.Message);
                }
            }


                /*if(digOpen.ShowDialog()==DialogResult.OK)
                {
                    try
                    {
                       items = CItems.Read(digOpen.FileName);
                    }
                    catch(Exception x)
                    {
                        MessageBox.Show(x.Message);
                    }
                }
                txtCostPrice.Text = items.CostPrice.ToString();
                txtItemCode.Text = items.ItemCode;
                txtRetailPrice.Text = items.RetailPrice.ToString();
                txtQuantity.Text = items.Quantity.ToString();
                txtItemName.Text = items.ItemName;
                */

            }
    }
}
