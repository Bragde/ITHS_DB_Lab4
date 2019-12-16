CREATE TABLE [dbo].[Gear] (
    [Id]   INT            IDENTITY (1, 1) NOT NULL,
    [Name] NVARCHAR (MAX) NOT NULL,
    CONSTRAINT [PK_Gear] PRIMARY KEY CLUSTERED ([Id] ASC)
);

