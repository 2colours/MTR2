﻿// Please see documentation at https://docs.microsoft.com/aspnet/core/client-side/bundling-and-minification
// for details on configuring this project to bundle and minify static web assets.

// Write your Javascript code.

const names = {
	1: [
		["Alpár", "Fruzsina", "Bazil"],
		["Ábel", "Gergely", "Vazul"],
		["Genovéva", "Gyöngyvér", "Benjámin", "Dzsenifer"],
		["Titusz", "Leona", "Angéla"],
		["Simon", "Emília"],
		["Gáspár", "Menyhért", "Boldizsár"],
		["Attila", "Ramóna", "Rajmund", "Bálint"],
		["Gyöngyvér", "Szeverin", "Szörény"],
		["Marcell", "Juliánusz"],
		["Melánia", "Vilmos", "Vilma"],
		["Ágota", "Honoráta"],
		["Ernő", "Erneszta", "Tatjána"],
		["Veronika", "Csongor", "Yvett"],
		["Bódog", "Félix"],
		["Lóránt", "Loránd", "Pál"],
		["Gusztáv", "Marcell"],
		["Antal", "Antónia"],
		["Margit", "Piroska"],
		["Sára", "Márta", "Márió"],
		["Fábián", "Sebestyén"],
		["Ágnes", "Agnéta"],
		["Vince", "Artúr"],
		["Zelma", "Rajmund", "Emerencia", "Emese"],
		["Timót", "Ferenc"],
		["Pál", "Henrik"],
		["Vanda", "Paula", "Timóteusz"],
		["Angéla", "Angelika"],
		["Károly", "Karola", "Tamás"],
		["Adél", "Valér"],
		["Martina", "Gerda", "Jácinta"],
		["Marcella", "János"]
	],
	2: [
		["Ignác", "Brigitta", "Kincső"],
		["Karolina", "Karola", "Aida"],
		["Balázs", "Oszkár", "Celerina"],
		["Ráhel", "Csenge", "Veronika", "András"],
		["Ágota", "Ingrid", "Etelka", "Léda"],
		["Dorottya", "Dóra", "Pál"],
		["Tódor", "Rómeó", "Richárd"],
		["Aranka", "Jeromos"],
		["Abigél", "Alex", "Apollónia"],
		["Elvira"],
		["Bertold", "Marietta"],
		["Lívia", "Lídia", "Eulália"],
		["Ella", "Linda", "Levente", "Katalin"],
		["Bálint", "Valentin", "Cirill", "Metód"],
		["Kolos", "Györgyi", "Georgina"],
		["Julianna", "Lilla", "Filippa"],
		["Donát"],
		["Bernadett", "Simon", "Zenkő"],
		["Zsuzsanna", "Eliza", "Konrád"],
		["Aladár", "Álmos", "Leó"],
		["Eleonóra", "Zelmira", "Péter"],
		["Gerzson", "Margit", "Zétény"],
		["Alfréd", "Polikárp", "Mirtill"],
		/* leap */
		["Mátyás", "Jázmin"],
		["Géza", "Cézár", "Vanda"],
		["Edina", "Viktor", "Győző"],
		["Ákos", "Bátor", "Gábor"],
		["Elemér", "Oszvald", "Román"]
	],
	3: [
		["Albin", "Albina", "Leonita", "Lea"],
		["Lujza", "Ágnes", "Henrik", "Magor"],
		["Kornélia", "Kunigunda", "Frigyes"],
		["Kázmér", "Lúciusz", "Zorán"],
		["Adorján", "Adrián"],
		["Leonóra", "Inez", "Koletta"],
		["Tamás", "Perpétua", "Felicitász"],
		["János", "Zoltán", "Apolka"],
		["Franciska", "Fanni"],
		["Ildikó", "Emil", "Gusztáv"],
		["Szilárd", "Tímea", "Konstantin"],
		["Gergely", "Maximilián"],
		["Krisztián", "Ajtony", "Egyed", "Patrícia"],
		["Matild", "Matilda", "Trilla"],
		["Kristóf", "Kelemen"],
		["Henrietta", "Herbert"],
		["Gertrúd", "Patrik"],
		["Sándor", "Ede", "Cirill"],
		["József", "Bánk"],
		["Klaudia", "Alexandra"],
		["Benedek", "Bence", "Miklós"],
		["Beáta", "Izolda", "Lea"],
		["Emőke", "Botond", "Ottó", "Kartal"],
		["Gábor", "Karina"],
		["Irén", "Írisz", "Lúcia"],
		["Emánuel", "Emánuéla", "Larissza", "Árpád"],
		["Hajnalka", "Lídia", "Auguszta"],
		["Gedeon", "Johanna"],
		["Auguszta", "Bertold"],
		["Zalán"],
		["Árpád", "Benjámin", "Benő"]
	],
	4: [
		["Hugó", "Agád"],
		["Áron", "Ferenc"],
		["Buda", "Richárd", "Hóvirág", "Indira"],
		["Izidor"],
		["Vince", "Irén", "Teodóra"],
		["Vilmos", "Bíborka", "Taksony", "Celesztin"],
		["Herman", "János"],
		["Dénes", "Valér", "Valter"],
		["Erhard", "Ákos", "Döme"],
		["Zsolt", "Ezékiel"],
		["Leó", "Szaniszló", "Glória"],
		["Gyula", "Baldvin", "Sába"],
		["Ida", "Márton", "Hermina"],
		["Tibor"],
		["Anasztázia", "Tas", "Oktávia"],
		["Csongor", "Bernadett"],
		["Rudolf", "Izidóra"],
		["Andrea", "Ilma", "Apolló", "Aladár"],
		["Emma", "Malvin", "Zseraldina"],
		["Tivadar", "Tihamér", "Töhötöm"],
		["Konrád", "Zelmira", "Anzelm"],
		["Csilla", "Noémi", "Kájusz"],
		["Béla", "Adalbert"],
		["György", "Fidél", "Debóra"],
		["Márk", "Ányos"],
		["Ervin", "Klétusz"],
		["Zita", "Mariann", "Anasztáz"],
		["Valéria", "Péter"],
		["Péter", "Katalin", "Roberta"],
		["Katalin", "Kitti", "Zsófia", "Piusz"]
	],
	5: [
		["Fülöp", "Jakab", "Zsaklin", "Jefte", "József"],
		["Zsigmond", "Atanáz", "Zoé"],
		["Tímea", "Irma", "Jakab", "Fülöp"],
		["Mónika", "Flórián"],
		["Györgyi", "Irén"],
		["Ivett", "Frida", "Judit", "Yvett"],
		["Gizella", "Gusztáv", "Bendegúz"],
		["Mihály", "Győző"],
		["Gergely", "Katinka", "Alberta", "Édua"],
		["Ármin", "Pálma", "Izidor"],
		["Ferenc"],
		["Pongrác"],
		["Szervác", "Imola", "Imelda"],
		["Bonifác", "Gyöngyi"],
		["Zsófia", "Szonja", "Döníz"],
		["Mózes", "Botond", "János"],
		["Paszkál", "Ditmár", "Rezeda"],
		["Erik", "Alexandra", "János"],
		["Ivó", "Iván", "Milán"],
		["Bernát", "Bernardin", "Felícia"],
		["Konstantin", "András"],
		["Júlia", "Rita", "Emil"],
		["Dezső", "Vilmos", "Renáta"],
		["Eszter", "Eliza", "Vanessza"],
		["Orbán", "Gergely"],
		["Fülöp", "Evelin"],
		["Hella", "Pelbárt", "Ágoston"],
		["Emil", "Csanád", "Vilmos"],
		["Magdolna", "Magda", "Ervin", "Léna"],
		["Janka", "Zsanett", "Johanna", "Nándor"],
		["Angéla", "Petronella"]
	],
	6: [
		["Tünde", "Jusztinusz"],
		["Kármen", "Anita", "Péter", "Marcellinusz"],
		["Klotild", "Cecília", "Károly"],
		["Bulcsú", "Kerény", "Kerubin"],
		["Fatime", "Fatima", "Bonifác"],
		["Norbert", "Norberta", "Cintia"],
		["Róbert", "Robertina", "Arianna", "Fülöp", "Roberta"],
		["Medárd", "Helga"],
		["Félix", "Előd", "Annamária", "Annabella"],
		["Margit", "Gréta"],
		["Barnabás"],
		["Villő", "Orfeusz", "Adelaida"],
		["Antal", "Anett"],
		["Vazul", "Elizeus", "Herta"],
		["Jolán", "Vid", "Viola"],
		["Jusztin", "Jusztina", "Auréliusz"],
		["Laura", "Alida", "Alina", "Szabolcs", "Adolf", "Bató"],
		["Arnold", "Levente", "Doloróza"],
		["Gyárfás", "Romuald"],
		["Rafael", "Dina"],
		["Alajos", "Leila"],
		["Paulina", "Tamás"],
		["Zoltán", "Szultána"],
		["János", "Iván"],
		["Vilmos", "Viola", "Vilma"],
		["János", "Pál", "Cirill"],
		["László", "Sámson"],
		["Levente", "Irén", "Iréneusz"],
		["Péter", "Pál", "Emőke", "Judit", "Petra", "Szulamit", "Ivett"],
		["Pál"]
	],
	7: [
		["Tihamér", "Annamária", "Olivér", "Áron"],
		["Ottó"],
		["Kornél", "Soma", "Tamás"],
		["Ulrik", "Erzsébet"],
		["Emese", "Sarolta", "Lotti", "Antal"],
		["Csaba", "Mária"],
		["Apollónia", "Vilibald", "Bene"],
		["Ellák", "Edgár", "Eperke"],
		["Lukrécia", "Veronika", "Hajnalka"],
		["Amália", "Melina", "Engelbert", "Ulrika"],
		["Nóra", "Lili", "Nelli", "Benedek"],
		["Izabella", "Dalma", "Eleonóra"],
		["Jenő", "Henrik"],
		["Örs", "Stella", "Kamil"],
		["Örkény", "Henrik", "Roland", "Bonaventúra"],
		["Valter", "Irma"],
		["Endre", "Elek", "András"],
		["Szömér", "Frigyes", "Milla", "Hedvig", "Mirkó"],
		["Emília"],
		["Illés", "Margaréta"],
		["Dániel", "Daniella", "Lőrinc"],
		["Magdolna", "Mária", "Magda"],
		["Lenke", "Brigitta", "Apollinár"],
		["Kinga", "Kunigunda", "Kincső", "Krisztina"],
		["Kristóf", "Jakab"],
		["Anna", "Anikó", "Joakim"],
		["Olga", "Liliána", "Natália", "Pantaleon"],
		["Szabolcs", "Alina", "Ince", "Győző"],
		["Márta", "Flóra"],
		["Judit", "Xénia", "Péter"],
		["Oszkár", "Ignác", "Bató"]
	],
	8: [
		["Boglárka", "Nimród", "Alfonz"],
		["Lehel"],
		["Hermina", "Lídia", "Kamélia", "Mirtill"],
		["Domonkos", "Dominik", "János", "Dominika"],
		["Krisztina"],
		["Berta", "Bettina"],
		["Ibolya"],
		["László", "Domonkos"],
		["Emőd", "Román"],
		["Lőrinc", "Blanka", "Csilla"],
		["Zsuzsanna", "Tiborc", "Klára"],
		["Klára", "Hilária", "Diána"],
		["Ipoly", "Ince", "Vitália"],
		["Marcell", "Maximilián"],
		["Mária"],
		["Ábrahám", "Rókus"],
		["Jácint", "Réka", "Hetény"],
		["Ilona", "Rajnald"],
		["Huba", "Marián", "Emília"],
		["István", "Bernát"],
		["Sámuel", "Hajna", "Piusz"],
		["Menyhért", "Mirjam"],
		["Bence", "Róza", "Szidónia"],
		["Bertalan", "Aliz", "Detre"],
		["Lajos", "Patrícia"],
		["Izsó", "Tália", "Natália", "Zamfira"],
		["Gáspár", "Mónika"],
		["Ágoston", "Mózes"],
		["Beatrix", "Erna"],
		["Rózsa", "Félix", "Letícia"],
		["Erika", "Bella", "Arisztid"]
	],
	9: [
		["Egyed", "Egon", "Noémi", "Tamara"],
		["Rebeka", "Dorina", "Renáta", "Ingrid", "István"],
		["Hilda", "Gergely"],
		["Rozália", "Róza", "Ida"],
		["Viktor", "Lőrinc", "Ofélia"],
		["Zakariás", "Beáta"],
		["Regina"],
		["Mária", "Adrienn"],
		["Ádám", "Péter"],
		["Nikolett", "Hunor", "Miklós"],
		["Teodóra", "Jácint", "Igor", "Helga"],
		["Mária", "Irma"],
		["Kornél", "János"],
		["Szeréna", "Roxána"],
		["Enikő", "Melitta"],
		["Edit", "Ciprián"],
		["Zsófia", "Róbert"],
		["Diána", "József"],
		["Vilhelmina", "Januáriusz", "Dorián"],
		["Friderika"],
		["Máté", "Mirella", "Jónás"],
		["Móric", "Tamás"],
		["Tekla", "Líviusz", "Ila"],
		["Gellért", "Gerda", "Mercédesz"],
		["Eufrozina", "Kende"],
		["Jusztina", "Kozma", "Damján"],
		["Adalbert", "Vince"],
		["Vencel", "Salamon"],
		["Mihály", "Gábor", "Rafael", "Mirabella"],
		["Jeromos", "Honória", "Hunor"]
	],
	10: [
		["Malvin", "Teréz"],
		["Petra", "Örs"],
		["Helga", "Évald"],
		["Ferenc", "Hajnalka"],
		["Aurél", "Placid", "Attila", "Rella"],
		["Brúnó", "Renáta", "Renátó"],
		["Amália", "Bekény"],
		["Koppány", "Benedikta"],
		["Dénes", "János"],
		["Gedeon", "Ferenc", "Bendegúz"],
		["Brigitta", "Placida", "Etel", "Gitta"],
		["Miksa", "Rezső", "Edvin"],
		["Kálmán", "Ede", "Edvárd"],
		["Helén", "Kaldixtusz"],
		["Teréz", "Aranka"],
		["Gál", "Margit", "Hedvig"],
		["Hedvig", "Ignác", "Rudolf"],
		["Lukács", "Jusztusz"],
		["Nándor", "János", "Pál"],
		["Vendel", "Irén", "Kleopátra"],
		["Orsolya", "Zsolt"],
		["Előd", "Szalóme", "Kordélia"],
		["Gyöngyvér", "János", "Gyöngyi"],
		["Salamon", "Antal"],
		["Blanka", "Bianka", "Mór"],
		["Dömötör", "Armand", "Örs"],
		["Szabina", "Antonietta"],
		["Simon", "Szimonetta", "Szimóna", "Júdás", "Tádé"],
		["Nárcisz", "Melinda", "Őzike"],
		["Alfonz", "Zenóbia"],
		["Farkas", "Rodrigó", "Wolfgang"]
	],
	11: [
		["Marianna"],
		["Achilles", "Bató"],
		["Győző", "Márton"],
		["Károly", "Karola"],
		["Imre", "Zakariás", "Tétény"],
		["Lénárd", "Krisztina"],
		["Csenger", "Rezső", "Ernő", "Florentin"],
		["Zsombor", "Kolos", "Gottfrid"],
		["Tivadar"],
		["Réka", "András", "Leó"],
		["Márton", "Atád", "Tódor"],
		["Jónás", "Renátó", "Jozafát"],
		["Szilvia", "Szaniszló"],
		["Aliz", "Vanda", "Huba", "Klementina"],
		["Albert", "Lipót"],
		["Ödön", "Margit"],
		["Hortenzia", "Gergő", "Dénes"],
		["Jenő"],
		["Erzsébet", "Zsóka"],
		["Jolán", "Zsolt", "Ödön", "Bódog"],
		["Olivér"],
		["Cecília", "Filemon"],
		["Kelemen", "Klementina", "Kolumbán"],
		["Emma", "Flóra", "Virág"],
		["Katalin", "Liza", "Katinka"],
		["Virág", "Szvetlana", "Konrád", "Viktória", "Milos"],
		["Virgil", "Virgínia"],
		["Stefánia", "Jakab"],
		["Taksony", "Ilma", "Filoména"],
		["András", "Andor", "Andrea"]
	],
	12: [
		["Elza", "Natália", "Blanka", "Bonita"],
		["Melinda", "Vivien", "Aranka"],
		["Ferenc", "Olívia"],
		["Borbála", "Barbara", "János"],
		["Vilma", "Ünige", "Csaba"],
		["Miklós", "Csinszka", "Gyopár", "Gyopárka"],
		["Ambrus", "Ambrózia"],
		["Mária", "Emőke"],
		["Natália", "Valéria", "Filótea"],
		["Judit", "Loretta", "Eulália"],
		["Árpád", "Árpádina", "Damazusz"],
		["Gabriella", "Johanna", "Franciska"],
		["Luca", "Otília", "Lúcia", "Éda", "Tilia"],
		["Szilárda", "Szilárd", "János"],
		["Valér", "Detre"],
		["Etelka", "Aletta", "Adelaida"],
		["Lázár", "Olimpia"],
		["Auguszta", "Gracián"],
		["Viola", "Anasztáz"],
		["Teofil", "Liberátusz"],
		["Tamás", "Péter"],
		["Zénó", "Flórián"],
		["Viktória", "János"],
		["Ádám", "Éva", "Adél"],
		["Eugénia", "Anasztázia"],
		["István"],
		["János", "Teodor"],
		["Kamilla", "Apor"],
		["Tamás", "Tamara"],
		["Dávid", "Hunor", "Libériusz"],
		["Szilveszter", "Donáta"]
	]
};