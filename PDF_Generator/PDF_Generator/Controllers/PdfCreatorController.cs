using DinkToPdf;
using DinkToPdf.Contracts;
using Microsoft.AspNetCore.Mvc;
using PDF_Generator.Utility;
using System.IO;

namespace PDF_Generator.Controllers
{
    [Route("api/pdfcreator")]
    [ApiController]
    public class PdfCreatorController : ControllerBase
    {
        private IConverter _converter;

        public PdfCreatorController(IConverter converter)
        {
            _converter = converter;
        }

        [HttpGet]
        public IActionResult CreatePDF()
        {
            var globalSettings = new GlobalSettings
            {
                ColorMode = ColorMode.Color,
                Orientation = Orientation.Landscape,
                PaperSize = PaperKind.Letter,
                PageOffset = -1,
                Margins = new MarginSettings { Top = 0, Left = 0, Right = 0, Bottom = 0 },
                DocumentTitle = "Availability Summary",
            };

            var objectSettings = new ObjectSettings
            {
                PagesCount = true,
                UseExternalLinks = true,
                UseLocalLinks = true,
                HeaderSettings = { FontName = "TTHoves", FontSize = 9, Right = "Pg [page] of [toPage]", Line = false,
                    HtmUrl= Path.Combine(Directory.GetCurrentDirectory(), "assets", "htmlpage.html") },
                HtmlContent = TemplateGenerator.GetHTMLString(),
                WebSettings = { DefaultEncoding = "utf-8", UserStyleSheet = Path.Combine(Directory.GetCurrentDirectory(), "assets", "pure-css.css") },
                FooterSettings = { FontName = "TTHoves", FontSize = 9, Right = "Pg [page] of [toPage]", Line = false,
                    HtmUrl= Path.Combine(Directory.GetCurrentDirectory(), "assets", "footer.html") },
            };

            var pdf = new HtmlToPdfDocument()
            {
                GlobalSettings = globalSettings,
                Objects = { objectSettings }
            };

            var file = _converter.Convert(pdf);

            return File(file, "application/pdf");
        }
    }
}