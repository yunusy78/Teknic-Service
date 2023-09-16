-- Kategori 1
INSERT INTO [dbo].[Categories] ([CategoryId], [Name], [Status])
VALUES (NEWID(), 'Electronics', 1);

-- Kategori 2
INSERT INTO [dbo].[Categories] ([CategoryId], [Name], [Status])
VALUES (NEWID(), 'Clothing', 1);

-- Kategori 3
INSERT INTO [dbo].[Categories] ([CategoryId], [Name], [Status])
VALUES (NEWID(), 'Furniture', 1);

-- Kategori 4
INSERT INTO [dbo].[Categories] ([CategoryId], [Name], [Status])
VALUES (NEWID(), 'Books', 1);

-- Kategori 5
INSERT INTO [dbo].[Categories] ([CategoryId], [Name], [Status])
VALUES (NEWID(), 'Sports Equipment', 1);

-- Kategori 6
INSERT INTO [dbo].[Categories] ([CategoryId], [Name], [Status])
VALUES (NEWID(), 'Toys', 1);

-- Kategori 7
INSERT INTO [dbo].[Categories] ([CategoryId], [Name], [Status])
VALUES (NEWID(), 'Beauty Products', 1);

-- Kategori 8
INSERT INTO [dbo].[Categories] ([CategoryId], [Name], [Status])
VALUES (NEWID(), 'Home Appliances', 1);

-- Kategori 9
INSERT INTO [dbo].[Categories] ([CategoryId], [Name], [Status])
VALUES (NEWID(), 'Jewelry', 1);

-- Kategori 10
INSERT INTO [dbo].[Categories] ([CategoryId], [Name], [Status])
VALUES (NEWID(), 'Food and Beverages', 1);





-- Ürün 1
INSERT INTO [dbo].[Products] ([ProductID], [ProductName], [CategoryID], [PurchasePrice], [UnitPrice], [UnitsInStock], [Status])
VALUES (NEWID(), 'Smartphone', '360b7ff3-8a34-44e7-a22e-4bb63bdeed81', 200.00, 299.99, 50, 1);

-- Ürün 2
INSERT INTO [dbo].[Products] ([ProductID], [ProductName], [CategoryID], [PurchasePrice], [UnitPrice], [UnitsInStock], [Status])
VALUES (NEWID(), 'Laptop', '360b7ff3-8a34-44e7-a22e-4bb63bdeed81', 500.00, 799.99, 25, 1);

-- Ürün 3
INSERT INTO [dbo].[Products] ([ProductID], [ProductName], [CategoryID], [PurchasePrice], [UnitPrice], [UnitsInStock], [Status])
VALUES (NEWID(), 'T-Shirt', '21507c87-cb91-4a4a-a7d3-2d6105d1ed5c', 10.00, 19.99, 100, 1);

-- Ürün 4
INSERT INTO [dbo].[Products] ([ProductID], [ProductName], [CategoryID], [PurchasePrice], [UnitPrice], [UnitsInStock], [Status])
VALUES (NEWID(), 'Jeans', '21507c87-cb91-4a4a-a7d3-2d6105d1ed5c', 15.00, 29.99, 75, 1);

-- Ürün 5
INSERT INTO [dbo].[Products] ([ProductID], [ProductName], [CategoryID], [PurchasePrice], [UnitPrice], [UnitsInStock], [Status])
VALUES (NEWID(), 'Chocolate', '1f8093e2-6c20-4f04-8f91-33f9ec44a8be', 2.00, 4.99, 200, 1);

-- Ürün 6
INSERT INTO [dbo].[Products] ([ProductID], [ProductName], [CategoryID], [PurchasePrice], [UnitPrice], [UnitsInStock], [Status])
VALUES (NEWID(), 'LED TV', '360b7ff3-8a34-44e7-a22e-4bb63bdeed81', 400.00, 599.99, 30, 1);

-- Ürün 7
INSERT INTO [dbo].[Products] ([ProductID], [ProductName], [CategoryID], [PurchasePrice], [UnitPrice], [UnitsInStock], [Status])
VALUES (NEWID(), 'Table', 'e7bf7716-ba48-4c50-8243-70369c73c468', 50.00, 89.99, 40, 1);

-- Ürün 8
INSERT INTO [dbo].[Products] ([ProductID], [ProductName], [CategoryID], [PurchasePrice], [UnitPrice], [UnitsInStock], [Status])
VALUES (NEWID(), 'Action Figure', 'd3404b13-4a55-4af6-8577-72ca42432b09', 5.00, 12.99, 150, 1);

