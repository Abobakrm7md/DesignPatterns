//The Facade design pattern provides a unified interface to a set of interfaces in a subsystem.
//This pattern defines a higher-level interface that makes the subsystem easier to use.

using FacadePattern.FacadeInterface;
using FacadePattern.FacadeSubSystem;

PerchaseOrder order = new PerchaseOrder(new StockAvailability(), new PlaceOrder(), new Invoice(), new PaymentService(), new EmailService());
order.RequestOrder(new List<int> { 10});