using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Final_Exam;

public class PriceChangeLog
{
    public int Product { get; set; }
    public decimal NewPrice { get; set; }
    public DateTime ChangeDate { get; set; }

    public PriceChangeLog(int product, decimal newPrice, DateTime changeDate)
    {
        Product = product;
        NewPrice = newPrice;
        ChangeDate = changeDate;
    }
}