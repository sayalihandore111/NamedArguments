using System;

namespace NamedArgsDemo
{
    class Orders
    {
        public void orderDet(int orderNum, string sellerName, string productName)
        {
            Console.WriteLine("{0}\t\t{1}\t\t{2}", orderNum, sellerName, productName);
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Order No.\tSeller Name\tProduct Name");
            Console.WriteLine("------------------------------------------------------");
            Orders o = new Orders();
            o.orderDet(sellerName: "Swapnil", orderNum: 1, productName: "Solar Panels");
            new Orders().orderDet(sellerName: "ABC", orderNum: 2, productName: "STQ");
            new Orders().orderDet(orderNum: 3, sellerName: "PQR", productName: "XYZ");
        }
    }
}