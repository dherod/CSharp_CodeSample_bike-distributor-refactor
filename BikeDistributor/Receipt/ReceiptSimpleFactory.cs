namespace BikeDistributor
{
    /// NOTE: To add more Receipt types do the following
    ///     1. Create a Receipt class similar to TextReceipt and HtmlReceipt
    ///     2. Add to Receipt enum
    ///     3. Add to ReceiptSimpleFactory.CreateReceipt()
    
    /// <summary>
    /// The supported Receipt types
    /// </summary>
    public enum Receipt
    {
        Text,
        Html
    }

    /// <summary>
    /// A class that returns a concrete Receipt based upon the specified type
    /// This implements the Simple Factory design idiom
    /// </summary>
    public class ReceiptSimpleFactory
    {
        /// <summary>
        /// Creates a concrete Receipt based upon requested type
        /// </summary>
        /// <param name="type">The type of the Receipt to create</param>
        /// <returns>The concrete Receipt</returns>
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