-- Örnek 25 Norveçli müşteri kaydı
INSERT INTO [dbo].[Customers] ([CustomerID], [FirstName], [LastName], [Title], [Address], [City], [Region], [PostalCode], [Country], [Phone], [Bank], [Email])
VALUES
  (NEWID(), 'Hans', 'Andersen', 'Bay', 'Storgata 123', 'Oslo', 'Oslo', '0123', 'Norveç', '+47 1234 5678', 'Nordea Bank', 'hans.andersen@example.no'),
(NEWID(), 'Ingrid', 'Larsen', 'Bayan', 'Grensen 45', 'Bergen', 'Hordaland', '0456', 'Norveç', '+47 2345 6789', 'DNB Bank', 'ingrid.larsen@example.no'),
(NEWID(), 'Erik', 'Pedersen', 'Bay', 'Trondheimsveien 78', 'Trondheim', 'Sør-Trøndelag', '0789', 'Norveç', '+47 3456 7890', 'SpareBank 1', 'erik.pedersen@example.no'),
(NEWID(), 'Kari', 'Johansen', 'Bayan', 'Strandgaten 56', 'Stavanger', 'Rogaland', '0567', 'Norveç', '+47 4567 8901', 'Sbanken', 'kari.johansen@example.no'),
(NEWID(), 'Andreas', 'Olsen', 'Bay', 'Skippergata 32', 'Drammen', 'Buskerud', '0321', 'Norveç', '+47 5678 9012', 'Handelsbanken', 'andreas.olsen@example.no'),
(NEWID(), 'Mette', 'Solberg', 'Bayan', 'Kongensgate 87', 'Bodø', 'Nordland', '0876', 'Norveç', '+47 6789 0123', 'DNB Bank', 'mette.solberg@example.no'),
(NEWID(), 'Ole', 'Kristensen', 'Bay', 'Kirkeveien 14', 'Trondheim', 'Sør-Trøndelag', '0789', 'Norveç', '+47 3456 7890', 'SpareBank 1', 'ole.kristensen@example.no'),
(NEWID(), 'Marianne', 'Haugen', 'Bayan', 'Karl Johans Gate 33', 'Oslo', 'Oslo', '0123', 'Norveç', '+47 1234 5678', 'Nordea Bank', 'marianne.haugen@example.no'),
(NEWID(), 'Per', 'Andresen', 'Bay', 'Dronningens Gate 2', 'Bergen', 'Hordaland', '0456', 'Norveç', '+47 2345 6789', 'DNB Bank', 'per.andresen@example.no'),
(NEWID(), 'Kirsten', 'Moen', 'Bayan', 'Olav Tryggvasons Gate 67', 'Trondheim', 'Sør-Trøndelag', '0789', 'Norveç', '+47 3456 7890', 'SpareBank 1', 'kirsten.moen@example.no'),
(NEWID(), 'Geir', 'Eide', 'Bay', 'Kongsgata 11', 'Stavanger', 'Rogaland', '0567', 'Norveç', '+47 4567 8901', 'Sbanken', 'geir.eide@example.no'),
(NEWID(), 'Lise', 'Iversen', 'Bayan', 'Brugata 22', 'Drammen', 'Buskerud', '0321', 'Norveç', '+47 5678 9012', 'Handelsbanken', 'lise.iversen@example.no'),
(NEWID(), 'Anders', 'Sivertsen', 'Bay', 'Strandgaten 7', 'Bodø', 'Nordland', '0876', 'Norveç', '+47 6789 0123', 'DNB Bank', 'anders.sivertsen@example.no'),
(NEWID(), 'Lars', 'Nilsen', 'Bay', 'Kongensgate 89', 'Trondheim', 'Sør-Trøndelag', '0789', 'Norveç', '+47 3456 7890', 'SpareBank 1', 'lars.nilsen@example.no'),
(NEWID(), 'Mette', 'Olsen', 'Bayan', 'Karl Johans Gate 45', 'Oslo', 'Oslo', '0123', 'Norveç', '+47 1234 5678', 'Nordea Bank', 'mette.olsen@example.no'),
(NEWID(), 'Ola', 'Hansen', 'Bay', 'Olav Tryggvasons Gate 21', 'Bergen', 'Hordaland', '0456', 'Norveç', '+47 2345 6789', 'DNB Bank', 'ola.hansen@example.no'),
(NEWID(), 'Kari', 'Solberg', 'Bayan', 'Sjøgata 5', 'Trondheim', 'Sør-Trøndelag', '0789', 'Norveç', '+47 3456 7890', 'SpareBank 1', 'kari.solberg@example.no'),
(NEWID(), 'Anders', 'Larsen', 'Bay', 'Kirkeveien 32', 'Stavanger', 'Rogaland', '0567', 'Norveç', '+47 4567 8901', 'Sbanken', 'anders.larsen@example.no'),
(NEWID(), 'Marianne', 'Kristiansen', 'Bayan', 'Karl Johans Gate 55', 'Drammen', 'Buskerud', '0321', 'Norveç', '+47 5678 9012', 'Handelsbanken', 'marianne.kristiansen@example.no'),
(NEWID(), 'Erik', 'Moen', 'Bay', 'Strandveien 11', 'Bodø', 'Nordland', '0876', 'Norveç', '+47 6789 0123', 'DNB Bank', 'erik.moen@example.no');


-- Agder eyaletinden müşteri kaydı ekle
INSERT INTO [dbo].[Customers] ([CustomerID], [FirstName], [LastName], [Title], [Address], [City], [Region], [PostalCode], [Country], [Phone], [Bank], [Email])
VALUES
   (NEWID(), 'Melo', 'Solberg', 'Bay', 'Agder Cad. 123', 'Arendal', 'Agder', '0123', 'Norvec', '+47 1234 5678', 'Agder Bank', 'agder.musteri@example.no');

-- Troms eyaletinden müşteri kaydı ekle
INSERT INTO [dbo].[Customers] ([CustomerID], [FirstName], [LastName], [Title], [Address], [City], [Region], [PostalCode], [Country], [Phone], [Bank], [Email])
VALUES
   (NEWID(), 'Troms', 'Musteri', 'Bayan', 'Troms Cad. 456', 'Tromsø', 'Troms', '0456', 'Norvec', '+47 4567 8901', 'Troms Bank', 'troms.musteri@example.no');
