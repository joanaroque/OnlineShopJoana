using iTextSharp.text;
using iTextSharp.text.html.simpleparser;
using iTextSharp.text.pdf;

using OnlineShopJoana.WEB.Data.Entities;

using System;
using System.IO;
using System.Text;

namespace OnlineShopJoana.Helpers
{
    public class EmailWithPdf
    {
        public byte[] CreatePdf(Order order, string email)
        {
            var html = BuildEmailContent(order, email);

            byte[] bytes = null;

            StringReader sr = new StringReader(html.ToString());

            Document pdfDoc = new Document(PageSize.A4, 10f, 10f, 10f, 0f);
            HTMLWorker htmlparser = new HTMLWorker(pdfDoc);
            using (MemoryStream memoryStream = new MemoryStream())
            {
                PdfWriter writer = PdfWriter.GetInstance(pdfDoc, memoryStream);
                pdfDoc.Open();

                htmlparser.Parse(sr);
                pdfDoc.Close();

                bytes = memoryStream.ToArray();
                memoryStream.Close();
            }
            return bytes;
        }

        protected StringBuilder BuildEmailContent(Order order, string email)
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("<header class='clearfix'>");
            sb.Append("<h1>INVOICE</h1>");
            sb.Append("<div id='company' class='clearfix'>");
            sb.Append("<div><h2>Plants Shop Joana</h2></div>");
            sb.Append("<div>1800-280 Lisboa</div>");
            sb.Append("<div>21 125 124 8</div>");
            sb.Append("<div><a href='mailto:joanatpsi@gmail.com'>joanatpsi@gmail.com</a></div>");
            sb.Append("</div>");
            sb.Append("<br/>");
            sb.Append("<div>");
            sb.Append($"<div><span>Client:</span> {order.User.FullName}</div>");
            sb.Append($"<div><span>Address:</span> {order.User.Address}</div>");
            sb.Append($"<div><span>Date:</span> {DateTime.UtcNow.ToLocalTime().ToLongDateString()}</div>");
            sb.Append("<br/>");
            sb.Append("</div>");
            sb.Append("</header>");
            sb.Append("<main>");
            sb.Append("<table>");
            sb.Append("<thead>");
            sb.Append("<tr>");
            sb.Append("<th>Product</th>");
            sb.Append("<th>Price</th>");
            sb.Append("<th>Quantity</th>");
            sb.Append("<th>Total</th>");
            sb.Append("</tr>");
            sb.Append("</thead>");
            sb.Append("<tbody>");
            foreach (var item in order.Items)
            {
                sb.Append("<tr>");
                sb.Append($"<td>{item.Product.Name}</td>");
                sb.Append($"<td>{item.Product.Price}</td>");
                sb.Append($"<td>{item.Quantity}</td>");
                sb.Append($"<td>{item.Value}</td>");
                sb.Append("</tr>");
            }

            sb.Append("<tr>");
            sb.Append("<td></td>");
            sb.Append("<td><strong>Total: </strong></td>");
            sb.Append("</tr>");

            sb.Append("<tr>");
            sb.Append("<td></td>");
            sb.Append($"<td><strong>{order.Value}</strong></td>");
            sb.Append("</tr>");
            sb.Append("</tbody>");
            sb.Append("</table>");
            sb.Append("<div id='notices'>");


            return sb;
        }

    }

}

