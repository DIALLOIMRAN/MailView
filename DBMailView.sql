
-- --------------------------------------------------
-- Entity Designer DDL Script for SQL Server 2005, 2008, 2012 and Azure
-- --------------------------------------------------
-- Date Created: 04/13/2015 15:40:46
-- Generated from EDMX file: D:\projets\application de messagerie électronique( MailView )\WindowsFormsApplication1\WindowsFormsApplication1\Model1.edmx
-- --------------------------------------------------

SET QUOTED_IDENTIFIER OFF;
GO
USE [MailView];
GO
IF SCHEMA_ID(N'dbo') IS NULL EXECUTE(N'CREATE SCHEMA [dbo]');
GO

-- --------------------------------------------------
-- Dropping existing FOREIGN KEY constraints
-- --------------------------------------------------

IF OBJECT_ID(N'[dbo].[FK_UserMailBox]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[MailBox] DROP CONSTRAINT [FK_UserMailBox];
GO
IF OBJECT_ID(N'[dbo].[FK_MailBoxMail_MailBox]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[MailBoxMail] DROP CONSTRAINT [FK_MailBoxMail_MailBox];
GO
IF OBJECT_ID(N'[dbo].[FK_MailBoxMail_Mail]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[MailBoxMail] DROP CONSTRAINT [FK_MailBoxMail_Mail];
GO
IF OBJECT_ID(N'[dbo].[FK_UserUser_User]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[UserUser] DROP CONSTRAINT [FK_UserUser_User];
GO
IF OBJECT_ID(N'[dbo].[FK_UserUser_User1]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[UserUser] DROP CONSTRAINT [FK_UserUser_User1];
GO

-- --------------------------------------------------
-- Dropping existing tables
-- --------------------------------------------------

IF OBJECT_ID(N'[dbo].[User]', 'U') IS NOT NULL
    DROP TABLE [dbo].[User];
GO
IF OBJECT_ID(N'[dbo].[MailBox]', 'U') IS NOT NULL
    DROP TABLE [dbo].[MailBox];
GO
IF OBJECT_ID(N'[dbo].[Mail]', 'U') IS NOT NULL
    DROP TABLE [dbo].[Mail];
GO
IF OBJECT_ID(N'[dbo].[Administrateur]', 'U') IS NOT NULL
    DROP TABLE [dbo].[Administrateur];
GO
IF OBJECT_ID(N'[dbo].[MailBoxMail]', 'U') IS NOT NULL
    DROP TABLE [dbo].[MailBoxMail];
GO
IF OBJECT_ID(N'[dbo].[UserUser]', 'U') IS NOT NULL
    DROP TABLE [dbo].[UserUser];
GO

-- --------------------------------------------------
-- Creating all tables
-- --------------------------------------------------

-- Creating table 'User'
CREATE TABLE [dbo].[User] (
    [Id_user] int IDENTITY(1,1) NOT NULL,
    [nom] varchar(50)  NOT NULL,
    [prenom] varchar(50)  NOT NULL,
    [adresse_email] varchar(100)  NOT NULL,
    [password] varchar(50)  NOT NULL,
    [sexe] varchar(2)  NULL,
    [connecté] int  NULL,
    [photo] varbinary(max)  NULL,
	[numTelephone] varchar(20)  NOT NULL
);
GO

-- Creating table 'MailBox'
CREATE TABLE [dbo].[MailBox] (
    [Id_mailbox] int IDENTITY(1,1) NOT NULL,
    [libellé] varchar(20)  NOT NULL,
    [UserId_user] int  NOT NULL
);
GO

-- Creating table 'Mail'
CREATE TABLE [dbo].[Mail] (
    [Id_mail] int IDENTITY(1,1) NOT NULL,
    [adresse_source] varchar(100)  NOT NULL,
    [adresse_dest] varchar(100)  NOT NULL,
    [objet] varchar(255)  NOT NULL,
    [contenu] Text  NOT NULL,
    [date_msg] Datetime  NOT NULL,
    [etat_msg] int  NULL
);
GO

-- Creating table 'Administrateur'
CREATE TABLE [dbo].[Administrateur] (
    [Id_admin] int IDENTITY(1,1) NOT NULL,
    [nom] varchar(50)  NOT NULL,
    [prenom] varchar(50)  NOT NULL,
    [email] varchar(100)  NOT NULL,
    [password] varchar(50)  NOT NULL
);
GO

-- Creating table 'MailBoxMail'
CREATE TABLE [dbo].[MailBoxMail] (
    [MailBox_Id_mailbox] int  NOT NULL,
    [Mail_Id_mail] int  NOT NULL
);
GO

-- Creating table 'UserUser'
CREATE TABLE [dbo].[UserUser] (
    [User1_Id_user] int  NOT NULL,
    [User2_Id_user] int  NOT NULL
);
GO

-- --------------------------------------------------
-- Creating all PRIMARY KEY constraints
-- --------------------------------------------------

-- Creating primary key on [Id_user] in table 'User'
ALTER TABLE [dbo].[User]
ADD CONSTRAINT [PK_User]
    PRIMARY KEY CLUSTERED ([Id_user] ASC);
GO

-- Creating primary key on [Id_mailbox] in table 'MailBox'
ALTER TABLE [dbo].[MailBox]
ADD CONSTRAINT [PK_MailBox]
    PRIMARY KEY CLUSTERED ([Id_mailbox] ASC);
GO

-- Creating primary key on [Id_mail] in table 'Mail'
ALTER TABLE [dbo].[Mail]
ADD CONSTRAINT [PK_Mail]
    PRIMARY KEY CLUSTERED ([Id_mail] ASC);
GO

-- Creating primary key on [Id_admin] in table 'Administrateur'
ALTER TABLE [dbo].[Administrateur]
ADD CONSTRAINT [PK_Administrateur]
    PRIMARY KEY CLUSTERED ([Id_admin] ASC);
GO

-- Creating primary key on [MailBox_Id_mailbox], [Mail_Id_mail] in table 'MailBoxMail'
ALTER TABLE [dbo].[MailBoxMail]
ADD CONSTRAINT [PK_MailBoxMail]
    PRIMARY KEY CLUSTERED ([MailBox_Id_mailbox], [Mail_Id_mail] ASC);
GO

-- Creating primary key on [User1_Id_user], [User2_Id_user] in table 'UserUser'
ALTER TABLE [dbo].[UserUser]
ADD CONSTRAINT [PK_UserUser]
    PRIMARY KEY CLUSTERED ([User1_Id_user], [User2_Id_user] ASC);
GO

-- --------------------------------------------------
-- Creating all FOREIGN KEY constraints
-- --------------------------------------------------

-- Creating foreign key on [UserId_user] in table 'MailBox'
ALTER TABLE [dbo].[MailBox]
ADD CONSTRAINT [FK_UserMailBox]
    FOREIGN KEY ([UserId_user])
    REFERENCES [dbo].[User]
        ([Id_user])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_UserMailBox'
CREATE INDEX [IX_FK_UserMailBox]
ON [dbo].[MailBox]
    ([UserId_user]);
GO

-- Creating foreign key on [MailBox_Id_mailbox] in table 'MailBoxMail'
ALTER TABLE [dbo].[MailBoxMail]
ADD CONSTRAINT [FK_MailBoxMail_MailBox]
    FOREIGN KEY ([MailBox_Id_mailbox])
    REFERENCES [dbo].[MailBox]
        ([Id_mailbox])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating foreign key on [Mail_Id_mail] in table 'MailBoxMail'
ALTER TABLE [dbo].[MailBoxMail]
ADD CONSTRAINT [FK_MailBoxMail_Mail]
    FOREIGN KEY ([Mail_Id_mail])
    REFERENCES [dbo].[Mail]
        ([Id_mail])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_MailBoxMail_Mail'
CREATE INDEX [IX_FK_MailBoxMail_Mail]
ON [dbo].[MailBoxMail]
    ([Mail_Id_mail]);
GO

-- Creating foreign key on [User1_Id_user] in table 'UserUser'
ALTER TABLE [dbo].[UserUser]
ADD CONSTRAINT [FK_UserUser_User]
    FOREIGN KEY ([User1_Id_user])
    REFERENCES [dbo].[User]
        ([Id_user])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating foreign key on [User2_Id_user] in table 'UserUser'
ALTER TABLE [dbo].[UserUser]
ADD CONSTRAINT [FK_UserUser_User1]
    FOREIGN KEY ([User2_Id_user])
    REFERENCES [dbo].[User]
        ([Id_user])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_UserUser_User1'
CREATE INDEX [IX_FK_UserUser_User1]
ON [dbo].[UserUser]
    ([User2_Id_user]);
GO

-- --------------------------------------------------
-- Script has ended
-- --------------------------------------------------