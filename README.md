


<p align="center">
  <img src="https://i.imgur.com/etrrN7p.png">
</p>


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

Info, info or i:
Real-time data pertaining to the number of infections, deceased COVID-19 patients and cured patients.

Using Bundesländer , bl oder BL , you'll receive a visual representation of current case numbers in all federal states of the FRG.

Ausgangssperre [Post Code] returns information on whether a curfew is in effect in that area. You may also use the name of that Landkreis instead.
Ausgangssperre BL y or Ausgangssperre Bundesland y displays all area codes in the aforementioned Bundesland (federal state) in which a mandatory curfew is in effect. 

Send tipps or hygiene to obtain guidelines pertaining measures and precautions to be followed as to curb the spread of COVID-19.

symptome gives you a list of observed symptoms related to COVID-19 infection. Should you notice such symptoms in yourself or someone you've been in close contact with,
you may call 116 117 and speak to a healthcare professional as to determine whether a COVID-19 test will be necessary and which precautions should be taken.

## Data Migration and Integration

The project folder contains Python programs for the migration and integration of data from the Federal Statistical Office 

## Changelog

### Version 3.20: Data Statistics and Analysis Tool integrated (DSAAT)

We have added a Windows application for writing current curfews and messages and updating links also for access statistical Data from the Bot Server and the infection counters.

It is available in every current release.

## Screenshot

Version: 3.20



<p align="center">
  <img src="https://i.imgur.com/xXsHwuq.png">
</p>

## License
CITBS

(C) 2020 Dierk-Bent Piening, Roman Spies

[MIT](https://choosealicense.com/licenses/mit/)
