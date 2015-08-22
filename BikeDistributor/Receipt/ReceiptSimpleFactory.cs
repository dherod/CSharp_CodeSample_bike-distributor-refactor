using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BikeDistributor
{
    /// <summary>
    /// 
    /// </summary>
    public enum Receipt
    {
        Text,
        Html
    }

    /// <summary>
    /// 
    /// </summary>
    public class ReceiptSimpleFactory
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="type"></param>
        /// <returns></returns>
        public static IReceipt CreateReceipt(Receipt type)
        {
            IReceipt receipt;
            switch (type)
            {
                case Receipt.Text:
                    receipt = new TextReceipt();
                    break;

                case Receipt.Html:
                    receipt = new HtmlReceipt();
                    break;

                default:
                    receipt = null;
                    break;
            }
            return receipt;
        }
    }
}