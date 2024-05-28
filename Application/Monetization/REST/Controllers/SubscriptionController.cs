using System.Net.Mime;
using Domain.Monetization.Model.Aggregates;
using Domain.Monetization.Repository;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace Application.Monetization.REST.Controllers;

[Route("api/v1/monetization/[controller]")]
[ApiController]
[Produces(MediaTypeNames.Application.Json)]
[AllowAnonymous]
public class SubscriptionController(IRepositoryGeneric<Subscription> repositoryGeneric)  : ControllerBase
{
    private readonly IRepositoryGeneric<Subscription> _repositoryGeneric = repositoryGeneric;
    [HttpGet]
    [Route("get-all")]
    public async Task<IActionResult> GetAll()
    {
        return Ok(await _repositoryGeneric.ListAsync());
    }
    
    [HttpPost]
    [Route("add-subscription")]
    public async Task<IActionResult> Post([FromBody] Subscription subscription)
    {
        await _repositoryGeneric.AddAsync(subscription);
        return Ok(true);
    }
}