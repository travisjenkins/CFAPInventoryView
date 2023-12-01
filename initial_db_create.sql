IF NOT EXISTS (SELECT name FROM master.dbo.sysdatabases WHERE name = N'[CFAPInventory]')
BEGIN
    CREATE DATABASE [CFAPInventory];
END
GO

USE [CFAPInventory];
GO

IF NOT EXISTS (SELECT * FROM INFORMATION_SCHEMA.TABLES WHERE TABLE_NAME = 'AgeGroups')
BEGIN
    CREATE TABLE [AgeGroups] (
        [AgeGroupId] uniqueidentifier NOT NULL,
        [Description] nvarchar(50) NOT NULL,
        [SortOrder] int NOT NULL,
        [LastUpdateId] nvarchar(max) NULL,
        [LastUpdateDateTime] datetime2 NOT NULL,
        CONSTRAINT [PK_AgeGroups] PRIMARY KEY ([AgeGroupId])
    );
END
GO

IF NOT EXISTS (SELECT * FROM INFORMATION_SCHEMA.TABLES WHERE TABLE_NAME = 'AspNetRoles')
BEGIN
    CREATE TABLE [AspNetRoles] (
        [Id] nvarchar(450) NOT NULL,
        [Name] nvarchar(256) NULL,
        [NormalizedName] nvarchar(256) NULL,
        [ConcurrencyStamp] nvarchar(max) NULL,
        CONSTRAINT [PK_AspNetRoles] PRIMARY KEY ([Id])
    );
END
GO

IF NOT EXISTS (SELECT * FROM INFORMATION_SCHEMA.TABLES WHERE TABLE_NAME = 'AspNetUsers')
BEGIN
    CREATE TABLE [AspNetUsers] (
        [Id] nvarchar(450) NOT NULL,
        [FirstName] nvarchar(max) NOT NULL,
        [LastName] nvarchar(max) NOT NULL,
        [Address1] nvarchar(max) NOT NULL,
        [Address2] nvarchar(max) NULL,
        [City] nvarchar(max) NOT NULL,
        [State] nvarchar(max) NOT NULL,
        [ZipCode] nvarchar(10) NOT NULL,
        [RegisteredOn] datetime2 NULL,
        [LastLogin] datetime2 NULL,
        [UserName] nvarchar(256) NULL,
        [NormalizedUserName] nvarchar(256) NULL,
        [Email] nvarchar(256) NULL,
        [NormalizedEmail] nvarchar(256) NULL,
        [EmailConfirmed] bit NOT NULL,
        [PasswordHash] nvarchar(max) NULL,
        [SecurityStamp] nvarchar(max) NULL,
        [ConcurrencyStamp] nvarchar(max) NULL,
        [PhoneNumber] nvarchar(max) NULL,
        [PhoneNumberConfirmed] bit NOT NULL,
        [TwoFactorEnabled] bit NOT NULL,
        [LockoutEnd] datetimeoffset NULL,
        [LockoutEnabled] bit NOT NULL,
        [AccessFailedCount] int NOT NULL,
        CONSTRAINT [PK_AspNetUsers] PRIMARY KEY ([Id])
    );
END
GO

IF NOT EXISTS (SELECT * FROM INFORMATION_SCHEMA.TABLES WHERE TABLE_NAME = 'Categories')
BEGIN
    CREATE TABLE [Categories] (
        [CategoryId] uniqueidentifier NOT NULL,
        [Name] nvarchar(150) NOT NULL,
        [Quantity] int NOT NULL,
        [SafeStockLevel] int NOT NULL,
        [LastUpdateId] nvarchar(max) NULL,
        [LastUpdateDateTime] datetime2 NOT NULL,
        CONSTRAINT [PK_Categories] PRIMARY KEY ([CategoryId])
    );
END
GO

IF NOT EXISTS (SELECT * FROM INFORMATION_SCHEMA.TABLES WHERE TABLE_NAME = 'Donors')
BEGIN
    CREATE TABLE [Donors] (
        [DonorId] uniqueidentifier NOT NULL,
        [FirstName] nvarchar(max) NOT NULL,
        [LastName] nvarchar(max) NOT NULL,
        [Address1] nvarchar(max) NOT NULL,
        [Address2] nvarchar(max) NULL,
        [City] nvarchar(max) NOT NULL,
        [State] nvarchar(max) NOT NULL,
        [ZipCode] nvarchar(10) NOT NULL,
        [LastUpdateId] nvarchar(max) NULL,
        [LastUpdateDateTime] datetime2 NOT NULL,
        CONSTRAINT [PK_Donors] PRIMARY KEY ([DonorId])
    );
END
GO

IF NOT EXISTS (SELECT * FROM INFORMATION_SCHEMA.TABLES WHERE TABLE_NAME = 'Ethnicities')
BEGIN
    CREATE TABLE [Ethnicities] (
        [EthnicityId] uniqueidentifier NOT NULL,
        [Description] nvarchar(50) NOT NULL,
        [LastUpdateId] nvarchar(max) NULL,
        [LastUpdateDateTime] datetime2 NOT NULL,
        CONSTRAINT [PK_Ethnicities] PRIMARY KEY ([EthnicityId])
    );
END
GO

IF NOT EXISTS (SELECT * FROM INFORMATION_SCHEMA.TABLES WHERE TABLE_NAME = 'ExcludeCategories')
BEGIN
    CREATE TABLE [ExcludeCategories] (
        [ExcludeCategoryId] uniqueidentifier NOT NULL,
        [Name] nvarchar(150) NOT NULL,
        [Quantity] int NOT NULL,
        [LastUpdateId] nvarchar(max) NULL,
        [LastUpdateDateTime] datetime2 NOT NULL,
        CONSTRAINT [PK_ExcludeCategories] PRIMARY KEY ([ExcludeCategoryId])
    );
END
GO

IF NOT EXISTS (SELECT * FROM INFORMATION_SCHEMA.TABLES WHERE TABLE_NAME = 'Genders')
BEGIN
    CREATE TABLE [Genders] (
        [GenderId] uniqueidentifier NOT NULL,
        [Description] nvarchar(50) NOT NULL,
        [LastUpdateId] nvarchar(max) NULL,
        [LastUpdateDateTime] datetime2 NOT NULL,
        CONSTRAINT [PK_Genders] PRIMARY KEY ([GenderId])
    );
END
GO

IF NOT EXISTS (SELECT * FROM INFORMATION_SCHEMA.TABLES WHERE TABLE_NAME = 'OptionalCategories')
BEGIN
    CREATE TABLE [OptionalCategories] (
        [OptionalCategoryId] uniqueidentifier NOT NULL,
        [Name] nvarchar(150) NOT NULL,
        [Quantity] int NOT NULL,
        [SafeStockLevel] int NOT NULL,
        [LastUpdateId] nvarchar(max) NULL,
        [LastUpdateDateTime] datetime2 NOT NULL,
        CONSTRAINT [PK_OptionalCategories] PRIMARY KEY ([OptionalCategoryId])
    );
END
GO

IF NOT EXISTS (SELECT * FROM INFORMATION_SCHEMA.TABLES WHERE TABLE_NAME = 'Recipients')
BEGIN
    CREATE TABLE [Recipients] (
        [RecipientId] uniqueidentifier NOT NULL,
        [FirstName] nvarchar(max) NOT NULL,
        [LastName] nvarchar(max) NOT NULL,
        [Address1] nvarchar(max) NOT NULL,
        [Address2] nvarchar(max) NULL,
        [City] nvarchar(max) NOT NULL,
        [State] nvarchar(max) NOT NULL,
        [ZipCode] nvarchar(10) NOT NULL,
        [IsFosterParent] bit NOT NULL,
        [IsAdoptiveParent] bit NOT NULL,
        [LastUpdateId] nvarchar(max) NULL,
        [LastUpdateDateTime] datetime2 NOT NULL,
        CONSTRAINT [PK_Recipients] PRIMARY KEY ([RecipientId])
    );
END
GO

IF NOT EXISTS (SELECT * FROM INFORMATION_SCHEMA.TABLES WHERE TABLE_NAME = 'AspNetRoleClaims')
BEGIN
    CREATE TABLE [AspNetRoleClaims] (
        [Id] int NOT NULL IDENTITY,
        [RoleId] nvarchar(450) NOT NULL,
        [ClaimType] nvarchar(max) NULL,
        [ClaimValue] nvarchar(max) NULL,
        CONSTRAINT [PK_AspNetRoleClaims] PRIMARY KEY ([Id]),
        CONSTRAINT [FK_AspNetRoleClaims_AspNetRoles_RoleId] FOREIGN KEY ([RoleId]) REFERENCES [AspNetRoles] ([Id]) ON DELETE CASCADE
    );
END
GO

IF NOT EXISTS (SELECT * FROM INFORMATION_SCHEMA.TABLES WHERE TABLE_NAME = 'AspNetUserClaims')
BEGIN
    CREATE TABLE [AspNetUserClaims] (
        [Id] int NOT NULL IDENTITY,
        [UserId] nvarchar(450) NOT NULL,
        [ClaimType] nvarchar(max) NULL,
        [ClaimValue] nvarchar(max) NULL,
        CONSTRAINT [PK_AspNetUserClaims] PRIMARY KEY ([Id]),
        CONSTRAINT [FK_AspNetUserClaims_AspNetUsers_UserId] FOREIGN KEY ([UserId]) REFERENCES [AspNetUsers] ([Id]) ON DELETE CASCADE
    );
END
GO

IF NOT EXISTS (SELECT * FROM INFORMATION_SCHEMA.TABLES WHERE TABLE_NAME = 'AspNetUserLogins')
BEGIN
    CREATE TABLE [AspNetUserLogins] (
        [LoginProvider] nvarchar(128) NOT NULL,
        [ProviderKey] nvarchar(128) NOT NULL,
        [ProviderDisplayName] nvarchar(max) NULL,
        [UserId] nvarchar(450) NOT NULL,
        CONSTRAINT [PK_AspNetUserLogins] PRIMARY KEY ([LoginProvider], [ProviderKey]),
        CONSTRAINT [FK_AspNetUserLogins_AspNetUsers_UserId] FOREIGN KEY ([UserId]) REFERENCES [AspNetUsers] ([Id]) ON DELETE CASCADE
    );
END
GO

IF NOT EXISTS (SELECT * FROM INFORMATION_SCHEMA.TABLES WHERE TABLE_NAME = 'AspNetUserRoles')
BEGIN
    CREATE TABLE [AspNetUserRoles] (
        [UserId] nvarchar(450) NOT NULL,
        [RoleId] nvarchar(450) NOT NULL,
        CONSTRAINT [PK_AspNetUserRoles] PRIMARY KEY ([UserId], [RoleId]),
        CONSTRAINT [FK_AspNetUserRoles_AspNetRoles_RoleId] FOREIGN KEY ([RoleId]) REFERENCES [AspNetRoles] ([Id]) ON DELETE CASCADE,
        CONSTRAINT [FK_AspNetUserRoles_AspNetUsers_UserId] FOREIGN KEY ([UserId]) REFERENCES [AspNetUsers] ([Id]) ON DELETE CASCADE
    );
END
GO

IF NOT EXISTS (SELECT * FROM INFORMATION_SCHEMA.TABLES WHERE TABLE_NAME = 'AspNetUserTokens')
BEGIN
    CREATE TABLE [AspNetUserTokens] (
        [UserId] nvarchar(450) NOT NULL,
        [LoginProvider] nvarchar(128) NOT NULL,
        [Name] nvarchar(128) NOT NULL,
        [Value] nvarchar(max) NULL,
        CONSTRAINT [PK_AspNetUserTokens] PRIMARY KEY ([UserId], [LoginProvider], [Name]),
        CONSTRAINT [FK_AspNetUserTokens_AspNetUsers_UserId] FOREIGN KEY ([UserId]) REFERENCES [AspNetUsers] ([Id]) ON DELETE CASCADE
    );
END
GO

IF NOT EXISTS (SELECT * FROM INFORMATION_SCHEMA.TABLES WHERE TABLE_NAME = 'Baskets')
BEGIN
    CREATE TABLE [Baskets] (
        [BasketId] uniqueidentifier NOT NULL,
        [BasketNumber] int NULL,
        [AgeGroupId] uniqueidentifier NOT NULL,
        [EthnicityId] uniqueidentifier NOT NULL,
        [GenderId] uniqueidentifier NOT NULL,
        [DateAssembled] datetime2 NOT NULL,
        [Quantity] int NULL,
        [SafeStockLevel] int NULL,
        [IsShoppingListItem] bit NOT NULL,
        [LastUpdateId] nvarchar(max) NULL,
        [LastUpdateDateTime] datetime2 NOT NULL,
        CONSTRAINT [PK_Baskets] PRIMARY KEY ([BasketId]),
        CONSTRAINT [FK_Baskets_AgeGroups_AgeGroupId] FOREIGN KEY ([AgeGroupId]) REFERENCES [AgeGroups] ([AgeGroupId]) ON DELETE CASCADE,
        CONSTRAINT [FK_Baskets_Ethnicities_EthnicityId] FOREIGN KEY ([EthnicityId]) REFERENCES [Ethnicities] ([EthnicityId]) ON DELETE CASCADE,
        CONSTRAINT [FK_Baskets_Genders_GenderId] FOREIGN KEY ([GenderId]) REFERENCES [Genders] ([GenderId]) ON DELETE CASCADE
    );
END
GO

IF NOT EXISTS (SELECT * FROM INFORMATION_SCHEMA.TABLES WHERE TABLE_NAME = 'AgeGroupCategories')
BEGIN
    CREATE TABLE [AgeGroupCategories] (
        [AgeGroupCategoryId] uniqueidentifier NOT NULL,
        [AgeGroupId] uniqueidentifier NOT NULL,
        [CategoryId] uniqueidentifier NULL,
        [OptionalCategoryId] uniqueidentifier NULL,
        [ExcludeCategoryId] uniqueidentifier NULL,
        CONSTRAINT [PK_AgeGroupCategories] PRIMARY KEY ([AgeGroupCategoryId]),
        CONSTRAINT [FK_AgeGroupCategories_AgeGroups_AgeGroupId] FOREIGN KEY ([AgeGroupId]) REFERENCES [AgeGroups] ([AgeGroupId]) ON DELETE CASCADE,
        CONSTRAINT [FK_AgeGroupCategories_Categories_CategoryId] FOREIGN KEY ([CategoryId]) REFERENCES [Categories] ([CategoryId]),
        CONSTRAINT [FK_AgeGroupCategories_ExcludeCategories_ExcludeCategoryId] FOREIGN KEY ([ExcludeCategoryId]) REFERENCES [ExcludeCategories] ([ExcludeCategoryId]),
        CONSTRAINT [FK_AgeGroupCategories_OptionalCategories_OptionalCategoryId] FOREIGN KEY ([OptionalCategoryId]) REFERENCES [OptionalCategories] ([OptionalCategoryId])
    );
END
GO

IF NOT EXISTS (SELECT * FROM INFORMATION_SCHEMA.TABLES WHERE TABLE_NAME = 'Supplies')
BEGIN
    CREATE TABLE [Supplies] (
        [SupplyId] uniqueidentifier NOT NULL,
        [Name] nvarchar(100) NOT NULL,
        [CategoryId] uniqueidentifier NULL,
        [OptionalCategoryId] uniqueidentifier NULL,
        [ExcludeCategoryId] uniqueidentifier NULL,
        [Description] nvarchar(max) NULL,
        [Expires] bit NOT NULL,
        [ExpirationDate] datetime2 NULL,
        [PurchaseDate] datetime2 NOT NULL,
        [Quantity] int NOT NULL,
        [Price] decimal(13,4) NOT NULL,
        [Barcode] nvarchar(100) NULL,
        [LastUpdateId] nvarchar(max) NULL,
        [LastUpdateDateTime] datetime2 NOT NULL,
        CONSTRAINT [PK_Supplies] PRIMARY KEY ([SupplyId]),
        CONSTRAINT [FK_Supplies_Categories_CategoryId] FOREIGN KEY ([CategoryId]) REFERENCES [Categories] ([CategoryId]),
        CONSTRAINT [FK_Supplies_ExcludeCategories_ExcludeCategoryId] FOREIGN KEY ([ExcludeCategoryId]) REFERENCES [ExcludeCategories] ([ExcludeCategoryId]),
        CONSTRAINT [FK_Supplies_OptionalCategories_OptionalCategoryId] FOREIGN KEY ([OptionalCategoryId]) REFERENCES [OptionalCategories] ([OptionalCategoryId])
    );
END
GO

