
--CEO 
Create Table CEOS(
	FullName Varchar(50) NOT NULL,
	Email Varchar(250) NOT NULL Primary key,
	Phone Varchar(20) NOT NULL,
	Gender	Varchar(20) NOT NULL,
	[Address]	Varchar(50) NOT NULL,
	AboutCEO	Varchar(250) NOT NULL
)

--GenderType 
CREATE TABLE GENDERTYPES(
	Gender	Varchar(20)	NOT NULL PRIMARY KEY
)

INSERT INTO  GENDERTYPES VALUES
	('Male'),('Female'),('Other')

ALTER TABLE CEOS
ADD CONSTRAINT	FK_GenderType FOREIGN KEY (Gender) REFERENCES GENDERTYPES(Gender)


--Client 
CREATE TABLE CLIENTS(

	FullName Varchar(50) NOT NULL,
	Email_Client Varchar(250) NOT NULL Primary key,
	Phone Varchar(20) NOT NULL,
	Gender	Varchar(20) NOT NULL,
	BirthDate	Date NOT NULL,
	AddressCountry	Varchar(50) NOT NULL,
	AddressCity	Varchar(50) NOT NULL,
	NumOfCoachingMeeting	int NOT NULL,
	NumOfWorkshops	int NOT NULL,
	NumOfLectures	int NOT NULL,
	Discount	Real NOT NULL,
	LastActivityDate	Date NOT NULL
	
	
)
-- GenderType
ALTER TABLE CLIENTS
ADD CONSTRAINT	FK_GenderCLIENT FOREIGN KEY (Gender) REFERENCES GENDERTYPES(Gender)




--Activity  
Create Table ACTIVITIES(
	ActivityID	int not null Primary Key,
	[Name]	Varchar (50) NOT NULL,
	[Description] Varchar (500) NOT NULL,
	Price	Real NOT NULL,
	StartDate	Date NOT NULL,
	Capacity	int NOT NULL,
	[Location]	Varchar(200) NOT NULL,
	SeatsLeft	int	NOT NULL

)



--Lecture 
Create Table LECTURES(
	
	Duration	Real NOT NULL,
	LectureType	Varchar(20) NOT NULL,
	ActivityID	int not null ,
	Email		Varchar(250) NOT NULL, 
	


	CONSTRAINT		fk_Activity_Lecture	
	FOREIGN KEY 		(ActivityID) 
	REFERENCES 		ACTIVITIES(ActivityID),

	CONSTRAINT 	pk_Lectures  
	PRIMARY KEY 		(ActivityID),

	CONSTRAINT		fk_Ceo_Lecture	
	FOREIGN KEY 		(Email) 
	REFERENCES 		CEOS(Email)


)


--LectureType 
CREATE TABLE LECTURETYPES(
	LectureType		Varchar(20)	NOT NULL	PRIMARY KEY
)

INSERT INTO  LECTURETYPES VALUES
	('In Person'),('Online'),('Hybrid')

ALTER TABLE LECTURES
ADD CONSTRAINT	FK_LectureType FOREIGN KEY (LectureType) REFERENCES LECTURETYPES(LectureType)





--WorkShop 
Create Table WORKSHOPS(

	NumOfMeetings	int NOT NULL,
	Repetivity		Varchar(50) NOT NULL,
	EndDate			Date NOT NULL,
	ActivityID		int NOT NULL ,
	Email			Varchar(250) NOT NULL, 


	CONSTRAINT		fk_Activity_WorkShop	
	FOREIGN KEY 		(ActivityID) 
	REFERENCES 		ACTIVITIES(ActivityID),

	CONSTRAINT 	pk_WorkShop 
	PRIMARY KEY 		(ActivityID),

	CONSTRAINT		fk_Ceo_WorkShop	
	FOREIGN KEY 		(Email) 
	REFERENCES 		CEOS(Email)

)

--Equipment
CREATE TABLE EQUIPMENTS(
	
	equipmentID		int NOT NULL,
	workShopEquipment Varchar(20) NOT NULL,
	quantity int NOT NULL,
	ActivityID		int NOT NULL ,

	CONSTRAINT		fk_WorkShop_Equipment	
	FOREIGN KEY 		(ActivityID) 
	REFERENCES 		WORKSHOPS(ActivityID),

	CONSTRAINT 		pk_Equipment 
	PRIMARY KEY 	(equipmentID,ActivityID),
)




