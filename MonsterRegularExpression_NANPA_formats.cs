#include System.Text.RegularExpressions;
///# [North American Numbering Plan Administrator](https://nationalnanpa.com/)
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
    string NANPAFormat =
        "(^" +
        "(?<ERC>(811|[0-79](11|22|33|44|55|66|66|88|99)))|" +
        "(?<ReservedAreaCode>([2-9]9[0-9])|(37|96)[0-9])"
        "(?<NonGeoSvc>(5(00|2[1-9][0-9]33|44|55|66|77|88|99)))|" +
        "(?<CASvc>(6(00|22)))|" +
        "(?<InterExch>(700))|" +
        "(?<USGovt>(710))|" +
        "(?<TollFree>8(00|33|44|55|66|77|88))|" +
        "(?<Premium>(900))|" +
        "(?<AreaCode>([2-9][0-8])[0-9])" +
            "-" +
            "(?<Triple5Exchg>(555))-(?<EntertainNum>(01[0-9]{2}))|(?<InfoNum>(1212|4334))|(?<AssngNum>(0[2-9]){2}|[1-9][0-9]{2})|(?<Exchange>[2-9][0-9]{1})-(?<Number>[0-9]{3})"
        ")"$;

}