IF NOT EXISTS (SELECT * FROM INFORMATION_SCHEMA.TABLES WHERE TABLE_NAME = 'BasketTransactions')
BEGIN
    CREATE TABLE [BasketTransactions] (
        [BasketTransactionId] uniqueidentifier NOT NULL,
        [BasketId] uniqueidentifier NOT NULL,
        [RecipientId] uniqueidentifier NOT NULL,
        [DateDistributed] datetime2 NOT NULL,
        [DistributedBy] nvarchar(max) NULL,
        [LastUpdateId] nvarchar(max) NULL,
        [LastUpdateDateTime] datetime2 NOT NULL,
        [DonorId] uniqueidentifier NULL,
        CONSTRAINT [PK_BasketTransactions] PRIMARY KEY ([BasketTransactionId]),
        CONSTRAINT [FK_BasketTransactions_Baskets_BasketId] FOREIGN KEY ([BasketId]) REFERENCES [Baskets] ([BasketId]) ON DELETE CASCADE,
        CONSTRAINT [FK_BasketTransactions_Donors_DonorId] FOREIGN KEY ([DonorId]) REFERENCES [Donors] ([DonorId]),
        CONSTRAINT [FK_BasketTransactions_Recipients_RecipientId] FOREIGN KEY ([RecipientId]) REFERENCES [Recipients] ([RecipientId]) ON DELETE CASCADE
    );
END
GO

IF NOT EXISTS (SELECT * FROM INFORMATION_SCHEMA.TABLES WHERE TABLE_NAME = 'CategoryBaskets')
BEGIN
    CREATE TABLE [CategoryBaskets] (
        [CategoryBasketId] uniqueidentifier NOT NULL,
        [BasketId] uniqueidentifier NOT NULL,
        [CategoryId] uniqueidentifier NULL,
        [OptionalCategoryId] uniqueidentifier NULL,
        [ExcludeCategoryId] uniqueidentifier NULL,
        [LastUpdateId] nvarchar(max) NULL,
        [LastUpdateDateTime] datetime2 NOT NULL,
        CONSTRAINT [PK_CategoryBaskets] PRIMARY KEY ([CategoryBasketId]),
        CONSTRAINT [FK_CategoryBaskets_Baskets_BasketId] FOREIGN KEY ([BasketId]) REFERENCES [Baskets] ([BasketId]) ON DELETE CASCADE,
        CONSTRAINT [FK_CategoryBaskets_Categories_CategoryId] FOREIGN KEY ([CategoryId]) REFERENCES [Categories] ([CategoryId]),
        CONSTRAINT [FK_CategoryBaskets_ExcludeCategories_ExcludeCategoryId] FOREIGN KEY ([ExcludeCategoryId]) REFERENCES [ExcludeCategories] ([ExcludeCategoryId]),
        CONSTRAINT [FK_CategoryBaskets_OptionalCategories_OptionalCategoryId] FOREIGN KEY ([OptionalCategoryId]) REFERENCES [OptionalCategories] ([OptionalCategoryId])
    );
END
GO

IF NOT EXISTS (SELECT * FROM INFORMATION_SCHEMA.TABLES WHERE TABLE_NAME = 'SupplyBaskets')
BEGIN
    CREATE TABLE [SupplyBaskets] (
        [SupplyBasketId] uniqueidentifier NOT NULL,
        [BasketId] uniqueidentifier NOT NULL,
        [SupplyId] uniqueidentifier NOT NULL,
        [LastUpdateId] nvarchar(max) NULL,
        [LastUpdateDateTime] datetime2 NOT NULL,
        CONSTRAINT [PK_SupplyBaskets] PRIMARY KEY ([SupplyBasketId]),
        CONSTRAINT [FK_SupplyBaskets_Baskets_BasketId] FOREIGN KEY ([BasketId]) REFERENCES [Baskets] ([BasketId]) ON DELETE CASCADE,
        CONSTRAINT [FK_SupplyBaskets_Supplies_SupplyId] FOREIGN KEY ([SupplyId]) REFERENCES [Supplies] ([SupplyId]) ON DELETE CASCADE
    );
END
GO

IF NOT EXISTS (SELECT * FROM INFORMATION_SCHEMA.TABLES WHERE TABLE_NAME = 'SupplyTransactions')
BEGIN
    CREATE TABLE [SupplyTransactions] (
        [SupplyTransactionId] uniqueidentifier NOT NULL,
        [SupplyId] uniqueidentifier NOT NULL,
        [RecipientId] uniqueidentifier NOT NULL,
        [DateDistributed] datetime2 NOT NULL,
        [DistributedBy] nvarchar(max) NULL,
        [LastUpdateId] nvarchar(max) NULL,
        [LastUpdateDateTime] datetime2 NOT NULL,
        [DonorId] uniqueidentifier NULL,
        CONSTRAINT [PK_SupplyTransactions] PRIMARY KEY ([SupplyTransactionId]),
        CONSTRAINT [FK_SupplyTransactions_Donors_DonorId] FOREIGN KEY ([DonorId]) REFERENCES [Donors] ([DonorId]),
        CONSTRAINT [FK_SupplyTransactions_Recipients_RecipientId] FOREIGN KEY ([RecipientId]) REFERENCES [Recipients] ([RecipientId]) ON DELETE CASCADE,
        CONSTRAINT [FK_SupplyTransactions_Supplies_SupplyId] FOREIGN KEY ([SupplyId]) REFERENCES [Supplies] ([SupplyId]) ON DELETE CASCADE
    );
END
GO

IF NOT EXISTS (SELECT 1 FROM [AgeGroups])
BEGIN
    IF EXISTS (SELECT * FROM [sys].[identity_columns] WHERE [name] IN (N'AgeGroupId', N'Description', N'LastUpdateDateTime', N'LastUpdateId', N'SortOrder') AND [object_id] = OBJECT_ID(N'[AgeGroups]'))
        SET IDENTITY_INSERT [AgeGroups] ON;
    INSERT INTO [AgeGroups] ([AgeGroupId], [Description], [LastUpdateDateTime], [LastUpdateId], [SortOrder])
    VALUES ('290c1063-f288-46ef-8377-3113586b7c62', N'12-18', '2023-11-27T15:38:38.4888980-06:00', N'travis@mailsac.com', 5),
    ('39d9931f-e6a6-449d-aa69-d7aad053e298', N'1-2', '2023-11-27T15:38:38.4888980-06:00', N'travis@mailsac.com', 2),
    ('75200021-5b2f-4079-96be-7e38a1ad1adb', N'3-6', '2023-11-27T15:38:38.4888980-06:00', N'travis@mailsac.com', 3),
    ('e7581e8f-e2ac-4550-aac7-d4ff7fe778e1', N'6-12 months', '2023-11-27T15:38:38.4888970-06:00', N'travis@mailsac.com', 1),
    ('ed2da6d8-a312-489d-b7d0-253d75c6c820', N'0-6 months', '2023-11-27T15:38:38.4888930-06:00', N'travis@mailsac.com', 0),
    ('f574f025-f5c3-4611-96d7-ad679e6b1467', N'7-11', '2023-11-27T15:38:38.4888980-06:00', N'travis@mailsac.com', 4);
    IF EXISTS (SELECT * FROM [sys].[identity_columns] WHERE [name] IN (N'AgeGroupId', N'Description', N'LastUpdateDateTime', N'LastUpdateId', N'SortOrder') AND [object_id] = OBJECT_ID(N'[AgeGroups]'))
        SET IDENTITY_INSERT [AgeGroups] OFF;
END
GO

IF NOT EXISTS (SELECT 1 FROM [Categories])
BEGIN
    IF EXISTS (SELECT * FROM [sys].[identity_columns] WHERE [name] IN (N'CategoryId', N'LastUpdateDateTime', N'LastUpdateId', N'Name', N'Quantity', N'SafeStockLevel') AND [object_id] = OBJECT_ID(N'[Categories]'))
        SET IDENTITY_INSERT [Categories] ON;
    INSERT INTO [Categories] ([CategoryId], [LastUpdateDateTime], [LastUpdateId], [Name], [Quantity], [SafeStockLevel])
    VALUES ('027ea222-f944-41b8-8dea-7f922c43c8a3', '2023-11-27T15:38:38.4889570-06:00', N'travis@mailsac.com', N'Body lotion', 5, 3),
    ('039c1f4e-7a2c-4b4a-9aee-53f4957a7b01', '2023-11-27T15:38:38.4889500-06:00', N'travis@mailsac.com', N'Baby brush/comb', 5, 3),
    ('067ac574-c50a-4f2c-b8d7-52877ea217d4', '2023-11-27T15:38:38.4889500-06:00', N'travis@mailsac.com', N'Leak-proof water bottle', 5, 3),
    ('07ebd8cf-f55b-47a9-bf52-072a1f89e16f', '2023-11-27T15:38:38.4889430-06:00', N'travis@mailsac.com', N'Body wash or mild soap (unscented)', 5, 3),
    ('0c2c3738-e62e-4875-b786-46246636769b', '2023-11-27T15:38:38.4889480-06:00', N'travis@mailsac.com', N'Baby blanket or sleep sack', 5, 3),
    ('0dda4f68-adc2-4136-b8cd-5efff84ae6ce', '2023-11-27T15:38:38.4889510-06:00', N'travis@mailsac.com', N'Satin bonnet or hair scarf', 5, 3),
    ('17d0900f-c48d-4059-8caa-7697af8efbe0', '2023-11-27T15:38:38.4889570-06:00', N'travis@mailsac.com', N'Twin sheet set', 5, 3),
    ('18b0b2a3-3163-463d-b8a1-c6314aee6766', '2023-11-27T15:38:38.4889620-06:00', N'travis@mailsac.com', N'Detangling comb', 5, 3),
    ('1aa58da2-d195-4ffc-9bb7-51920ea8fde4', '2023-11-27T15:38:38.4889490-06:00', N'travis@mailsac.com', N'Stuffed animal', 5, 3),
    ('1db3a928-231f-48f2-acaf-16747cfdd4ad', '2023-11-27T15:38:38.4889450-06:00', N'travis@mailsac.com', N'Deck of cards', 5, 3),
    ('280a00c3-05b5-415e-876d-9e74d723b175', '2023-11-27T15:38:38.4889590-06:00', N'travis@mailsac.com', N'Bar soap', 5, 3),
    ('2be28886-7e2e-41c6-886b-3a30ef4cf378', '2023-11-27T15:38:38.4889480-06:00', N'travis@mailsac.com', N'Baby lotion', 5, 3),
    ('2fb04be4-3b23-42eb-9534-20d767654667', '2023-11-27T15:38:38.4889460-06:00', N'travis@mailsac.com', N'Footed sleeper', 5, 3),
    ('2fcbd4e6-479f-4c55-858e-ac69aeab01b1', '2023-11-27T15:38:38.4889600-06:00', N'travis@mailsac.com', N'Toddler toothbrush and toothpaste (fluoride-free)', 5, 3),
    ('305f2292-4230-403c-8e78-ccab2b7faf66', '2023-11-27T15:38:38.4889630-06:00', N'travis@mailsac.com', N'Pacifier (for age 6+ months)', 5, 3),
    ('3186795c-ec04-4bf2-b31d-1d0caf80cb24', '2023-11-27T15:38:38.4889450-06:00', N'travis@mailsac.com', N'Wide tooth comb', 5, 3),
    ('377311f0-f434-46c1-ac21-b05b82413e41', '2023-11-27T15:38:38.4889610-06:00', N'travis@mailsac.com', N'Composition book and pens', 5, 3),
    ('3c7975d7-283f-4876-bf2c-c6c4a885d6ca', '2023-11-27T15:38:38.4889620-06:00', N'travis@mailsac.com', N'Aluminum-free deodorant', 3, 3),
    ('44726539-9806-46a9-99b6-4bdb7dfd7363', '2023-11-27T15:38:38.4889490-06:00', N'travis@mailsac.com', N'Large throw', 5, 3),
    ('483c2687-b6cc-4132-a386-c8351a3ce03c', '2023-11-27T15:38:38.4889630-06:00', N'travis@mailsac.com', N'Towel and wash cloth', 5, 3),
    ('4a7c2d02-c39a-48c9-9e81-c6198f87a2ed', '2023-11-27T15:38:38.4889620-06:00', N'travis@mailsac.com', N'Head-to-toe body wash', 2, 3),
    ('4b223b2e-f4fe-4640-9dd0-2aa7f0263dee', '2023-11-27T15:38:38.4889470-06:00', N'travis@mailsac.com', N'Sketch or composition book and pencils', 5, 3),
    ('4edacb15-8c72-4361-911e-add9c1ef26af', '2023-11-27T15:38:38.4889600-06:00', N'travis@mailsac.com', N'Water bottle', 1, 3),
    ('51d50f02-b916-4824-a9f0-59008d6bb8f8', '2023-11-27T15:38:38.4889510-06:00', N'travis@mailsac.com', N'Soft throw', 5, 3),
    ('618dbc0d-a9b0-4be2-9a87-3442e309f746', '2023-11-27T15:38:38.4889470-06:00', N'travis@mailsac.com', N'Black hair care products (sulfate-free shampoo, leave-in conditioner, SheaMoisture, Cantu or Dream Kids brands)', 5, 3),
    ('61da1441-6b0e-4d1a-88a2-ec632d01906d', '2023-11-27T15:38:38.4889650-06:00', N'travis@mailsac.com', N'Gentle baby wash and shampoo (sulfate-free)', 5, 3),
    ('620b66ed-e341-4a14-b89c-48fd30632d5d', '2023-11-27T15:38:38.4889490-06:00', N'travis@mailsac.com', N'Bottles (for age 6+ months)', 5, 3),
    ('65d5ca12-de4b-4f4b-b57b-a28f14f4fd42', '2023-11-27T15:38:38.4889590-06:00', N'travis@mailsac.com', N'Toothbrush and toothpaste', 2, 3),
    ('65ea10fe-b443-4233-a48a-d8bd7896d244', '2023-11-27T15:38:38.4889640-06:00', N'travis@mailsac.com', N'Swaddle wrap', 5, 3),
    ('6eb9d0bb-c37f-4ba0-a911-0f76be2fb119', '2023-11-27T15:38:38.4889440-06:00', N'travis@mailsac.com', N'Package of socks (size youth small)', 5, 3),
    ('70feab08-d33a-409b-af35-dee1c37fe46b', '2023-11-27T15:38:38.4889650-06:00', N'travis@mailsac.com', N'Shampoo', 1, 3),
    ('726ccf14-58b8-4878-b3ea-e58504bb71b3', '2023-11-27T15:38:38.4889650-06:00', N'travis@mailsac.com', N'Deodorant', 5, 3),
    ('7665e398-50b4-4e36-a8fc-a6368f192946', '2023-11-27T15:38:38.4889590-06:00', N'travis@mailsac.com', N'Body wash or bar soap', 5, 3),
    ('7ac8c99f-aaca-4883-ab1f-fb94fbaa9fca', '2023-11-27T15:38:38.4889660-06:00', N'travis@mailsac.com', N'Anti-colic bottles', 5, 3),
    ('7fab58da-a415-40d1-8fd7-1dc1fcdbb729', '2023-11-27T15:38:38.4889460-06:00', N'travis@mailsac.com', N'Package of socks (size woman''s)', 5, 3),
    ('802350c7-e12b-4ac2-a57e-6f394d67cc0c', '2023-11-27T15:38:38.4889560-06:00', N'travis@mailsac.com', N'Nerf or stress ball', 5, 3),
    ('86921bfc-74e7-47f8-a3eb-72928e5e2a8c', '2023-11-27T15:38:38.4889570-06:00', N'travis@mailsac.com', N'Shampoo/Conditioner 2-in-1', 5, 3),
    ('9441220a-15ea-40e5-b452-9d5406794978', '2023-11-27T15:38:38.4889580-06:00', N'travis@mailsac.com', N'Hair brush', 5, 3),
    ('a6760763-1106-426c-aeb9-05142aba7f57', '2023-11-27T15:38:38.4889430-06:00', N'travis@mailsac.com', N'Maxi pads or tampons', 5, 3),
    ('a809dfba-5e21-491e-ab19-5374a141fe88', '2023-11-27T15:38:38.4889500-06:00', N'travis@mailsac.com', N'Board book', 5, 3),
    ('a8aae37c-e94b-4099-96a7-23bc27b9bdce', '2023-11-27T15:38:38.4889460-06:00', N'travis@mailsac.com', N'Night light', 5, 3),
    ('b0a6921d-55fd-40ff-b7e4-cef32e093c21', '2023-11-27T15:38:38.4889630-06:00', N'travis@mailsac.com', N'Pillow (travel or child sized)', 2, 3);
    INSERT INTO [Categories] ([CategoryId], [LastUpdateDateTime], [LastUpdateId], [Name], [Quantity], [SafeStockLevel])
    VALUES ('b2488733-9e8d-47a5-b1a4-fe6ffe3da0d5', '2023-11-27T15:38:38.4889660-06:00', N'travis@mailsac.com', N'Kids 3-in-1 soap (shampoo/conditioner/body wash)', 2, 3),
    ('b396c541-ffc3-4231-86fb-8cfed6eae3a4', '2023-11-27T15:38:38.4889580-06:00', N'travis@mailsac.com', N'Gift card for diapers (Walmart/Target/Amazon)', 5, 3),
    ('b43b17b3-b34d-4efb-a07e-8c00e6e7aab0', '2023-11-27T15:38:38.4889580-06:00', N'travis@mailsac.com', N'Crib sheet', 5, 3),
    ('b8409915-46fb-408b-9070-a1bc72240000', '2023-11-27T15:38:38.4889590-06:00', N'travis@mailsac.com', N'Baby bottle (for ages 12+ months)', 5, 3),
    ('badafee8-1c62-46be-98c9-e83c89f06322', '2023-11-27T15:38:38.4889650-06:00', N'travis@mailsac.com', N'Package of socks', 5, 3),
    ('bb8f1f6e-57d7-4537-8b66-59aa04728add', '2023-11-27T15:38:38.4889510-06:00', N'travis@mailsac.com', N'Gentle body wash (unscented)', 5, 3),
    ('bf225467-4b08-4da0-a1e5-2ef0ff6e2f96', '2023-11-27T15:38:38.4889470-06:00', N'travis@mailsac.com', N'Diaper cream', 5, 3),
    ('bf4a75e5-825c-4fed-a4c4-57ea77f21473', '2023-11-27T15:38:38.4889500-06:00', N'travis@mailsac.com', N'Package of socks (size youth medium)', 5, 3),
    ('c37a088f-7112-424b-a187-1b295d2b3cbc', '2023-11-27T15:38:38.4889450-06:00', N'travis@mailsac.com', N'Deodorant (non-aerosol preferred)', 5, 3),
    ('c4878700-862c-4748-a0f5-43b1ef4d0655', '2023-11-27T15:38:38.4889480-06:00', N'travis@mailsac.com', N'Body lotion for sensitive skin (unscented)', 5, 3),
    ('c50504d5-a7ec-4aab-acae-0ed0a39d1578', '2023-11-27T15:38:38.4889440-06:00', N'travis@mailsac.com', N'Infant toy (0-6 months)', 5, 3),
    ('c915d086-e1cb-4a9c-a8f4-ef7d6331eb1d', '2023-11-27T15:38:38.4889650-06:00', N'travis@mailsac.com', N'Plastic hair pick', 5, 3),
    ('cdfc6b7f-31fb-4bd1-a246-6b8efc241dff', '2023-11-27T15:38:38.4889520-06:00', N'travis@mailsac.com', N'Baby lotion for sensitive skin', 5, 3),
    ('d0083f7a-cf78-4223-8328-c5fcac9a8639', '2023-11-27T15:38:38.4889620-06:00', N'travis@mailsac.com', N'Body lotion (unscented: Jergens, Vaseline with Cocoa or Shea butter)', 5, 3),
    ('d07d2c78-acbb-4d73-806d-1b5c67914554', '2023-11-27T15:38:38.4889450-06:00', N'travis@mailsac.com', N'Baby wipes', 5, 3),
    ('d11d87e7-126c-4a3c-8125-b6a656d64fcc', '2023-11-27T15:38:38.4889610-06:00', N'travis@mailsac.com', N'Pacifier (newborn/up to 6 months)', 5, 3),
    ('d24a4561-f64b-4371-943c-0d4ac6e9be57', '2023-11-27T15:38:38.4889440-06:00', N'travis@mailsac.com', N'Hair brush or comb', 5, 3),
    ('d2d503a2-f55c-4f44-87e1-6c4464a5f16b', '2023-11-27T15:38:38.4889530-06:00', N'travis@mailsac.com', N'Infant toy or stuffed animal (6+ months)', 5, 3),
    ('d5f318f9-d031-416f-b61d-bff6eb3ddc21', '2023-11-27T15:38:38.4889610-06:00', N'travis@mailsac.com', N'Pillow', 2, 3),
    ('d69feee3-f0ae-456b-b000-9b8fb301dad2', '2023-11-27T15:38:38.4889580-06:00', N'travis@mailsac.com', N'Soft throw (crib/toddler sized)', 5, 3),
    ('d8ac84a3-afff-485b-8949-b0c2c6272e85', '2023-11-27T15:38:38.4889610-06:00', N'travis@mailsac.com', N'Flashlight', 5, 3),
    ('dce8a93b-66c4-4d10-a5c5-d72ae5add07f', '2023-11-27T15:38:38.4889640-06:00', N'travis@mailsac.com', N'Package of socks (size youth large)', 5, 3),
    ('dd47744e-3eb3-4cdc-a697-8a707bf8ab3c', '2023-11-27T15:38:38.4889570-06:00', N'travis@mailsac.com', N'Package of socks (size men''s)', 5, 3),
    ('dfa15e75-56e9-4fd9-8abe-c7ce9c28a6d8', '2023-11-27T15:38:38.4889630-06:00', N'travis@mailsac.com', N'Clear/invisible deodorant (non-aerosol preferred)', 5, 3),
    ('e0f5c01d-a72a-4e59-abba-24c7309e9d37', '2023-11-27T15:38:38.4889460-06:00', N'travis@mailsac.com', N'Pillow case', 5, 3),
    ('e90c0353-dd59-4a87-9897-da2ba2070999', '2023-11-27T15:38:38.4889640-06:00', N'travis@mailsac.com', N'Conditioner', 5, 3),
    ('e9800b98-0e56-4260-ae26-2e2939230c01', '2023-11-27T15:38:38.4889470-06:00', N'travis@mailsac.com', N'Twin blanket', 5, 3),
    ('ec00957f-aa3b-4c34-8554-aa2aaf10335f', '2023-11-27T15:38:38.4889600-06:00', N'travis@mailsac.com', N'Package of diapers (size NB, 1, or 2)', 3, 3),
    ('f27211ee-28cb-42a1-b487-51aa7456ccd3', '2023-11-27T15:38:38.4889490-06:00', N'travis@mailsac.com', N'Socks', 5, 3),
    ('fceef0f8-c4d3-4ba3-ba6b-5c3288d794b2', '2023-11-27T15:38:38.4889510-06:00', N'travis@mailsac.com', N'Coloring book and washable crayons', 5, 3);
    IF EXISTS (SELECT * FROM [sys].[identity_columns] WHERE [name] IN (N'CategoryId', N'LastUpdateDateTime', N'LastUpdateId', N'Name', N'Quantity', N'SafeStockLevel') AND [object_id] = OBJECT_ID(N'[Categories]'))
        SET IDENTITY_INSERT [Categories] OFF;
