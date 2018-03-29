﻿SELECT  AvgPrice UnitPrice FROM @table with(nolock) WHERE CityId = @cityid AND FxtCompanyId = @fxtcompanyid AND AreaId =@areaid AND SubAreaId = @subareaid
AND ProjectId = 0 AND BuildingAreaType = 0 AND HouseType = 0 AND PurposeType = 0 AND BuildingDateType =0 AND BuildingTypeCode = 0 AND DATEDIFF(month,AvgPriceDate+'01',GETDATE())<13 AND DATEDIFF(month,AvgPriceDate+'01',GETDATE())>0  order by AvgPriceDate