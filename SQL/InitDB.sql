USE HotelReservation

-- Task 1 Create hotels table
CREATE TABLE Hotels
(
    Id int Primary Key Not Null Identity(1,1),
    Name nvarchar(256) NOT NULL,
	Foundation_year int Not Null,
	Address nvarchar(512) Not Null,
	Is_active bit Not Null
)