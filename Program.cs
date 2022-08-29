using Oop_Rehearse;


var orderProcessor = new OrderProcessor(new ShippingCalculator());
var order = new Order
{
    DatePlaced = DateTime.Now,
    TotalPrice = 1f,
    Shipment = new Shipment
    {
        Cost = 100f,
        ShippingDate = DateTime.Now,
    }
};
orderProcessor.Process(order);
