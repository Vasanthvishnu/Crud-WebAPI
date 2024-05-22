create table Vehicle
(Id bigint identity(1,1) primary key ,
Name nvarchar(50) not null,
VehicleNumber varchar(20) not null,
OwnerName nvarchar(60) not null,
DriverName nvarchar(50) not null,
ContactNummber bigint not null)

select* from Vehicle

alter procedure InsertVehicle
(@Name nvarchar(50),
@VehicleNumber varchar(20),
@OwnerName nvarchar(60),
@DriverName nvarchar(50),
@ContactNummber bigint)
as 
begin
insert into Vehicle
(Name,VehicleNumber,OwnerName,DriverName,ContactNummber)
values(@Name,@VehicleNumber,@OwnerName,@DriverName,@ContactNummber)
end
exec InsertVehicle 'AshokLeyland(Dost)',TN94Z5517,'Vasanth','Raja',9789876544