END
GO

IF NOT EXISTS (SELECT 1 FROM [Ethnicities])
BEGIN
    IF EXISTS (SELECT * FROM [sys].[identity_columns] WHERE [name] IN (N'EthnicityId', N'Description', N'LastUpdateDateTime', N'LastUpdateId') AND [object_id] = OBJECT_ID(N'[Ethnicities]'))
        SET IDENTITY_INSERT [Ethnicities] ON;
    INSERT INTO [Ethnicities] ([EthnicityId], [Description], [LastUpdateDateTime], [LastUpdateId])
    VALUES ('0040e5c2-0d7f-4db8-a7e8-28c5efa6cf4f', N'Black/Mixed Race', '2023-11-27T15:38:38.4889140-06:00', N'travis@mailsac.com'),
    ('b5c934b6-c7e0-493f-8726-c3fd5ff2141f', N'White/Hispanic', '2023-11-27T15:38:38.4889140-06:00', N'travis@mailsac.com');
    IF EXISTS (SELECT * FROM [sys].[identity_columns] WHERE [name] IN (N'EthnicityId', N'Description', N'LastUpdateDateTime', N'LastUpdateId') AND [object_id] = OBJECT_ID(N'[Ethnicities]'))
        SET IDENTITY_INSERT [Ethnicities] OFF;
END
GO

IF NOT EXISTS (SELECT 1 FROM [ExcludeCategories])
BEGIN
    IF EXISTS (SELECT * FROM [sys].[identity_columns] WHERE [name] IN (N'ExcludeCategoryId', N'LastUpdateDateTime', N'LastUpdateId', N'Name', N'Quantity') AND [object_id] = OBJECT_ID(N'[ExcludeCategories]'))
        SET IDENTITY_INSERT [ExcludeCategories] ON;
    INSERT INTO [ExcludeCategories] ([ExcludeCategoryId], [LastUpdateDateTime], [LastUpdateId], [Name], [Quantity])
    VALUES ('5cef1269-2589-4a6f-a150-5ed172d16a1a', '2023-11-27T15:38:38.4889190-06:00', N'travis@mailsac.com', N'Baby food or formula', 0),
    ('695b89cf-9c4d-4ad4-af45-e9d0422d41ef', '2023-11-27T15:38:38.4889200-06:00', N'travis@mailsac.com', N'Food or beverages', 0),
    ('9fe23dd1-3946-4456-8c5d-5808458eafd3', '2023-11-27T15:38:38.4889190-06:00', N'travis@mailsac.com', N'Items with spiral binding', 0),
    ('bb0c0779-5261-4d14-8a96-12ff3e0d8dff', '2023-11-27T15:38:38.4889190-06:00', N'travis@mailsac.com', N'Items requiring batteries', 0),
    ('ebfef241-8abb-4b02-89a1-9a5d19893c11', '2023-11-27T15:38:38.4889200-06:00', N'travis@mailsac.com', N'Used items', 0),
    ('f77cbfaa-11cd-44e7-abb7-e3e0f030e212', '2023-11-27T15:38:38.4889200-06:00', N'travis@mailsac.com', N'Sharp objects such as razors or manicure sets', 0);
    IF EXISTS (SELECT * FROM [sys].[identity_columns] WHERE [name] IN (N'ExcludeCategoryId', N'LastUpdateDateTime', N'LastUpdateId', N'Name', N'Quantity') AND [object_id] = OBJECT_ID(N'[ExcludeCategories]'))
        SET IDENTITY_INSERT [ExcludeCategories] OFF;
END
GO

IF NOT EXISTS (SELECT 1 FROM [Genders])
BEGIN
    IF EXISTS (SELECT * FROM [sys].[identity_columns] WHERE [name] IN (N'GenderId', N'Description', N'LastUpdateDateTime', N'LastUpdateId') AND [object_id] = OBJECT_ID(N'[Genders]'))
        SET IDENTITY_INSERT [Genders] ON;
    INSERT INTO [Genders] ([GenderId], [Description], [LastUpdateDateTime], [LastUpdateId])
    VALUES ('629f93b9-15d1-4aab-a0a6-9ab22e6ac159', N'Boy', '2023-11-27T15:38:38.4889160-06:00', N'travis@mailsac.com'),
    ('78cc56f2-717b-45cb-b025-09c0cca68f27', N'Girl', '2023-11-27T15:38:38.4889160-06:00', N'travis@mailsac.com'),
    ('aedb28bc-17de-436e-8348-217802299584', N'Neutral', '2023-11-27T15:38:38.4889160-06:00', N'travis@mailsac.com');
    IF EXISTS (SELECT * FROM [sys].[identity_columns] WHERE [name] IN (N'GenderId', N'Description', N'LastUpdateDateTime', N'LastUpdateId') AND [object_id] = OBJECT_ID(N'[Genders]'))
        SET IDENTITY_INSERT [Genders] OFF;
END
GO

IF NOT EXISTS (SELECT 1 FROM [OptionalCategories])
BEGIN
    IF EXISTS (SELECT * FROM [sys].[identity_columns] WHERE [name] IN (N'OptionalCategoryId', N'LastUpdateDateTime', N'LastUpdateId', N'Name', N'Quantity', N'SafeStockLevel') AND [object_id] = OBJECT_ID(N'[OptionalCategories]'))
        SET IDENTITY_INSERT [OptionalCategories] ON;
    INSERT INTO [OptionalCategories] ([OptionalCategoryId], [LastUpdateDateTime], [LastUpdateId], [Name], [Quantity], [SafeStockLevel])
    VALUES ('010a1cc4-259b-4198-a841-92a5b784787d', '2023-11-27T15:38:38.4889350-06:00', N'travis@mailsac.com', N'Gift card (Walmart/Target)', 5, 3),
    ('02561934-85a8-4ef0-a890-82092b240fb4', '2023-11-27T15:38:38.4889340-06:00', N'travis@mailsac.com', N'Burp cloths', 5, 3),
    ('15423c38-cbd8-4b49-bbb8-ba74804189e2', '2023-11-27T15:38:38.4889370-06:00', N'travis@mailsac.com', N'Baby brush/comb', 5, 3),
    ('18db181a-39c7-4ff6-aa5f-504c9fd42495', '2023-11-27T15:38:38.4889320-06:00', N'travis@mailsac.com', N'Baby towel and washcloths', 5, 3),
    ('1d6ad3d8-d44c-4982-a912-24454286fead', '2023-11-27T15:38:38.4889230-06:00', N'travis@mailsac.com', N'Small toy', 5, 5),
    ('2d024344-dd8e-49bb-a069-ef59a2625d34', '2023-11-27T15:38:38.4889390-06:00', N'travis@mailsac.com', N'Bulb aspirator', 5, 3),
    ('337e6455-6bcb-4241-a3b8-58c7a6f2200c', '2023-11-27T15:38:38.4889340-06:00', N'travis@mailsac.com', N'Themed adhesive band-aids', 5, 10),
    ('34f51fd8-5e64-46df-beb9-d3caad869f22', '2023-11-27T15:38:38.4889390-06:00', N'travis@mailsac.com', N'Activity book and crayons/pencils', 5, 3),
    ('355cfdc5-4ef5-4ef1-b881-c5cede5d6270', '2023-11-27T15:38:38.4889380-06:00', N'travis@mailsac.com', N'Hair lotion, oil, or gel', 5, 3),
    ('373ffcaf-8c96-4dc5-b7fd-a5247e1a62cd', '2023-11-27T15:38:38.4889360-06:00', N'travis@mailsac.com', N'Crib Sheet', 5, 3),
    ('4a0e060b-e159-49af-9ecd-1790f8d7a0b3', '2023-11-27T15:38:38.4889230-06:00', N'travis@mailsac.com', N'Adhesive bandages/band-aids', 5, 10),
    ('678425c7-3b3e-4f23-b073-8268f4ce273a', '2023-11-27T15:38:38.4889340-06:00', N'travis@mailsac.com', N'Aquaphor healing ointment', 5, 3),
    ('6c1f919d-8b90-43f0-9bf4-c4d69ed6537d', '2023-11-27T15:38:38.4889380-06:00', N'travis@mailsac.com', N'Body lotion', 5, 3),
    ('6c31ed18-3271-4434-af24-5697a341ed6e', '2023-11-27T15:38:38.4889330-06:00', N'travis@mailsac.com', N'Nerf ball or fidget toy', 5, 3),
    ('741217d0-a963-489a-863d-2570bb91c4e5', '2023-11-27T15:38:38.4889230-06:00', N'travis@mailsac.com', N'Hair gel', 3, 4),
    ('743c8970-b53d-496c-9ee9-96c0be328f55', '2023-11-27T15:38:38.4889350-06:00', N'travis@mailsac.com', N'Kids satin night cap/bonnet', 5, 3),
    ('7c65fb61-080a-4ff7-9d27-37904280e926', '2023-11-27T15:38:38.4889240-06:00', N'travis@mailsac.com', N'Wave brush or Denman brush', 5, 3),
    ('7e95c73e-2251-4680-b71a-ed86f3951efb', '2023-11-27T15:38:38.4889390-06:00', N'travis@mailsac.com', N'Shower cap', 5, 3),
    ('811f6a9a-0845-4116-a3f6-b1c0cd3a5912', '2023-11-27T15:38:38.4889370-06:00', N'travis@mailsac.com', N'Toy (e.g. chunky puzzle, baby doll, toy car)', 5, 3),
    ('84f608e3-e046-4cfc-9525-56677374cce9', '2023-11-27T15:38:38.4889330-06:00', N'travis@mailsac.com', N'Children''s book', 5, 3),
    ('85bcb30f-f902-485d-a82f-c9544d435df5', '2023-11-27T15:38:38.4889380-06:00', N'travis@mailsac.com', N'Face wipes or face wash', 5, 3),
    ('86eecf1b-d8bb-4526-a9c1-9b3d511ec50f', '2023-11-27T15:38:38.4889350-06:00', N'travis@mailsac.com', N'Coloring or sketch book, and colored pencils', 5, 3),
    ('989a01f0-8f0e-468c-ab51-2c6501348672', '2023-11-27T15:38:38.4889240-06:00', N'travis@mailsac.com', N'Small backpack', 3, 3),
    ('a2197138-9321-473e-891f-1507671d43d7', '2023-11-27T15:38:38.4889220-06:00', N'travis@mailsac.com', N'Satin bonnet or hair scarf', 3, 4),
    ('a31f289e-a7b7-4b51-ae96-d742a3dbf460', '2023-11-27T15:38:38.4889390-06:00', N'travis@mailsac.com', N'Wave cap or satin hair tie', 5, 3),
    ('a698b945-513b-4379-a13c-398f31e47bb6', '2023-11-27T15:38:38.4889250-06:00', N'travis@mailsac.com', N'Backpack or drawstring bag', 5, 3),
    ('aa154101-bce0-4973-b9aa-7291f06b571c', '2023-11-27T15:38:38.4889340-06:00', N'travis@mailsac.com', N'Infant nail clippers', 5, 10),
    ('b88a0b8b-0460-4fa6-b5cf-9f94261fd823', '2023-11-27T15:38:38.4889360-06:00', N'travis@mailsac.com', N'Toiletry bag', 5, 3),
    ('b9a71948-1ac2-4e86-bda7-9dde074be330', '2023-11-27T15:38:38.4889360-06:00', N'travis@mailsac.com', N'Hair accessories', 5, 3),
    ('bf55fcfc-ce99-436c-8127-aa6898af039f', '2023-11-27T15:38:38.4889360-06:00', N'travis@mailsac.com', N'Diaper cream', 5, 3),
    ('d0193bc7-1a7f-48a2-bee5-2d5402a2c66f', '2023-11-27T15:38:38.4889240-06:00', N'travis@mailsac.com', N'Sleep sack', 4, 2),
    ('d03154ff-da79-4b02-b231-cd0d8494c2e5', '2023-11-27T15:38:38.4889380-06:00', N'travis@mailsac.com', N'Thermometer', 5, 3),
    ('d9caf847-0312-4808-979b-25b5bffc4fb8', '2023-11-27T15:38:38.4889240-06:00', N'travis@mailsac.com', N'Oil/cream moisturizer for curly hair', 4, 3),
    ('de8bbea2-fffe-4073-9acc-b91c45a05a2c', '2023-11-27T15:38:38.4889370-06:00', N'travis@mailsac.com', N'Chapstick', 5, 3),
    ('e58de252-2495-4a19-94b4-9641320fa900', '2023-11-27T15:38:38.4889350-06:00', N'travis@mailsac.com', N'Soft bristle brush', 5, 3);
    IF EXISTS (SELECT * FROM [sys].[identity_columns] WHERE [name] IN (N'OptionalCategoryId', N'LastUpdateDateTime', N'LastUpdateId', N'Name', N'Quantity', N'SafeStockLevel') AND [object_id] = OBJECT_ID(N'[OptionalCategories]'))
        SET IDENTITY_INSERT [OptionalCategories] OFF;
