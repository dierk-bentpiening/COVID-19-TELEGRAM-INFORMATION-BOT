# Copyright 2020 Dierk-Bent Piening, Roman Spies

# Permission is hereby granted, free of charge, to any person obtaining a copy of this software and associated documentation files (the "Software"),
# to deal in the Software without restriction, including without limitation the rights to use, copy, modify,merge, publish, distribute, sublicense,
# and/or sell copies of the Software,and to permit persons to whom the Software is furnished to do so, subject to the following conditions:

# The above copyright notice and this permission notice shall be included in all copies or substantial portions of the Software.

# SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND, EXPRESS OR IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF MERCHANTABILITY,
# FITNESS FOR A PARTICULAR PURPOSE AND NONINFRINGEMENT. IN NO EVENT SHALL THE AUTHORS OR COPYRIGHT HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER LIABILITY,
# WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING FROM, OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR OTHER DEALINGS IN THE SOFTWARE.


import sqlite3
import os
os.chdir("D:\\GitWorking\\COVID-19-TELEGRAM-INFORMATION-BOT\\")
db_conn = sqlite3.connect('CISB_test.sqlite3')
db_conn_cursor = db_conn.cursor()
db_conn_cursor.execute("CREATE TABLE AusgangssperrenLK ([ID] INTEGER NOT NULL PRIMARY KEY, [LKN] text not null, [VON] numeric not null, [BIS] numeric not null, [Bundesland] text not null, [BEHÖRDE] text, [PLZ] numeric)")
db_conn_cursor.execute("CREATE TABLE Einreiseverbote ([ID] INTEGER NOT NULL PRIMARY KEY, [Nation] INTEGER, [VON] numeric not null, [BIS] INTEGER not null)")
db_conn_cursor.execute("CREATE TABLE InfektionStatistics ([ID] INTEGER NOT NULL PRIMARY KEY, [INFEKTIONCOUNT] text not null, [TIMEDATEDATASOURCE] text not null, [CRAWLTIMEDATE] text not null, [DEATH] text not null, [RECOVERED] text not null)")
db_conn_cursor.execute("CREATE TABLE PMESSAGES ([ID] INTEGER NOT NULL PRIMARY KEY, [MESSAGE] text not null)")
db_conn_cursor.execute("CREATE TABLE URLLIST ([ID] INTEGER NOT NULL PRIMARY KEY, [URL] text not null)")
db_conn_cursor.execute("CREATE TABLE statistics ([ID] INTEGER NOT NULL PRIMARY KEY, [CHATID] text not null, [QUERRYTYPE] text not null, [DATETIME] text not null)")
db_conn.commit()
db_conn.close()


