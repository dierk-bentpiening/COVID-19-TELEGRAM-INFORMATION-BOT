
![Logo](https://i.ibb.co/FzfmF5J/logo.png)


# COVID-19 Telegram Information Bot Server for Germany
COVID-19 Telegram Information Bot Server is a bot server software to inform the citizens of the Federal Republic of Germany about the current number of infections, deaths and cured patients in the Federal Republic.

The bot allows to search for imposed curfews and new restrictions.
Tips on hygiene and information on COVID-19 symptoms are transmitted.

It is also possible to send current news and advice messages to the users.

CTIBS creates statistics about the number of requests and case numbers with time markings.

CTIBS uses SQLite as database system.
And generates its data via a JSON API.

## Installation

Start Bot.exe and Place the cbot.cfg config containing your SQLite Database Path on to your C:\ root directory.

## Usage / Commands

Info, info oder i:
Allgemeine Daten zu Infektionen / Geheilten / Verstorbenen in Deutschland sowie aktuelle Hinweise.

Mit Bundesländer , bl oder BL erhalten Sie eine aktuelle Infografik mit den Fallzahlen zu den einzelnen Bundesländern.

Ausgangssperre [PLZ] zeigt Ihnen, ob eine Ausgangssperre für diese PLZ vorliegt. Anstatt PLZ können Sie aber auch Landkreis x verwenden, z.B. Diepholz.
Ausgangssperre BL y oder Ausgangssperre Bundesland y zeigt Ihnen alle PLZ-Bereiche in diesem Bundesland, für die eine Ausgangssperre vorliegt.

Geben Sie tipps oder hygiene ein, um eine Auflistung der Schutzmaßnahmen bezüglich viraler Infektionen im Allgemeinen und CoV-2 im Besonderen zu erhalten.

symptome liefert eine Auflistung von Symptomen, die möglicherweise bei einer Corona-Infektion auftreten. Sollten Sie derartige Symptome bei sich oder bei Ihrer Familie 
beobachten, so beantragen Sie bitte einen Test unter 116 117

## Data Migration and Integration

The project folder contains Python programs for the migration and integration of data from the Federal Statistical Office 

## Changelog

### Version 3.20: Data Statistics and Analysis Tool integrated (DSAAT)

We have added a Windows application for writing current curfews and messages and updating links also for access statistical Data from the Bot Server and the infection counters.

It is available in every current release.

## Screenshot

Version: 3.20

![Logo](https://i.ibb.co/DM0wpJn/grafik.png)

## License
CITBS

(C) 2020 Dierk-Bent Piening, Roman Spies

[MIT](https://choosealicense.com/licenses/mit/)