END
GO

IF NOT EXISTS (SELECT 1 FROM [Supplies])
BEGIN
    IF EXISTS (SELECT * FROM [sys].[identity_columns] WHERE [name] IN (N'SupplyId', N'Barcode', N'CategoryId', N'Description', N'ExcludeCategoryId', N'ExpirationDate', N'Expires', N'LastUpdateDateTime', N'LastUpdateId', N'Name', N'OptionalCategoryId', N'Price', N'PurchaseDate', N'Quantity') AND [object_id] = OBJECT_ID(N'[Supplies]'))
        SET IDENTITY_INSERT [Supplies] ON;
    INSERT INTO [Supplies] ([SupplyId], [Barcode], [CategoryId], [Description], [ExcludeCategoryId], [ExpirationDate], [Expires], [LastUpdateDateTime], [LastUpdateId], [Name], [OptionalCategoryId], [Price], [PurchaseDate], [Quantity])
    VALUES ('06f703f4-dfbf-4fd0-b0a6-5c75bc8fe17a', NULL, '2fb04be4-3b23-42eb-9534-20d767654667', N'Koala baby girls'' newborn blanket sleeper, 2 pack, take me home sleep n play pajamas (Newborn-6M)', NULL, NULL, CAST(0 AS bit), '2023-11-27T15:38:38.4889740-06:00', N'travis@mailsac.com', N'Koala Baby Footed Sleeper (girl, 2 pk, NB-6M)', NULL, 10.58, '2023-11-27T15:38:38.4889740-06:00', 1),
    ('07979a90-bab9-47cf-befd-f0b16999ee00', NULL, 'f27211ee-28cb-42a1-b487-51aa7456ccd3', N'Gerber baby boy and girl unisex terry bootie wiggle-proof socks, 4-pack, newborn, 0-6 months.', NULL, NULL, CAST(0 AS bit), '2023-11-27T15:38:38.4889820-06:00', N'travis@mailsac.com', N'Baby socks (unisex, 4 pk, newborn, 0-6 months)', NULL, 4.0, '2023-11-27T15:38:38.4889820-06:00', 1),
    ('16f0b155-8127-4eab-99e1-65473bc89952', NULL, '61da1441-6b0e-4d1a-88a2-ec632d01906d', N'Johnson''s head-to-toe gentle baby wash & shampoo, tear-free, sulfate-free & hypoallergenic wash for baby''s sensitive skin & hair, 27.1 fl. oz.', NULL, NULL, CAST(0 AS bit), '2023-11-27T15:38:38.4889750-06:00', N'travis@mailsac.com', N'Gentle Baby Wash & Shampoo (tear-free, sulfate-free, hypoallergenic, 27.1 fl oz)', NULL, 11.95, '2023-11-27T15:38:38.4889750-06:00', 1),
    ('1ec27cd4-58a3-49d3-8395-8d83536a4305', NULL, 'bf225467-4b08-4da0-a1e5-2ef0ff6e2f96', N'Desitin maximum strength baby diaper rash cream with zinc oxide, 4 oz', NULL, NULL, CAST(0 AS bit), '2023-11-27T15:38:38.4889760-06:00', N'travis@mailsac.com', N'Desitin Diaper Cream (4 oz)', NULL, 7.78, '2023-11-27T15:38:38.4889750-06:00', 1),
    ('331d83d3-04e4-41ca-9527-8ebcc1316090', NULL, 'd07d2c78-acbb-4d73-806d-1b5c67914554', N'Pampers sensitive baby wipes, 8 flip-top packs, 672 wipes', NULL, NULL, CAST(0 AS bit), '2023-11-27T15:38:38.4889800-06:00', N'travis@mailsac.com', N'Pampers Baby Wipes (sensitive, 8 pk, 672 wipes)', NULL, 23.47, '2023-11-27T15:38:38.4889800-06:00', 1),
    ('3a13f50b-b57f-44ae-ba14-f65e4e27cd54', NULL, 'ec00957f-aa3b-4c34-8554-aa2aaf10335f', N'Pampers baby-dry leakproof day & night diapers, size 2 (12-18 lb), 37 count, unisex.', NULL, NULL, CAST(0 AS bit), '2023-11-27T15:38:38.4889830-06:00', N'travis@mailsac.com', N'Pampers Baby Dry Diapers Size 2 (12-18 lb), 37 Count', NULL, 9.97, '2023-11-27T15:38:38.4889820-06:00', 1),
    ('3e2d5eee-ebfc-4a86-9c9c-18049eccaeed', NULL, 'd11d87e7-126c-4a3c-8125-b6a656d64fcc', N'NUK newborn orthodontic pacifiers, girl, 0-2 months, 2-pack.', NULL, NULL, CAST(0 AS bit), '2023-11-27T15:38:38.4889720-06:00', N'travis@mailsac.com', N'Orthodontic Pacifiers (2 pk, girl, 0-2 month)', NULL, 6.77, '2023-11-27T15:38:38.4889720-06:00', 1),
    ('5aa553c8-f564-4755-9d2a-8e5a66f884d1', NULL, 'cdfc6b7f-31fb-4bd1-a246-6b8efc241dff', N'Aveeno baby daily moisture body lotion for sensitive skin with natural colloidal oatmeal, suitable  for newborns, 18 FL oz', NULL, NULL, CAST(0 AS bit), '2023-11-27T15:38:38.4889790-06:00', N'travis@mailsac.com', N'Aveeno Baby Daily Moisture Body Lotion (sensitive skin, 18 FL oz)', NULL, 11.38, '2023-11-27T15:38:38.4889790-06:00', 1),
    ('6d59f00f-d7d8-48e3-ab36-9d96de8b09d0', NULL, '7ac8c99f-aaca-4883-ab1f-fb94fbaa9fca', N'NUK smooth flow pro anti-colic baby bottle, 5 oz, blue, 3-pack', NULL, NULL, CAST(0 AS bit), '2023-11-27T15:38:38.4889800-06:00', N'travis@mailsac.com', N'Anti-colic Baby Bottles (blue, 3 pk, 5 oz)', NULL, 14.97, '2023-11-27T15:38:38.4889800-06:00', 1),
    ('7604aea7-96b0-4096-8bbb-bbef00fdc221', NULL, 'ec00957f-aa3b-4c34-8554-aa2aaf10335f', N'Pampers swaddlers diapers, newborn (< 10 lb), 31 count, unisex', NULL, NULL, CAST(0 AS bit), '2023-11-27T15:38:38.4889810-06:00', N'travis@mailsac.com', N'Pampers Diapers (NB, 31 count)', NULL, 14.5, '2023-11-27T15:38:38.4889810-06:00', 1),
    ('9e0ef560-c184-46bb-9f57-45e295bf57b2', NULL, 'd07d2c78-acbb-4d73-806d-1b5c67914554', N'Huggies natural care refreshing baby wipes, scented, (3 pk, 168 ct)', NULL, NULL, CAST(0 AS bit), '2023-11-27T15:38:38.4889740-06:00', N'travis@mailsac.com', N'Huggies Baby Wipes (scented, 3 pk, 168 ct)', NULL, 6.77, '2023-11-27T15:38:38.4889740-06:00', 1),
    ('a4913d87-9305-4a4f-981f-09b0a226f753', NULL, 'ec00957f-aa3b-4c34-8554-aa2aaf10335f', N'Pampers baby-dry leakproof day & night diapers, size 1 (8-14 lb), 44 count, unisex.', NULL, NULL, CAST(0 AS bit), '2023-11-27T15:38:38.4889710-06:00', N'travis@mailsac.com', N'Pampers Baby Dry Diapers Size 1 (8-14 lb), 44 Count', NULL, 9.97, '2023-11-27T15:38:38.4889710-06:00', 1),
    ('a864cd79-d226-441d-9f23-db77c2b9bd85', NULL, 'c50504d5-a7ec-4aab-acae-0ed0a39d1578', N'Amerteer 4 pcs foot finder socks & wrist rattles - newborn toys for baby boy or girl - brain development infant toys - hand and foot rattles suitable for 0-3, 3-6, 6-12 month babies.', NULL, NULL, CAST(0 AS bit), '2023-11-27T15:38:38.4889820-06:00', N'travis@mailsac.com', N'Foot Finder Socks & Wrist Rattles (NB, toys, 4 pcs)', NULL, 7.28, '2023-11-27T15:38:38.4889810-06:00', 1),
    ('d5b42185-f6f5-4d33-9c7d-392eadb5b1e6', NULL, '65ea10fe-b443-4233-a48a-d8bd7896d244', N'Gilquen baby organic cotton swaddle blankets for 0-3 months infant boys girls, adjustable newborn swaddles, 3-pack wrap set, twinkle & rainbow.', NULL, NULL, CAST(0 AS bit), '2023-11-27T15:38:38.4889730-06:00', N'travis@mailsac.com', N'Baby Cotton Swaddle Blankets (0-3 months, 3-pk)', NULL, 18.76, '2023-11-27T15:38:38.4889730-06:00', 1),
    ('dd6d4bec-20f1-4149-8f14-2141bad77e9b', NULL, 'a809dfba-5e21-491e-ab19-5374a141fe88', N'The Very Hungry Caterpillar, Board Book, English, 0-3 yrs, Infant-Toddler', NULL, NULL, CAST(0 AS bit), '2023-11-27T15:38:38.4889730-06:00', N'travis@mailsac.com', N'The Very Hungry Caterpillar (board book)', NULL, 8.78, '2023-11-27T15:38:38.4889720-06:00', 1);
    IF EXISTS (SELECT * FROM [sys].[identity_columns] WHERE [name] IN (N'SupplyId', N'Barcode', N'CategoryId', N'Description', N'ExcludeCategoryId', N'ExpirationDate', N'Expires', N'LastUpdateDateTime', N'LastUpdateId', N'Name', N'OptionalCategoryId', N'Price', N'PurchaseDate', N'Quantity') AND [object_id] = OBJECT_ID(N'[Supplies]'))
        SET IDENTITY_INSERT [Supplies] OFF;
END
GO

