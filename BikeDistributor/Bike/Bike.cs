namespace BikeDistributor
{
    /// <summary>
    /// 
    /// </summary>
    public class Bike
    {
        #region Constructors

        /// <summary>
        /// 
        /// </summary>
        /// <param name="brand"></param>
        /// <param name="model"></param>
        /// <param name="price"></param>
        /// <param name="discountCode"></param>
        /// <param name="percentageOff"></param>
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
        /// 
        /// </summary>
        public string Brand { get; private set; }
        /// <summary>
        /// 
        /// </summary>
        public string Model { get; private set; }
        /// <summary>
        /// 
        /// </summary>
        public double Price { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public int DiscountCode { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public double PercentageOff { get; set; }

        #endregion Public Properties

        #region Public Methods

        /// <summary>
        /// 
        /// </summary>
        /// <param name="quantity"></param>
        /// <returns></returns>
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