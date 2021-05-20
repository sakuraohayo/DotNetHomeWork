using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork12.Controllers
{
    [ApiController]

    [Route("api/[controller]")]

    public class OrderController : ControllerBase

    {

        private readonly OrderContext orderDB;



        public OrderController(OrderContext context)

        {

            this.orderDB = context;

        }



        [HttpGet("{id}")]

        public ActionResult<Order> GetOrderById(int id)

        {

            var order = orderDB.Orders.FirstOrDefault(o => o.OrderId == id);

            if (order == null)

            {

                return NotFound();

            }

            return order;

        }



        [HttpPost]

        public ActionResult<Order> AddOrder(Order order)

        {

            try

            {

                orderDB.Orders.Add(order);

                orderDB.SaveChanges();

            }

            catch (Exception error)

            {

                return BadRequest(error.InnerException.Message);

            }

            return order;

        }



        [HttpPut("{id}")]

        public ActionResult<Order> UpdateOrder(int id, Order order)

        {

            if (id != order.OrderId)

            {

                return BadRequest("Id cannot be modified!");

            }

            try

            {

                orderDB.Entry(order).State = EntityState.Modified;

                orderDB.SaveChanges();

            }

            catch (Exception error)

            {

                return BadRequest(error.InnerException.Message);

            }

            return NoContent();

        }



        [HttpDelete("{id}")]

        public ActionResult DeleteOrder(int id)

        {

            try

            {

                var order = orderDB.Orders.FirstOrDefault(o => o.OrderId == id);

                if (order == null)

                {

                    return BadRequest("Not have this Order");

                }

                orderDB.Remove(order);

                orderDB.SaveChanges();

            }

            catch (Exception error)

            {

                return BadRequest(error.InnerException.Message);

            }

            return NoContent();

        }

    }
}
