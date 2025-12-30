using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinForm_sales_module
{
    //حتى نحقق مبدأ فصل الواجهة عن التنفيذ interface نستخدم ال
    public interface IInvoiceService
    {
        void Add(Invoice invoice);
        string GetInvoicesByCustomerName(string customerName);
        
    }

    public class InvoiceService : IInvoiceService
    {

        private List<Invoice> Invoices;

        public InvoiceService()
        {
            Invoices = ExternalStorage.Load<List<Invoice>>("invoices.json");
        }
        public void Add(Invoice invoice)
        {
            Invoices.Add(invoice);
            ExternalStorage.Save("invoices.json", Invoices);
        }


        // ميثود تبحث عن جميع الفواتير الخاصة بزبون محدد
        public string GetInvoicesByCustomerName(string customerName)
        {
            StringBuilder strb = new StringBuilder();
            // invoices وضع الفواتير الخاصة بلزيون المدخل اسمه داخل متحول 
            var invoices = Invoices
                .Where(i => i.CustomerName.Equals(customerName)).ToList();
            // في حال عدم وجود فواتير للزبون
            if (!invoices.Any())
            {
                strb.AppendLine("لا توجد فواتير لهذا الزبون.");
                return strb.ToString();
            }
            // عرض اسم الزبون و الفواتير الخاصة به
            strb.AppendLine($" {customerName} :الفواتير الخاصة بالزبون");
            strb.AppendLine("================================");

            foreach (var inv in invoices)
            {
                strb.AppendLine($"  رقم الفاتورة :           { inv.Id}");
                strb.AppendLine($"التاريخ :{inv.InvoiceDate.ToShortDateString()}");
                strb.AppendLine($"  المبلغ :       {inv.TotalAmount}");
                strb.AppendLine("==========================");
            }

            return strb.ToString();
        }
    }
}
