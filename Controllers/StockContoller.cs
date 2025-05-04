using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using api.Data;
using api.models;
using Microsoft.AspNetCore.Http.HttpResults;
using Microsoft.AspNetCore.Mvc;
using System.Text.Json;

namespace api.Controllers
{
    [Route("api/stock")]
    [ApiController]
    public class StockContoller : ControllerBase
    {
        private readonly ApplicationDBContext _context;
        private readonly List<Stock> _stocks;
        public StockContoller(ApplicationDBContext context)
        {
            _context = context;
            var jsonFilePath = Path.Combine("Data", "stocks.json");
            var jsonData = System.IO.File.ReadAllText(jsonFilePath);
            _stocks = JsonSerializer.Deserialize<List<Stock>>(jsonData);

        }

        [HttpGet]

        public IActionResult GetAll()
        {
            // var stocks = _context.Stock.ToList();
            return Ok(_stocks);
        }
        [HttpGet("{id}")]


        public IActionResult GetById([FromRoute] int id)
        {
            var stock = _stocks.FirstOrDefault(s => s.Id == id);

            //var stock = _context.Stock.Find(id);
            if (stock == null)
            {
                return NotFound();
            }
            return Ok(stock);

        }

    }
}