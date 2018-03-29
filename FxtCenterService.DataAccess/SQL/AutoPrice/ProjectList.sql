﻿select a.* from (
SELECT [ProjectId],[ProjectName] +'['+a.[AreaName]+']' ProjectName,a.areaid,p.[Address],p.x,p.y,isevalue  FROM @table_project p with(nolock),FxtDataCenter.dbo.SYS_Area a with(nolock)where p.[Valid]=1 and p.[CityId]=@cityid and p.[AreaID]=a.[AreaID] 
and ([PinYin] like @key or [Address] like @address or [ProjectName] like @key or [OtherName] like @key or [PinYinAll] like @key) 
and p.ProjectId not in (select ProjectId from @table_project_sub ps with(nolock) where p.ProjectId=ps.ProjectId and ps.Fxt_CompanyId=@fxtcompanyid and ps.CityId=p.CityId) AND p.FxtCompanyId  IN (SELECT value FROM  dbo.SplitToTable((SELECT ShowCompanyId FROM FxtDataCenter.dbo.Privi_Company_ShowData WHERE CityId=@cityid AND FxtCompanyId=@fxtcompanyid and TypeCode = @typecode),',')) 
union 
SELECT [ProjectId],[ProjectName] +'['+a.[AreaName]+']' ProjectName,a.areaid,p.[Address],p.x,p.y,isevalue  FROM @table_project_sub p with(nolock),FxtDataCenter.dbo.SYS_Area a with(nolock)where p.[Valid]=1 and p.[CityId]=@cityid and p.[AreaID]=a.[AreaID] 
and ([PinYin] like @key or [Address] like @address or [ProjectName] like @key or [OtherName] like @key or [PinYinAll] like @key) and p.Fxt_CompanyId=@fxtcompanyid  )a

where 1=1