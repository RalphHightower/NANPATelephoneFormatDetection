#include System.Text.RegularExpressions;
.///# [North American Numbering Plan Administrator](https://nationalnanpa.com/)
///
///- Easily Recognizable Codes	When the second and third digits of an area code are the same, that code is called an
///easily recognizable code (ERC). ERCs designate special services; e.g., 888 for toll-free service.
///- N11	These 8 ERCs, called service codes, are not used as area codes.
///- N9X	The 80 codes in this format, called expansion codes, have been reserved for use during the period when the 
///current 10-digit NANP number format undergoes expansion.
///- 37X and 96X	Two blocks of 10 codes each have been set aside by the INC for unanticipated purposes where it may be
///important to have a full range of 10 contiguous codes available.

namespace NorthAmericaNumberingPlanAdmistration
class TelephoneFormatDetection
{
    string TelephoneFormatRegularExpression = 
        "(^" +
            "(?<ERC>([2-79](11|22|33|44|55|66|77|88|99)$))$|" +
            "(" +
                "(?<ReservedAreaCode>[2-9]9[0-9]|39[0-9]|96[0-9])" +
                "(?<NonGeoSvc>(5[00|2[1-9]|33|44|66|77|88]))|" +
                "(?<CAservices>(6[00|22]))|" +
                "(?<InterExch>(700))|" +
                "(?<USgovt>(710))|" +
                "(?<TollFree>(8[00|33|44|55|66|77|88]))|" +
                "(?<Premium>(900))" +
                "(?<AreaCode>([2-9][0-8][0-9]))" +
            ")-" +
            "((?<Exchange555>555)-(?<EntertainmentLineNumber>(01[0-9]{1}))|(?<DirectoryAssistance>(1212|4334))|((?<LineNumber555)(0[2-9]{2}|1[0-9]{3})))|((?<Exchange>[2-9][0-9][0-9])-(?<LineNumber>[0-9{3}])))$";

    string test = "";
}

