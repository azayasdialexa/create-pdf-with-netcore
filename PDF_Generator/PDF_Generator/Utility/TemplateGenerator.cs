using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using PDF_Generator.Models;
using System.IO;
using System;
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
            //using (StreamReader reader = new StreamReader("Template/TestHTML.html"))
            //{
            //    string line = "";
            //    StringBuilder stringBuilder = new StringBuilder();
            //    while ((line = reader.ReadLine()) != null)
            //    {
            //        stringBuilder.Append(line);
            //    }

            //    Console.WriteLine(stringBuilder.ToString());
            //    Console.ReadLine();
            //    sb = stringBuilder;
            //}

            sb.Append(@"
                        <html>
                            <body>
                                <div class='page'>
                                    <div class='header'>
                                        <div class='col-2'>
                                            <div class='property-details'>
                                                <div class='property-name-address'>
                                                    <div class='property-name'>Clifford Drive</div>
                                                    <div class='property-address'>9749 Clifford Drive, Dallas, TX 75220</div>
                                                </div>
                                                <div class='property-id-specs'>
                                                    <div class='specs-left'>
                                                        <table>
                                                            <tr><td><div class='icon-24 market'/></td><td>Market:</td><td class='spacer'></td><td class='details'>Dallas/Ft Worth</td></tr>
                                                            <tr><td><div class='icon-24 submarket'/></td><td>Submarket:</td><td class='spacer'></td><td class='details'>Dallas</td></tr>
                                                        </table>
                                                    </div>
                                                    <div class='specs-right'>
                                                        <table>
                                                            <tr><td><div class='icon-24 clock'/></td><td>Available Date:</td><td class='spacer'></td><td class='details'>Mar 2024</td></tr>
                                                            <tr><td><div class='icon-24 ruler'/></td><td>Available Sq Ft:</td><td class='spacer'></td><td class='details'>102,900 Sq Ft</td></tr>
                                                        </table>
                                                    </div>
                                                </div>
                                            </div>
                                        </div>
                                        <div class='col-2'><div class='hero-image'></div></div>
                                    </div>
                                    <div class='unit-specs-container'>
                                        <div class='unit-specs-title'>Unit Specs</div>
                                        <div class='unit-specs-items'>
                                            <div><span>Year Built</span><span>2015</span></div>
                                            <div><span>Unit Drive In Door(2)</span><span>25 Doors</span></div>
                                            <div><span>Warehouse Sq Ft</span><span>100,00 Sq Ft</span></div>
                                            <div><span>Rail Served</span><span>No</span></div>
                                            <div><span>Office Sq Ft</span><span>9,200 Sq Ft</span></div>
                                            <div><span>Auto Parking</span><span>160</span></div>
                                            <div><span>% Office</span><span>9.2%</span></div>
                                            <div><span>Truck Parking</span><span>20</span></div>
                                            <div><span>Clear Height</span><span>32'</span></div>
                                            <div><span>Truck Court Depth</span><span>130'</span></div>
                                            <div><span>Dock Door Count</span><span>28 Doors</span></div>
                                        </div>
                                    </div>
                                    <div class='agent-bar'>
                                        <table>
                                            <tr>
                                                <td class='av-1'><div class='avatar agent-1'></div></td>
                                                <td class='av-2'>
                                                    <table class='agent-details'>
                                                        <tr><td class='agent-name'>Tracy Bertman</td></tr>
                                                        <tr><td class='agent-title'>Broker for ABC Realty</td></tr>
                                                    </table>
                                                </td>
                                                <td class='av-3'>
                                                    <table class='agent-contact'>
                                                        <tr><td><div class='icon-21 phone'/></td><td>(321) 123-5548)</td></tr>
                                                        <tr><td><div class='icon-21 email'/></td><td>tbertman@linklogistics.com</td></tr>
                                                    </table>
                                                </td>
                                                <td class='av-4'><div class='divider'></div></td>
                                                <td class='av-1'><div class='avatar agent-2'></div></td>
                                                <td class='av-2'>
                                                    <table class='agent-details'>
                                                        <tr><td class='agent-name'>Bill Harmen</td></tr>
                                                        <tr><td class='agent-title'>Broker for ABC Realty</td></tr>
                                                    </table>
                                                </td>
                                                <td class='av-3'>
                                                    <table class='agent-contact'>
                                                        <tr><td><div class='icon-21 phone'/></td><td>(321) 123-5548)</td></tr>
                                                        <tr><td><div class='icon-21 email'/></td><td>bharmen@linklogistics.com</td></tr>
                                                    </table>
                                                </td>
                                                <td class='av-4'></td>
                                            </tr>
                                        </table>
                                    </div>
                                    <div class='footer'>
                                        <table>
                                            <tr>
                                                <td><div class='footer-icon'><div></td>
                                                <td class='title'>AVAILABILITY SUMMARY</td>
                                                <td class='page'>Page 3</td>
                                                <td class='footer-spacer'></td>
                                            </tr>
                                        </table>
                                    </div>
                                </div>"
            );

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
            //    , market.MarketId, market.Name);

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
            //sb.Append(@"</table>");

            sb.Append(@"</div></div></body></html>");
            return sb.ToString();
        }
    }
}
