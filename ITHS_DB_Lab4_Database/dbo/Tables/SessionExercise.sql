CREATE TABLE [dbo].[SessionExercise] (
    [Id]          INT IDENTITY (1, 1) NOT NULL,
    [Repetitions] INT NULL,
    [PainLevel]   INT NULL,
    [SessionId]   INT NOT NULL,
    [ExerciseId]  INT NOT NULL,
    CONSTRAINT [PK_SessionExercise] PRIMARY KEY CLUSTERED ([Id] ASC),
    CONSTRAINT [FK_SessionExercise_Exercise_ExerciseId] FOREIGN KEY ([ExerciseId]) REFERENCES [dbo].[Exercise] ([Id]) ON DELETE CASCADE,
    CONSTRAINT [FK_SessionExercise_Session_SessionId] FOREIGN KEY ([SessionId]) REFERENCES [dbo].[Session] ([Id]) ON DELETE CASCADE
);


GO
CREATE NONCLUSTERED INDEX [IX_SessionExercise_ExerciseId]
    ON [dbo].[SessionExercise]([ExerciseId] ASC);


GO
CREATE NONCLUSTERED INDEX [IX_SessionExercise_SessionId]
    ON [dbo].[SessionExercise]([SessionId] ASC);

