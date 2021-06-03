--Select
Select * From ContactDetails
Where IsActive = 1 And AreaCode = 012

--Update 
Update ContactDetails
Set 
IsActive = 1
Where
ContactDetails.Description Like '%x%'
And OrderNumber <= 50

--Reorder section
Declare @Amount as int = 10
Select * From ContactDetails
Where ID <= @Amount

--Alter table
Alter Table ContactDetails
Add TelephoneNumber AS AreaCode + Telephone

Alter Table ContactDetails
Drop Column AreaCode

Alter Table ContactDetails
Drop Column Telephone