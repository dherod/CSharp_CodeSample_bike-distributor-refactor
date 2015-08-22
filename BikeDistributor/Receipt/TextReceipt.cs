using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BikeDistributor
{
    /// <summary>
    /// A TextReceipt domain object
    /// </summary>
    public class TextReceipt : IReceipt
    {
        /// <summary>
        /// Generate a Receipt for the provided Order
        /// </summary>
        /// <param name="order">The Order for which to generate a Receipt</param>
        /// <returns>A string representing the Receipt</returns>
        public string GenerateReceipt(Order order)
        {
            var totalAmount = 0d;
            var result = new StringBuilder(string.Format("Order Receipt for {0}{1}", order.Company, Environment.NewLine));
            foreach (var line in order.GetLines())
            {
                var thisAmount = line.Bike.GetAdjustedPrice(line.Quantity);
                result.AppendLine(string.Format("\t{0} x {1} {2} = {3}", line.Quantity, line.Bike.Brand, line.Bike.Model, thisAmount.ToString("C")));
                totalAmount += thisAmount;
            }
            result.AppendLine(string.Format("Sub-Total: {0}", totalAmount.ToString("C")));
            var tax = totalAmount * order.TaxRate;
            result.AppendLine(string.Format("Tax: {0}", tax.ToString("C")));
            result.Append(string.Format("Total: {0}", (totalAmount + tax).ToString("C")));
            return result.ToString();
        }
    }
}