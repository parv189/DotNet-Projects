use MyPractice
go

create table destributer(
destributer_id int primary key,
compeny_name varchar(10),
car_id int, 
transport_id int, 
bill_no int
);

create table seller (
seller_id int primary key, 
distributer_id int foreign key references destributer(destributer_id)
);

create table car (
car_id int primary key,
model_name varchar(10),
seller_id int foreign key references seller(seller_id)
);
go 

create procedure data 
AS
begin
select * from destributer where compeny_name = 'honda';
end

exec data;

go

create procedure data2
As
begin
select c.car_id,c.model_name,d.destributer_id,d.compeny_name from car c join seller s on c.seller_id=s.seller_id
join destributer d on s.distributer_id = d.destributer_id
end
go
exec data2

drop procedure data