IF NOT EXISTS (SELECT 1 FROM [AgeGroupCategories])
BEGIN
    IF EXISTS (SELECT * FROM [sys].[identity_columns] WHERE [name] IN (N'AgeGroupCategoryId', N'AgeGroupId', N'CategoryId', N'OptionalCategoryId', N'ExcludeCategoryId') AND [object_id] = OBJECT_ID(N'[AgeGroupCategories]'))
        SET IDENTITY_INSERT [AgeGroupCategories] ON;
    INSERT INTO [AgeGroupCategories] ([AgeGroupCategoryId], [AgeGroupId], [CategoryId], [OptionalCategoryId], [ExcludeCategoryId])
    VALUES (N'930f1d1e-9b0c-4ef1-b731-0235ca2e573e', N'e7581e8f-e2ac-4550-aac7-d4ff7fe778e1', NULL, N'678425c7-3b3e-4f23-b073-8268f4ce273a', NULL),
    (N'950edd1c-e24b-452d-a601-028ffa1094a1', N'e7581e8f-e2ac-4550-aac7-d4ff7fe778e1', N'61da1441-6b0e-4d1a-88a2-ec632d01906d', NULL, NULL),
    (N'0105fc09-49f8-49f7-98e7-069a6507f501', N'f574f025-f5c3-4611-96d7-ad679e6b1467', N'1aa58da2-d195-4ffc-9bb7-51920ea8fde4', NULL, NULL),
    (N'ef0bf4fa-4895-4c83-bc13-06ac32ee7c4e', N'39d9931f-e6a6-449d-aa69-d7aad053e298', N'51d50f02-b916-4824-a9f0-59008d6bb8f8', NULL, NULL),
    (N'78a8c9af-1abc-49b6-87ff-07cb9c1dfd29', N'f574f025-f5c3-4611-96d7-ad679e6b1467', N'4b223b2e-f4fe-4640-9dd0-2aa7f0263dee', NULL, NULL),
    (N'1d2a1efe-683f-44ca-b4eb-08779d58c706', N'f574f025-f5c3-4611-96d7-ad679e6b1467', NULL, N'34f51fd8-5e64-46df-beb9-d3caad869f22', NULL),
    (N'b6fb6c0b-db13-4059-a56d-08da6767e050', N'ed2da6d8-a312-489d-b7d0-253d75c6c820', NULL, NULL, N'ebfef241-8abb-4b02-89a1-9a5d19893c11'),
    (N'1100fd5f-3ca8-4957-843d-09eef57c7ea4', N'e7581e8f-e2ac-4550-aac7-d4ff7fe778e1', N'a809dfba-5e21-491e-ab19-5374a141fe88', NULL, NULL),
    (N'2abc257b-b3c2-41f8-8fc2-0a47e2d0a854', N'75200021-5b2f-4079-96be-7e38a1ad1adb', N'9441220a-15ea-40e5-b452-9d5406794978', NULL, NULL),
    (N'7cddd7d4-82ed-4e78-88c8-0b1df8bc0cfc', N'ed2da6d8-a312-489d-b7d0-253d75c6c820', N'a809dfba-5e21-491e-ab19-5374a141fe88', NULL, NULL),
    (N'510eee46-6d5a-44c8-b91f-0b5d0e01e6be', N'290c1063-f288-46ef-8377-3113586b7c62', N'483c2687-b6cc-4132-a386-c8351a3ce03c', NULL, NULL),
    (N'a8be3d51-1f50-4eda-8364-0b83b9625a35', N'f574f025-f5c3-4611-96d7-ad679e6b1467', NULL, N'6c1f919d-8b90-43f0-9bf4-c4d69ed6537d', NULL),
    (N'1bf80e05-25cd-48d2-a042-0d2c9ac5b2b6', N'e7581e8f-e2ac-4550-aac7-d4ff7fe778e1', NULL, NULL, N'bb0c0779-5261-4d14-8a96-12ff3e0d8dff'),
    (N'48e8e85c-9b02-42c4-9782-1116dd88a58c', N'75200021-5b2f-4079-96be-7e38a1ad1adb', N'fceef0f8-c4d3-4ba3-ba6b-5c3288d794b2', NULL, NULL),
    (N'7b41c5b4-421c-4a81-b04f-12dd590f85a3', N'290c1063-f288-46ef-8377-3113586b7c62', N'c915d086-e1cb-4a9c-a8f4-ef7d6331eb1d', NULL, NULL),
    (N'8b48ed57-0041-49e7-a141-15a011bb8faa', N'e7581e8f-e2ac-4550-aac7-d4ff7fe778e1', N'2be28886-7e2e-41c6-886b-3a30ef4cf378', NULL, NULL),
    (N'66bfb9f4-a8d7-476e-a5c5-186b826ae6ce', N'39d9931f-e6a6-449d-aa69-d7aad053e298', NULL, N'd9caf847-0312-4808-979b-25b5bffc4fb8', NULL),
    (N'632f923e-b414-4c18-980d-1b60b67d5061', N'e7581e8f-e2ac-4550-aac7-d4ff7fe778e1', N'f27211ee-28cb-42a1-b487-51aa7456ccd3', NULL, NULL),
    (N'7a85cb4b-6d25-4424-9dc1-1db6062b1840', N'ed2da6d8-a312-489d-b7d0-253d75c6c820', N'2be28886-7e2e-41c6-886b-3a30ef4cf378', NULL, NULL),
    (N'65128995-3cd2-426c-8d73-1dba41727410', N'39d9931f-e6a6-449d-aa69-d7aad053e298', N'd69feee3-f0ae-456b-b000-9b8fb301dad2', NULL, NULL),
    (N'5d586dd3-29f6-4ec0-a16f-1eb142f63399', N'e7581e8f-e2ac-4550-aac7-d4ff7fe778e1', NULL, NULL, N'5cef1269-2589-4a6f-a150-5ed172d16a1a'),
    (N'7d1fa673-67aa-47cb-b0fd-1edfba87af89', N'290c1063-f288-46ef-8377-3113586b7c62', N'86921bfc-74e7-47f8-a3eb-72928e5e2a8c', NULL, NULL),
    (N'2783d927-e473-4905-b1ea-1f8452c604ee', N'39d9931f-e6a6-449d-aa69-d7aad053e298', N'a8aae37c-e94b-4099-96a7-23bc27b9bdce', NULL, NULL),
    (N'ade29596-1769-4abb-9091-20b1f5ce9197', N'ed2da6d8-a312-489d-b7d0-253d75c6c820', NULL, N'2d024344-dd8e-49bb-a069-ef59a2625d34', NULL),
    (N'dc75ce7f-bafd-49ee-aa6c-247c32620dd6', N'e7581e8f-e2ac-4550-aac7-d4ff7fe778e1', N'4a7c2d02-c39a-48c9-9e81-c6198f87a2ed', NULL, NULL),
    (N'11dcb357-65cd-4744-a2c7-26e3ca6fe7ea', N'75200021-5b2f-4079-96be-7e38a1ad1adb', NULL, N'989a01f0-8f0e-468c-ab51-2c6501348672', NULL),
    (N'9c8a0fa3-75a7-4bc7-8631-28356ac8405c', N'75200021-5b2f-4079-96be-7e38a1ad1adb', NULL, N'b9a71948-1ac2-4e86-bda7-9dde074be330', NULL),
    (N'a30a4443-3cbf-4db1-a1be-2a8fa5c58126', N'ed2da6d8-a312-489d-b7d0-253d75c6c820', N'2fb04be4-3b23-42eb-9534-20d767654667', NULL, NULL),
    (N'892a9a86-8fae-49aa-a56c-2abc2d230566', N'75200021-5b2f-4079-96be-7e38a1ad1adb', NULL, N'743c8970-b53d-496c-9ee9-96c0be328f55', NULL),
    (N'ffb98e60-0496-42ee-bb32-2acf55cf7122', N'ed2da6d8-a312-489d-b7d0-253d75c6c820', NULL, N'373ffcaf-8c96-4dc5-b7fd-a5247e1a62cd', NULL),
    (N'aa3c41a1-d391-4972-9954-2ed84df7f12f', N'290c1063-f288-46ef-8377-3113586b7c62', N'280a00c3-05b5-415e-876d-9e74d723b175', NULL, NULL),
    (N'70e435f6-0cfc-4be4-ac32-2f4dc84bd41c', N'e7581e8f-e2ac-4550-aac7-d4ff7fe778e1', N'b43b17b3-b34d-4efb-a07e-8c00e6e7aab0', NULL, NULL),
    (N'124a9693-1ee8-4622-9e71-2fadece54efc', N'290c1063-f288-46ef-8377-3113586b7c62', N'e9800b98-0e56-4260-ae26-2e2939230c01', NULL, NULL),
    (N'f6e50d1b-efda-4d0c-af50-2fc24241614e', N'e7581e8f-e2ac-4550-aac7-d4ff7fe778e1', N'305f2292-4230-403c-8e78-ccab2b7faf66', NULL, NULL),
    (N'77bcd5b7-cb5e-4949-a3d5-362198fa35c2', N'75200021-5b2f-4079-96be-7e38a1ad1adb', NULL, N'4a0e060b-e159-49af-9ecd-1790f8d7a0b3', NULL),
    (N'a79ca795-877b-4244-a26c-3687821789bf', N'ed2da6d8-a312-489d-b7d0-253d75c6c820', NULL, N'18db181a-39c7-4ff6-aa5f-504c9fd42495', NULL),
    (N'c7caaa46-70fb-4c55-84a4-369928a60fb3', N'290c1063-f288-46ef-8377-3113586b7c62', N'65d5ca12-de4b-4f4b-b57b-a28f14f4fd42', NULL, NULL),
    (N'daf79b37-4197-43af-ae31-37498cc44e05', N'290c1063-f288-46ef-8377-3113586b7c62', N'3186795c-ec04-4bf2-b31d-1d0caf80cb24', NULL, NULL),
    (N'23c9b831-1985-4c3c-bf76-37e03a91612f', N'f574f025-f5c3-4611-96d7-ad679e6b1467', N'b2488733-9e8d-47a5-b1a4-fe6ffe3da0d5', NULL, NULL),
    (N'5ba16b57-4da7-4568-ab51-38d3435d4000', N'75200021-5b2f-4079-96be-7e38a1ad1adb', N'6eb9d0bb-c37f-4ba0-a911-0f76be2fb119', NULL, NULL),
    (N'd0bc544e-bee9-4f84-b0d3-39ad24850d89', N'f574f025-f5c3-4611-96d7-ad679e6b1467', N'17d0900f-c48d-4059-8caa-7697af8efbe0', NULL, NULL),
    (N'9c779128-54bd-475d-880e-3bc16aae65d6', N'ed2da6d8-a312-489d-b7d0-253d75c6c820', N'd07d2c78-acbb-4d73-806d-1b5c67914554', NULL, NULL),
    (N'887eeb81-1d7a-4714-ab9a-3e5701a3bb69', N'ed2da6d8-a312-489d-b7d0-253d75c6c820', NULL, N'd0193bc7-1a7f-48a2-bee5-2d5402a2c66f', NULL),
    (N'c922263a-b30b-4817-807f-3ea60aa88ee2', N'290c1063-f288-46ef-8377-3113586b7c62', NULL, N'6c1f919d-8b90-43f0-9bf4-c4d69ed6537d', NULL),
    (N'7416fe4d-eba2-4de1-98a0-3fc6443cb04f', N'ed2da6d8-a312-489d-b7d0-253d75c6c820', NULL, NULL, N'5cef1269-2589-4a6f-a150-5ed172d16a1a'),
    (N'85a51986-fd06-4920-a87a-41887583d626', N'290c1063-f288-46ef-8377-3113586b7c62', N'802350c7-e12b-4ac2-a57e-6f394d67cc0c', NULL, NULL),
    (N'acfcee30-1410-4208-8183-4239d1e4b7b4', N'f574f025-f5c3-4611-96d7-ad679e6b1467', N'18b0b2a3-3163-463d-b8a1-c6314aee6766', NULL, NULL),
    (N'838c287e-fcd2-47a5-9163-457bfe460e17', N'290c1063-f288-46ef-8377-3113586b7c62', NULL, N'86eecf1b-d8bb-4526-a9c1-9b3d511ec50f', NULL),
    (N'cdf169da-f23d-45de-bfb4-48e8ab8bed00', N'f574f025-f5c3-4611-96d7-ad679e6b1467', N'0dda4f68-adc2-4136-b8cd-5efff84ae6ce', NULL, NULL),
    (N'a442ced7-4ef0-4e50-b924-4e9e819567d3', N'39d9931f-e6a6-449d-aa69-d7aad053e298', NULL, N'811f6a9a-0845-4116-a3f6-b1c0cd3a5912', NULL),
    (N'de23be1e-9da3-47f4-96f8-50348217698a', N'290c1063-f288-46ef-8377-3113586b7c62', NULL, N'34f51fd8-5e64-46df-beb9-d3caad869f22', NULL),
    (N'f1ef8f50-1606-49e0-b885-50604409e827', N'f574f025-f5c3-4611-96d7-ad679e6b1467', N'd5f318f9-d031-416f-b61d-bff6eb3ddc21', NULL, NULL),
    (N'f53d1cef-c2db-456c-8ddb-5154e76eda79', N'75200021-5b2f-4079-96be-7e38a1ad1adb', NULL, NULL, N'695b89cf-9c4d-4ad4-af45-e9d0422d41ef'),
    (N'48ca3975-0f91-4860-9a90-5277add9dbde', N'e7581e8f-e2ac-4550-aac7-d4ff7fe778e1', N'cdfc6b7f-31fb-4bd1-a246-6b8efc241dff', NULL, NULL),
    (N'27eb683b-4706-4943-89f1-533f99dc1746', N'39d9931f-e6a6-449d-aa69-d7aad053e298', NULL, N'bf55fcfc-ce99-436c-8127-aa6898af039f', NULL),
    (N'eff95caf-387f-4b8b-8e62-53a5fbc6814b', N'75200021-5b2f-4079-96be-7e38a1ad1adb', N'17d0900f-c48d-4059-8caa-7697af8efbe0', NULL, NULL),
    (N'dd3345a5-853d-4e30-a15b-53e71d28430f', N'75200021-5b2f-4079-96be-7e38a1ad1adb', N'1aa58da2-d195-4ffc-9bb7-51920ea8fde4', NULL, NULL),
    (N'b4e3fb50-48ef-4f80-b842-54a716f169a6', N'290c1063-f288-46ef-8377-3113586b7c62', NULL, N'7c65fb61-080a-4ff7-9d27-37904280e926', NULL),
    (N'5d11104b-6c7c-4326-b00d-56699883ef08', N'f574f025-f5c3-4611-96d7-ad679e6b1467', NULL, NULL, N'695b89cf-9c4d-4ad4-af45-e9d0422d41ef'),
    (N'110d2b4c-2d0b-4be3-8db9-5767945f693b', N'290c1063-f288-46ef-8377-3113586b7c62', N'027ea222-f944-41b8-8dea-7f922c43c8a3', NULL, NULL),
    (N'e7427b7b-01ba-45e7-8006-578c7ef16d0a', N'ed2da6d8-a312-489d-b7d0-253d75c6c820', NULL, N'aa154101-bce0-4973-b9aa-7291f06b571c', NULL),
    (N'dda4d0c0-2665-4ffc-82f8-5809dde663b6', N'39d9931f-e6a6-449d-aa69-d7aad053e298', NULL, N'e58de252-2495-4a19-94b4-9641320fa900', NULL),
    (N'af14ee2a-4791-4197-9151-588f5daa08ff', N'290c1063-f288-46ef-8377-3113586b7c62', N'3c7975d7-283f-4876-bf2c-c6c4a885d6ca', NULL, NULL),
    (N'fd8b2eb9-b2b7-4974-9c70-5916b7cc5a10', N'39d9931f-e6a6-449d-aa69-d7aad053e298', N'badafee8-1c62-46be-98c9-e83c89f06322', NULL, NULL),
    (N'd0227c5f-cd95-46ed-95cc-5a7d11eb56a0', N'75200021-5b2f-4079-96be-7e38a1ad1adb', N'd5f318f9-d031-416f-b61d-bff6eb3ddc21', NULL, NULL),
    (N'a6c142b0-ba13-4207-8658-5b3241642655', N'290c1063-f288-46ef-8377-3113586b7c62', NULL, N'b88a0b8b-0460-4fa6-b5cf-9f94261fd823', NULL),
    (N'55ee88dc-379d-4b68-a650-5c9b7257bcaa', N'ed2da6d8-a312-489d-b7d0-253d75c6c820', NULL, N'010a1cc4-259b-4198-a841-92a5b784787d', NULL),
    (N'64e73c7e-bcfe-4730-9a80-61223d507467', N'290c1063-f288-46ef-8377-3113586b7c62', NULL, NULL, N'695b89cf-9c4d-4ad4-af45-e9d0422d41ef'),
    (N'18d18ed5-c2a7-461f-a4d1-6192082e1603', N'39d9931f-e6a6-449d-aa69-d7aad053e298', N'9441220a-15ea-40e5-b452-9d5406794978', NULL, NULL),
    (N'9c4ce292-a18c-4928-8ec0-619e9ff65db1', N'e7581e8f-e2ac-4550-aac7-d4ff7fe778e1', N'620b66ed-e341-4a14-b89c-48fd30632d5d', NULL, NULL),
    (N'e9d35a48-98ea-4a58-94fd-61b965ac11ee', N'75200021-5b2f-4079-96be-7e38a1ad1adb', N'618dbc0d-a9b0-4be2-9a87-3442e309f746', NULL, NULL),
    (N'9473357e-9563-4348-8b2c-635a6c5db357', N'290c1063-f288-46ef-8377-3113586b7c62', N'e90c0353-dd59-4a87-9897-da2ba2070999', NULL, NULL),
    (N'f4f60e01-ddc4-4828-809d-6957c22c961e', N'75200021-5b2f-4079-96be-7e38a1ad1adb', N'3186795c-ec04-4bf2-b31d-1d0caf80cb24', NULL, NULL),
    (N'71740381-eace-424d-b0e8-699744ed8b01', N'290c1063-f288-46ef-8377-3113586b7c62', N'44726539-9806-46a9-99b6-4bdb7dfd7363', NULL, NULL),
    (N'e6897dae-9ae9-4f37-ad53-6bb5b229ab81', N'ed2da6d8-a312-489d-b7d0-253d75c6c820', N'0c2c3738-e62e-4875-b786-46246636769b', NULL, NULL),
    (N'28a1a835-fbdd-4491-aad6-6f66cb8aad21', N'f574f025-f5c3-4611-96d7-ad679e6b1467', NULL, N'b9a71948-1ac2-4e86-bda7-9dde074be330', NULL),
    (N'b5c8f703-3d78-4aca-bef2-70913f664512', N'39d9931f-e6a6-449d-aa69-d7aad053e298', N'b0a6921d-55fd-40ff-b7e4-cef32e093c21', NULL, NULL),
    (N'af793bea-4dea-44dc-a3f4-70ebce0995cf', N'ed2da6d8-a312-489d-b7d0-253d75c6c820', N'f27211ee-28cb-42a1-b487-51aa7456ccd3', NULL, NULL),
    (N'46c08c7c-8780-4ec0-915c-726473bcf7d7', N'290c1063-f288-46ef-8377-3113586b7c62', N'7fab58da-a415-40d1-8fd7-1dc1fcdbb729', NULL, NULL),
    (N'2f8ee97f-5e5c-48d5-91a2-7399f4e69a62', N'290c1063-f288-46ef-8377-3113586b7c62', N'726ccf14-58b8-4878-b3ea-e58504bb71b3', NULL, NULL),
    (N'9c32185f-7f34-4549-a083-7741c97f4340', N'e7581e8f-e2ac-4550-aac7-d4ff7fe778e1', NULL, NULL, N'ebfef241-8abb-4b02-89a1-9a5d19893c11'),
    (N'4f298bd7-3623-4e74-b2f8-7c253243008e', N'39d9931f-e6a6-449d-aa69-d7aad053e298', N'61da1441-6b0e-4d1a-88a2-ec632d01906d', NULL, NULL),
    (N'753db748-dd9a-438a-ac03-7f45c6ce66ec', N'ed2da6d8-a312-489d-b7d0-253d75c6c820', N'ec00957f-aa3b-4c34-8554-aa2aaf10335f', NULL, NULL),
    (N'1d5e9be3-d6d9-4087-a868-8012b324a6eb', N'e7581e8f-e2ac-4550-aac7-d4ff7fe778e1', NULL, N'18db181a-39c7-4ff6-aa5f-504c9fd42495', NULL),
    (N'50ce6097-c204-4bf6-889a-80b4cb8f7cb5', N'39d9931f-e6a6-449d-aa69-d7aad053e298', N'618dbc0d-a9b0-4be2-9a87-3442e309f746', NULL, NULL),
    (N'857ec3b8-5a9c-4c3d-b2d4-83f8abba4765', N'f574f025-f5c3-4611-96d7-ad679e6b1467', NULL, N'de8bbea2-fffe-4073-9acc-b91c45a05a2c', NULL),
    (N'b44657dc-0e77-4de1-991a-8542cef0e0ab', N'f574f025-f5c3-4611-96d7-ad679e6b1467', N'4edacb15-8c72-4361-911e-add9c1ef26af', NULL, NULL),
    (N'bdb8ded7-2e72-49ce-b0de-85730ad1c6a9', N'75200021-5b2f-4079-96be-7e38a1ad1adb', N'65d5ca12-de4b-4f4b-b57b-a28f14f4fd42', NULL, NULL),
    (N'8ddf6175-2973-488e-89a2-858280e7b8e7', N'f574f025-f5c3-4611-96d7-ad679e6b1467', N'1db3a928-231f-48f2-acaf-16747cfdd4ad', NULL, NULL),
    (N'4f623b6c-4515-43a5-a8af-867f5af26503', N'f574f025-f5c3-4611-96d7-ad679e6b1467', NULL, N'7e95c73e-2251-4680-b71a-ed86f3951efb', NULL),
    (N'd1e6420f-71c2-49ab-8e6b-887fc62a8c5b', N'75200021-5b2f-4079-96be-7e38a1ad1adb', N'027ea222-f944-41b8-8dea-7f922c43c8a3', NULL, NULL),
    (N'9c6629cb-04ed-478f-85a8-8a6611e23653', N'290c1063-f288-46ef-8377-3113586b7c62', N'07ebd8cf-f55b-47a9-bf52-072a1f89e16f', NULL, NULL),
    (N'82f1d064-f266-4010-9d2a-8a690e96b276', N'39d9931f-e6a6-449d-aa69-d7aad053e298', N'd24a4561-f64b-4371-943c-0d4ac6e9be57', NULL, NULL),
    (N'd48a532a-09f1-4a98-ab82-8b49f04ca11a', N'75200021-5b2f-4079-96be-7e38a1ad1adb', N'a8aae37c-e94b-4099-96a7-23bc27b9bdce', NULL, NULL),
    (N'29ca9648-f3f0-4d61-8198-8f1c01a557a3', N'290c1063-f288-46ef-8377-3113586b7c62', NULL, N'355cfdc5-4ef5-4ef1-b881-c5cede5d6270', NULL),
    (N'1e102900-8bd7-46bd-9efa-8f25895cad46', N'290c1063-f288-46ef-8377-3113586b7c62', N'4edacb15-8c72-4361-911e-add9c1ef26af', NULL, NULL),
    (N'e241986a-cec1-4ff4-80c5-8f28c73f2351', N'f574f025-f5c3-4611-96d7-ad679e6b1467', N'618dbc0d-a9b0-4be2-9a87-3442e309f746', NULL, NULL),
    (N'444f8b6b-5b75-4fe2-99a0-8f494aa363ed', N'75200021-5b2f-4079-96be-7e38a1ad1adb', N'c4878700-862c-4748-a0f5-43b1ef4d0655', NULL, NULL),
    (N'bb5a1c13-aad3-4cdf-b0ef-8f4bbaebb639', N'75200021-5b2f-4079-96be-7e38a1ad1adb', NULL, N'84f608e3-e046-4cfc-9525-56677374cce9', NULL),
    (N'a72f66b2-183f-419e-937f-8f9a2761b960', N'290c1063-f288-46ef-8377-3113586b7c62', N'dd47744e-3eb3-4cdc-a697-8a707bf8ab3c', NULL, NULL);
    INSERT INTO [AgeGroupCategories] ([AgeGroupCategoryId], [AgeGroupId], [CategoryId], [OptionalCategoryId], [ExcludeCategoryId])
    VALUES (N'76830dfe-7595-47d2-8d11-9109b591b847', N'39d9931f-e6a6-449d-aa69-d7aad053e298', N'1aa58da2-d195-4ffc-9bb7-51920ea8fde4', NULL, NULL),
    (N'ba7a0623-c11a-46c9-be00-91d34be20046', N'ed2da6d8-a312-489d-b7d0-253d75c6c820', N'4a7c2d02-c39a-48c9-9e81-c6198f87a2ed', NULL, NULL),
    (N'377cf865-e19c-4729-87c4-95cac791222d', N'e7581e8f-e2ac-4550-aac7-d4ff7fe778e1', N'bf225467-4b08-4da0-a1e5-2ef0ff6e2f96', NULL, NULL),
    (N'756561c9-eb91-46af-b249-9677679b1a1d', N'75200021-5b2f-4079-96be-7e38a1ad1adb', NULL, N'6c1f919d-8b90-43f0-9bf4-c4d69ed6537d', NULL),
    (N'e5721546-9a2d-46d2-838c-97ec3b37a275', N'e7581e8f-e2ac-4550-aac7-d4ff7fe778e1', N'7ac8c99f-aaca-4883-ab1f-fb94fbaa9fca', NULL, NULL),
    (N'832571b8-fa98-451b-8032-9bf866037271', N'290c1063-f288-46ef-8377-3113586b7c62', N'377311f0-f434-46c1-ac21-b05b82413e41', NULL, NULL),
    (N'fbfdc57d-35ed-4fac-b05c-9eb2fdfa0e12', N'ed2da6d8-a312-489d-b7d0-253d75c6c820', NULL, N'd03154ff-da79-4b02-b231-cd0d8494c2e5', NULL),
    (N'7f6a093e-31d6-4840-9d94-a04ef2164439', N'290c1063-f288-46ef-8377-3113586b7c62', NULL, NULL, N'9fe23dd1-3946-4456-8c5d-5808458eafd3'),
    (N'61c279c6-942f-4853-9225-a09ade0a2211', N'ed2da6d8-a312-489d-b7d0-253d75c6c820', NULL, NULL, N'bb0c0779-5261-4d14-8a96-12ff3e0d8dff'),
    (N'b30e158f-7130-492d-89be-a0f50f4dbae7', N'e7581e8f-e2ac-4550-aac7-d4ff7fe778e1', N'1aa58da2-d195-4ffc-9bb7-51920ea8fde4', NULL, NULL),
    (N'62bc9698-e6b8-4b8d-a3b9-a51590ea6766', N'290c1063-f288-46ef-8377-3113586b7c62', N'7665e398-50b4-4e36-a8fc-a6368f192946', NULL, NULL),
    (N'dc6b97ab-da38-4b95-b7b6-a5943ce9e59a', N'e7581e8f-e2ac-4550-aac7-d4ff7fe778e1', NULL, N'2d024344-dd8e-49bb-a069-ef59a2625d34', NULL),
    (N'ebea3925-d8fd-401b-829c-a6c6c328e5dc', N'290c1063-f288-46ef-8377-3113586b7c62', NULL, N'a698b945-513b-4379-a13c-398f31e47bb6', NULL),
    (N'b86a4a55-cc05-4415-ad4c-aa090fbc8b7b', N'f574f025-f5c3-4611-96d7-ad679e6b1467', N'027ea222-f944-41b8-8dea-7f922c43c8a3', NULL, NULL),
    (N'f9d65ff5-299b-429a-8a79-aceaa281a0f4', N'39d9931f-e6a6-449d-aa69-d7aad053e298', N'2fcbd4e6-479f-4c55-858e-ac69aeab01b1', NULL, NULL),
    (N'3c9684d0-762c-4b28-8f30-adf56c733f46', N'f574f025-f5c3-4611-96d7-ad679e6b1467', N'07ebd8cf-f55b-47a9-bf52-072a1f89e16f', NULL, NULL),
    (N'3f8dea16-442d-4e34-9542-af0e2369c5ae', N'290c1063-f288-46ef-8377-3113586b7c62', N'a6760763-1106-426c-aeb9-05142aba7f57', NULL, NULL),
    (N'845d3b53-e22c-4d51-b3cb-b0377abda2b8', N'290c1063-f288-46ef-8377-3113586b7c62', NULL, N'de8bbea2-fffe-4073-9acc-b91c45a05a2c', NULL),
    (N'a4e98706-f5d4-491f-bfa6-b106c67a4a4d', N'ed2da6d8-a312-489d-b7d0-253d75c6c820', N'c50504d5-a7ec-4aab-acae-0ed0a39d1578', NULL, NULL),
    (N'9eb824dc-7d05-4dfb-9f57-b127dc40c9eb', N'e7581e8f-e2ac-4550-aac7-d4ff7fe778e1', NULL, N'02561934-85a8-4ef0-a890-82092b240fb4', NULL),
    (N'83cb4614-fc71-4717-abda-b166fa2bf2f7', N'f574f025-f5c3-4611-96d7-ad679e6b1467', NULL, N'a698b945-513b-4379-a13c-398f31e47bb6', NULL),
    (N'58ef2660-06a9-4e59-8a68-b4902d293e8d', N'290c1063-f288-46ef-8377-3113586b7c62', N'9441220a-15ea-40e5-b452-9d5406794978', NULL, NULL),
    (N'b6144e2f-32cf-4bdf-848c-b553cff010fd', N'75200021-5b2f-4079-96be-7e38a1ad1adb', N'bf4a75e5-825c-4fed-a4c4-57ea77f21473', NULL, NULL),
    (N'15f50cd4-6d82-4850-84f4-b5b0bffa602c', N'75200021-5b2f-4079-96be-7e38a1ad1adb', N'067ac574-c50a-4f2c-b8d7-52877ea217d4', NULL, NULL),
    (N'359724a2-1723-4215-940c-b821f16588a6', N'290c1063-f288-46ef-8377-3113586b7c62', N'1db3a928-231f-48f2-acaf-16747cfdd4ad', NULL, NULL),
    (N'e7788214-bc58-49f7-9dd1-b9dde9230e6d', N'290c1063-f288-46ef-8377-3113586b7c62', N'70feab08-d33a-409b-af35-dee1c37fe46b', NULL, NULL),
    (N'a6749735-8e2a-402a-9802-ba70d5e3b107', N'ed2da6d8-a312-489d-b7d0-253d75c6c820', N'bf225467-4b08-4da0-a1e5-2ef0ff6e2f96', NULL, NULL),
    (N'3749e353-b95d-4cec-a3d4-bbaacd0b73aa', N'ed2da6d8-a312-489d-b7d0-253d75c6c820', NULL, N'02561934-85a8-4ef0-a890-82092b240fb4', NULL),
    (N'2ccffba4-fa32-4c76-a999-bc663a404a92', N'f574f025-f5c3-4611-96d7-ad679e6b1467', N'dce8a93b-66c4-4d10-a5c5-d72ae5add07f', NULL, NULL),
    (N'e601056a-3ba7-4089-8b38-be6978395c9e', N'ed2da6d8-a312-489d-b7d0-253d75c6c820', N'cdfc6b7f-31fb-4bd1-a246-6b8efc241dff', NULL, NULL),
    (N'ce7902af-f91c-40c6-90a0-c1fa681cefc5', N'ed2da6d8-a312-489d-b7d0-253d75c6c820', N'65ea10fe-b443-4233-a48a-d8bd7896d244', NULL, NULL),
    (N'b051b8cf-8c71-46e6-a3bf-c6374eb30228', N'290c1063-f288-46ef-8377-3113586b7c62', NULL, N'a31f289e-a7b7-4b51-ae96-d742a3dbf460', NULL),
    (N'12736543-335f-43a0-93c4-c72539081a1e', N'290c1063-f288-46ef-8377-3113586b7c62', N'd5f318f9-d031-416f-b61d-bff6eb3ddc21', NULL, NULL),
    (N'514d7f66-a6b4-4797-abba-ca0184eb1e35', N'f574f025-f5c3-4611-96d7-ad679e6b1467', N'3186795c-ec04-4bf2-b31d-1d0caf80cb24', NULL, NULL),
    (N'0b0d1fcb-0e05-4f40-95a2-cd48c9466ca0', N'f574f025-f5c3-4611-96d7-ad679e6b1467', N'3c7975d7-283f-4876-bf2c-c6c4a885d6ca', NULL, NULL),
    (N'343ac31a-b9ee-41e8-9422-cf052cfc3068', N'75200021-5b2f-4079-96be-7e38a1ad1adb', N'e9800b98-0e56-4260-ae26-2e2939230c01', NULL, NULL),
    (N'3cee5ccd-1fb3-474a-95b2-d0e348dadb06', N'e7581e8f-e2ac-4550-aac7-d4ff7fe778e1', NULL, N'aa154101-bce0-4973-b9aa-7291f06b571c', NULL),
    (N'eb471fab-3630-40b8-b36b-d10b5b08f9c8', N'f574f025-f5c3-4611-96d7-ad679e6b1467', N'd0083f7a-cf78-4223-8328-c5fcac9a8639', NULL, NULL),
    (N'09602646-2239-436d-b9da-d1fff7aeed01', N'290c1063-f288-46ef-8377-3113586b7c62', NULL, N'85bcb30f-f902-485d-a82f-c9544d435df5', NULL),
    (N'4363e523-5b90-4387-9100-d25e249f4ef5', N'f574f025-f5c3-4611-96d7-ad679e6b1467', N'e9800b98-0e56-4260-ae26-2e2939230c01', NULL, NULL),
    (N'2e5abf49-41ea-4634-b6b2-d3611e3dcc05', N'290c1063-f288-46ef-8377-3113586b7c62', NULL, NULL, N'f77cbfaa-11cd-44e7-abb7-e3e0f030e212'),
    (N'e42deb4a-ee19-4dcc-a619-d476871e4eb6', N'75200021-5b2f-4079-96be-7e38a1ad1adb', N'bb8f1f6e-57d7-4537-8b66-59aa04728add', NULL, NULL),
    (N'4c688225-58fa-4271-9d4f-d5aee5295c16', N'f574f025-f5c3-4611-96d7-ad679e6b1467', NULL, N'6c31ed18-3271-4434-af24-5697a341ed6e', NULL),
    (N'6ca32b9b-9483-49ce-92f9-d956560e8c17', N'ed2da6d8-a312-489d-b7d0-253d75c6c820', N'7ac8c99f-aaca-4883-ab1f-fb94fbaa9fca', NULL, NULL),
    (N'd4d09ac9-1854-4935-9a92-dffdd4e7dac7', N'39d9931f-e6a6-449d-aa69-d7aad053e298', N'3186795c-ec04-4bf2-b31d-1d0caf80cb24', NULL, NULL),
    (N'ca04f94e-46c6-4246-8b55-e0cf92cba706', N'39d9931f-e6a6-449d-aa69-d7aad053e298', N'b8409915-46fb-408b-9070-a1bc72240000', NULL, NULL),
    (N'b246603a-7a92-4ace-bb58-e1f2f814e622', N'f574f025-f5c3-4611-96d7-ad679e6b1467', NULL, N'741217d0-a963-489a-863d-2570bb91c4e5', NULL),
    (N'89c178cb-8c59-4176-873f-e3ae61223ec8', N'f574f025-f5c3-4611-96d7-ad679e6b1467', N'a8aae37c-e94b-4099-96a7-23bc27b9bdce', NULL, NULL),
    (N'bb473e60-331f-48a6-90d1-e412e1d7aa23', N'39d9931f-e6a6-449d-aa69-d7aad053e298', NULL, N'337e6455-6bcb-4241-a3b8-58c7a6f2200c', NULL),
    (N'f0821ecd-2925-4bc4-a6ca-e4d1ba6cd91a', N'ed2da6d8-a312-489d-b7d0-253d75c6c820', NULL, N'15423c38-cbd8-4b49-bbb8-ba74804189e2', NULL),
    (N'b692f146-c7f5-4cee-95f6-e573005d2665', N'290c1063-f288-46ef-8377-3113586b7c62', N'dfa15e75-56e9-4fd9-8abe-c7ce9c28a6d8', NULL, NULL),
    (N'39b61519-4554-40e7-ab73-e76254e5d76c', N'e7581e8f-e2ac-4550-aac7-d4ff7fe778e1', N'b396c541-ffc3-4231-86fb-8cfed6eae3a4', NULL, NULL),
    (N'a6ad3988-9631-4c11-be79-e8278a430039', N'f574f025-f5c3-4611-96d7-ad679e6b1467', N'd8ac84a3-afff-485b-8949-b0c2c6272e85', NULL, NULL),
    (N'8c6a44d3-9315-4277-8050-e947272c5801', N'f574f025-f5c3-4611-96d7-ad679e6b1467', N'65d5ca12-de4b-4f4b-b57b-a28f14f4fd42', NULL, NULL),
    (N'f82e1943-a1b9-4d0f-8fe7-ec8d8fdfaec1', N'ed2da6d8-a312-489d-b7d0-253d75c6c820', N'd11d87e7-126c-4a3c-8125-b6a656d64fcc', NULL, NULL),
    (N'b1a9ad05-ce62-4dc8-9798-ecafa2c1fc8c', N'e7581e8f-e2ac-4550-aac7-d4ff7fe778e1', N'd2d503a2-f55c-4f44-87e1-6c4464a5f16b', NULL, NULL),
    (N'e6bc6891-f317-49f2-90c5-ed526c753304', N'290c1063-f288-46ef-8377-3113586b7c62', N'17d0900f-c48d-4059-8caa-7697af8efbe0', NULL, NULL),
    (N'54fab57d-c760-4805-918b-ef9f1e6c6e47', N'e7581e8f-e2ac-4550-aac7-d4ff7fe778e1', N'd07d2c78-acbb-4d73-806d-1b5c67914554', NULL, NULL),
    (N'd1da7a40-c437-4ee2-afb2-efd196cf3313', N'39d9931f-e6a6-449d-aa69-d7aad053e298', N'e0f5c01d-a72a-4e59-abba-24c7309e9d37', NULL, NULL),
    (N'7438cd3b-ff5f-4d3c-995b-f31dc433fbe8', N'e7581e8f-e2ac-4550-aac7-d4ff7fe778e1', N'039c1f4e-7a2c-4b4a-9aee-53f4957a7b01', NULL, NULL),
    (N'dd9cbbe4-9724-425a-94e4-f3bcb184ea9c', N'290c1063-f288-46ef-8377-3113586b7c62', N'c37a088f-7112-424b-a187-1b295d2b3cbc', NULL, NULL),
    (N'4932d003-429b-4d38-beac-f603fd8e5e57', N'f574f025-f5c3-4611-96d7-ad679e6b1467', N'483c2687-b6cc-4132-a386-c8351a3ce03c', NULL, NULL),
    (N'dae6260b-8362-4dca-b958-f9b509323468', N'75200021-5b2f-4079-96be-7e38a1ad1adb', NULL, N'1d6ad3d8-d44c-4982-a912-24454286fead', NULL),
    (N'c6fc8a4b-34fc-4eec-9f94-fce6131c0aed', N'f574f025-f5c3-4611-96d7-ad679e6b1467', N'9441220a-15ea-40e5-b452-9d5406794978', NULL, NULL);
    IF EXISTS (SELECT * FROM [sys].[identity_columns] WHERE [name] IN (N'AgeGroupCategoryId', N'AgeGroupId', N'CategoryId', N'OptionalCategoryId', N'ExcludeCategoryId') AND [object_id] = OBJECT_ID(N'[AgeGroupCategories]'))
        SET IDENTITY_INSERT [AgeGroupCategories] OFF;
