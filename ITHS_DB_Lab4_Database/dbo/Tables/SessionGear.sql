CREATE TABLE [dbo].[SessionGear] (
    [SessionId] INT NOT NULL,
    [GearId]    INT NOT NULL,
    CONSTRAINT [PK_SessionGear] PRIMARY KEY CLUSTERED ([SessionId] ASC, [GearId] ASC),
    CONSTRAINT [FK_SessionGear_Gear_GearId] FOREIGN KEY ([GearId]) REFERENCES [dbo].[Gear] ([Id]) ON DELETE CASCADE,
    CONSTRAINT [FK_SessionGear_Session_SessionId] FOREIGN KEY ([SessionId]) REFERENCES [dbo].[Session] ([Id]) ON DELETE CASCADE
);


GO
CREATE NONCLUSTERED INDEX [IX_SessionGear_GearId]
    ON [dbo].[SessionGear]([GearId] ASC);

