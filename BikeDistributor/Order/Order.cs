using System.Collections.Generic;

namespace BikeDistributor
{
    /// <summary>
    /// An Order domain object
    /// </summary>
    public class Order
    {
        #region Private Variables

        /// <summary>
        /// The default tax rate
        /// </summary>
        private const double _taxRate = .0725d;

        /// <summary>
        /// The order lines
        /// </summary>
        private readonly IList<Line> _lines = new List<Line>();

        #endregion Private Variables

        #region Constructors

        /// <summary>
        /// Constructs a new instance of the Order class
        /// This uses the default tax rate
        /// </summary>
        /// <param name="company">The company ordering</param>
        public Order(string company) : this(company, _taxRate)
        {}

        /// <summary>
        /// Constructs a new instance of the Order class
        /// </summary>
        /// <param name="company">The company ordering</param>
        /// <param name="taxRate">The tax rate on the order</param>
        public Order(string company, double taxRate)
        {
            Company = company;
            TaxRate = taxRate;
        }

        #endregion Constructors

        #region Public Properties

        /// <summary>
        /// Gets the company
        /// </summary>
        public string Company { get; private set; }

        /// <summary>
        /// Gets the tax rate
        /// </summary>
        public double TaxRate { get; private set; }

        #endregion Public Properties

        #region Public Methods

        /// <summary>
        /// Adds a line to the order
        /// </summary>
        /// <param name="line">The line to be added to the order</param>
        public void AddLine(Line line)
        {
            _lines.Add(line);
        }

        /// <summary>
        /// Gets the lines on the order
        /// </summary>
        /// <returns>The lines on the order</returns>
        public IList<Line> GetLines()
        {
            return _lines;
        }

        /// <summary>
        /// Creates the receipt for the order
        /// </summary>
        /// <param name="type">The type of the receipt to be created</param>
        /// <returns></returns>
        public string CreateReceipt(Receipt type)
        {
            IReceipt receipt = ReceiptSimpleFactory.CreateReceipt(type);
            return receipt.GenerateReceipt(this);
        }

        #endregion Public Methods
    }
}