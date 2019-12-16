CREATE VIEW vw_GetAllPersonsAndSessions AS 
SELECT 
	PE.FirstName,
	PE.LastName,
	SE.Name AS Session,
	SE.Description,
	SE.Time,
	SEX.Repetitions,
	SEX.PainLevel,
	GE.Name AS Gear
FROM Person PE
LEFT JOIN Session SE ON SE.PersonId = PE.Id
LEFT JOIN SessionExercise SEX ON SEX.SessionId = SE.Id
LEFT JOIN Exercise EX ON EX.Id = SEX.SessionId
LEFT JOIN SessionGear SEG ON SEG.SessionId = SE.Id
LEFT JOIN Gear GE ON GE.Id = SEG.GearId