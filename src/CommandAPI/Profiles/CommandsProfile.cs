using AutoMapper;
using CommandAPI.Dtos;
using CommandAPI.Models;
namespace CommandAPI.Profiles
{
    public class CommandsProfile : Profile
    {
        public CommandsProfile()
        {   
            // mapping our Model to DTO
            /*********SOURCE  ->  TARGET **********/
            CreateMap<Command, CommandReadDto>();
            //CreateMap<CommandCreateDto, Command>();
        }
} }
