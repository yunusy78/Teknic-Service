INSERT INTO [dbo].[Notifications] ([NotificationID], [Title], [Content], [Status])
VALUES
   (NEWID(), 'Forventet Levering', 'Pakken din er på vei! Forventet leveringsdato: 15. oktober 2023', 1),
   (NEWID(), 'Betaling Fullført', 'Betalingen din ble vellykket mottatt. Takk!', 0),
   (NEWID(), 'Ny Kampanje', 'Stor rabatt på våre nye produkter! Sjekk dem ut nå.', 1),
   (NEWID(), 'Konto Sikkerhet', 'For din konto sikkerhet, vennligst oppdater passordet ditt.', 0),
   (NEWID(), 'Ny Produkt Annonse', 'Utforsk våre nyeste produkter. Tilgjengelig nå!', 1),
   (NEWID(), 'Nyhetsbrev Abonnement', 'Abonner på nyhetsbrevet vårt og hold deg oppdatert på kampanjer.', 0),
   (NEWID(), 'Kundeservice Kontakt', 'Kundeservice er tilgjengelig 24/7 for din hjelp.', 1),
   (NEWID(), 'Ordre Avbrutt', 'Din ordre ble avbrutt. Tilbakebetalingsprosessen har startet.', 0),
   (NEWID(), 'Nye Produkter På Lager', 'Våre mest populære produkter er nå på lager! Bestill nå.', 1),
   (NEWID(), 'Tidspunkt Justering', 'Vintertid starter snart. Ikke glem å stille klokken tilbake!', 0);
