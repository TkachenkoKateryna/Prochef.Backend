using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Prochef.Application.Interfaces;
using Prochef.Core.Dtos.Request.Chains;

namespace Prochef.WebApi.Controllers
{
    public class ChainController : Controller
    {
        private readonly IChainService _chainService;

        public ChainController(IChainService chainService)
        {
            _chainService = chainService;
        }

        [HttpGet("chains")]
        public IActionResult GetAllChains()
        {
            return Json(_chainService.GetAllChains());
        }

        [HttpPost("chains/add")]
        public IActionResult AddChain(UpsertChainRequest chainRequest)
        {
            try
            {
                _chainService.CreateChain(chainRequest);
                return Ok();
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        [HttpPost("chains/update")]
        public IActionResult UpdateChain(UpsertChainRequest chainRequest, int chainId)
        {
            try
            {
                _chainService.UpdateChain(chainRequest, chainId);
                return Ok();
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        [HttpDelete("chains/delete")]
        public IActionResult DeleteChain(int chainId)
        {
            try
            {
                _chainService.DeleteChain(chainId);
                return Ok();
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }
    }
}
