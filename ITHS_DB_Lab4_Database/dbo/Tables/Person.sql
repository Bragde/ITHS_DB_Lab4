CREATE TABLE [dbo].[Person] (
    [Id]        INT            IDENTITY (1, 1) NOT NULL,
    [Email]     NVARCHAR (MAX) NULL,
    [FirstName] NVARCHAR (255) DEFAULT (N'') NOT NULL,
    [LastName]  NVARCHAR (255) DEFAULT (N'') NOT NULL,
    CONSTRAINT [PK_Person] PRIMARY KEY CLUSTERED ([Id] ASC)
);

