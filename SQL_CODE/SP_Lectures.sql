Create Procedure dbo.Get_all_Lectures
AS
Select*from [bgu-users\poursh].LECTURES


CREATE PROCEDURE dbo.SP_add_Lecture @id int, @duration int, @lectureType varchar(20), @email varchar(250), @name varchar(50), @description varchar(500), @price real, @startDate date, @capacity int, @location varchar(200), @seatsLeft int
AS
INSERT INTO [bgu-users\poursh].LECTURES
Values (@id, @duration, @lectureType, @email, @name, @description, @price, @startDate, @capacity, @location, @seatsLeft)



CREATE PROCEDURE dbo.SP_Update_Lecture @id int, @duration int, @repetivity varchar(50), @lectureType varchar(20), @email varchar(250), @name varchar(50), @description varchar(500), @price real, @startDate date, @capacity int, @location varchar(200), @seatsLeft int
AS
Update  [bgu-users\poursh].LECTURES
SET
Duration = @duration, LectureType = @lectureType, Email = @email, [Name] = @name, [Description] = @description, Price = @price, StartDate = @startDate, Capacity = @capacity, [Location] = @location, SeatsLeft = @seatsLeft
WHERE ActivityID = @id


CREATE PROCEDURE dbo.SP_delete_Lecture @activityID varchar(250)
AS
Delete from  [bgu-users\poursh].LECTURES
WHERE ActivityID = @activityID

