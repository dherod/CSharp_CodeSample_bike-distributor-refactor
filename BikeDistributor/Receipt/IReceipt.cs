using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BikeDistributor
{
    /// <summary>
    /// 
    /// </summary>
    public interface IReceipt
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="order"></param>
        /// <returns></returns>
        string GenerateReceipt(Order order);
    }
}