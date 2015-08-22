using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BikeDistributor
{
    /// <summary>
    /// 
    /// </summary>
    public class Order
    {
        #region Private Variables

        /// <summary>
        /// 
        /// </summary>
        private const double _taxRate = .0725d;

        /// <summary>
        /// 
        /// </summary>
        private readonly IList<Line> _lines = new List<Line>();

        #endregion Private Variables

        #region Constructors

        /// <summary>
        /// 
        /// </summary>
        /// <param name="company"></param>
        public Order(string company) : this(company, _taxRate)
        { }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="company"></param>
        public Order(string company, double taxRate)
        {
            Company = company;
            TaxRate = taxRate;
        }

        #endregion Constructors

        #region Public Properties

        /// <summary>
        /// 
        /// </summary>
        public string Company { get; private set; }

        /// <summary>
        /// 
        /// </summary>
        public double TaxRate { get; private set; }

        #endregion Public Properties

        #region Public Methods

        /// <summary>
        /// 
        /// </summary>
        /// <param name="line"></param>
        public void AddLine(Line line)
        {
            _lines.Add(line);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public IList<Line> GetLines()
        {
            return _lines;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="type"></param>
        /// <returns></returns>
        public string CreateReceipt(Receipt type)
        {
            IReceipt receipt = ReceiptSimpleFactory.CreateReceipt(type);
            return receipt.GenerateReceipt(this);
        }

        #endregion Public Methods
    }
}