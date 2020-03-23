# Copyright 2020 Dierk-Bent Piening, Roman Spies

# Permission is hereby granted, free of charge, to any person obtaining a copy of this software and associated documentation files (the "Software"),
# to deal in the Software without restriction, including without limitation the rights to use, copy, modify,merge, publish, distribute, sublicense,
# and/or sell copies of the Software,and to permit persons to whom the Software is furnished to do so, subject to the following conditions:

# The above copyright notice and this permission notice shall be included in all copies or substantial portions of the Software.

# SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND, EXPRESS OR IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF MERCHANTABILITY,
# FITNESS FOR A PARTICULAR PURPOSE AND NONINFRINGEMENT. IN NO EVENT SHALL THE AUTHORS OR COPYRIGHT HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER LIABILITY,
# WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING FROM, OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR OTHER DEALINGS IN THE SOFTWARE.

import sys
import getopt
import sqlite3
import os
if len(sys.argv) == 1:
    path_userinput = input("Bitte geben Sie den gewünschten Pfad inklusive Dateinamen zu Ihrer sqlite3-Datei ein. Beispiel: \"C:\\Users\\Username\\Documents\\CISB.sqlite3\"")
else:
    try:
        opts, args = getopt.getopt(sys.argv[1:], "p:", ["path="])
    except getopt.GetoptError as err:
        print(str(err))
        sys.exit(2)
    for o, a in opts:
        if o in ("-p", "--path"):
            path_userinput = a
        else:
            assert False, "bitte verwenden Sie entweder -p oder --path, um einen gültigen Pfad zu der gewünschten sqlite3-Datei zu definieren!"




db_conn = sqlite3.connect(str(path_userinput))
db_conn_cursor = db_conn.cursor()
try:
    z = db_conn_cursor.execute("CREATE TABLE AusgangssperrenLK ([ID] INTEGER NOT NULL PRIMARY KEY, [LKN] text not null, [VON] numeric not null, [BIS] numeric not null, [Bundesland] text not null, [BEHÖRDE] text, [PLZ] numeric)")
except:
    print("Bei der Erstellung von Table AusgangssperrenLK ist ein Fehler aufgetreten!")
else:
    print("Table AusgangssperrenLK erfolgreich erstellt!")
try:
    z = db_conn_cursor.execute("CREATE TABLE Einreiseverbote ([ID] INTEGER NOT NULL PRIMARY KEY, [Nation] INTEGER, [VON] numeric not null, [BIS] INTEGER not null)")
except:
    print("Bei der Erstellung von Table Einreiseverbote ist ein Fehler aufgetreten!")
else:
    print("Table Einreiseverbote erfolgreich erstellt!")
try:
    z = db_conn_cursor.execute("CREATE TABLE InfektionStatistics ([ID] INTEGER NOT NULL PRIMARY KEY, [INFEKTIONCOUNT] text not null, [TIMEDATEDATASOURCE] text not null, [CRAWLTIMEDATE] text not null, [DEATH] text not null, [RECOVERED] text not null)")
except:
    print("Bei der Erstellung von Table InfektionStatistics ist ein Fehler aufgetreten!")
else:
    print("Table InfektionStatistics erfolgreich erstellt!")
try:
    z = db_conn_cursor.execute("CREATE TABLE PMESSAGES ([ID] INTEGER NOT NULL PRIMARY KEY, [MESSAGE] text not null)")
except:
    print("Bei der Erstellung von Table PMESSAGES ist ein Fehler aufgetreten!")
else:
    print("Table PMESSAGES erfolgreich erstellt!")
try:
    z = db_conn_cursor.execute("CREATE TABLE URLLIST ([ID] INTEGER NOT NULL PRIMARY KEY, [URL] text not null)")
except:
    print("Bei der Erstellung von Table URLLIST ist ein Fehler aufgetreten!")
else:
    print("Table URLLIST erfolgreich erstellt!")
try:
    z = db_conn_cursor.execute("CREATE TABLE statistics ([ID] INTEGER NOT NULL PRIMARY KEY, [CHATID] text not null, [QUERRYTYPE] text not null, [DATETIME] text not null)")
except:
    print("Bei der Erstellung von Table statistics ist ein Fehler aufgetreten!")
else:
    print("Table statistics erfolgreich erstellt!")
try:
    db_conn.commit()
except:
    print("Beim Speichern in der DB ist ein Fehler aufgetreten!")
else:
    print("Daten erfolgreich in der DB gespeichert!")
db_conn.close()


