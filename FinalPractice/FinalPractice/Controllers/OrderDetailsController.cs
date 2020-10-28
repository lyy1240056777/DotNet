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
    public class OrderDetailsController : ControllerBase
    {
        private readonly OrderContext _context;

        public OrderDetailsController(OrderContext context)
        {
            _context = context;
        }

        // GET: api/OrderDetails
        [HttpGet]
        public ActionResult<List<OrderDetails>> GetOrderDetails(string item)//获得所有商品信息
        {
            IQueryable<OrderDetails> query = _context.OrderDetails;
            if (item != null)
            {
                query = query.Where(od => od.Item.Contains(item));
            }
            return query.ToList();
        }

        // GET: api/OrderDetails/5
        [HttpGet("{id}")]
        public ActionResult<List<OrderDetails>> GetOrderDetail(long id)//获取某订单下的商品信息
        {
            var order = _context.Orders.FirstOrDefault(o => o.ID == id);
            if (order == null)
            {
                return NotFound();
            }
            IQueryable<OrderDetails> query = _context.OrderDetails.Where(od => od.Order.ID == id);
            return query.ToList();
        }

        // PUT: api/OrderDetails/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        //[HttpPut("{id}")]
        [HttpPut]
        public ActionResult<OrderDetails> PutOrderDetail(OrderDetails orderDetails)//修改某商品信息
        {
            try
            {
                orderDetails.TotalPrice = orderDetails.UnitPrice * orderDetails.Amount;
                _context.Entry(orderDetails).State = EntityState.Modified;
                _context.SaveChanges();
                UpdateOrder(orderDetails);
            }catch(Exception e)
            {
                string error = e.Message;
                if (e.InnerException != null) error = e.InnerException.Message;
                return BadRequest(error);
            }
            return NoContent();
        }

        // POST: api/OrderDetails
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPost]
        public ActionResult<OrderDetails> PostOrderDetail(OrderDetails orderDetails)//新建一个商品条目
        {
            try
            {
                orderDetails.TotalPrice = orderDetails.UnitPrice * orderDetails.Amount;
                _context.OrderDetails.Add(orderDetails);
                _context.SaveChanges();
                UpdateOrder(orderDetails);
            }catch(Exception e)
            {
                return BadRequest(e.InnerException.Message);
            }
            return orderDetails;
        }
        //不需要
        // DELETE: api/OrderDetails/5
        [HttpDelete("{id}")]
        public async Task<ActionResult<OrderDetails>> DeleteOrderDetails(string id)
        {
            var orderDetails = await _context.OrderDetails.FindAsync(id);
            if (orderDetails == null)
            {
                return NotFound();
            }

            _context.OrderDetails.Remove(orderDetails);
            await _context.SaveChangesAsync();

            return orderDetails;
        }
        //不需要
        private bool OrderDetailsExists(string id)
        {
            return _context.OrderDetails.Any(e => e.Item == id);
        }
        private void UpdateOrder(OrderDetails orderDetails)//更新对应订单的总价信息
        {
            var order = _context.Orders.FirstOrDefault(o => o.ID == orderDetails.OrderId);
            var totalPrice = _context.OrderDetails.Where(od => od.Order.ID == order.ID).Select(od => od.TotalPrice);
            double total = 0;
            foreach (double t in totalPrice) total += t;
            order.Total = total;
            _context.SaveChanges();
        }
    }
}
