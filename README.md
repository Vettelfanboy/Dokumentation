# Dokumentation

✍️ Simon Veljkovic

| Datum | Version | Zusammenfassung                                              |
| ----- | ------- | ------------------------------------------------------------ |
|23.08.22      | 0.0.1   |   |
|       |     |                                                              |
|06.09.22       | 1.0.0   |                                                              |

## 1 Informieren

### 1.1 Ihr Projekt

✍️ Ich werde einen number guesser erstellen.

### 1.2 User Stories

| US-№ | Verbindlichkeit | Typ  | Beschreibung                       |
| ---- | --------------- | ---- | ---------------------------------- |
| 1    | Muss                |Funktional| Als ein Spieler möchte ich immer informiert werden, wie weit weg von der richtigen Zahl ich noch bin, damit ich immer bessere S chätzungen abgeben kann.|
| 2    | Muss                |Funktional|  Als ein Programmierer möchte ich es gerne so haben, dass die gesuchte Zahl gut versteckt wird, aber auch gute Tipps sollen ausgeteilt werden, damit der Spieler nicht ewig raten muss.                                   |
| 3    | Muss                |Qualität| Als ein Programmierer möchte ich, dass die Webseite nicht nach 20 falschen Antworten plötzlich abstürzt oder sonstige Faxen macht.
| 4    | Muss                |Qualität| Als ein Programmierer möchte ich eine Falle bei ungültigen Zahlen einbauen, damit es wirklich nur an die Vorgabe limitiert ist
| 5   | Kann               |Qualität| Als ein Spieler möchte ich, dass nach 2 falschen Schätzungen eine kleinere Zahlenspanne ausgegeben wird, damit man immer schneller zur richtigen Zahl kommt.             


### 1.3 Testfälle

| TC-№ | Ausgangslage | Eingabe | Erwartete Ausgabe |
| ---- | ------------ | ------- | ----------------- |
| 1.1  | Benutzer startet das Spiel | gibt eine Zahl ein | gesuchte Zahl ist grösser/kleiner |
| 2.1  | Zahl finden beim Start | Zahl verstecken, Tipps vorbereiten | Tipp grösser/kleiner |                   
| 3.1  | 2 falsche Zahlen eingegeben | 3.Zahl eingeben | soll normal funktionieren wie immer |
| 4.1  | ungültige Zahl eingegeben | nichts mehr möglich bzw. Spiel manipuliert
| 5.1  | 2 falsche Zahlen eingegeben | erneut falsche Zahl eingeben | Zahlenspanne verkürzt (grosser Tipp) |


### 1.4 Diagramme



## 2 Planen

| AP-№ | Frist | Zuständig | Beschreibung | geplante Zeit |
| ---- | ----- | --------- | ------------ | ------------- |
| 1.A  | 06.09.22 | Veljkovic Simon | Infos/Tipps für den Spieler vorbereiten | 60 Minuten |
| 2.A  | 06.09.22 | Veljkovic Simon | Zahl bestimmen, richtige Tipps ausgeben | 60 Minuten |              
| 3.A  | 06.09.22 | Veljkovic Simon | unbegrenzte Versuche einbauen, ohne das System zu überlasten | 60 Minuten |
| 4.A  | 06.09.22 | Veljkovic Simon | nach einer bestimmten Anzahl Schätzungen kleinere Zeitspanne einsetzen | 60 Minuten |
Total: 240 Minuten (4 Stunden)





## 3 Entscheiden



## 4 Realisieren

| AP-№ | Datum | Zuständig | geplante Zeit | tatsächliche Zeit |
| ---- | ----- | --------- | ------------- | ----------------- |
| 1.A | 06.09.22       |Veljkovic Simon           |60 Minuten               |90 Minuten                   |
| 2.A | 06.09.22       |Veljkovic Simon           |60 Minuten               |90 Minuten                   |
| 3.A | 06.09.22       |Veljkovic Simon           |60 Minuten               |90 Minuten                   |
| 4.A | 06.09.22       |Veljkovic Simon           |60 Minuten               |90 Minuten                   |
| 5.A | 06.09.22       |Veljkovic Simon           |60 Minuten               |nicht verwirklicht           |



## 5 Kontrollieren

### 5.1 Testprotokoll

| TC-№ | Datum | Resultat | Tester |
| ---- | ----- | -------- | ------ |
| 1.1  | 13.09.22      |funktioniert          |Simon Veljkovic        |
| 2.1  | 13.09.22      |funktioniert          |Simon Veljkovic        |
| 3.1  | 13.09.22      |funktioniert          |Simon Veljkovic        |
| 4.1  | 13.09.22      |funktioniert          |Simon Veljkovic        |

Alles funktioniert, nur die "Kann" User Story konnte nicht umgesetzt werden.

### 5.2 Exploratives Testen

| BR-№ | Ausgangslage | Eingabe | Erwartete Ausgabe | Tatsächliche Ausgabe |
| ---- | ------------ | ------- | ----------------- | -------------------- |
| I    |Benutzer startet das Spiel| hiqhfb |Spiel wird beendet  |Spiel stürzt ab |


✍️ Ausgeführt von Rebecca Willi

## 6 Auswerten


