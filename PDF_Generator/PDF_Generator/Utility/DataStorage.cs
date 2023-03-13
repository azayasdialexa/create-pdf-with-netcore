using PDF_Generator.Models;
using System.Collections.Generic;

namespace PDF_Generator.Utility
{
    public static class DataStorage
    {
        public static List<Market> GetAllMarkets() =>
            new List<Market>
            {
                new Market { MarketId=1, Name="Dallas / Ft. Worth"},
                new Market { MarketId=2, Name="Austin"},
                new Market { MarketId=3, Name="DFW 2"},
            };

        public static List<Available> GetAllAvailable() =>
            new()
            {
                new Available { MarketId = 1, Address="9749 Clifford Dr", City="Dallas", State="TX", TotalSF=109200, ClearHt=30, Doors=28, AvailableDate="Immediate", ListingRep="Tracy Bertman"},
                new Available { MarketId = 1, Address="3150 Marquis Dr", City="Garland", State="TX", TotalSF=355071, ClearHt=32, Doors=128, AvailableDate="3/12/23", ListingRep="Tracy Bertman"},
                new Available { MarketId = 1, Address="2601 West Bethel Rd", City="Dallas", State="TX", TotalSF=1008176, ClearHt=42, Doors=70, AvailableDate="Immediate", ListingRep="Tracy Bertman"},
                new Available { MarketId = 1, Address="Strandridge Dr & Memorial Dr", City="The Colony", State="TX", TotalSF=1107848, ClearHt=32, Doors=0, AvailableDate="3/26/23", ListingRep="Tracy Bertman"},
                new Available { MarketId = 1, Address="9233 Waterford Centre Blvd", City="Dallas", State="TX", TotalSF=508364, ClearHt=28, Doors=4, AvailableDate="Immediate", ListingRep="Tracy Bertman"},
                new Available { MarketId = 1, Address="363 Imagine Ave", City="Dallas", State="TX", TotalSF=230913, ClearHt=24, Doors=22, AvailableDate="4/6/23", ListingRep="Tracy Bertman"},

                new Available { MarketId = 2, Address="912521 Harris Branch Parkway", City="Austin", State="TX", TotalSF=654080, ClearHt=32, Doors=141, AvailableDate="5/17/23", ListingRep="Richard Myers"},
                new Available { MarketId = 2, Address="2111 A.W. Grimes Blvd", City="Austin", State="TX", TotalSF=367887, ClearHt=32, Doors=95, AvailableDate="Immediate", ListingRep="Richard Myers"},
                new Available { MarketId = 2, Address="2100 Chisolm Trl", City="Round Rock", State="TX", TotalSF=663267, ClearHt=34, Doors=148, AvailableDate="6/25/23", ListingRep="Richard Myers"},
                new Available { MarketId = 2, Address="912521 Harris Branch Parkway", City="Austin", State="TX", TotalSF=654080, ClearHt=32, Doors=141, AvailableDate="5/17/23", ListingRep="Richard Myers"},
                new Available { MarketId = 2, Address="2111 A.W. Grimes Blvd", City="Austin", State="TX", TotalSF=367887, ClearHt=32, Doors=95, AvailableDate="Immediate", ListingRep="Richard Myers"},
                new Available { MarketId = 2, Address="2100 Chisolm Trl", City="Round Rock", State="TX", TotalSF=663267, ClearHt=34, Doors=148, AvailableDate="6/25/23", ListingRep="Richard Myers"},
                new Available { MarketId = 2, Address="912521 Harris Branch Parkway", City="Austin", State="TX", TotalSF=654080, ClearHt=32, Doors=141, AvailableDate="5/17/23", ListingRep="Richard Myers"},
                new Available { MarketId = 2, Address="2111 A.W. Grimes Blvd", City="Austin", State="TX", TotalSF=367887, ClearHt=32, Doors=95, AvailableDate="Immediate", ListingRep="Richard Myers"},
                new Available { MarketId = 2, Address="2100 Chisolm Trl", City="Round Rock", State="TX", TotalSF=663267, ClearHt=34, Doors=148, AvailableDate="6/25/23", ListingRep="Richard Myers"},

                new Available { MarketId = 3, Address="9749 Clifford Dr", City="Dallas", State="TX", TotalSF=109200, ClearHt=30, Doors=28, AvailableDate="Immediate", ListingRep="Tracy Bertman"},
                new Available { MarketId = 3, Address="3150 Marquis Dr", City="Garland", State="TX", TotalSF=355071, ClearHt=32, Doors=128, AvailableDate="3/12/23", ListingRep="Tracy Bertman"},
                new Available { MarketId = 3, Address="2601 West Bethel Rd", City="Dallas", State="TX", TotalSF=1008176, ClearHt=42, Doors=70, AvailableDate="Immediate", ListingRep="Tracy Bertman"},
                new Available { MarketId = 3, Address="Strandridge Dr & Memorial Dr", City="The Colony", State="TX", TotalSF=1107848, ClearHt=32, Doors=0, AvailableDate="3/26/23", ListingRep="Tracy Bertman"},
                new Available { MarketId = 3, Address="9233 Waterford Centre Blvd", City="Dallas", State="TX", TotalSF=508364, ClearHt=28, Doors=4, AvailableDate="Immediate", ListingRep="Tracy Bertman"},
                new Available { MarketId = 3, Address="363 Imagine Ave", City="Dallas", State="TX", TotalSF=230913, ClearHt=24, Doors=22, AvailableDate="4/6/23", ListingRep="Tracy Bertman"},
            };
    }
}
