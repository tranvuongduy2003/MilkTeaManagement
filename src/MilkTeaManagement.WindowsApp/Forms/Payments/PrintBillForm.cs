using MailKit.Search;
using MilkTeaManagement.Domain.Entities;
using MilkTeaManagement.WindowsApp.Helpers;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Printing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MilkTeaManagement.WindowsApp.Forms.Payments
{
    public partial class PrintBillForm : Form
    {
        private List<OrderItem> OrderItems;

        public PrintBillForm(Order order, List<OrderItem> orderItems)
        {
            InitializeComponent();

            lbDate.Text = order.CreatedDate.ToString("dd/MM/yyyy");
            lbCustomerPhone.Text = order.CustomerPhone;

            lbDiscount.Text = (int)(order.Discount * 100) + "%";
            lbTotal.Text = ConvertCurrency.ToVND(order.TotalPrice);

            var total = order.TotalPrice;
            int discountPercent = (int)(order.Discount * 100);
            var subTotal = total / (1 - (decimal)discountPercent / 100);
            lbSubTotal.Text = ConvertCurrency.ToVND(subTotal);

            OrderItems = orderItems;
            LoadOrderItems();
        }

        private void LoadOrderItems()
        {
            BillTable.Rows.Clear();
            if (OrderItems.Count > 0)
            {
                BillTable.Rows.Add(OrderItems.Count);
                for (int index = 0; index < OrderItems.Count; index++)
                {
                    var orderItems = OrderItems[index];
                    BillTable.Rows[index].Cells["TT"].Value = index + 1;
                    BillTable.Rows[index].Cells["ProductName"].Value = orderItems.Product.Name;
                    BillTable.Rows[index].Cells["SL"].Value = orderItems.Quantity;
                    BillTable.Rows[index].Cells["Price"].Value = ConvertCurrency.ToVND(orderItems.Product.Price);
                }
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void PrintBill()
        {
            Bitmap bitmap = new Bitmap(Width, Height);
            this.DrawToBitmap(bitmap, new Rectangle(0, 0, Width, Height));

            PrintPreviewDialog printPreviewDialog = new PrintPreviewDialog();

            PrintDocument printDocument = new PrintDocument();
            printDocument.PrintPage += (s, e) =>
            {
                e.Graphics.DrawImage(bitmap, 0, 0);
            };

            printPreviewDialog.Document = printDocument;
            printPreviewDialog.Width = 800;
            printPreviewDialog.Height = 500;
            printPreviewDialog.ShowDialog();
        }

        private void PrintBillForm_Shown(object sender, EventArgs e)
        {
            BillTable.ClearSelection();
            BillTable.RowHeadersVisible = false;
            PrintBill();
        }
    }
}
