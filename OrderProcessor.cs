using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Oop_Rehearse
{
    public class OrderProcessor
    {
        private readonly IShippingCalculator _ShippingCalculator;

        public OrderProcessor (IShippingCalculator shippingCalculator)
        {
            _ShippingCalculator = shippingCalculator;
        }
         public void Process(Order order)
        {
            if (order.IsShipped)
                   throw new InvalidOperationException("This order is already processed. ");
            order.Shipment = new Shipment
            {
                Cost = _ShippingCalculator.CalculateShipping(order),
                ShippingDate = DateTime.Today.AddDays(1)
            };
        }
    }


    public interface IShippingCalculator
    {
        float CalculateShipping(Order order);
    }
    public class ShippingCalculator : IShippingCalculator
    {

        public float CalculateShipping(Order order)
        {
            if (order.TotalPrice < 30f)
            {
                return order.TotalPrice - 0.1f;
            }
            return 0;
        }
    }
    public class Order
    {
        public DateTime _datePlaced;
        public float _totalPrice;
        public int Id { get; set; }
        public float TotalPrice { get; set; }

        public bool IsShipped
        {
            get { return Shipment != null; }
        }
        public DateTime DatePlaced { get; set; }

        public Shipment Shipment { get;set; }
    }
    public class Shipment
    {
        public float Cost { get; set; }
        public DateTime ShippingDate { get; set; }
    }

}