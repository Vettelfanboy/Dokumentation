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
| 4    | Kann               |Qualität| Als ein Spieler möchte ich, dass nach 2 falschen Schätzungen eine kleinere Zahlenspanne ausgegeben wird, damit man immer schneller zur richtigen Zahl kommt.             
✍️ Jede User Story hat eine ganzzahlige Nummer (1, 2, 3 etc.), eine Verbindlichkeit (Muss oder Kann?), und einen Typ (Funktional, Qualität, Rand). Die User Story selber hat folgende Form: *Als ein 🤷‍♂️ möchte ich 🤷‍♂️, damit 🤷‍♂️*.

### 1.3 Testfälle

| TC-№ | Ausgangslage | Eingabe | Erwartete Ausgabe |
| ---- | ------------ | ------- | ----------------- |
| 1.1  | Benutzer startet das Spiel | gibt eine Zahl ein | gesuchte Zahl ist grösser/kleiner |
| 2.1  | Zahl finden beim Start | Zahl verstecken, Tipps vorbereiten | Tipp grösser/kleiner |                   
| 3.1  | 2 falsche Zahlen eingegeben | 3.Zahl eingeben | soll normal funktionieren wie immer |
| 4.1  | 2 falsche Zahlen eingegeben | erneut falsche Zahl eingeben | Zahlenspanne verkürzt (grosser Tipp) |
✍️ Die Nummer hat das Format `N.m`, wobei `N` die Nummer der User Story ist, die der Testfall abdeckt, und `m` von `1` an nach oben gezählt. Beispiel: Der dritte Testfall, der die zweite User Story abdeckt, hat also die Nummer `2.3`.

### 1.4 Diagramme

✍️ Hier können Sie PAPs, Use Case- und Gantt-Diagramme oder Ähnliches einfügen.

## 2 Planen

| AP-№ | Frist | Zuständig | Beschreibung | geplante Zeit |
| ---- | ----- | --------- | ------------ | ------------- |
| 1.A  | 06.09.22 | Veljkovic Simon | Infos/Tipps für den Spieler vorbereiten | 60 Minuten |
| 2.A  | 06.09.22 | Veljkovic Simon | Zahl bestimmen, richtige Tipps ausgeben | 60 Minuten |              
| 3.A  | 06.09.22 | Veljkovic Simon | unbegrenzte Versuche einbauen, ohne das System zu überlasten | 60 Minuten |
| 4.A  | 06.09.22 | Veljkovic Simon | nach einer bestimmten Anzahl Schätzungen kleinere Zeitspanne einsetzen | 60 Minuten |
Total: 240 Minuten (4 Stunden)

✍️ Die Nummer hat das Format `N.m`, wobei `N` die Nummer der User Story ist, auf die sich das Arbeitspaket bezieht, und `m` von `A` an nach oben buchstabiert. Beispiel: Das dritte Arbeitspaket, das die zweite User Story betrifft, hat also die Nummer `2.C`.

✍️ Ein Arbeitspaket sollte etwa 45' für eine Person in Anspruch nehmen. Die totale Anzahl Arbeitspakete sollte etwa Folgendem entsprechen: `Anzahl R-Sitzungen` ╳ `Anzahl Gruppenmitglieder` ╳ `4`. Wenn Sie also zu dritt an einem Projekt arbeiten, für welches zwei R-Sitzungen geplant sind, sollten Sie auf `2` ╳ `3` ╳`4` = `24` Arbeitspakete kommen. Sollten Sie merken, dass Sie hier nicht genügend Arbeitspakte haben, denken Sie sich weitere "Kann"-User Stories für Kapitel 1.2 aus.

## 3 Entscheiden

✍️ Dokumentieren Sie hier Ihre Entscheidungen und Annahmen, die Sie im Bezug auf Ihre User Stories und die Implementierung getroffen haben.

## 4 Realisieren

| AP-№ | Datum | Zuständig | geplante Zeit | tatsächliche Zeit |
| ---- | ----- | --------- | ------------- | ----------------- |
| 1.A  | 06.09.22      |Veljkovic Simon           |60 Minuten               |90 Minuten                   |
| 2.A | 06.09.22       |Veljkovic Simon           |60 Minuten               |90 Minuten                   |
| 3.A | 06.09.22       |Veljkovic Simon           |60 Minuten               |90 Minuten                   |
| 4.A | 06.09.22       |Veljkovic Simon           |60 Minuten               |nicht verwirklicht

✍️ Tragen Sie jedes Mal, wenn Sie ein Arbeitspaket abschließen, hier ein, wie lang Sie effektiv dafür hatten.

## 5 Kontrollieren

### 5.1 Testprotokoll

| TC-№ | Datum | Resultat | Tester |
| ---- | ----- | -------- | ------ |
| 1.1  |       |          |        |
| ...  |       |          |        |

✍️ Vergessen Sie nicht, ein Fazit hinzuzufügen, welches das Test-Ergebnis einordnet.

### 5.2 Exploratives Testen

| BR-№ | Ausgangslage | Eingabe | Erwartete Ausgabe | Tatsächliche Ausgabe |
| ---- | ------------ | ------- | ----------------- | -------------------- |
| I    |              |         |                   |                      |
| ...  |              |         |                   |                      |

✍️ Verwenden Sie römische Ziffern für Ihre Bug Reports, also I, II, III, IV etc.

## 6 Auswerten

✍️ Fügen Sie hier eine Verknüpfung zu Ihrem Lern-Bericht ein.
