


select distinct firstname+' '+Lastname as Name,[EMPLOYEE ID NUMBER], a.Department, isnull(case when b.Supervisor not like '%,%' then b.Supervisor else ltrim(rtrim(substring(b.Supervisor,CHARINDEX(', ',b.Supervisor)+1,len(b.Supervisor)))) +' '+ltrim(rtrim(substring(b.Supervisor,0,CHARINDEX(', ',b.Supervisor)))) end,'') as Supervisor,a.role, a.Location 
from tblVKPOEmployee_HRNames a 
inner join (select * from tblMasterAttendance where DATE=(select MAX(date) from tblMasterAttendance)) b on a.[EMPLOYEE ID NUMBER]=b.AgentID 
where employeestatus='ACTIVE'  and a.department not in ('EXC','EXR')  
order by firstname+' '+Lastname,Supervisor