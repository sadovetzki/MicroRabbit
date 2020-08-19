using MicroRabbit.Transfer.Application.Interfaces;
using MicroRabbit.Transfer.Domain.Models;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

namespace MicroRabbit.Transfer.Api.Controllers
{
	[ApiController]
	[Route("api/[controller]")]
	public class TransferController : ControllerBase
	{
		private readonly ITransferService transferService;

		public TransferController(ITransferService _transferService)
		{
			transferService = _transferService;
		}

		[HttpGet]
		public ActionResult<IEnumerable<TransferLog>> Get()
		{
			return Ok(transferService.GetTransferLogs());
		}
	}
}
