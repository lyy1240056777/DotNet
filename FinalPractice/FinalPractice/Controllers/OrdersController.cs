using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using FinalPractice.Models;

namespace FinalPractice.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class OrdersController : ControllerBase
    {
        private readonly OrderContext _context;

        public OrdersController(OrderContext context)
        {
            _context = context;
        }

        // GET: api/Orders
        [HttpGet]
        public ActionResult<List<Order>> GetOrders()//获取所有订单信息
        {
            IQueryable<Order> query = _context.Orders;
            return query.ToList();
        }

        // GET: api/Orders/5
        [HttpGet("{id}")]
        public ActionResult<Order> GetOrder(long id)//获取某订单信息
        {
            var order = _context.Orders.FirstOrDefault(o => o.ID == id);
            _context.SaveChanges();
            if (order == null)
            {
                return NotFound();
            }
            return order;
        }
        //不需要
        // PUT: api/Orders/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPut("{id}")]
        public async Task<IActionResult> PutOrder(int id, Order order)
        {
            if (id != order.ID)
            {
                return BadRequest();
            }

            _context.Entry(order).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!OrderExists(id))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return NoContent();
        }

        // POST: api/Orders
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPost]
        public ActionResult<Order> PostOrder(Order order)//新建一个订单
        {
            try
            {
                order.Total = 0;
                _context.Orders.Add(order);
                _context.SaveChanges();
            }catch(Exception e)
            {
                return BadRequest(e.InnerException.Message);
            }
            return order;
        }

        // DELETE: api/Orders/5
        [HttpDelete("{id}")]
        public ActionResult<List<Order>> DeleteOrder(long id)//删除某订单
        {
            try
            {
                var order = _context.Orders.FirstOrDefault(o => o.ID == id);
                if (order != null)
                {
                    _context.Remove(order);
                    _context.SaveChanges();
                }
            }catch(Exception e)
            {
                return BadRequest(e.InnerException.Message);
            }
            return NoContent();
        }
        //不需要
        private bool OrderExists(int id)
        {
            return _context.Orders.Any(e => e.ID == id);
        }
    }
}
