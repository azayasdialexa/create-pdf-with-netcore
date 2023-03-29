using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System.Linq;
using System.Text;

namespace PDF_Generator.Utility
{
    public static class TemplateGenerator
    {
        public static string GetHTMLString()
        {
            var availableMarkets = DataStorage.GetAllMarkets();
            var availableSummaries = DataStorage.GetAllAvailable();

            var sb = new StringBuilder();
            sb.Append(@"
                        <html>
                            <body>
                                <div class='grid'>
                                    <div class='col-4'> Column 1 </div>
                                    <div class='col-4 alt'> Column 2 </div>
                                    <div class='col-2'> <img /> </div>
                                </div>");

            //foreach (var market in availableMarkets)
            //{
            //    sb.AppendFormat(@"
            //                    <table align='center' class='table_{0}'>
            //                        <tr>
            //                            <th class='rotate' rowspan=99><div>{1}</div></th>
            //                            <th>Address</th>
            //                            <th>City</th>
            //                            <th>State</th>
            //                            <th>Total SF</th>
            //                            <th>Clear HT</th>
            //                            <th># Doors</th>
            //                            <th>Available</th>
            //                            <th>Leasing Rep</th>
            //                        </tr>"
            //    ,market.MarketId, market.Name);

            //    foreach (var summary in availableSummaries.Where(s => s.MarketId == market.MarketId))
            //    {
            //        sb.AppendFormat(@"<tr>
            //                            <td>{0}</td>
            //                            <td>{1}</td>
            //                            <td>{2}</td>
            //                            <td>{3}</td>
            //                            <td>{4}</td>
            //                            <td>{5}</td>
            //                            <td>{6}</td>
            //                            <td>{7}</td>
            //                          </tr>", summary.Address, summary.City, summary.State, summary.TotalSF, summary.ClearHt, summary.Doors, summary.AvailableDate, summary.ListingRep);
            //    }
            //}
                                    //</ table >

            sb.Append(@"
                                </body>
                            </html>");
            return sb.ToString();
        }
    }
}
