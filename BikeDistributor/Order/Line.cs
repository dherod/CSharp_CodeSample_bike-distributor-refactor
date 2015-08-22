namespace BikeDistributor
{
    /// <summary>
    /// 
    /// </summary>
    public class Line
    {
        #region Constructors

        /// <summary>
        /// 
        /// </summary>
        /// <param name="bike"></param>
        /// <param name="quantity"></param>
        public Line(Bike bike, int quantity)
        {
            Bike = bike;
            Quantity = quantity;
        }

        #endregion Constructors

        #region Public Properties

        /// <summary>
        /// 
        /// </summary>
        public Bike Bike { get; private set; }
        /// <summary>
        /// 
        /// </summary>
        public int Quantity { get; private set; }

        #endregion Public Properties
    }
}