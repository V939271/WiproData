use Venkat;

CREATE TABLE QuestionTestData (
    ID INT PRIMARY KEY,
    QuestionType VARCHAR(50),    
    InputText VARCHAR(100),       
    SearchChar CHAR(1),           
    ReferenceDate DATE            
);

INSERT INTO QuestionTestData (ID, QuestionType, InputText, SearchChar, ReferenceDate) VALUES
(1, 'LastOccurrence', 'Keerthi', 'e', NULL),
(2, 'SplitFullName', 'Venkata Narayana', NULL, NULL),
(3, 'CountChar', 'missisipi', 'i', NULL),
(4, 'LastDayNextMonth', NULL, NULL, '2025-08-01'),
(5, 'FirstDayPrevMonth', NULL, NULL, '2025-08-01'),
(6, 'AllFridays', NULL, NULL, '2025-08-01');


--1
SELECT 
    ID,
    InputText,
    SearchChar,
    LEN(InputText) - CHARINDEX(SearchChar, REVERSE(InputText)) + 1 AS LastOccurrencePosition
FROM QuestionTestData
WHERE QuestionType = 'LastOccurrence';


--2
SELECT 
    ID,
    InputText AS FullName,
    LEFT(InputText, CHARINDEX(' ', InputText) - 1) AS FirstName,
    RIGHT(InputText, LEN(InputText) - CHARINDEX(' ', InputText)) AS LastName
FROM QuestionTestData
WHERE QuestionType = 'SplitFullName';

--3
SELECT 
    ID,
    InputText,
    SearchChar,
    LEN(InputText) - LEN(REPLACE(InputText, SearchChar, '')) AS OccurrenceCount
FROM QuestionTestData
WHERE QuestionType = 'CountChar';

--4
SELECT 
    ID,
    ReferenceDate,
    EOMONTH(DATEADD(MONTH, 1, ReferenceDate)) AS LastDayOfNextMonth
FROM QuestionTestData
WHERE QuestionType = 'LastDayNextMonth';

--5
SELECT 
    ID,
    ReferenceDate,
    DATEFROMPARTS(
        YEAR(DATEADD(MONTH, -1, ReferenceDate)),
        MONTH(DATEADD(MONTH, -1, ReferenceDate)),
        1
    ) AS FirstDayOfPreviousMonth
FROM QuestionTestData
WHERE QuestionType = 'FirstDayPrevMonth';


--6

WITH DateList AS (
    
    SELECT CAST(DATEFROMPARTS(YEAR(GETDATE()), MONTH(GETDATE()), 1) AS DATE) AS DateVal

    UNION ALL

   
    SELECT DATEADD(DAY, 1, DateVal)
    FROM DateList
    WHERE MONTH(DATEADD(DAY, 1, DateVal)) = MONTH(DateVal)
)

SELECT DateVal AS FridayDate
FROM DateList
WHERE DATENAME(WEEKDAY, DateVal) = 'Friday'
OPTION (MAXRECURSION 31);




