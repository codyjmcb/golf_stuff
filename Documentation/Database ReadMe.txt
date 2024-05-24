/*
FILE  				: Database ReadMe.txt
AUTHOR				: Cody J. McBride
AUTHOR CONTACT			: cody.j.mcbride@gmail.com
AUTHOR PHONE			: 603-289-1113
DATE				: 05/16/2024 (11:00)
REVISION			: Rev. 0.1
REVISION DETAILS
	Rev. 0.1		: Initial Release


NOTES ABOUT THIS DOCUMENT	
	This document serves as a reference to the database objects utilized by the PHP server.
	The database is a MySql database and the syntax is constrained by MySql syntax.
	Decimal valuse in MySql use the following convention "decimal(X,Y)" where X is the total number of digits
		and Y is the number of digits after the decimal point. Ex. 12.3 is valid, whereas 123.4 is not for decimal(3,1).
*/

[GOLFERS]
+--------------+------------+--------+---+-------+-----+
|Field         |Type        |Nullable|Key|Default|Extra|
+--------------+------------+--------+---+-------+-----+
|golferID      |varchar(10) |NO      |PRI|NULL   |     |
|firstName     |varchar(20) |NO      |   |NULL   |     |
|middleInitial |varchar(1)  |NO      |   |NULL   |     |
|lastName      |varchar(20) |NO      |   |NULL   |     |
|handicap      |decimal(3,1)|NO      |   |NULL   |     |
+--------------+------------+--------+---+-------+-----+
	No restrictions currently placed on golferID ... typical ID's are the following format: XXXYYYYY
		where XXX are uppercase letters and YYYYY are numbers. Ex. CJM12345

[CLUB_TYPES]
+---------+-----------+--------+---+-------+--------------+
|Field    |Type       |Nullable|Key|Default|Extra         |
+---------+-----------+--------+---+-------+--------------+
|uniqueID |tinyint    |NO      |PRI|NULL   |auto_increment|
|clubName |varchar(20)|NO      |   |NULL   |              |
----------+-----------+--------+---+-------+--------------+

[GOLF_COURSES]
+--------------+------------+--------+---+-------+-----+
|Field         |Type        |Nullable|Key|Default|Extra|
+--------------+------------+--------+---+-------+-----+
|courseID      |varchar(10) |NO      |PRI|NULL   |     |
|courseName    |varchar(50) |NO      |   |NULL   |     |
|numTees       |tinyint     |NO      |   |NULL   |     |
|par           |tinyint     |NO      |   |72     |     |
+--------------+------------+--------+---+-------+-----+	

[TEE_INFORMATION]
+--------------+------------------+--------+---+-------+--------------+
|Field         |Type              |Nullable|Key|Default|Extra         |
+--------------+------------------+--------+---+-------+--------------+
|uniqueID      |smallint          |NO      |PRI|NULL   |auto_increment|
|courseID      |varchar(10)       |NO      |FK |NULL   |              |
|teeName       |varchar(10)       |NO      |   |NULL   |              |
|yardage       |int unsigned      |NO      |   |NULL   |              |
|rating        |decimal(4,1)      |NO      |   |NULL   |              |
|slope         |tinyint unsigned  |NO      |   |NULL   |              |
+--------------+------------------+--------+---+-------+--------------+
	The Foreign Key (courseID) references [GOLF_COURSES].{courseID}

[ROUND_INFORMATION]
+--------------+------------+--------+---+-------+--------------+
|Field         |Type        |Nullable|Key|Default|Extra         |
+--------------+------------+--------+---+-------+--------------+
|roundID       |smallint    |NO      |PRI|NULL   |auto_increment|
|golferID      |varchar(10) |NO      |FK |NULL   |              |
|teeID         |smallint    |NO      |FK |NULL   |              |
|par           |tinyint     |NO      |   |NULL   |              |
|score         |tinyint     |NO      |   |NULL   |              |
|roundDate     |date        |NO      |   |NULL   |              |
+--------------+------------+--------+---+-------+--------------+
	The Foreign Key (golferID) references [GOLFERS].{golferID}
	The Foreign Key (teeID) references [TEE_INFORMATION].{uniqueID}

[GOLF_BAG]
+--------------+------------+--------+---+-------+--------------+
|Field         |Type        |Nullable|Key|Default|Extra         |
+--------------+------------+--------+---+-------+--------------+
|uniqueID      |smallint    |NO      |PRI|NULL   |auto_increment|
|golferID      |varchar(10) |NO      |FK |NULL   |              |
|clubID        |tinyint     |NO      |FK |NULL   |              |
|lie           |decimal(3,1)|YES     |   |-1.0   |              |
|make          |varchar(20) |YES     |   |N/A    |              |
|model         |varchar(20) |YES     |   |N/A    |              |
+--------------+------------+--------+---+-------+--------------+
	The Foreign Key (golferID) references [GOLFERS].{golferID}
	The Foreign Key (clubID) references [CLUB_TYPES].{uniqueID}



