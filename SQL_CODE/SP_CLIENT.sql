Create Procedure dbo.Get_all_clients
AS
Select*from [bgu-users\poursh].CLIENT


CREATE PROCEDURE dbo.SP_add_client @fullname varchar(50), @client_email varchar(250), @phone varchar(20), @Gender varchar(20), @Birthdate date, @AddressCountry varchar(50), @AddressCity varchar(50), @NumofWorkshops integer, @NumofLectures integer, @Discount real, @LastActivityDate date
AS
INSERT INTO [bgu-users\poursh].CLIENT
Values (@fullname, @client_email, @phone, @Gender, @Birthdate, @AddressCountry, @AddressCity, @NumofWorkshops, @NumofLectures, @Discount, @LastActivityDate)



CREATE PROCEDURE dbo.SP_Update_Client @fullname varchar(50), @client_email varchar(250), @phone varchar(20), @Gender varchar(20), @Birthdate date, @AddressCountry varchar(50), @AddressCity varchar(50), @NumofWorkshops integer, @NumofLectures integer, @Discount real, @LastActivityDate date
AS
Update [bgu-users\poursh].CLIENT
SET
FullName = @fullname, Phone = @phone, Gender = @Gender, BirthDate = @Birthdate, AddressCountry = @AddressCountry, AddressCity = @AddressCity, Discount = @Discount, LastActivityDate = @LastActivityDate 
WHERE Email_Client = @client_email


CREATE PROCEDURE dbo.SP_delete_Client @client_email varchar(250)
AS
Delete from  [bgu-users\poursh].CLIENT
WHERE Email_Client = @client_email

