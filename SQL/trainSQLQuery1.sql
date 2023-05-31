create table train (TrainName varchar(20),TrainNo int,PNRNO int,Orgin varchar(20),Destination varchar(20),Date int,Time int,Category varchar(20),Class varchar(30),Status varchar(30)) 
insert into train values('Maharaja Express',1345,0863,'Nagpur','Vadodera',02-05-23,12.00,'General','Laidies','Availabel')
insert into train values('Rajdhani Express',1563,0745,'Nagpur','Hydrabad',03-05-23,11.00,'General','Tatkal','Availabel')
insert into train values('Prerna Express',1378,0362,'Shegaon','Nagpur',05-06-23,90.00,'Ac','Primium Tatkal','Waiting')
insert into train values('Vande Bharat Express',1345,0863,'Nagpur','Pune',10-05-23,50.00,'Ac','General','Availabel')
insert into train values('Avantika Express',8632,0833,'Delhi','Bihar',25-05-23,70.00,'Sleeper','Person with Diability','Wating')
insert into train values('Mumbai Express',4625,9463,'Indore','Bihar',30-05-23,13.00,'General','Laidies','Wating')
insert into train values('Rajdhani Express',4745,0093,'Nagpur','Ahemdabad',02-05-23,70.00,'Sleeper','Laidies','Availabel')
insert into train values('Bagmati Express',1748,0853,'Ernakulam','Pune',07-05-23,12.00,'General','Laidies','Wating')
insert into train values('Aazad Hind Express',8445,1833,'Buxar','Kolkata',02-06-23,15.00,'General','General','Availabel')
insert into train values('Maharaja Express',180,7263,'Nagpur','Amravati',09-05-23,17.00,'General','Sleeper','Availabel')
select * from train 
