using System.Linq;
using System.Text;

namespace PDF_Generator.Utility
{
    public static class TemplateGenerator
    {
        public static string GetHTMLString()
        {
            var availableMarkets = DataStorage.GetAllMarkets().FirstOrDefault();
            var availableSubMarkets = DataStorage.GetAllSubMarkets().FirstOrDefault();
            var availableSummaries = DataStorage.GetAllAvailable().Where(r => r.ListingId == 1).FirstOrDefault();
            var unitSpecs = DataStorage.GetUnitSpecs().Where(r => r.ListingId == 1).ToList();
            var agents = DataStorage.GetAgents().AsQueryable().Where(r => r.ListingId == 1).ToList();

            var sb = new StringBuilder();
            var returnStr = sb.ToString();

            sb.AppendFormat(@"
                        <html>
                            <body>
                                <div class='page'>
                                    <div class='header'>
                                        <div class='col-2'>
                                            <div class='property-details'>
                                                <div class='property-name-address'>
                                                    <div class='property-name'>{0}</div>
                                                    <div class='property-address'>{1}</div>
                                                </div>
                                                <div class='property-id-specs'>
                                                    <div class='specs-left'>
                                                        <table>
                                                            <tr><td><div class='icon-24 market'/></td><td>Market:</td><td class='spacer'></td><td class='details'>{2}</td></tr>
                                                            <tr><td><div class='icon-24 submarket'/></td><td>Submarket:</td><td class='spacer'></td><td class='details'>{3}</td></tr>
                                                        </table>
                                                    </div>
                                                    <div class='specs-right'>
                                                        <table>
                                                            <tr><td><div class='icon-24 clock'/></td><td>Available Date:</td><td class='spacer'></td><td class='details'>{4}</td></tr>
                                                            <tr><td><div class='icon-24 ruler'/></td><td>Available Sq Ft:</td><td class='spacer'></td><td class='details'>{5}</td></tr>
                                                        </table>
                                                    </div>
                                                </div>
                                            </div>
                                        </div>
                                        <div class='col-2'><div class='hero-image'></div></div>
                                    </div>
                                    <div class='unit-specs-container'>
                                        <div class='unit-specs-title'>Unit Specs</div>
                                        <div class='unit-specs-items'>",
                                        availableSummaries.Name, 
                                        availableSummaries.FullAddress, 
                                        availableMarkets.Name,
                                        availableSubMarkets.Name,
                                        availableSummaries.AvailableDate,
                                        availableSummaries.TotalSF);

            foreach (var spec in unitSpecs.Where(s => s.ListingId == 1)){
                sb.AppendFormat(@"      <div><span>{0}</span><span>{1}</span></div>", spec.Name, spec.Value);
            }

            sb.AppendFormat(@"
                                        </div>
                                    </div>
                                    <div class='agent-bar'>
                                        <table>
                                            <tr>"
            );
            foreach (var agent in agents.Where(s => s.ListingId == 1)) {
                sb.AppendFormat(@"              <td class='av-1'><img width=75 height=75 src={0} />", agent.Avatar);
                                                sb.AppendFormat(@"</td>
                                                <td class='av-2'>
                                                    <table class='agent-details'>
                                                        <tr><td class='agent-name'>{0}</td></tr>
                                                        <tr><td class='agent-title'>{1}</td></tr>
                                                    </table>
                                                </td>
                                                <td class='av-3'>
                                                    <table class='agent-contact'>
                                                        <tr><td><div class='icon-21 phone'/></td><td>(321) 123-5548)</td></tr>
                                                        <tr><td><div class='icon-21 email'/></td><td>tbertman@linklogistics.com</td></tr>
                                                    </table>
                                                </td>", agent.Name, agent.Title);
                if ((agents.Count > 1) && (agents.IndexOf(agent) < agents.Count-1)) {
                    sb.AppendFormat(@"<td class='av-4'><div class='divider'></div></td>");
                }
            }
            sb.AppendFormat(@"
                                    </tr>
                                </table>
                            </div>
                            <div class='footer'>
                                <table>
                                    <tr>
                                        <td><div class='link-logo'></div></td>
                                        <td class='title'>AVAILABILITY SUMMARY</td>
                                        <td class='page'>Page 3</td>
                                        <td class='footer-spacer'></td>
                                    </tr>
                                </table>
                            </div>
                        </div>
                    </body>
                </html>");

            returnStr = sb.ToString();

            return returnStr;
        }
    }
}
