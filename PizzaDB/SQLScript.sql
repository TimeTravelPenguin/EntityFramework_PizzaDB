CREATE TABLE [Addresses] (
    [AddressId] int NOT NULL IDENTITY,
    [StreetAddress] nvarchar(50) NOT NULL,
    [Suburb] nvarchar(50) NOT NULL,
    [PostCode] nvarchar(4) NOT NULL,
    [State] int NOT NULL,
    CONSTRAINT [PK_Addresses] PRIMARY KEY ([AddressId])
);
GO


CREATE TABLE [Banks] (
    [BankId] int NOT NULL IDENTITY,
    [Bsb] nvarchar(6) NOT NULL,
    [BankName] nvarchar(25) NOT NULL,
    CONSTRAINT [PK_Banks] PRIMARY KEY ([BankId])
);
GO


CREATE TABLE [Contacts] (
    [ContactId] int NOT NULL IDENTITY,
    [ContactName] nvarchar(30) NOT NULL,
    [ContactNumber] nvarchar(10) NOT NULL,
    CONSTRAINT [PK_Contacts] PRIMARY KEY ([ContactId])
);

CREATE TABLE [Customers] (
    [CustomerId] int NOT NULL IDENTITY,
    [FirstName] nvarchar(25) NOT NULL,
    [LastName] nvarchar(25) NOT NULL,
    CONSTRAINT [PK_Customers] PRIMARY KEY ([CustomerId])
);
GO


CREATE TABLE [Discounts] (
    [DiscountId] int NOT NULL IDENTITY,
    [DiscountCode] int NOT NULL,
    [Description] nvarchar(200) NOT NULL,
    CONSTRAINT [PK_Discounts] PRIMARY KEY ([DiscountId])
);
GO


CREATE TABLE [Ingredients] (
    [IngredientId] int NOT NULL IDENTITY,
    [IngredientName] nvarchar(25) NULL,
    [IngredientType] int NOT NULL,
    CONSTRAINT [PK_Ingredients] PRIMARY KEY ([IngredientId])
);
GO


CREATE TABLE [MenuItems] (
    [MenuItemId] int NOT NULL IDENTITY,
    [Name] nvarchar(50) NULL,
    [SellPrice] float NOT NULL,
    CONSTRAINT [PK_MenuItems] PRIMARY KEY ([MenuItemId])
);
GO


CREATE TABLE [Suppliers] (
    [SupplierId] int NOT NULL IDENTITY,
    [Name] nvarchar(50) NULL,
    CONSTRAINT [PK_Suppliers] PRIMARY KEY ([SupplierId])
);
GO


CREATE TABLE [BankAccounts] (
    [BankAccountId] int NOT NULL IDENTITY,
    [BankId] int NOT NULL,
    [AccountNumber] nvarchar(20) NOT NULL,
    CONSTRAINT [PK_BankAccounts] PRIMARY KEY ([BankAccountId]),
    CONSTRAINT [FK_BankAccounts_Banks_BankId] FOREIGN KEY ([BankId]) REFERENCES [Banks] ([BankId]) ON DELETE CASCADE
);
GO


CREATE TABLE [CustomerAddresses] (
    [CustomerId] int NOT NULL,
    [AddressId] int NOT NULL,
    CONSTRAINT [PK_CustomerAddresses] PRIMARY KEY ([CustomerId], [AddressId]),
    CONSTRAINT [FK_CustomerAddresses_Addresses_AddressId] FOREIGN KEY ([AddressId]) REFERENCES [Addresses] ([AddressId]) ON DELETE CASCADE,
    CONSTRAINT [FK_CustomerAddresses_Customers_CustomerId] FOREIGN KEY ([CustomerId]) REFERENCES [Customers] ([CustomerId]) ON DELETE CASCADE
);
GO


CREATE TABLE [Payments] (
    [PaymentId] int NOT NULL IDENTITY,
    [CustomerId] int NOT NULL,
    [DiscountId] int NOT NULL,
    [DiscountPercentage] float NOT NULL,
    [PaymentSubTotal] float NOT NULL,
    [PaymentTax] float NOT NULL,
    [PaymentTotal] float NOT NULL,
    CONSTRAINT [PK_Payments] PRIMARY KEY ([PaymentId]),
    CONSTRAINT [FK_Payments_Customers_CustomerId] FOREIGN KEY ([CustomerId]) REFERENCES [Customers] ([CustomerId]) ON DELETE CASCADE,
    CONSTRAINT [FK_Payments_Discounts_DiscountId] FOREIGN KEY ([DiscountId]) REFERENCES [Discounts] ([DiscountId]) ON DELETE CASCADE
);
GO


CREATE TABLE [IngredientStocks] (
    [IngredientStockId] int NOT NULL IDENTITY,
    [IngredientId] int NOT NULL,
    [CurrentStockLevel] int NOT NULL,
    [RecommendedStockLevel] int NOT NULL,
    [ReorderStockLevel] int NOT NULL,
    CONSTRAINT [PK_IngredientStocks] PRIMARY KEY ([IngredientStockId]),
    CONSTRAINT [FK_IngredientStocks_Ingredients_IngredientId] FOREIGN KEY ([IngredientId]) REFERENCES [Ingredients] ([IngredientId]) ON DELETE CASCADE
);
GO