-- Ürün 9
INSERT INTO [dbo].[Products] ([ProductID], [ProductName], [CategoryID], [PurchasePrice], [UnitPrice], [UnitsInStock], [Status])
VALUES (NEWID(), 'Microwave Oven', '04c9adec-8cd1-4596-9dd0-8a27f5524ce8', 75.00, 129.99, 20, 1);

-- Ürün 10
INSERT INTO [dbo].[Products] ([ProductID], [ProductName], [CategoryID], [PurchasePrice], [UnitPrice], [UnitsInStock], [Status])
VALUES (NEWID(), 'Basketball', '3a2159c1-df43-4151-a28e-c039538d65c3', 10.00, 19.99, 50, 1);

-- Ürün 11
INSERT INTO [dbo].[Products] ([ProductID], [ProductName], [CategoryID], [PurchasePrice], [UnitPrice], [UnitsInStock], [Status])
VALUES (NEWID(), 'Earrings', '6a1e0462-2381-4595-bd1e-c220ddd78072', 15.00, 29.99, 30, 1);

-- Ürün 12
INSERT INTO [dbo].[Products] ([ProductID], [ProductName], [CategoryID], [PurchasePrice], [UnitPrice], [UnitsInStock], [Status])
VALUES (NEWID(), 'Running Shoes', '3a2159c1-df43-4151-a28e-c039538d65c3', 20.00, 49.99, 40, 1);

-- Ürün 13
INSERT INTO [dbo].[Products] ([ProductID], [ProductName], [CategoryID], [PurchasePrice], [UnitPrice], [UnitsInStock], [Status])
VALUES (NEWID(), 'Cooking Pot', '04c9adec-8cd1-4596-9dd0-8a27f5524ce8', 10.00, 24.99, 60, 1);

-- Ürün 14
INSERT INTO [dbo].[Products] ([ProductID], [ProductName], [CategoryID], [PurchasePrice], [UnitPrice], [UnitsInStock], [Status])
VALUES (NEWID(), 'Novel', '9e6b8e10-fb9d-42fc-a56a-04ba2db03478', 5.00, 12.99, 100, 1);

-- Ürün 15
INSERT INTO [dbo].[Products] ([ProductID], [ProductName], [CategoryID], [PurchasePrice], [UnitPrice], [UnitsInStock], [Status])
VALUES (NEWID(), 'Perfume', '36476c2a-4cdb-4cde-abdf-d7239d92aeee', 10.00, 24.99, 80, 1);

-- Ürün 16
INSERT INTO [dbo].[Products] ([ProductID], [ProductName], [CategoryID], [PurchasePrice], [UnitPrice], [UnitsInStock], [Status])
VALUES (NEWID(), 'Desk Chair', 'e7bf7716-ba48-4c50-8243-70369c73c468', 40.00, 89.99, 25, 1);

-- Ürün 17
INSERT INTO [dbo].[Products] ([ProductID], [ProductName], [CategoryID], [PurchasePrice], [UnitPrice], [UnitsInStock], [Status])
VALUES (NEWID(), 'Soccer Ball', '3a2159c1-df43-4151-a28e-c039538d65c3', 12.00, 24.99, 70, 1);

-- Ürün 18
INSERT INTO [dbo].[Products] ([ProductID], [ProductName], [CategoryID], [PurchasePrice], [UnitPrice], [UnitsInStock], [Status])
VALUES (NEWID(), 'Dining Table', 'e7bf7716-ba48-4c50-8243-70369c73c468', 60.00, 129.99, 15, 1);

-- Ürün 19
INSERT INTO [dbo].[Products] ([ProductID], [ProductName], [CategoryID], [PurchasePrice], [UnitPrice], [UnitsInStock], [Status])
VALUES (NEWID(), 'Necklace', '6a1e0462-2381-4595-bd1e-c220ddd78072', 25.00, 49.99, 40, 1);

-- Ürün 20
INSERT INTO [dbo].[Products] ([ProductID], [ProductName], [CategoryID], [PurchasePrice], [UnitPrice], [UnitsInStock], [Status])
VALUES (NEWID(), 'Headphones', '360b7ff3-8a34-44e7-a22e-4bb63bdeed81', 15.00, 29.99, 50, 1);