--workShopEQUIPMENT
CREATE TABLE WORKSHOPEQUIPMENTS(
	workShopEquipment	Varchar(20)		NOT NULL	PRIMARY KEY
)

INSERT INTO  [workShopEQUIPMENTS] VALUES
	('Whiteboard'),('Roll Up'),('Notebooks')

ALTER TABLE EQUIPMENTS
ADD CONSTRAINT	FK_workShopEquipment FOREIGN KEY (workShopEquipment) REFERENCES WORKSHOPEQUIPMENTS(workShopEquipment)




--CoachingMeeting 
CREATE TABLE COACHING_MEETINGS(

	meetingID	int NOT NULL PRIMARY KEY,
	bookingDate Date NOT NULL,
	meetingDate Date NOT NULL,
	price		money NOT NULL,
	meetingNum	int NOT NULL,
	Email_Client		Varchar(250) NOT NULL,--fk_CIENT
	Email		Varchar(250) NOT NULL, --fk_CEO
	
	CONSTRAINT		fk_CEO_Coaching_Meeting	
	FOREIGN KEY 		(Email ) 
	REFERENCES 		CEOS(Email),

	CONSTRAINT		fk_Client_Business_Schedules	
	FOREIGN KEY 		(Email_Client) 
	REFERENCES 		CLIENTS(Email_Client),


)

--BOOKINGS
CREATE TABLE BOOKINGS(

	BookingID		int NOT NULL ,
	Price			money NOT NULL,
	BookingDate		Date NOT NULL,
	BookingStatus	Varchar(20) NOT NULL,
	ActivityID		int NOT NULL ,
	Email_Client	Varchar(250) NOT NULL,
	

	CONSTRAINT		fk_Client_Bookings	
	FOREIGN KEY 		(Email_Client) 
	REFERENCES 		CLIENTS(Email_Client),


	CONSTRAINT		fk_Activitys_Bookings	
	FOREIGN KEY 		(ActivityID) 
	REFERENCES 		ACTIVITIES(ActivityID),

	CONSTRAINT 		pk_Bookings
	PRIMARY KEY 	(Email_Client,ActivityID,BookingID)
)

--BookingStatus 
CREATE TABLE BOOKING_STATUS(
	BookingStatus		Varchar(20)		NOT NULL	PRIMARY KEY
)

INSERT INTO  BOOKING_STATUS VALUES
('In Procces'),('Confirmed'),('Declind')

ALTER TABLE	 BOOKINGS
ADD CONSTRAINT	FK_bookingStatus FOREIGN KEY (BookingStatus) REFERENCES BOOKING_STATUS(BookingStatus)


--FEEDBACKS
CREATE TABLE FEEDBACKS(

	FeedbackID int NOT NULL ,
	FeedbackDate Date NOT NULL,
	[Rank] Varchar(20) NOT NULL,
	FeedbackText Varchar(1000) NOT NULL,
	Email_Client	Varchar(250) NOT NULL,
	ActivityID		int NOT NULL ,

	CONSTRAINT		fk_Client_Feedback	
	FOREIGN KEY 		(Email_Client) 
	REFERENCES 		CLIENTS(Email_Client),

	CONSTRAINT		fk_Activity_Feedback	
	FOREIGN KEY 	(ActivityID) 
	REFERENCES 		ACTIVITIES(ActivityID),

	CONSTRAINT 	pk_Feedback
	PRIMARY KEY 	(Email_Client,ActivityID,FeedbackID)
)


--Rank
CREATE TABLE [RANKS](
	[Rank]		Varchar(20)			PRIMARY KEY
)

INSERT INTO  [RANKS] VALUES
	('Very Bad'),('Bad'),('Okay'),('Good'),('Excellent')

ALTER TABLE	 FEEDBACKS
ADD CONSTRAINT	FK_rank FOREIGN KEY ([Rank]) REFERENCES [RankS]([Rank])
