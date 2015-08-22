namespace BikeDistributor
{
    /// <summary>
    /// The interface common to all Receipt domain objects
    /// </summary>
    public interface IReceipt
    {
        /// <summary>
        /// Method to generate a Receipt for the provided Order
        /// </summary>
        /// <param name="order">The Order for which to generate a Receipt</param>
        /// <returns>A string representing the Receipt</returns>
        string GenerateReceipt(Order order);
    }
}