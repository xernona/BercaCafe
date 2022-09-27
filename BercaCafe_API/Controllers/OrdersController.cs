using BercaCafe_API.Repositories.Interfaces;
using BercaCafe_API.ViewModels;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Net;

namespace BercaCafe_API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class OrdersController : ControllerBase
    {
        private readonly IOrderRepository orderRepository;
        private readonly IEmployeeUserRepository employeeUserRepository;
        public OrdersController(IOrderRepository repository, IEmployeeUserRepository empRepository)
        {
            this.orderRepository = repository;
            this.employeeUserRepository = empRepository;
        }

        [HttpPost]
        public ActionResult PlaceOrder(OrderVM order)
        {
            try
            {
                var emp = employeeUserRepository.GetByCardNo(order.CardNo);
                if (emp.ErrorCode.Contains("resign"))
                {
                    return StatusCode(400, new
                    {
                        status = HttpStatusCode.BadRequest,
                        message = emp.ErrorCode
                    });
                }
                else if (emp.ErrorCode != "-")
                {
                    return StatusCode(400, new
                    {
                        status = HttpStatusCode.BadRequest,
                        message = "Maaf, Anda sudah melakukan tapping hari ini"
                    });
                }
                else
                {
                    var transaction = orderRepository.ComposeOrder(emp, order);
                    var result = orderRepository.PlaceOrder(transaction);
                    return StatusCode(200, new
                    {
                        status = HttpStatusCode.OK,
                        message = "Pesanan berhasil ditambahkan",
                        result = result
                    });
                }
            }
            catch
            {
                return StatusCode(400, new
                {
                    status = HttpStatusCode.BadRequest,
                    message = "Kartu invalid"
                });
            }
        }
    }
}
