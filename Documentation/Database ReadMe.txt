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
+--------------+------------+------------------+---+-------+-----+
|Field         |Type        |Nullable          |Key|Default|Extra|
+--------------+------------+------------------+---+-------+-----+
|golferID      |varchar(10) |String            |PRI|NULL   |     |
|firstName     |varchar(20) |String            |   |NULL   |     |
|middleInitial |varchar(1)  |String            |   |NULL   |     |
|lastName      |varchar(20) |String            |   |NULL   |     |
|handicap      |decimal(3,1)|Nullable<Decimal> |   |NULL   |     |
+--------------+------------+------------------+---+-------+-----+
	No restrictions currently placed on golferID ... typical ID's are the following format: XXXYYYYY
		where XXX are uppercase letters and YYYYY are numbers. Ex. CJM12345

[CLUB_TYPES]
+---------+-----------+--------+---+-------+--------------+
|Field    |Type       |Nullable|Key|Default|Extra         |
+---------+-----------+--------+---+-------+--------------+
|uniqueID |tinyint    |byte    |PRI|NULL   |auto_increment|
|clubName |varchar(20)|String  |   |NULL   |              |
----------+-----------+--------+---+-------+--------------+

[GOLF_COURSES]
+--------------+------------+--------+---+-------+-----+
|Field         |Type        |Nullable|Key|Default|Extra|
+--------------+------------+--------+---+-------+-----+
|courseID      |varchar(10) |String  |PRI|NULL   |     |
|courseName    |varchar(50) |String  |   |NULL   |     |
|numTees       |tinyint     |byte    |   |NULL   |     |
|par           |tinyint     |byte    |   |72     |     |
+--------------+------------+--------+---+-------+-----+	

[TEE_INFORMATION]
+--------------+------------------+---------------------+---+-------+--------------+
|Field         |Type              |Nullable             |Key|Default|Extra         |
+--------------+------------------+---------------------+---+-------+--------------+
|uniqueID      |smallint          |Nullable<Int16>      |PRI|NULL   |auto_increment|
|courseID      |varchar(10)       |String               |FK |NULL   |              |
|teeName       |varchar(10)       |String               |   |NULL   |              |
|yardage       |int unsigned      |Nullable<Int32>      |   |NULL   |              |
|rating        |decimal(4,1)      |Nullable<Decimal>    |   |NULL   |              |
|slope         |tinyint unsigned  |byte                 |   |NULL   |              |
+--------------+------------------+---------------------+---+-------+--------------+
	The Foreign Key (courseID) references [GOLF_COURSES].{courseID}

[ROUND_INFORMATION]
+--------------+------------+---------------------+---+-------+--------------+
|Field         |Type        |Nullable             |Key|Default|Extra         |
+--------------+------------+---------------------+---+-------+--------------+
|roundID       |smallint    |Nullable<Int16>      |PRI|NULL   |auto_increment|
|golferID      |varchar(10) |String               |FK |NULL   |              |
|teeID         |smallint    |Nullable<Int16>      |FK |NULL   |              |
|par           |tinyint     |byte                 |   |NULL   |              |
|score         |tinyint     |byte                 |   |NULL   |              |
|roundDate     |date        |Nullable<DateTime>	  |   |NULL   |              |
+--------------+------------+---------------------+---+-------+--------------+
	The Foreign Key (golferID) references [GOLFERS].{golferID}
	The Foreign Key (teeID) references [TEE_INFORMATION].{uniqueID}

[GOLF_BAG]
+--------------+------------+------------------+---+-------+--------------+
|Field         |Type        |Nullable          |Key|Default|Extra         |
+--------------+------------+------------------+---+-------+--------------+
|uniqueID      |smallint    |Nullable<Int16>   |PRI|NULL   |auto_increment|
|golferID      |varchar(10) |String            |FK |NULL   |              |
|clubID        |tinyint     |byte              |FK |NULL   |              |
|lie           |decimal(3,1)|Nullable<Decimal> |   |-1.0   |              |
|make          |varchar(20) |String            |   |N/A    |              |
|model         |varchar(20) |String            |   |N/A    |              |
+--------------+------------+------------------+---+-------+--------------+
	The Foreign Key (golferID) references [GOLFERS].{golferID}
	The Foreign Key (clubID) references [CLUB_TYPES].{uniqueID}


	MySQL >> C# Type mapping
+------------------+----------------+---------------------+------------------------+
|MySQL Data Type   |C# Data Type    |C# Nullable Data Type| C# Primitive Type      |
+------------------+----------------+---------------------+------------------------+
|bigint            |Int64           |Nullable<Int64>      |long                    |
|bit               |Boolean			|Nullable<Boolean>	  |bool					   |
|char			   |Char			|Nullable<Char>		  |char					   |
|date              |DateTime		|Nullable<DateTime>   |                        |
|datetime          |DateTime		|Nullable<DateTime>   |                        |
|decimal           |Decimal			|Nullable<Decimal>    |decimal                 |
|float             |Single			|Nullable<Single>     |float                   |
|int               |Int32			|Nullable<Int32>      |int                     |
|longtext          |String			|String               |string                  |
|mediumint         |Int32			|Nullable<Int32>      |int                     |
|mediumtext		   |String			|String               |string                  |
|smallint		   |Int16			|Nullable<Int16>	  |short                   |
|text			   |String			|String               |string                  |
|time			   |DateTime		|Nullable<DateTime>	  |                        |
|timestamp	  	   |DateTime		|Nullable<DateTime>	  |                        |
|tinyint           |byte			|byte                 |                        |
|tinytext          |String			|String               |string                  |
|varbinary         |byte[]			|byte[]	              |                        |
|varchar           |String			|String               |string                  |
+------------------+----------------+---------------------+------------------------+