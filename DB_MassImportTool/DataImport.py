# Copyright 2020 Dierk-Bent Piening, Roman Spies

# Permission is hereby granted, free of charge, to any person obtaining a copy of this software and associated documentation files (the "Software"),
# to deal in the Software without restriction, including without limitation the rights to use, copy, modify,merge, publish, distribute, sublicense,
# and/or sell copies of the Software,and to permit persons to whom the Software is furnished to do so, subject to the following conditions:

# The above copyright notice and this permission notice shall be included in all copies or substantial portions of the Software.

# SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND, EXPRESS OR IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF MERCHANTABILITY,
# FITNESS FOR A PARTICULAR PURPOSE AND NONINFRINGEMENT. IN NO EVENT SHALL THE AUTHORS OR COPYRIGHT HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER LIABILITY,
# WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING FROM, OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR OTHER DEALINGS IN THE SOFTWARE.

import csv
import sqlite3
import os
#gloVARs
bl_filter = ['Bayern', 'Saarland', 'Sachsen']
start_dates = ['21.03.2020', '21.03.2020', '23.03.2020']
stop_dates = ['03.04.2020', '03.04.2020', '05.04.2020']
# Change dir
os.chdir("D:\\Roman\\Projects_Private\\coronabot\\")
# öffne CSV File mit allen Städten
file_current = open("zuordnung_plz_ort_landkreis.csv", encoding="UTF-8")
# Lese File ein
fileread = csv.reader(file_current)
# Filtere nach Bundesländern
subset_zugelassen = list(filter(lambda z: z[5] in bl_filter, fileread))
# Etabliere DB connection
db_open = sqlite3.connect('CISB.sqlite3')
# Erstelle Cursor
db_open_cursor = db_open.cursor()
# Lade alle bisherigen Einträge aus der DB
double_prevention = db_open_cursor.execute("SELECT PLZ, VON, BIS, Bundesland FROM AusgangssperrenLK").fetchall()
# Erstelle PLZ Kategorien
plz_list_disregard = []
plz_list_update = []
# Prüfe welche Einträge aktualisiert werden müssen (z.B. verlängerte Ausgangssperre)
for i in range(0,len(double_prevention)):
    try:
        end_date_new = stop_dates[bl_filter.index(double_prevention[i][3])]
        if end_date_new == double_prevention[i][2]:
            plz_list_disregard = plz_list_disregard  + [double_prevention[i][0]]
            print("dis")
        else:
            plz_list_update = plz_list_update + [double_prevention[i][0]]
            print("up")
    except:
        plz_list_disregard = plz_list_disregard  + [double_prevention[i][0]]
# Füge Daten ein
for o in range(0,len(subset_zugelassen)):
    if int(subset_zugelassen[o][3]) in plz_list_disregard:
        pass
    elif int(subset_zugelassen[o][3]) in plz_list_update:
         db_open_cursor.execute("UPDATE AusgangssperrenLK SET BIS = ? WHERE PLZ = ?", [stop_dates[bl_filter.index(subset_zugelassen[o][5])], subset_zugelassen[o][3]])
    else:
        LKNCurr = 'Kreisfreie Stadt ' + subset_zugelassen[o][2] if subset_zugelassen[o][4] == '' else subset_zugelassen[o][4]
        VONCurr = start_dates[bl_filter.index(subset_zugelassen[o][5])] if subset_zugelassen[o][5] in bl_filter else '01.01.1970'
        BISCurr = stop_dates[bl_filter.index(subset_zugelassen[o][5])] if subset_zugelassen[o][5] in bl_filter else '31.12.2222'
        BUNDESLANDCurr = subset_zugelassen[o][5]
        BEHOERDECurr = 'Staatskanzlei ' + subset_zugelassen[o][5] if not subset_zugelassen[o][5] in ['Bremen', 'Berlin', 'Hamburg'] else 'Senat ' + subset_zugelassen[o][5]
        PLZCurr = subset_zugelassen[o][3]
        db_open_cursor.execute("INSERT INTO AusgangssperrenLK (LKN, VON, BIS, Bundesland, BEHÖRDE, PLZ) VALUES (?,?,?,?,?,?)", [LKNCurr, VONCurr, BISCurr, BUNDESLANDCurr, BEHOERDECurr, PLZCurr])
# Schließe DBs
db_open.commit()
db_open.close()
file_current.close()
