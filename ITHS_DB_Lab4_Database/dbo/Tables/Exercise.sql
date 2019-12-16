CREATE TABLE [dbo].[Exercise] (
    [Id]   INT            IDENTITY (1, 1) NOT NULL,
    [Name] NVARCHAR (MAX) NOT NULL,
    CONSTRAINT [PK_Exercise] PRIMARY KEY CLUSTERED ([Id] ASC)
);

