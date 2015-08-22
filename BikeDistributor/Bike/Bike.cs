namespace BikeDistributor
{
    /// <summary>
    /// A Bike domain object
    /// </summary>
    public class Bike
    {
        #region Constructors

        /// <summary>
        /// Constructs a new instance of the Bike class
        /// </summary>
        /// <param name="brand">The bike brand</param>
        /// <param name="model">The bike model</param>
        /// <param name="price">The bike price</param>
        /// <param name="discountCode">The threshold for the discount</param>
        /// <param name="percentageOff">The percentage off for the discount</param>
        public Bike(string brand, string model, double price, int discountCode, double percentageOff)
        {
            Brand = brand;
            Model = model;
            Price = price;
            DiscountCode = discountCode;
            PercentageOff = percentageOff;
        }

        #endregion Constructors

        #region Public Properties

        /// <summary>
        /// Gets the brand
        /// </summary>
        public string Brand { get; private set; }
        /// <summary>
        /// Gets the model
        /// </summary>
        public string Model { get; private set; }
        /// <summary>
        /// Gets or Sets the price
        /// </summary>
        public double Price { get; set; }
        /// <summary>
        /// Gets or  Sets the discount count
        /// </summary>
        public int DiscountCode { get; set; }
        /// <summary>
        /// Gets or Sets the percentage off
        /// </summary>
        public double PercentageOff { get; set; }

        #endregion Public Properties

        #region Public Methods

        /// <summary>
        /// Calculates the price of the bike adjusted for discounts based on quantity, etc.
        /// </summary>
        /// <param name="quantity"></param>
        /// <returns>The adjusted price of the bike</returns>
        public double GetAdjustedPrice(int quantity)
        {
            double percentageOff = 0;
            if (quantity >= DiscountCode)
            {
                percentageOff = PercentageOff;
            }
            return quantity * Price * (100 - percentageOff) / 100;
        }

        #endregion Public Methods
    }
}