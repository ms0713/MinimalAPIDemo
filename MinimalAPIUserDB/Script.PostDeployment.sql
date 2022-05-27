If not exists (SELECT 1 FROM dbo.[User])
BEGIN
	INSERT INTO dbo.[User] 
	(FirstName, LastName)
	VALUES ('Milan', 'Sangani'),
	('Nayan', 'Surani'),
	('Pratik', 'Thakkar');
END