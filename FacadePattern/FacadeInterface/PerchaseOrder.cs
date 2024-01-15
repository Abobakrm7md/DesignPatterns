using FacadePattern.FacadeSubSystem;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FacadePattern.FacadeInterface
{
    public class PerchaseOrder
    {

        public PerchaseOrder(StockAvailability stockAvailability, PlaceOrder placeOrder, Invoice invoice, PaymentService paymentService, EmailService emailService)
        {
            this.stockAvailability = stockAvailability;
            this.placeOrder = placeOrder;
            this.invoice = invoice;
            this.paymentService = paymentService;
            this.emailService = emailService;
        }
        private StockAvailability stockAvailability;
        private PlaceOrder placeOrder;
        private Invoice invoice;
        private PaymentService  paymentService;
        private EmailService emailService;
        public void RequestOrder(List<int> ids)
        {
            var prod = stockAvailability.CheckAvailablityAndGetProducts(ids);
            if(prod.Count<=0)
            { Console.WriteLine("product not found"); return; }
            placeOrder.Place();
            invoice.CreateInvoice(prod);
            paymentService.OrderPaid();
            emailService.Send();
        }
    }
}
