using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WinForm_Werehouse_Management_System.Omar;

//namespace WinForm_admin_module
//{
//    //حتى نحقق مبدأ فصل الواجهة عن التنفيذ interface نستخدم ال
//    public interface IInvoiceService
//    {
//        void Add(Invoice invoice);
//        string GetInvoicesByCustomerName(string customerName);
//    }

//    public class InvoiceService : IInvoiceService
//    {
//        private readonly JsonFileStorage<Invoice> _storage;
//        private List<Invoice> _invoices;

//        public InvoiceService()
//        {
//            // الملف سيتخزن داخل مجلد Data في المشروع
//            _storage = new JsonFileStorage<Invoice>("Invoices.txt");
//            _invoices = _storage.Load();
//        }

//        public void Add(Invoice invoice)
//        {
//            if (invoice == null)
//                throw new ArgumentNullException(nameof(invoice));

//            if (_invoices == null)
//                _invoices = new List<Invoice>();

//            // لو بدك تعطي أرقام تلقائية للفواتير
//            if (invoice.Id == 0)
//            {
//                int nextId = (_invoices.Count == 0) ? 1 : _invoices.Max(i => i.Id) + 1;
//                invoice.Id = nextId;
//            }

//            _invoices.Add(invoice);
//            _storage.Save(_invoices);
//        }

//        public string GetInvoicesByCustomerName(string customerName)
//        {
//            var strb = new StringBuilder();

//            if (string.IsNullOrWhiteSpace(customerName))
//            {
//                strb.AppendLine("يرجى إدخال اسم زبون صحيح.");
//                return strb.ToString();
//            }

//            string term = customerName.Trim();

//            var invoices = _invoices
//                .Where(i =>
//                    !string.IsNullOrWhiteSpace(i.CustomerName) &&
//                    i.CustomerName.Equals(term, StringComparison.OrdinalIgnoreCase))
//                .ToList();

//            if (!invoices.Any())
//            {
//                strb.AppendLine("لا توجد فواتير لهذا الزبون.");
//                return strb.ToString();
//            }

//            strb.AppendLine($"الفواتير الخاصة بالزبون: {term}");
//            strb.AppendLine("================================");

//            foreach (var inv in invoices)
//            {
//                strb.AppendLine($"رقم الفاتورة : {inv.Id}");
//                strb.AppendLine($"التاريخ      : {inv.InvoiceDate.ToShortDateString()}");
//                strb.AppendLine($"المبلغ       : {inv.TotalAmount}");
//                strb.AppendLine("==============================");
//            }

//            return strb.ToString();
//        }
//    }
//}