CREATE TABLE [StockTakes] (
    [StockTakeId] int NOT NULL IDENTITY,
    [IngredientId] int NOT NULL,
    [DateTime] datetime2 NOT NULL,
    [StockLevel] int NOT NULL,
    CONSTRAINT [PK_StockTakes] PRIMARY KEY ([StockTakeId]),
    CONSTRAINT [FK_StockTakes_Ingredients_IngredientId] FOREIGN KEY ([IngredientId]) REFERENCES [Ingredients] ([IngredientId]) ON DELETE CASCADE
);
GO


CREATE TABLE [MenuItemIngredients] (
    [MenuItemId] int NOT NULL,
    [IngredientId] int NOT NULL,
    CONSTRAINT [PK_MenuItemIngredients] PRIMARY KEY ([MenuItemId], [IngredientId]),
    CONSTRAINT [FK_MenuItemIngredients_Ingredients_IngredientId] FOREIGN KEY ([IngredientId]) REFERENCES [Ingredients] ([IngredientId]) ON DELETE CASCADE,
    CONSTRAINT [FK_MenuItemIngredients_MenuItems_MenuItemId] FOREIGN KEY ([MenuItemId]) REFERENCES [MenuItems] ([MenuItemId]) ON DELETE CASCADE
);
GO


CREATE TABLE [IngredientSuppliers] (
    [IngredientId] int NOT NULL,
    [SupplierId] int NOT NULL,
    CONSTRAINT [PK_IngredientSuppliers] PRIMARY KEY ([IngredientId], [SupplierId]),
    CONSTRAINT [FK_IngredientSuppliers_Ingredients_IngredientId] FOREIGN KEY ([IngredientId]) REFERENCES [Ingredients] ([IngredientId]) ON DELETE CASCADE,
    CONSTRAINT [FK_IngredientSuppliers_Suppliers_SupplierId] FOREIGN KEY ([SupplierId]) REFERENCES [Suppliers] ([SupplierId]) ON DELETE CASCADE
);
GO


CREATE TABLE [Employees] (
    [EmployeeId] int NOT NULL IDENTITY,
    [ContactId] int NOT NULL,
    [FirstName] nvarchar(max) NOT NULL,
    [LastName] nvarchar(max) NOT NULL,
    [AddressId] int NOT NULL,
    [TaxFileNumber] nvarchar(9) NOT NULL,
    [BankAccountId] int NOT NULL,
    [EmployeeType] int NOT NULL,
    [PayRatePerDelivery] float NULL,
    [PayRatePerHour] float NULL,
    CONSTRAINT [PK_Employees] PRIMARY KEY ([EmployeeId]),
    CONSTRAINT [FK_Employees_Addresses_AddressId] FOREIGN KEY ([AddressId]) REFERENCES [Addresses] ([AddressId]) ON DELETE CASCADE,
    CONSTRAINT [FK_Employees_BankAccounts_BankAccountId] FOREIGN KEY ([BankAccountId]) REFERENCES [BankAccounts] ([BankAccountId]) ON DELETE CASCADE,
    CONSTRAINT [FK_Employees_Contacts_ContactId] FOREIGN KEY ([ContactId]) REFERENCES [Contacts] ([ContactId]) ON DELETE CASCADE
);
GO


CREATE TABLE [Orders] (
    [OrderId] int NOT NULL IDENTITY,
    [PaymentId] int NOT NULL,
    [DateTimeOrderPlaced] datetime2 NOT NULL,
    [DateTimeOrderDue] datetime2 NOT NULL,
    [DateTimeOrderFulfilled] datetime2 NULL,
    CONSTRAINT [PK_Orders] PRIMARY KEY ([OrderId]),
    CONSTRAINT [FK_Orders_Payments_PaymentId] FOREIGN KEY ([PaymentId]) REFERENCES [Payments] ([PaymentId]) ON DELETE CASCADE
);
GO


CREATE INDEX [IX_BankAccounts_BankId] ON [BankAccounts] ([BankId]);
GO


CREATE INDEX [IX_CustomerAddresses_AddressId] ON [CustomerAddresses] ([AddressId]);
GO


CREATE UNIQUE INDEX [IX_Discounts_DiscountCode] ON [Discounts] ([DiscountCode]);
GO


CREATE INDEX [IX_Employees_AddressId] ON [Employees] ([AddressId]);
GO


CREATE INDEX [IX_Employees_BankAccountId] ON [Employees] ([BankAccountId]);
GO


CREATE INDEX [IX_Employees_ContactId] ON [Employees] ([ContactId]);
GO


CREATE INDEX [IX_IngredientStocks_IngredientId] ON [IngredientStocks] ([IngredientId]);
GO


CREATE INDEX [IX_IngredientSuppliers_SupplierId] ON [IngredientSuppliers] ([SupplierId]);
GO


CREATE INDEX [IX_MenuItemIngredients_IngredientId] ON [MenuItemIngredients] ([IngredientId]);
GO


CREATE INDEX [IX_Orders_PaymentId] ON [Orders] ([PaymentId]);
GO


CREATE INDEX [IX_Payments_CustomerId] ON [Payments] ([CustomerId]);
GO


CREATE INDEX [IX_Payments_DiscountId] ON [Payments] ([DiscountId]);
GO


CREATE UNIQUE INDEX [IX_StockTakes_IngredientId] ON [StockTakes] ([IngredientId]);
GO


