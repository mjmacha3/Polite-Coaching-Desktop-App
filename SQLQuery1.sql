


select distinct a.Location 
from tblVKPOEmployee_HRNames a
inner join tblMasterAttendance b on b.AgentID = a.[EMPLOYEE ID NUMBER] 
where [EMPLOYEE ID NUMBER] = 'V20040'
And EmployeeStatus = 'ACTIVE'

select * from tblMasterAttendance