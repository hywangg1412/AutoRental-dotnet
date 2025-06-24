CREATE DATABASE [AutoRental_dotnet]
GO;

USE [AutoRental_dotnet]
GO

CREATE TABLE [Roles] (
    [RoleId] UNIQUEIDENTIFIER NOT NULL,
    [RoleName] NVARCHAR(50) NOT NULL,
    [NormalizedName] NVARCHAR(256) NOT NULL,
    CONSTRAINT [PK_Roles] PRIMARY KEY ([RoleId]),
    CONSTRAINT [UQ_Roles_RoleName] UNIQUE ([RoleName]),
    CONSTRAINT [UQ_Roles_NormalizedName] UNIQUE ([NormalizedName])
);
GO

CREATE TABLE [Users] (
    [UserId] UNIQUEIDENTIFIER NOT NULL,
    [Username] NVARCHAR(100) NOT NULL,
    [UserDOB] DATE NULL,
    [PhoneNumber] NVARCHAR(11) NULL,
    [AvatarUrl] NVARCHAR(255) NULL,
    [Gender] NVARCHAR(10) NULL,
    [FirstName] NVARCHAR(255) NULL,
    [LastName] NVARCHAR(255) NULL,
    [Status] NVARCHAR(20) NOT NULL,
    [CreatedDate] DATETIME2 NULL,
    [NormalizedUserName] NVARCHAR(255) NULL,
    [Email] NVARCHAR(100) NOT NULL,
    [NormalizedEmail] NVARCHAR(255) NULL,
    [EmailVerified] BIT NOT NULL,
    [PasswordHash] NVARCHAR(255) NOT NULL,
    [SecurityStamp] NVARCHAR(MAX) NULL,
    [ConcurrencyStamp] NVARCHAR(MAX) NULL,
    [LockoutEnd] DATETIME2 NULL,
    [LockoutEnabled] BIT NOT NULL,
    [AccessFailedCount] INT NOT NULL,

    CONSTRAINT [PK_Users] PRIMARY KEY CLUSTERED (
        [UserId] ASC
    ) WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO;

CREATE TABLE [UserRoles] (
    [UserId] UNIQUEIDENTIFIER NOT NULL,
    [RoleId] UNIQUEIDENTIFIER NOT NULL,
    CONSTRAINT [PK_UserRoles] PRIMARY KEY ([UserId], [RoleId]),
    CONSTRAINT [FK_UserRoles_UserId] FOREIGN KEY ([UserId]) REFERENCES [Users]([UserId]) ON DELETE CASCADE,
    CONSTRAINT [FK_UserRoles_RoleId] FOREIGN KEY ([RoleId]) REFERENCES [Roles]([RoleId]) ON DELETE CASCADE
);
GO

CREATE NONCLUSTERED INDEX IX_UserRoles_UserId ON [UserRoles]([UserId]);
CREATE NONCLUSTERED INDEX IX_UserRoles_RoleId ON [UserRoles]([RoleId]);

