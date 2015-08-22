﻿using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace BikeDistributor.Test
{
    [TestClass]
    public class OrderTest
    {
        private readonly static Bike Defy = new Bike("Giant", "Defy 1", 1000, 20, 10);
        private readonly static Bike Elite = new Bike("Specialized", "Venge Elite", 2000, 10, 20);
        private readonly static Bike DuraAce = new Bike("Specialized", "S-Works Venge Dura-Ace", 5000, 5, 20);

        // "Madone is the ultimate fusion of power, aerodynamics, ride quality, and integration. 
        // There are no two ways about it: the first true superbike is a marvel of road bike engineering."
        private readonly static Bike Madone = new Bike("Trek", "Madone", 4499.99, 5, 15);

        [TestMethod]
        public void ReceiptTenMadoneDefaultTaxRate()
        {
            // Use default tax rate
            var order = new Order("Rolling Thunder Cycles");
            order.AddLine(new Line(Madone, 10));
            string temp = order.CreateReceipt(Receipt.Text);
            Assert.AreEqual(ResultStatementTenMadoneDefaultTaxRate, order.CreateReceipt(Receipt.Text));
        }

        private const string ResultStatementTenMadoneDefaultTaxRate = @"Order Receipt for Rolling Thunder Cycles
	10 x Trek Madone = $38,249.92
Sub-Total: $38,249.92
Tax: $2,773.12
Total: $41,023.03";

        [TestMethod]
        public void ReceiptTenMadoneSetTaxRate()
        {
            // Set custom tax rate
            var order = new Order("Rolling Thunder Cycles", 0.1d);
            order.AddLine(new Line(Madone, 10));
            string temp = order.CreateReceipt(Receipt.Text);
            Assert.AreEqual(ResultStatementTenMadoneCustomTaxRate, order.CreateReceipt(Receipt.Text));
        }

        private const string ResultStatementTenMadoneCustomTaxRate = @"Order Receipt for Rolling Thunder Cycles
	10 x Trek Madone = $38,249.92
Sub-Total: $38,249.92
Tax: $3,824.99
Total: $42,074.91";

        [TestMethod]
        public void ReceiptOneDefy()
        {
            var order = new Order("Anywhere Bike Shop");
            order.AddLine(new Line(Defy, 1));
            Assert.AreEqual(ResultStatementOneDefy, order.CreateReceipt(Receipt.Text));
        }

        private const string ResultStatementOneDefy = @"Order Receipt for Anywhere Bike Shop
	1 x Giant Defy 1 = $1,000.00
Sub-Total: $1,000.00
Tax: $72.50
Total: $1,072.50";

        [TestMethod]
        public void ReceiptOneElite()
        {
            var order = new Order("Anywhere Bike Shop");
            order.AddLine(new Line(Elite, 1));
            Assert.AreEqual(ResultStatementOneElite, order.CreateReceipt(Receipt.Text));
        }

        private const string ResultStatementOneElite = @"Order Receipt for Anywhere Bike Shop
	1 x Specialized Venge Elite = $2,000.00
Sub-Total: $2,000.00
Tax: $145.00
Total: $2,145.00";

        [TestMethod]
        public void ReceiptOneDuraAce()
        {
            var order = new Order("Anywhere Bike Shop");
            order.AddLine(new Line(DuraAce, 1));
            Assert.AreEqual(ResultStatementOneDuraAce, order.CreateReceipt(Receipt.Text));
        }

        private const string ResultStatementOneDuraAce = @"Order Receipt for Anywhere Bike Shop
	1 x Specialized S-Works Venge Dura-Ace = $5,000.00
Sub-Total: $5,000.00
Tax: $362.50
Total: $5,362.50";

        [TestMethod]
        public void HtmlReceiptOneDefy()
        {
            var order = new Order("Anywhere Bike Shop");
            order.AddLine(new Line(Defy, 1));
            Assert.AreEqual(HtmlResultStatementOneDefy, order.CreateReceipt(Receipt.Html));
        }

        private const string HtmlResultStatementOneDefy = @"<html><body><h1>Order Receipt for Anywhere Bike Shop</h1><ul><li>1 x Giant Defy 1 = $1,000.00</li></ul><h3>Sub-Total: $1,000.00</h3><h3>Tax: $72.50</h3><h2>Total: $1,072.50</h2></body></html>";

        [TestMethod]
        public void HtmlReceiptOneElite()
        {
            var order = new Order("Anywhere Bike Shop");
            order.AddLine(new Line(Elite, 1));
            Assert.AreEqual(HtmlResultStatementOneElite, order.CreateReceipt(Receipt.Html));
        }

        private const string HtmlResultStatementOneElite = @"<html><body><h1>Order Receipt for Anywhere Bike Shop</h1><ul><li>1 x Specialized Venge Elite = $2,000.00</li></ul><h3>Sub-Total: $2,000.00</h3><h3>Tax: $145.00</h3><h2>Total: $2,145.00</h2></body></html>";

        [TestMethod]
        public void HtmlReceiptOneDuraAce()
        {
            var order = new Order("Anywhere Bike Shop");
            order.AddLine(new Line(DuraAce, 1));
            Assert.AreEqual(HtmlResultStatementOneDuraAce, order.CreateReceipt(Receipt.Html));
        }

        private const string HtmlResultStatementOneDuraAce = @"<html><body><h1>Order Receipt for Anywhere Bike Shop</h1><ul><li>1 x Specialized S-Works Venge Dura-Ace = $5,000.00</li></ul><h3>Sub-Total: $5,000.00</h3><h3>Tax: $362.50</h3><h2>Total: $5,362.50</h2></body></html>";    
    }
}