END
GO

IF NOT EXISTS (SELECT 1 FROM [Baskets])
BEGIN
    IF EXISTS (SELECT * FROM [sys].[identity_columns] WHERE [name] IN (N'BasketId', N'AgeGroupId', N'EthnicityId', N'GenderId', N'DateAssembled', N'Quantity', N'SafeStockLevel', N'LastUpdateDateTime', N'LastUpdateId', N'IsShoppingListItem', N'BasketNumber') AND [object_id] = OBJECT_ID(N'[Baskets]'))
        SET IDENTITY_INSERT [Baskets] ON;
    INSERT INTO [Baskets] ([BasketId], [AgeGroupId], [EthnicityId], [GenderId], [DateAssembled], [Quantity], [SafeStockLevel], [LastUpdateDateTime], [LastUpdateId], [IsShoppingListItem], [BasketNumber]) 
    VALUES (N'542e0839-1b15-4336-a832-16fa88578c33', N'e7581e8f-e2ac-4550-aac7-d4ff7fe778e1', N'0040e5c2-0d7f-4db8-a7e8-28c5efa6cf4f', N'78cc56f2-717b-45cb-b025-09c0cca68f27', CAST(N'2023-11-10T00:00:00.0000000' AS DateTime2), 0, 5, CAST(N'2023-11-20T11:57:37.3760162' AS DateTime2), N'travis@mailsac.com', 1, 2),
    (N'7e50139d-1674-4bc5-9945-2841d9e50d7a', N'ed2da6d8-a312-489d-b7d0-253d75c6c820', N'0040e5c2-0d7f-4db8-a7e8-28c5efa6cf4f', N'78cc56f2-717b-45cb-b025-09c0cca68f27', CAST(N'2023-11-25T00:00:00.0000000' AS DateTime2), NULL, NULL, CAST(N'2023-11-25T12:53:40.7348907' AS DateTime2), N'travis@mailsac.com', 0, 1),
    (N'7d5ca2e0-5a84-47af-a31c-c80123eaab88', N'ed2da6d8-a312-489d-b7d0-253d75c6c820', N'0040e5c2-0d7f-4db8-a7e8-28c5efa6cf4f', N'78cc56f2-717b-45cb-b025-09c0cca68f27', CAST(N'2023-11-10T00:00:00.0000000' AS DateTime2), 1, 5, CAST(N'2023-11-20T11:57:25.8485341' AS DateTime2), N'travis@mailsac.com', 1, 1);
    IF EXISTS (SELECT * FROM [sys].[identity_columns] WHERE [name] IN (N'BasketId', N'AgeGroupId', N'EthnicityId', N'GenderId', N'DateAssembled', N'Quantity', N'SafeStockLevel', N'LastUpdateDateTime', N'LastUpdateId', N'IsShoppingListItem', N'BasketNumber') AND [object_id] = OBJECT_ID(N'[Baskets]'))
        SET IDENTITY_INSERT [Baskets] OFF;
