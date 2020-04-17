use StorageDB
drop table storage

create table Storage(
S_ID int identity (1,1),
PhysicalPath varchar(50) not null,
DeviceID varchar(50) not null,
Num int
)
insert into Storage(DeviceID,PhysicalPath)values('1-003','Aoo1')
insert into Storage(DeviceID,PhysicalPath)values('1-004','Aoo2')

select * from Storage where PhysicalPath like '%1%'
update Storage set PhysicalPath='' ,DeviceID='' where S_ID=10

select * from Storage