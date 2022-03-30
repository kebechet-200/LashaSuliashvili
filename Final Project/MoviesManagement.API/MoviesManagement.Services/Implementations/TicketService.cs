using Mapster;
using MoviesManagement.Data.Repository_Interfaces;
using MoviesManagement.Domain.POCO;
using MoviesManagement.Services.Abstractions;
using MoviesManagement.Services.Enum;
using MoviesManagement.Services.Exceptions;
using MoviesManagement.Services.Models;
using System;
using System.Threading.Tasks;

namespace MoviesManagement.Services.Implementations
{
    public class TicketService : ITicketService
    {
        private readonly ITicketRepository _ticketRepository;

        public TicketService(ITicketRepository ticketRepository, IMovieRepository movieRepository)
        {
            _ticketRepository = ticketRepository;
        }

        public async Task BuyTicketAsync(TicketModel ticket)
        {
            if (ticket.State != TicketStatus.Bought)
                ticket.State = TicketStatus.Bought;


            var ticketEntity = ticket.Adapt<Ticket>();

            if (await _ticketRepository.TicketBoughtExist(ticketEntity))
                throw new YouAlreadyHaveTicketException("თქვენ უკვე შეძენილი გაქვთ ბილეთი");

            await _ticketRepository.BuyTicketAsync(ticketEntity);
        }

        public async Task CancelTicketAsync(TicketModel ticket)
        {
            if (ticket.State != TicketStatus.Cancelled)
                ticket.State = TicketStatus.Cancelled;

            var ticketEntity = ticket.Adapt<Ticket>();
            if (!await _ticketRepository.TicketReserveExist(ticketEntity))
                throw new TicketDoesNotExistException("თქვენ არ შეგიძენიათ ბილეთი, შესაბამისად ვერ გააუქმებთ");

            await _ticketRepository.CancelTicket(ticketEntity);
        }

        public async Task TicketReservationAsync(TicketModel ticket)
        {
            if (ticket.State != TicketStatus.Reserved)
                ticket.State = TicketStatus.Reserved;


            var ticketEntity = ticket.Adapt<Ticket>();

            if (await _ticketRepository.TicketReserveExist(ticketEntity))
                throw new YouAlreadyHaveTicketException("თქვენ უკვე დაჯავშნილი გაქვთ ბილეთი");

            await _ticketRepository.TicketReservationAsync(ticket.Adapt<Ticket>());
        }
    }
}
