Create Procedure dbo.Get_all_workshops
AS
Select*from [bgu-users\poursh].WORKSHOPS


CREATE PROCEDURE dbo.SP_add_Workshop @id int, @numOfMeetings int, @repetivity varchar(50), @endDate date, @email varchar(250), @name varchar(50), @description varchar(500), @price real, @startDate date, @capacity int, @location varchar(200), @seatsLeft int
AS
INSERT INTO [bgu-users\poursh].WORKSHOPS
Values (@id, @numOfMeetings, @repetivity, @endDate, @email, @name, @description, @price, @startDate, @capacity, @location, @seatsLeft)



CREATE PROCEDURE dbo.SP_Update_Workshop @id int, @numOfMeetings int, @repetivity varchar(50), @endDate date, @email varchar(250), @name varchar(50), @description varchar(500), @price real, @startDate date, @capacity int, @location varchar(200), @seatsLeft int
AS
Update  [bgu-users\poursh].WORKSHOPS
SET
NumOfMeetings = @numOfMeetings, Repetivity = @repetivity, EndDate = @endDate, Email = @email, [Name] = @name, [Description] = @description, Price = @price, StartDate = @startDate, Capacity = @capacity, [Location] = @location, SeatsLeft = @seatsLeft
WHERE ActivityID = @id


CREATE PROCEDURE dbo.SP_delete_Workshop @activityID varchar(250)
AS
Delete from  [bgu-users\poursh].WORKSHOPS
WHERE ActivityID = @activityID