END
GO

IF NOT EXISTS (SELECT 1 FROM [CategoryBaskets])
BEGIN
    IF EXISTS (SELECT * FROM [sys].[identity_columns] WHERE [name] IN (N'CategoryBasketId',N'BasketId',N'CategoryId',N'LastUpdateId',N'LastUpdateDateTime',N'ExcludeCategoryId',N'OptionalCategoryId') AND [object_id] = OBJECT_ID(N'[CategoryBaskets]'))
        SET IDENTITY_INSERT [CategoryBaskets] ON;
    INSERT INTO[CategoryBaskets] ([CategoryBasketId], [BasketId], [CategoryId], [LastUpdateId], [LastUpdateDateTime], [ExcludeCategoryId], [OptionalCategoryId]) 
    VALUES (N'9d7a3d6f-2d6a-4a8c-8f77-038978eac6dc', N'7d5ca2e0-5a84-47af-a31c-c80123eaab88', NULL, N'travis@mailsac.com', CAST(N'2023-11-10T07:39:53.4065284' AS DateTime2), N'5cef1269-2589-4a6f-a150-5ed172d16a1a', NULL),
    (N'8d3f728f-059a-431b-8258-0b4238c49add', N'542e0839-1b15-4336-a832-16fa88578c33', N'620b66ed-e341-4a14-b89c-48fd30632d5d', N'travis@mailsac.com', CAST(N'2023-11-10T08:29:43.6033601' AS DateTime2), NULL, NULL),
    (N'6a539e1e-c826-48d2-90a8-1450e1541b3e', N'7d5ca2e0-5a84-47af-a31c-c80123eaab88', N'd11d87e7-126c-4a3c-8125-b6a656d64fcc', N'travis@mailsac.com', CAST(N'2023-11-10T07:39:53.4063194' AS DateTime2), NULL, NULL),
    (N'd6d3adf8-509a-467d-8461-15ca4c895c59', N'542e0839-1b15-4336-a832-16fa88578c33', N'b396c541-ffc3-4231-86fb-8cfed6eae3a4', N'travis@mailsac.com', CAST(N'2023-11-10T08:29:43.6033673' AS DateTime2), NULL, NULL),
    (N'a36180d3-b664-4ea6-b6b4-1f4196652e6c', N'542e0839-1b15-4336-a832-16fa88578c33', N'0c2c3738-e62e-4875-b786-46246636769b', N'travis@mailsac.com', CAST(N'2023-11-10T08:29:43.6033485' AS DateTime2), NULL, NULL),
    (N'b0d1f8f0-a3d6-4262-9543-26569bfae2e6', N'7d5ca2e0-5a84-47af-a31c-c80123eaab88', NULL, N'travis@mailsac.com', CAST(N'2023-11-10T07:39:53.4064206' AS DateTime2), NULL, N'15423c38-cbd8-4b49-bbb8-ba74804189e2'),
    (N'45c399a2-4738-4879-980b-2919d085d03e', N'542e0839-1b15-4336-a832-16fa88578c33', NULL, N'travis@mailsac.com', CAST(N'2023-11-10T08:29:43.6033767' AS DateTime2), N'5cef1269-2589-4a6f-a150-5ed172d16a1a', NULL),
    (N'63e067c4-4a2c-441b-8d69-3cb8db314984', N'7d5ca2e0-5a84-47af-a31c-c80123eaab88', NULL, N'travis@mailsac.com', CAST(N'2023-11-10T07:39:53.4064256' AS DateTime2), NULL, N'aa154101-bce0-4973-b9aa-7291f06b571c'),
    (N'f3af72d4-6570-478f-b5a2-4ff8adda2757', N'542e0839-1b15-4336-a832-16fa88578c33', N'a809dfba-5e21-491e-ab19-5374a141fe88', N'travis@mailsac.com', CAST(N'2023-11-10T08:29:43.6033579' AS DateTime2), NULL, NULL),
    (N'c0cae685-9099-4253-8d93-50c035ab8a31', N'542e0839-1b15-4336-a832-16fa88578c33', N'f27211ee-28cb-42a1-b487-51aa7456ccd3', N'travis@mailsac.com', CAST(N'2023-11-10T08:29:43.6033684' AS DateTime2), NULL, NULL),
    (N'83d8ac40-d890-49f5-9322-58b987204229', N'542e0839-1b15-4336-a832-16fa88578c33', N'bf225467-4b08-4da0-a1e5-2ef0ff6e2f96', N'travis@mailsac.com', CAST(N'2023-11-10T08:29:43.6033610' AS DateTime2), NULL, NULL),
    (N'48326523-16a9-46ea-9f7a-5c3633669d8b', N'542e0839-1b15-4336-a832-16fa88578c33', NULL, N'travis@mailsac.com', CAST(N'2023-11-10T08:29:43.6033721' AS DateTime2), NULL, N'18db181a-39c7-4ff6-aa5f-504c9fd42495'),
    (N'884a6c98-a542-477e-a6b4-5f0b8fa35f22', N'542e0839-1b15-4336-a832-16fa88578c33', NULL, N'travis@mailsac.com', CAST(N'2023-11-10T08:29:43.6033754' AS DateTime2), NULL, N'aa154101-bce0-4973-b9aa-7291f06b571c'),
    (N'c27875bd-8897-4251-b9a9-626475d2845d', N'542e0839-1b15-4336-a832-16fa88578c33', NULL, N'travis@mailsac.com', CAST(N'2023-11-10T08:29:43.6033771' AS DateTime2), N'bb0c0779-5261-4d14-8a96-12ff3e0d8dff', NULL),
    (N'200ccf73-cdea-4c9b-95ee-6293e67d875c', N'7d5ca2e0-5a84-47af-a31c-c80123eaab88', N'cdfc6b7f-31fb-4bd1-a246-6b8efc241dff', N'travis@mailsac.com', CAST(N'2023-11-10T07:39:53.4063117' AS DateTime2), NULL, NULL),
    (N'7029ab89-8a5b-45f7-afda-6e0e48d7ff8e', N'7d5ca2e0-5a84-47af-a31c-c80123eaab88', NULL, N'travis@mailsac.com', CAST(N'2023-11-10T07:39:53.4065311' AS DateTime2), N'ebfef241-8abb-4b02-89a1-9a5d19893c11', NULL),
    (N'62551252-6aaa-4685-bb38-6ecaa0741a9e', N'7d5ca2e0-5a84-47af-a31c-c80123eaab88', N'ec00957f-aa3b-4c34-8554-aa2aaf10335f', N'travis@mailsac.com', CAST(N'2023-11-10T07:39:53.4063199' AS DateTime2), NULL, NULL),
    (N'34ce437e-5348-4cb8-9434-771103c7d6b2', N'7d5ca2e0-5a84-47af-a31c-c80123eaab88', N'd07d2c78-acbb-4d73-806d-1b5c67914554', N'travis@mailsac.com', CAST(N'2023-11-10T07:39:53.4063138' AS DateTime2), NULL, NULL),
    (N'e450de36-7159-4d0b-97c5-78dd1d73ee8b', N'542e0839-1b15-4336-a832-16fa88578c33', NULL, N'travis@mailsac.com', CAST(N'2023-11-10T08:29:43.6033750' AS DateTime2), NULL, N'02561934-85a8-4ef0-a890-82092b240fb4'),
    (N'd35f06ab-5881-42a7-ace9-82d473f834ef', N'542e0839-1b15-4336-a832-16fa88578c33', N'd07d2c78-acbb-4d73-806d-1b5c67914554', N'travis@mailsac.com', CAST(N'2023-11-10T08:29:43.6033575' AS DateTime2), NULL, NULL),
    (N'd2f86622-8ab2-4b38-8e28-87986ed1ccca', N'542e0839-1b15-4336-a832-16fa88578c33', N'039c1f4e-7a2c-4b4a-9aee-53f4957a7b01', N'travis@mailsac.com', CAST(N'2023-11-10T08:29:43.6033515' AS DateTime2), NULL, NULL),
    (N'd65929bf-2f3b-4998-a4bc-89ec0840238e', N'542e0839-1b15-4336-a832-16fa88578c33', N'cdfc6b7f-31fb-4bd1-a246-6b8efc241dff', N'travis@mailsac.com', CAST(N'2023-11-10T08:29:43.6033571' AS DateTime2), NULL, NULL),
    (N'3603e88e-f245-4210-af3c-9832f8a685cc', N'7d5ca2e0-5a84-47af-a31c-c80123eaab88', NULL, N'travis@mailsac.com', CAST(N'2023-11-10T07:39:53.4064260' AS DateTime2), NULL, N'd0193bc7-1a7f-48a2-bee5-2d5402a2c66f'),
    (N'36febe6e-5492-4860-970e-9864baf2d5a5', N'7d5ca2e0-5a84-47af-a31c-c80123eaab88', NULL, N'travis@mailsac.com', CAST(N'2023-11-10T07:39:53.4064241' AS DateTime2), NULL, N'373ffcaf-8c96-4dc5-b7fd-a5247e1a62cd'),
    (N'f5285215-045e-4332-a100-99790dd20b16', N'7d5ca2e0-5a84-47af-a31c-c80123eaab88', N'61da1441-6b0e-4d1a-88a2-ec632d01906d', N'travis@mailsac.com', CAST(N'2023-11-10T07:39:53.4063159' AS DateTime2), NULL, NULL),
    (N'992e80b8-2d82-4ffc-886b-99ab8c221afb', N'542e0839-1b15-4336-a832-16fa88578c33', NULL, N'travis@mailsac.com', CAST(N'2023-11-10T08:29:43.6033776' AS DateTime2), N'ebfef241-8abb-4b02-89a1-9a5d19893c11', NULL),
    (N'5847657b-144f-4c8c-9059-99f65967f2f9', N'542e0839-1b15-4336-a832-16fa88578c33', NULL, N'travis@mailsac.com', CAST(N'2023-11-10T08:29:43.6033746' AS DateTime2), NULL, N'2d024344-dd8e-49bb-a069-ef59a2625d34'),
    (N'18342be5-475c-4efc-8726-a13a4c868512', N'542e0839-1b15-4336-a832-16fa88578c33', NULL, N'travis@mailsac.com', CAST(N'2023-11-10T08:29:43.6033716' AS DateTime2), NULL, N'678425c7-3b3e-4f23-b073-8268f4ce273a'),
    (N'b6ebda33-f4d2-4960-9999-a1c12a9e4e84', N'7d5ca2e0-5a84-47af-a31c-c80123eaab88', N'65ea10fe-b443-4233-a48a-d8bd7896d244', N'travis@mailsac.com', CAST(N'2023-11-10T07:39:53.4063209' AS DateTime2), NULL, NULL),
    (N'e3dda7d5-1887-49cc-90bd-a9e92cbcccd0', N'7d5ca2e0-5a84-47af-a31c-c80123eaab88', NULL, N'travis@mailsac.com', CAST(N'2023-11-10T07:39:53.4064264' AS DateTime2), NULL, N'd03154ff-da79-4b02-b231-cd0d8494c2e5'),
    (N'3cfa0036-8c4b-4b71-87ae-aa341162867f', N'7d5ca2e0-5a84-47af-a31c-c80123eaab88', N'c50504d5-a7ec-4aab-acae-0ed0a39d1578', N'travis@mailsac.com', CAST(N'2023-11-10T07:39:53.4063189' AS DateTime2), NULL, NULL),
    (N'7e21504a-5315-4694-88d4-b37edbe0743a', N'7d5ca2e0-5a84-47af-a31c-c80123eaab88', N'2fb04be4-3b23-42eb-9534-20d767654667', N'travis@mailsac.com', CAST(N'2023-11-10T07:39:53.4063155' AS DateTime2), NULL, NULL),
    (N'90f91722-e6ca-4e33-98da-b8586ed2e149', N'7d5ca2e0-5a84-47af-a31c-c80123eaab88', NULL, N'travis@mailsac.com', CAST(N'2023-11-10T07:39:53.4064227' AS DateTime2), NULL, N'18db181a-39c7-4ff6-aa5f-504c9fd42495'),
    (N'f47ad713-99e0-4566-93cb-b90470e5ac1f', N'542e0839-1b15-4336-a832-16fa88578c33', N'd2d503a2-f55c-4f44-87e1-6c4464a5f16b', N'travis@mailsac.com', CAST(N'2023-11-10T08:29:43.6033677' AS DateTime2), NULL, NULL),
    (N'5ab7a9b9-1bdb-4909-bf24-b9db2c3b4346', N'542e0839-1b15-4336-a832-16fa88578c33', N'305f2292-4230-403c-8e78-ccab2b7faf66', N'travis@mailsac.com', CAST(N'2023-11-10T08:29:43.6033680' AS DateTime2), NULL, NULL),
    (N'43c7d10d-ac2d-42a5-b28d-bb628043f420', N'7d5ca2e0-5a84-47af-a31c-c80123eaab88', N'a809dfba-5e21-491e-ab19-5374a141fe88', N'travis@mailsac.com', CAST(N'2023-11-10T07:39:53.4063143' AS DateTime2), NULL, NULL),
    (N'2f99fc46-74c2-46cb-9fc6-c6be69b1c9b2', N'542e0839-1b15-4336-a832-16fa88578c33', N'b43b17b3-b34d-4efb-a07e-8c00e6e7aab0', N'travis@mailsac.com', CAST(N'2023-11-10T08:29:43.6033605' AS DateTime2), NULL, NULL),
    (N'135c8ac0-c22a-47cd-aaff-c801731392de', N'542e0839-1b15-4336-a832-16fa88578c33', N'61da1441-6b0e-4d1a-88a2-ec632d01906d', N'travis@mailsac.com', CAST(N'2023-11-10T08:29:43.6033614' AS DateTime2), NULL, NULL),
    (N'776ad56e-1681-4d60-a327-cfb2ba2b7103', N'542e0839-1b15-4336-a832-16fa88578c33', NULL, N'travis@mailsac.com', CAST(N'2023-11-10T08:29:43.6033758' AS DateTime2), NULL, N'd03154ff-da79-4b02-b231-cd0d8494c2e5'),
    (N'a9ba9685-2c90-496e-9dc0-d474782860aa', N'7d5ca2e0-5a84-47af-a31c-c80123eaab88', N'bf225467-4b08-4da0-a1e5-2ef0ff6e2f96', N'travis@mailsac.com', CAST(N'2023-11-10T07:39:53.4063147' AS DateTime2), NULL, NULL),
    (N'0f428942-037f-4c5a-97c6-d99294583d9f', N'7d5ca2e0-5a84-47af-a31c-c80123eaab88', NULL, N'travis@mailsac.com', CAST(N'2023-11-10T07:39:53.4064233' AS DateTime2), NULL, N'2d024344-dd8e-49bb-a069-ef59a2625d34'),
    (N'0758af7e-ef6d-45ef-82a5-da0cd3c1e818', N'7d5ca2e0-5a84-47af-a31c-c80123eaab88', N'f27211ee-28cb-42a1-b487-51aa7456ccd3', N'travis@mailsac.com', CAST(N'2023-11-10T07:39:53.4063205' AS DateTime2), NULL, NULL),
    (N'ea7f2f35-209f-46c7-96ea-dca7b2efadc6', N'7d5ca2e0-5a84-47af-a31c-c80123eaab88', NULL, N'travis@mailsac.com', CAST(N'2023-11-10T07:39:53.4064247' AS DateTime2), NULL, N'010a1cc4-259b-4198-a841-92a5b784787d'),
    (N'efb3168c-0797-402d-a703-dd0b66205f9f', N'7d5ca2e0-5a84-47af-a31c-c80123eaab88', N'7ac8c99f-aaca-4883-ab1f-fb94fbaa9fca', N'travis@mailsac.com', CAST(N'2023-11-10T07:39:53.4062517' AS DateTime2), NULL, NULL),
    (N'825de3d2-2cd6-424c-9520-ef0babd98120', N'7d5ca2e0-5a84-47af-a31c-c80123eaab88', NULL, N'travis@mailsac.com', CAST(N'2023-11-10T07:39:53.4065306' AS DateTime2), N'bb0c0779-5261-4d14-8a96-12ff3e0d8dff', NULL),
    (N'5ed85bcf-00df-4b49-a45f-f7ead2e382d6', N'7d5ca2e0-5a84-47af-a31c-c80123eaab88', NULL, N'travis@mailsac.com', CAST(N'2023-11-10T07:39:53.4064236' AS DateTime2), NULL, N'02561934-85a8-4ef0-a890-82092b240fb4');
    IF EXISTS (SELECT * FROM [sys].[identity_columns] WHERE [name] IN (N'CategoryBasketId',N'BasketId',N'CategoryId',N'LastUpdateId',N'LastUpdateDateTime',N'ExcludeCategoryId',N'OptionalCategoryId') AND [object_id] = OBJECT_ID(N'[CategoryBaskets]'))
        SET IDENTITY_INSERT [CategoryBaskets] OFF;
