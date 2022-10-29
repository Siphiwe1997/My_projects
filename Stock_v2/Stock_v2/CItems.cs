using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Runtime.Serialization.Formatters;
using System.Runtime.Serialization.Formatters.Binary;
using System.Runtime.Serialization;
using System.Windows.Forms;

namespace Stock_v2
{
    [Serializable]
    class CItems
    {
        #region Constractor
        public CItems(string _sItemCode, string _sItemName, decimal _mCostPrice, decimal _mRetailPrice, int _iQuantity)
        {
            ItemCode = _sItemCode;
            ItemName = _sItemName;
            CostPrice = _mCostPrice;
            RetailPrice = _mRetailPrice;
            Quantity = _iQuantity;
        }
        #endregion Constractor

        #region Private Members
        private string sItemCode, sItemName;
        private decimal mCostPrice, mRetailPrice;
        private int iQuantity;
        #endregion Private Members

        #region Propaties
        public string ItemCode
        {
            get
            {
                return sItemCode;
            }
            set
            {
                sItemCode = value;
            }
        }

        public string ItemName { get => sItemName; set => sItemName = value; }
        public decimal CostPrice { get => mCostPrice; set => mCostPrice = value; }
        public decimal RetailPrice
        {
            get
            {
                return mRetailPrice;
            }
            set
            {
                if (value > mCostPrice)
                    mRetailPrice = mCostPrice;
                else
                    mRetailPrice = value;
            }
        }

        public int Quantity { get => iQuantity; set => iQuantity = value; }
        #endregion Propaties

        #region Methods
        public static string Instructions()
        {
            return "Enter reasonable value in all text boxies\n " +
                   "Enter non negative value";
        }
        public static double Markup;
        public void SetRetailPrice()
        {
            RetailPrice = CostPrice - CostPrice * (decimal)Markup/100;
        }
        public bool Sale()
        {
            if (Quantity > 0)
            {
                Quantity--;
                return true;
            }
            else
                return false;

        }
        public void Save(string _sFileName)
        {
            FileStream fs = new FileStream(_sFileName, FileMode.Create);
            IFormatter bf = new BinaryFormatter();
            bf.Serialize(fs, this);
            fs.Close();
            MessageBox.Show("Stock saved successfully.");
        }

        public static CItems Read(string _sFileName)
        {
            FileStream fs = new FileStream(_sFileName, FileMode.Open);
            IFormatter bf = new BinaryFormatter();
            CItems item = (CItems)bf.Deserialize(fs);
            fs.Close();
            MessageBox.Show("Stock read successfully");
            return item;

            #endregion Methods
        }
    }

}
