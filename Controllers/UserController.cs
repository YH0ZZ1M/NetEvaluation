using Microsoft.AspNetCore.Mvc;
using Net_Evaluation.Dtos;
using Net_Evaluation.Repositories;

namespace Net_Evaluation.Controllers;
{
[ApiController]
[Route("[user]")]

public class UserController : ControllerBase
    {
    private readonly IUserRepository repository;

    public UserController(IUserRepository repository)
    {
        this.repository = repository;
    }

        [HttpGet("{id}")]
        public ActionResult<GetUserDto> GetUser(int id)
         {
             var user = repository.GetUser(id);

             if(user is null)
                 {
                  return NotFound();
                 }

             return GetUser(id);
         }

        [HttpPut("{id}")]

        [HttpPost]
          public ActionResult UpdatedUser(int id, UpdateItemDto itemDto)
        {
            var registeredUser= repository.GetUser(id);

            if(registeredUser is null)
            {
                return NotFound();
            }

            User registereduser = registereduser with {Id = UserDto.Id, Name = UserDto.Name, Email = UserDto.Email};

            repository.UpdateUser(UpdatedUser);
            return NoContent();
        }
  
        [HttpDelete("{id}")]

           public ActionResult DeleteUser(int id)
        {
             var registeredUser = repository.GetUser(id);

            if(registeredUser is null)
            {
                return NotFound();
            }

            repository.DeleteUser(id);
            
            return NoContent();


    }
}