END
GO

IF NOT EXISTS (SELECT 1 FROM [SupplyBaskets])
BEGIN
    IF EXISTS (SELECT * FROM [sys].[identity_columns] WHERE [name] IN (N'SupplyBasketId', N'BasketId', N'SupplyId', N'LastUpdateId', N'LastUpdateDateTime') AND [object_id] = OBJECT_ID(N'[SupplyBaskets]'))
        SET IDENTITY_INSERT [SupplyBaskets] ON;
    INSERT INTO [SupplyBaskets] ([SupplyBasketId], [BasketId], [SupplyId], [LastUpdateId], [LastUpdateDateTime]) 
    VALUES (N'3a6552f6-b0e4-43d0-bb50-170bf2406068', N'7e50139d-1674-4bc5-9945-2841d9e50d7a', N'331d83d3-04e4-41ca-9527-8ebcc1316090', N'travis@mailsac.com', CAST(N'2023-11-25T12:54:08.6409171' AS DateTime2)),
    (N'60987576-f31d-45fe-a5b0-1a797678c6d9', N'7e50139d-1674-4bc5-9945-2841d9e50d7a', N'6d59f00f-d7d8-48e3-ab36-9d96de8b09d0', N'travis@mailsac.com', CAST(N'2023-11-25T12:54:01.8508262' AS DateTime2)),
    (N'96d73dc3-2c8d-40a6-95aa-395be171144d', N'7e50139d-1674-4bc5-9945-2841d9e50d7a', N'd5b42185-f6f5-4d33-9c7d-392eadb5b1e6', N'travis@mailsac.com', CAST(N'2023-11-25T12:54:08.5980220' AS DateTime2)),
    (N'476beac7-a707-4444-b296-5146b58e8aea', N'7e50139d-1674-4bc5-9945-2841d9e50d7a', N'7604aea7-96b0-4096-8bbb-bbef00fdc221', N'travis@mailsac.com', CAST(N'2023-11-25T12:54:08.6481751' AS DateTime2)),
    (N'b28a8bcc-ba04-4bda-a1a4-6c1aa8863148', N'7e50139d-1674-4bc5-9945-2841d9e50d7a', N'1ec27cd4-58a3-49d3-8395-8d83536a4305', N'travis@mailsac.com', CAST(N'2023-11-25T12:54:08.6132176' AS DateTime2)),
    (N'1c4c4fe2-95ea-4d6d-ad5d-7fc988b9a285', N'7e50139d-1674-4bc5-9945-2841d9e50d7a', N'5aa553c8-f564-4755-9d2a-8e5a66f884d1', N'travis@mailsac.com', CAST(N'2023-11-25T12:54:08.5899497' AS DateTime2)),
    (N'9999d441-9cde-4ad3-9166-875d7bb35d99', N'7e50139d-1674-4bc5-9945-2841d9e50d7a', N'a864cd79-d226-441d-9f23-db77c2b9bd85', N'travis@mailsac.com', CAST(N'2023-11-25T12:54:08.6228932' AS DateTime2)),
    (N'9445e88e-7885-4033-b2f3-a04431eda358', N'7e50139d-1674-4bc5-9945-2841d9e50d7a', N'dd6d4bec-20f1-4149-8f14-2141bad77e9b', N'travis@mailsac.com', CAST(N'2023-11-25T12:54:08.6570856' AS DateTime2)),
    (N'ffe36285-9f84-48d4-8910-a3f018ec3929', N'7e50139d-1674-4bc5-9945-2841d9e50d7a', N'07979a90-bab9-47cf-befd-f0b16999ee00', N'travis@mailsac.com', CAST(N'2023-11-25T12:54:08.6068747' AS DateTime2)),
    (N'a136eda7-96af-440a-a875-c4b41093b804', N'7e50139d-1674-4bc5-9945-2841d9e50d7a', N'3e2d5eee-ebfc-4a86-9c9c-18049eccaeed', N'travis@mailsac.com', CAST(N'2023-11-25T12:54:08.6315552' AS DateTime2));
    IF EXISTS (SELECT * FROM [sys].[identity_columns] WHERE [name] IN (N'SupplyBasketId', N'BasketId', N'SupplyId', N'LastUpdateId', N'LastUpdateDateTime') AND [object_id] = OBJECT_ID(N'[SupplyBaskets]'))
        SET IDENTITY_INSERT [SupplyBaskets] OFF;
END
GO

IF NOT EXISTS (SELECT * FROM sys.indexes WHERE name='IX_AgeGroupCategories_AgeGroupId' AND object_id = OBJECT_ID(N'[AgeGroupCategories]'))
BEGIN
    CREATE INDEX [IX_AgeGroupCategories_AgeGroupId] ON [AgeGroupCategories] ([AgeGroupId]);
END
GO

IF NOT EXISTS (SELECT * FROM sys.indexes WHERE name='IX_AgeGroupCategories_CategoryId' AND object_id = OBJECT_ID(N'[AgeGroupCategories]'))
BEGIN
    CREATE INDEX [IX_AgeGroupCategories_CategoryId] ON [AgeGroupCategories] ([CategoryId]);
END
GO

IF NOT EXISTS (SELECT * FROM sys.indexes WHERE name='IX_AgeGroupCategories_ExcludeCategoryId' AND object_id = OBJECT_ID(N'[AgeGroupCategories]'))
BEGIN
    CREATE INDEX [IX_AgeGroupCategories_ExcludeCategoryId] ON [AgeGroupCategories] ([ExcludeCategoryId]);
END
GO

IF NOT EXISTS (SELECT * FROM sys.indexes WHERE name='IX_AgeGroupCategories_OptionalCategoryId' AND object_id = OBJECT_ID(N'[AgeGroupCategories]'))
BEGIN
    CREATE INDEX [IX_AgeGroupCategories_OptionalCategoryId] ON [AgeGroupCategories] ([OptionalCategoryId]);
END
GO

IF NOT EXISTS (SELECT * FROM sys.indexes WHERE name='IX_AspNetRoleClaims_RoleId' AND object_id = OBJECT_ID(N'[AspNetRoleClaims]'))
BEGIN
    CREATE INDEX [IX_AspNetRoleClaims_RoleId] ON [AspNetRoleClaims] ([RoleId]);
END
GO

IF NOT EXISTS (SELECT * FROM sys.indexes WHERE name='RoleNameIndex' AND object_id = OBJECT_ID(N'[AspNetRoles]'))
BEGIN
    CREATE UNIQUE INDEX [RoleNameIndex] ON [AspNetRoles] ([NormalizedName]) WHERE [NormalizedName] IS NOT NULL;
END
GO

IF NOT EXISTS (SELECT * FROM sys.indexes WHERE name='IX_AspNetUserClaims_UserId' AND object_id = OBJECT_ID(N'[AspNetUserClaims]'))
BEGIN
    CREATE INDEX [IX_AspNetUserClaims_UserId] ON [AspNetUserClaims] ([UserId]);
END
GO

IF NOT EXISTS (SELECT * FROM sys.indexes WHERE name='IX_AspNetUserLogins_UserId' AND object_id = OBJECT_ID(N'[AspNetUserLogins]'))
BEGIN
    CREATE INDEX [IX_AspNetUserLogins_UserId] ON [AspNetUserLogins] ([UserId]);
END
GO

IF NOT EXISTS (SELECT * FROM sys.indexes WHERE name='IX_AspNetUserRoles_RoleId' AND object_id = OBJECT_ID(N'[AspNetUserRoles]'))
BEGIN
    CREATE INDEX [IX_AspNetUserRoles_RoleId] ON [AspNetUserRoles] ([RoleId]);
END
GO

IF NOT EXISTS (SELECT * FROM sys.indexes WHERE name='EmailIndex' AND object_id = OBJECT_ID(N'[AspNetUsers]'))
BEGIN
    CREATE INDEX [EmailIndex] ON [AspNetUsers] ([NormalizedEmail]);
END
GO

IF NOT EXISTS (SELECT * FROM sys.indexes WHERE name='UserNameIndex' AND object_id = OBJECT_ID(N'[AspNetUsers]'))
BEGIN
    CREATE UNIQUE INDEX [UserNameIndex] ON [AspNetUsers] ([NormalizedUserName]) WHERE [NormalizedUserName] IS NOT NULL;
END
GO

IF NOT EXISTS (SELECT * FROM sys.indexes WHERE name='IX_Baskets_AgeGroupId' AND object_id = OBJECT_ID(N'[Baskets]'))
BEGIN
    CREATE INDEX [IX_Baskets_AgeGroupId] ON [Baskets] ([AgeGroupId]);
END
GO

IF NOT EXISTS (SELECT * FROM sys.indexes WHERE name='IX_Baskets_EthnicityId' AND object_id = OBJECT_ID(N'[Baskets]'))
BEGIN
    CREATE INDEX [IX_Baskets_EthnicityId] ON [Baskets] ([EthnicityId]);
END
GO

IF NOT EXISTS (SELECT * FROM sys.indexes WHERE name='IX_Baskets_GenderId' AND object_id = OBJECT_ID(N'[Baskets]'))
BEGIN
    CREATE INDEX [IX_Baskets_GenderId] ON [Baskets] ([GenderId]);
END
GO

IF NOT EXISTS (SELECT * FROM sys.indexes WHERE name='IX_BasketTransactions_BasketId' AND object_id = OBJECT_ID(N'[BasketTransactions]'))
BEGIN
    CREATE INDEX [IX_BasketTransactions_BasketId] ON [BasketTransactions] ([BasketId]);
END
GO

IF NOT EXISTS (SELECT * FROM sys.indexes WHERE name='IX_BasketTransactions_DonorId' AND object_id = OBJECT_ID(N'[BasketTransactions]'))
BEGIN
    CREATE INDEX [IX_BasketTransactions_DonorId] ON [BasketTransactions] ([DonorId]);
END
GO

IF NOT EXISTS (SELECT * FROM sys.indexes WHERE name='IX_BasketTransactions_RecipientId' AND object_id = OBJECT_ID(N'[BasketTransactions]'))
BEGIN
    CREATE INDEX [IX_BasketTransactions_RecipientId] ON [BasketTransactions] ([RecipientId]);
END
GO

IF NOT EXISTS (SELECT * FROM sys.indexes WHERE name='IX_CategoryBaskets_BasketId' AND object_id = OBJECT_ID(N'[CategoryBaskets]'))
BEGIN
    CREATE INDEX [IX_CategoryBaskets_BasketId] ON [CategoryBaskets] ([BasketId]);
END
GO

IF NOT EXISTS (SELECT * FROM sys.indexes WHERE name='IX_CategoryBaskets_CategoryId' AND object_id = OBJECT_ID(N'[CategoryBaskets]'))
BEGIN
    CREATE INDEX [IX_CategoryBaskets_CategoryId] ON [CategoryBaskets] ([CategoryId]);
END
GO

IF NOT EXISTS (SELECT * FROM sys.indexes WHERE name='IX_CategoryBaskets_ExcludeCategoryId' AND object_id = OBJECT_ID(N'[CategoryBaskets]'))
BEGIN
    CREATE INDEX [IX_CategoryBaskets_ExcludeCategoryId] ON [CategoryBaskets] ([ExcludeCategoryId]);
END
GO

IF NOT EXISTS (SELECT * FROM sys.indexes WHERE name='IX_CategoryBaskets_OptionalCategoryId' AND object_id = OBJECT_ID(N'[CategoryBaskets]'))
BEGIN
    CREATE INDEX [IX_CategoryBaskets_OptionalCategoryId] ON [CategoryBaskets] ([OptionalCategoryId]);
END
GO

IF NOT EXISTS (SELECT * FROM sys.indexes WHERE name='IX_Supplies_CategoryId' AND object_id = OBJECT_ID(N'[Supplies]'))
BEGIN
    CREATE INDEX [IX_Supplies_CategoryId] ON [Supplies] ([CategoryId]);
END
GO

IF NOT EXISTS (SELECT * FROM sys.indexes WHERE name='IX_Supplies_ExcludeCategoryId' AND object_id = OBJECT_ID(N'[Supplies]'))
BEGIN
    CREATE INDEX [IX_Supplies_ExcludeCategoryId] ON [Supplies] ([ExcludeCategoryId]);
END
GO

IF NOT EXISTS (SELECT * FROM sys.indexes WHERE name='IX_Supplies_OptionalCategoryId' AND object_id = OBJECT_ID(N'[Supplies]'))
BEGIN
    CREATE INDEX [IX_Supplies_OptionalCategoryId] ON [Supplies] ([OptionalCategoryId]);
END
GO

IF NOT EXISTS (SELECT * FROM sys.indexes WHERE name='IX_SupplyBaskets_BasketId' AND object_id = OBJECT_ID(N'[SupplyBaskets]'))
BEGIN
    CREATE INDEX [IX_SupplyBaskets_BasketId] ON [SupplyBaskets] ([BasketId]);
END
GO

IF NOT EXISTS (SELECT * FROM sys.indexes WHERE name='IX_SupplyBaskets_SupplyId' AND object_id = OBJECT_ID(N'[SupplyBaskets]'))
BEGIN
    CREATE INDEX [IX_SupplyBaskets_SupplyId] ON [SupplyBaskets] ([SupplyId]);
END
GO

IF NOT EXISTS (SELECT * FROM sys.indexes WHERE name='IX_SupplyTransactions_DonorId' AND object_id = OBJECT_ID(N'[SupplyTransactions]'))
BEGIN
    CREATE INDEX [IX_SupplyTransactions_DonorId] ON [SupplyTransactions] ([DonorId]);
END
GO

IF NOT EXISTS (SELECT * FROM sys.indexes WHERE name='IX_SupplyTransactions_RecipientId' AND object_id = OBJECT_ID(N'[SupplyTransactions]'))
BEGIN
    CREATE INDEX [IX_SupplyTransactions_RecipientId] ON [SupplyTransactions] ([RecipientId]);
END
GO

IF NOT EXISTS (SELECT * FROM sys.indexes WHERE name='IX_SupplyTransactions_SupplyId' AND object_id = OBJECT_ID(N'[SupplyTransactions]'))
BEGIN
    CREATE INDEX [IX_SupplyTransactions_SupplyId] ON [SupplyTransactions] ([SupplyId]);
END
GO