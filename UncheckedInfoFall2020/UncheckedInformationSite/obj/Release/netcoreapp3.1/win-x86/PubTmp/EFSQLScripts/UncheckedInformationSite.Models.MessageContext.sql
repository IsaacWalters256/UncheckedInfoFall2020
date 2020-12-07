IF OBJECT_ID(N'[__EFMigrationsHistory]') IS NULL
BEGIN
    CREATE TABLE [__EFMigrationsHistory] (
        [MigrationId] nvarchar(150) NOT NULL,
        [ProductVersion] nvarchar(32) NOT NULL,
        CONSTRAINT [PK___EFMigrationsHistory] PRIMARY KEY ([MigrationId])
    );
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20201207010729_Initial')
BEGIN
    CREATE TABLE [User] (
        [UserID] int NOT NULL IDENTITY,
        [Name] nvarchar(max) NULL,
        CONSTRAINT [PK_User] PRIMARY KEY ([UserID])
    );
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20201207010729_Initial')
BEGIN
    CREATE TABLE [Messages] (
        [MessageID] int NOT NULL IDENTITY,
        [MessageTitle] nvarchar(max) NULL,
        [MessageText] nvarchar(max) NULL,
        [MessageDate] datetime2 NOT NULL,
        [MessengerUserID] int NULL,
        CONSTRAINT [PK_Messages] PRIMARY KEY ([MessageID]),
        CONSTRAINT [FK_Messages_User_MessengerUserID] FOREIGN KEY ([MessengerUserID]) REFERENCES [User] ([UserID]) ON DELETE NO ACTION
    );
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20201207010729_Initial')
BEGIN
    CREATE INDEX [IX_Messages_MessengerUserID] ON [Messages] ([MessengerUserID]);
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20201207010729_Initial')
BEGIN
    INSERT INTO [__EFMigrationsHistory] ([MigrationId], [ProductVersion])
    VALUES (N'20201207010729_Initial', N'3.1.9');
END;

GO

