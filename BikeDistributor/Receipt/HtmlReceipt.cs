using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BikeDistributor
{
    /// <summary>
    /// An HtmlReceipt domain object
    /// </summary>
    public class HtmlReceipt : IReceipt
    {
        /// <summary>
        /// Generate a Receipt for the provided Order
        /// </summary>
        /// <param name="order">The Order for which to generate a Receipt</param>
        /// <returns>A string representing the Receipt</returns>
        public string GenerateReceipt(Order order)
        {
            var totalAmount = 0d;
            IList<Line> lines = order.GetLines();
            var result = new StringBuilder(string.Format("<html><body><h1>Order Receipt for {0}</h1>", order.Company));
            if (lines.Any())
            {
                result.Append("<ul>");
                foreach (var line in lines)
                {
                    var thisAmount = line.Bike.GetAdjustedPrice(line.Quantity);
                    result.Append(string.Format("<li>{0} x {1} {2} = {3}</li>", line.Quantity, line.Bike.Brand, line.Bike.Model, thisAmount.ToString("C")));
                    totalAmount += thisAmount;
                }
                result.Append("</ul>");
            }
            result.Append(string.Format("<h3>Sub-Total: {0}</h3>", totalAmount.ToString("C")));
            var tax = totalAmount * order.TaxRate;
            result.Append(string.Format("<h3>Tax: {0}</h3>", tax.ToString("C")));
            result.Append(string.Format("<h2>Total: {0}</h2>", (totalAmount + tax).ToString("C")));
            result.Append("</body></html>");
            return result.ToString();
        }
    }
}