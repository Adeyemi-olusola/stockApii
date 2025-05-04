using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using api.Dtos.Stock;
using api.models;

namespace api.Mappers
{
    public static class StockMappers
    {
        public static StockDtos ToStockDto(this Stock stockmodel){
            return new StockDtos{
                Id =stockmodel.Id,
                Symbol = stockmodel.Symbol,
                CompanyName = stockmodel.CompanyName,
                Purchase = stockmodel.Purchase, 
                Industry = stockmodel.Industry, 
                LastDiv= stockmodel.LastDiv
            };

        }
        
    }
}