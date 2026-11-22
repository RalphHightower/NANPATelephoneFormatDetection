# [North American Numbering Plan Administrator](https://nationalnanpa.com/)

## NANPATelephoneFormatDetection

North American Numbering Plan 
The formatting rules:

- Easily Recognizable Codes	When the second and third digits of an area code are the same, that code is called an easily recognizable code (ERC). ERCs designate special services; e.g., 888 for toll-free service.
- N11	These 8 ERCs, called service codes, are not used as area codes.
- N9X	The 80 codes in this format, called expansion codes, have been reserved for use during the period when the current 10-digit NANP number format undergoes expansion.
- 37X and 96X	Two blocks of 10 codes each have been set aside by the INC for unanticipated purposes where it may be important to have a full range of 10 contiguous codes available.

- (?\<ERC\>^(\[2-9\](11\|22\|33\|44\|55\|66\|77\|88\|99)$))\|
  - (
    - (?\<NonGeoSvc\>^(5\(00\|21\|22\|23\|24\|25\|26\|27\|28\|29\|33\|44\|66\|77\|88\))\|
    - (?\<CAservices\>^(6(00\|22))\|
    - (?\<InterExch\>^(700))\|
    - (?\<USgovt\>^(710))|
    - (?\<TollFree\>^(8\(00\|33\|44\|55\|66\|77\|88)))\|
    - (?\<Premium\>^(900)
  - )(?\<SpecExchange\>(\[2-9\]\[0-9\]\[0-9\])-(?\<SpecNumber\>\[0-9\]{4}))
- (?\<ReservedAreaCode\>(\[2-9\]9\[0-9\])\|((37\|96)\[0-9\]))-\[2-9\]\[0-9\]\[0-9\]-\[0-9\]\{4\}$
- (?\<InfoAreaCode\>^(\[2-9\]\[0-8\]\[0-9\])-555-(?\<InfoNum\>(1212|4334)$)\|
- (?\<EntAreaCode\>^\[2-9\]\[0-8\]\[0-9\])-555-(?\<EntNumber>(01\[0-9\]\[0-9\]))$\|
- (?\<AreaCode\>(\[2-9\]\[0-8\]\[0-9\]))-(?\<Exchange>(\[2-9\]\[0-9\]\[0-9\]))-(?\<Number\>(\[0-9\]\{4\}))$

The rules:

1. Numbers must be in the following format: ddd, or ddd-ddd-dddd. No parentheses are allowed. 
2. If ERC is a group that is matched and the length is greater than 3, the number is invalid. 

[Zip file of Central Office Codes Report — Updated daily](https://www.nationalnanpa.com/nanp1/allutlzd.zip)
[![OpenSSF Baseline](https://www.bestpractices.dev/projects/12811/baseline)](https://www.bestpractices.dev/projects/12811)

| |
|---|
| [![GitHub Streak](https://streak-stats.demolab.com?user=RalphHightower&timezone=America/New_York&date_format=M%20j%5B%2C%20Y%5D&border=73000a&stroke=73000a&ring=73000a&fire=73000a&currStreakNum=73000a&sideNums=73000a&currStreakLabel=73000a&sideLabels=73000a&dates=73000a)](https://git.io/streak-stats) |
| [![GitHub Stats](https://github-stats-extended.vercel.app/api?username=RalphHightower&show=reviews%2Cdiscussions_started%2Cdiscussions_answered%2Cprs_merged%2Cprs_merged_percentage%2Cprs_commented%2Cprs_reviewed%2Cissues_commented%2Ccontributions%2Call_time_contribs&show_icons=true&include_all_commits=true&theme=default)](https://github-stats-extended.vercel.app/api?username=RalphHightower&show=reviews%2Cdiscussions_started%2Cdiscussions_answered%2Cprs_merged%2Cprs_merged_percentage%2Cprs_commented%2Cprs_reviewed%2Cissues_commented%2Ccontributions%2Call_time_contribs&show_icons=true&include_all_commits=true&theme=default&title_color=73000a&text_color=73000a&icon_color=73000a&border_color=ffffff) |
| ![RalphHightower's GitHub activity graph](https://github-readme-activity-graph.vercel.app/graph?username=RalphHightower&theme=default&color=73000a&title_color=73000a&line=73000a&point=73000a&bg_color=ffffff) |
| ![profile-details](http://github-profile-summary-cards.vercel.app/api/cards/profile-details?username=RalphHightower&theme=default) |

|    |    |
|---|---|
| ![repos-per-language](https://github-profile-summary-cards.vercel.app/api/cards/repos-per-language?username=RalphHightower&theme=default) | ![most-commit-language](https://github-profile-summary-cards.vercel.app/api/cards/most-commit-language?username=RalphHightower&theme=default) |
| ![stats](http://github-profile-summary-cards.vercel.app/api/cards/stats?username=RalphHightower&theme=default) | ![productive-time](http://github-profile-summary-cards.vercel.app/api/cards/productive-time?username=RalphHightower&theme=default&utcOffset=-5) |

<!-- ![stats](https://github-profile-summary-cards.vercel.app/api/cards/stats?username=RalphHightower&theme=transparent) -->
<!-- ![productive-time](https://github-profile-summary-cards.vercel.app/api/cards/productive-time?username=RalphHightower&theme=transparent&timeZone=America%2FNewYork) -->
