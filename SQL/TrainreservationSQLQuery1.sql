select * from train
--this query will remove repeating train name
select distinct TrainName from train 
select distinct TrainName ,Date from train
select distinct destination , orgin , class from train
select destination from train order by date
select destination from train order by destination
select distinct destination from train order by destination
select distinct TrainName from train  
select status from train where orgin='Nagpur'
select * from train where orgin='Nagpur' or status='Availabel'
select TrainNo from train where orgin='Nagpur' order by time desc
select TrainNo from train where TrainNo between '180' and '1345' 
select TrainName from train order by LEN(TrainName) desc
select TrainName from train order by LEN(TrainName)
select * from train where TrainNo like '%8%'
select * from train where TrainNo like '1%'
select * from train where orgin in ('Nagpur')
select *from train where orgin not in ('Pune')