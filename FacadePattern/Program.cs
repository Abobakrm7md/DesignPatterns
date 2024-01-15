using FacadePattern.FacadeInterface;
using FacadePattern.FacadeSubSystem;

PerchaseOrder order = new PerchaseOrder(new StockAvailability(), new PlaceOrder(), new Invoice(), new PaymentService(), new EmailService());
order.RequestOrder(new List<int> { 10});