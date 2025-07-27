using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POS02_For_Restuarent.ExternalClasses
{
    public class Public_Items
    {
        /// <summary>
        /// Part 01 
        /// </summary>
        public static string ItemNames = "";// used to retrieve and display item name in tbx

        // list for non-barcode item names
        public static List<string> non_barcodeItem_Names = new List<string>();

        // list for non-barcode item price (one item)
        public static List<double> non_barcodeItem_Price = new List<double>();

        // list for non-barcode item qty
        public static List<int> non_barcodeItem_qty = new List<int>();

        //list of non barcode item amount (use in bill)
        public static List<double> Amount = new List<double>();

       
        /// <summary>
        /// part 02 || Barcode items 
        /// </summary>
        public static List<string> barcode_item_names = new List<string>();
        public static List<double> barcode = new List<double>();
        public static List<double> barcode_Item_price = new List<double>();
        //public static List<double> total_price_of_barcodeItems = new List<double>();
        
        // Use to store barcode Item name and qty that use to print bill
        public static Dictionary<string,int> Barcode_item_name_and_qty = new Dictionary<string,int>();

        /// <summary>
        /// Part 03
        /// </summary>

        // This is used to store the permanet values || values that use for printing bill
        public static List<double> barcode_item_prices_02 = new List<double>(); //(In used)

        /// Global variable that use for remove barcode items (idex of selected item name need to remove)
        public static int Globale_index_of_selected_itemBarcode = 0;



        // This variable used to store the selected barcode item from main form that need to delete
        public static string barcodeItemThatSelectedToRemove = "";

    }
}
