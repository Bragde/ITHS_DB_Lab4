CREATE TABLE [dbo].[Session] (
    [Id]            INT            IDENTITY (1, 1) NOT NULL,
    [Name]          NVARCHAR (MAX) NOT NULL,
    [Description]   NVARCHAR (MAX) NOT NULL,
    [Time]          REAL           NOT NULL,
    [PersonId]      INT            NOT NULL,
    [Discriminator] NVARCHAR (MAX) NOT NULL,
    CONSTRAINT [PK_Session] PRIMARY KEY CLUSTERED ([Id] ASC),
    CONSTRAINT [FK_Session_Person_PersonId] FOREIGN KEY ([PersonId]) REFERENCES [dbo].[Person] ([Id]) ON DELETE CASCADE
);


GO
CREATE NONCLUSTERED INDEX [IX_Session_PersonId]
    ON [dbo].[Session]([PersonId] ASC);

