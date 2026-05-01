﻿CREATE DATABASE TollTaxDB;
USE TollTaxDB;

CREATE TABLE Drivers (
    AID INT IDENTITY(300,1) PRIMARY KEY,  
    DriverName NVARCHAR(100),
    DriverNIC NVARCHAR(20) ,
    CrossingVehicle NVARCHAR(50) ,
    FromCity NVARCHAR(50),
    ToCity NVARCHAR(50),
    TravelDate DATE ,
    TollTAX INT ,
    Passengers INT
);

INSERT INTO Drivers (DriverName, DriverNIC, CrossingVehicle, FromCity, ToCity, TravelDate, TollTAX, Passengers)
VALUES 
('Ali Khan', '42101-1234567-1', 'Car', 'Lahore', 'Islamabad', '2025-07-01', 500, 4),
('Ahmed Raza', '35201-2345678-2', 'Bus', 'Karachi', 'Hyderabad', '2025-07-01', 1000, 30),
('Usman Tariq', '37401-3456789-3', 'Truck', 'Multan', 'Lahore', '2025-07-01', 800, 1),
('Bilal Sheikh', '61101-4567890-4', 'Van', 'Rawalpindi', 'Peshawar', '2025-07-01', 600, 10),
('Faisal Jameel', '42501-5678901-5', 'Car', 'Faisalabad', 'Lahore', '2025-07-01', 450, 3),
('Sajid Mehmood', '35202-6789012-6', 'Bus', 'Quetta', 'Karachi', '2025-07-01', 1200, 35),
('Junaid Ashraf', '42102-7890123-7', 'Car', 'Lahore', 'Gujranwala', '2025-07-01', 300, 2),
('Imran Saeed', '61102-8901234-8', 'Truck', 'Islamabad', 'Abbottabad', '2025-07-01', 850, 1),
('Zubair Iqbal', '37402-9012345-9', 'Van', 'Bahawalpur', 'Multan', '2025-07-01', 500, 7),
('Noman Ali', '35203-0123456-0', 'Car', 'Sialkot', 'Lahore', '2025-07-01', 350, 3),
('Hamza Yousaf', '42103-1234567-1', 'Bus', 'Karachi', 'Sukkur', '2025-07-01', 1100, 28),
('Adeel Anwar', '61103-2345678-2', 'Truck', 'Gujrat', 'Rawalpindi', '2025-07-01', 900, 1),
('Shoaib Aslam', '37403-3456789-3', 'Van', 'Dera Ghazi Khan', 'Multan', '2025-07-01', 550, 9),
('Waqar Khan', '35204-4567890-4', 'Car', 'Larkana', 'Hyderabad', '2025-07-01', 400, 4),
('Muneeb Hassan', '42104-5678901-5', 'Bus', 'Abbottabad', 'Mansehra', '2025-07-01', 700, 25),
('Kashif Mehmood', '61104-6789012-6', 'Truck', 'Jhelum', 'Lahore', '2025-07-01', 820, 1),
('Farhan Zia', '37404-7890123-7', 'Van', 'Nowshera', 'Peshawar', '2025-07-01', 480, 6),
('Rehan Tariq', '35205-8901234-8', 'Car', 'Multan', 'Faisalabad', '2025-07-01', 370, 4),
('Shahbaz Ali', '42105-9012345-9', 'Bus', 'Hyderabad', 'Karachi', '2025-07-01', 1050, 32),
('Asad Jamil', '61105-0123456-0', 'Car', 'Rawalpindi', 'Murree', '2025-07-01', 250, 3);

select *from Drivers;