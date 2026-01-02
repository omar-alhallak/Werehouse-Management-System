using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using WinForm_Werehouse_Management_System.Omar;

namespace WinForm_Werehouse_Management_System
{
    public interface IInvoiceService
    {
        void Add(Invoice invoice);
        bool DeleteInvoice(string invoiceId);
        string GetInvoicesByCustomerName(string customerName);
    }

    public class InvoiceService : IInvoiceService
    {
        private readonly JsonFileStorage<Invoice> storage;
        private List<Invoice> invoices;

        public InvoiceService()
        {
            storage = new JsonFileStorage<Invoice>("invoices.txt");
            invoices = storage.Load();
        }

        public void Add(Invoice invoice)
        {
            if (invoice == null)
                throw new ArgumentNullException(nameof(invoice));

            // لا نغيّر الـ Id إطلاقًا — الكيان نفسه يولّده
            invoices.Add(invoice);
            storage.Save(invoices);
        }

        public bool DeleteInvoice(string invoiceId)
        {
            var inv = invoices.FirstOrDefault(i => i.Id == invoiceId);

            if (inv == null)
                return false;

            invoices.Remove(inv);
            storage.Save(invoices);
            return true;
        }

        public string GetInvoicesByCustomerName(string customerName)
        {
            var sb = new StringBuilder();

            if (string.IsNullOrWhiteSpace(customerName))
            {
                sb.AppendLine("يرجى إدخال اسم زبون صحيح.");
                return sb.ToString();
            }

            var result = invoices
                .Where(i => i.CustomerName.Equals(customerName, StringComparison.OrdinalIgnoreCase))
                .ToList();

            if (!result.Any())
            {
                sb.AppendLine("لا توجد فواتير لهذا الزبون.");
                return sb.ToString();
            }

            foreach (var inv in result)
            {
                sb.AppendLine($"رقم الفاتورة : {inv.Id}");
                sb.AppendLine($"التاريخ      : {inv.InvoiceDate.ToShortDateString()}");
                sb.AppendLine($"المبلغ       : {inv.TotalAmount}");
                sb.AppendLine("--------------------------------");
            }

            return sb.ToString();
        }
    }
}