namespace BikeDistributor
{
    /// <summary>
    /// A Line domain object
    /// This represents Lines on an Order
    /// </summary>
    public class Line
    {
        #region Constructors

        /// <summary>
        /// Constructs a new instance of the Line class
        /// </summary>
        /// <param name="bike">The bike on the order line</param>
        /// <param name="quantity">The quantity on the order line</param>
        public Line(Bike bike, int quantity)
        {
            Bike = bike;
            Quantity = quantity;
        }

        #endregion Constructors

        #region Public Properties

        /// <summary>
        /// Gets the bike
        /// </summary>
        public Bike Bike { get; private set; }
        /// <summary>
        /// Gets the quantity
        /// </summary>
        public int Quantity { get; private set; }

        #endregion Public Properties
    }
}